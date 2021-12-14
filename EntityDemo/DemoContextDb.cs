using EntityDemo.models;
using Microsoft.EntityFrameworkCore;

namespace EntityDemo
{
    public class DemoContextDb : DbContext
    {
        public DemoContextDb()
        {
            Database.EnsureCreated();
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=EntityDemo;Username=postgres;Password=admin");
        }
    }
}