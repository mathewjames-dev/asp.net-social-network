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
         * Set the Status table
         */
        public virtual DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>()
                .HasMany<Post>(c => c.Posts)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId);

            builder.Entity<ApplicationUser>()
                .HasMany<ApplicationUserFriend>(c => c.UserFriends)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId);

            builder.Entity<ApplicationUser>()
               .HasMany<ApplicationUserFriendRequest>(c => c.UserFriendRequests)
               .WithOne(a => a.User)
               .HasForeignKey(a => a.UserId);
        }
    }
}
