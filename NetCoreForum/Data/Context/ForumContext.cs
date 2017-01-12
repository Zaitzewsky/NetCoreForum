using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Data
{
    public class ForumContext : IdentityDbContext<User>
    {
        public ForumContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>()
                .Property(user => user.FirstName)
                .HasMaxLength(30)
                .IsRequired();

            builder.Entity<User>()
                .Property(user => user.LastName)
                .HasMaxLength(30)
                .IsRequired();

            builder.Entity<User>()
                .Property(user => user.Email)
                .IsRequired();

            builder.Entity<User>()
                .Property(user => user.UserName)
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
