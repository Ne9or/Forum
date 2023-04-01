using Forum.Data.Configure;
using Forum.Data.Models;
using Forum.Data.Models.Account;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Forum.Data
{
    public class ForumDbContext: IdentityDbContext<ApplicationUser>
    {
        public ForumDbContext(DbContextOptions<ForumDbContext> options)
            : base(options)
        {   
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration<Post>(new PostConfiguration());
            builder.Entity<Post>()
                .Property(p => p.IsDeleted)
                .HasDefaultValue(false);
            
            base.OnModelCreating(builder);
        }

        public DbSet<Post> Posts { get; set; }
    }
}
