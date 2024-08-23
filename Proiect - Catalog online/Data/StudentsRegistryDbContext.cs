using Microsoft.EntityFrameworkCore;
using Proiect___Catalog_online.Models;
namespace Proiect___Catalog_online.Data
{
    public class StudentsRegistryDbContext : DbContext
    {
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        public StudentsRegistryDbContext(DbContextOptions<StudentsRegistryDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

