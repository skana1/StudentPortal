using Microsoft.EntityFrameworkCore;
using StudentPortal.Web.Models.Entities;

namespace StudentPortal.Web.Data
{
    public class ApplicationDbContext: DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base (options)
        {
            
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(s => s.Id)
                .HasColumnType("CHAR(36)"); // Use CHAR(36) for Guid

            modelBuilder.Entity<Student>()
                .Property(s => s.Name)
                .HasColumnType("TEXT"); // Use TEXT for long strings

            modelBuilder.Entity<Student>()
                .Property(s => s.Email)
                .HasColumnType("TEXT"); // Use TEXT for long strings

            modelBuilder.Entity<Student>()
                .Property(s => s.Phone)
                .HasColumnType("TEXT"); // Use TEXT for long strings

            modelBuilder.Entity<Student>()
                .Property(s => s.Subscriber)
                .HasColumnType("TINYINT(1)"); // Use TINYINT(1) for boolean values
        }
    }
}