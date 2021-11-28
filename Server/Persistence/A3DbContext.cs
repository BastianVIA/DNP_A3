using Entities;
using Microsoft.EntityFrameworkCore;

namespace Server.Persistence
{
    public class A3DbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Adult> Adults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = C:\Users\basti\RiderProjects\DNP_Assignment3\Server\A3.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}