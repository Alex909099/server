using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAuthorization22.Data.Identity;

namespace WebAuthorization22.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationIdentityUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Message>().Property(z => z.ID).UseIdentityColumn();
            builder.Entity<Message>().Property(z => z.Text).HasMaxLength(200);


            base.OnModelCreating(builder);
        }

        public DbSet<Message> Messages { get; set; }   
    }
}