using Microsoft.EntityFrameworkCore;
using REPLSolutions_IDGenerator.Models;

namespace REPLSolutions_IDGenerator.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Admission> Admissions { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Guardian> Guardians { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guardian>()
       .HasOne(g => g.GuardianExtensionForIndium)
       .WithOne(e => e.IdNavigation)
       .HasForeignKey<GuardianExtensionForIndium>(e => e.Id);


            modelBuilder.Entity<Student>()
        .HasOne(s => s.StudentExtensionForIndium)
        .WithOne(e => e.IdNavigation)
        .HasForeignKey<StudentExtensionForIndium>(e => e.Id);

        }
    }
}
