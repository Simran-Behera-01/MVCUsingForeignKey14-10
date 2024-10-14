using Microsoft.EntityFrameworkCore;

namespace MVCUsingForeignKey14_10.Models
{
    public class TrainingDbContext : DbContext
    {
        public TrainingDbContext(DbContextOptions<TrainingDbContext> options) : base(options) { }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
    }
}
