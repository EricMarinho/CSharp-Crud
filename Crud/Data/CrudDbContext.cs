using Microsoft.EntityFrameworkCore;
using Crud.src.User;
using Crud.src.State;
using Crud.src.City;

namespace Crud.Data
{
    public class CrudDbContext : DbContext
    {
        public CrudDbContext(DbContextOptions<CrudDbContext> options) : base(options)
        {
        }
        public DbSet<StateEntity> States { get; set; }
        public DbSet<CityEntity> Cities { get; set; }
        public DbSet<UserEntity> People { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StateEntity>().ToTable("State");
            modelBuilder.Entity<CityEntity>().ToTable("City");
            modelBuilder.Entity<UserEntity>().ToTable("Person");
        }
    }
}
