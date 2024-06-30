using LINQ5_Practice.Models;
using Microsoft.EntityFrameworkCore;

namespace LINQ5_Practice.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<tblStudent> tblStudent { get; set; }
        public DbSet<tblSubject> tblSubject { get; set; }
        public DbSet<tblCourse> tblCourse { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Student - Course many-to-many relationship
            modelBuilder.Entity<tblStudent>()
                .HasOne(s => s.tblCourse)
                .WithMany(c => c.tblStudent)
                .HasForeignKey(s => s.CourseId);

            //Student - Suject many-to-many relationship
            modelBuilder.Entity<tblStudent>()
                .HasOne(s => s.tblSubject)
                .WithMany(sub => sub.tblStudent)
                .HasForeignKey(s => s.SubjectId);

            //Subject - Course many-to-many relationship
            modelBuilder.Entity<tblSubject>()
                .HasOne(sub => sub.tblCourse)
                .WithMany(c => c.tblSubject)
                .HasForeignKey(sub => sub.CourseId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
