using Microsoft.EntityFrameworkCore;
using EmailSendingWithOtp.Model;

namespace EmailSendingWithOtp.Data
{
    public class DemoDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var path = "Server=localhost\\SQLEXPRESS;Database=Test;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(path);
        }
        public DbSet<Email> Emails { get; set; }
        public DbSet<User> Users { get;set; }
        
    }
}
