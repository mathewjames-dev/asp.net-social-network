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

            /* builder.Entity<ApplicationUser>()
                 .HasMany<Post>(c => c.Posts)
                 .WithOne(a => a.User)
                 .HasForeignKey(a => a.UserId);*/

            builder.Entity<ApplicationUser>()
                .HasMany(up => up.UserFriends)
                .WithOne(u => u.User)
                .OnDelete(DeleteBehavior.Cascade);

            /*builder.Entity<ApplicationUser>()
               .HasMany(up => up.UserFriendRequests)
               .WithOne(u => u.User)
               .HasForeignKey(a => a.UserId);*/
        }
    }
}
