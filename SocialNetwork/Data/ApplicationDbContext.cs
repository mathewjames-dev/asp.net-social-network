using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Models.Users;
using SocialNetwork.Models.Users.Status;

namespace SocialNetwork.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Set the Status
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configure 1 - Many relationship between user and status updates.
            builder.Entity<ApplicationUser>()
                .HasMany(c => c.Posts)
                .WithOne(e => e.User);

        }
    }
}
