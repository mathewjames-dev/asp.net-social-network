using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Models.Users;
using SocialNetwork.Models.Users.Status;

namespace SocialNetwork.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /*
         * Set the tables up
         */
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<ApplicationUserFriend> UserFriends { get; set; }
        public virtual DbSet<ApplicationUserFriendRequest> UserFriendRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>(aU =>
            {
                aU.HasMany<Post>(a => a.Posts)
                    .WithOne(b => b.User)
                    .HasForeignKey(c => c.UserId)
                    .OnDelete(DeleteBehavior.Cascade);   
                aU.HasMany(d => d.UserFriends)
                    .WithOne(e => e.User)
                    .HasForeignKey(f => f.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
                aU.HasMany(g => g.UserFriendRequests)
                    .WithOne(h => h.User)
                    .HasForeignKey(i => i.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
