using Hackaton.Domain.Entity.Foods;
using Hackaton.Domain.Entity.Orders;
using Hackaton.Domain.Entity.Tables;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.DataAcces.DBContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { }

        public DbSet<Food> Foods { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderInFood> OrdersInFood { get; set; }

        public DbSet<Table> Tables { get; set; }
    }
}
