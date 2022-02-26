using Microsoft.EntityFrameworkCore;
using N_tierCrudEntity.Domain;
using N_tierCrudEntity.Domain.Customs;

namespace N_tierCrudEntity.Data.Contexts
{
    internal class TestDbContext : DbContext
    {
        public DbSet<University> Universities { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Student> Students { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Constants.TESTDB_CONNECTION);
        }
    }
}
