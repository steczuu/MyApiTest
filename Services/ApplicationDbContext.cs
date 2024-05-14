using Microsoft.EntityFrameworkCore;
using MyAPI.Models;

namespace MyAPI.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> customers { get; set; }
        public DbSet<Product> products { get; set; }    
        public DbSet<Transaction> transactions { get; set; }    
    }
}
