using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Database
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)         
        {         
        }
        
        public DbSet<Person> Persons { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}