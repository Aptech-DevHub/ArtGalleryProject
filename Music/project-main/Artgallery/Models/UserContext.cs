using Microsoft.EntityFrameworkCore;

namespace Artgallery.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Art> Arts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
