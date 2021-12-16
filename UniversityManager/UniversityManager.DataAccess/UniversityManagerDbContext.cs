using UniversityManager.DataAccess.Entity;
using Microsoft.EntityFrameworkCore;

namespace UniversityManager.DataAccess
{
    public partial class UniversityManagerDbContext : DbContext
    {
        public UniversityManagerDbContext()
        {
        }

        public UniversityManagerDbContext(DbContextOptions<UniversityManagerDbContext> options)
            : base(options)
        {
        }

        public DbSet<StudentDataSet> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentDataSet>();

            base.OnModelCreating(modelBuilder);
        }


    }



}
