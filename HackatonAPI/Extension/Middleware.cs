using Hackaton.DataAcces.DBContexts;
using Hackaton.DataAcces.IRepository;
using Hackaton.DataAcces.Repository;
using Hackaton.Domain.Entity.Foods;
using Hackaton.Domain.Entity.Orders;
using Hackaton.Domain.Entity.Tables;
using Hackaton.Service.IService;
using Hackaton.Service.Service;
using Microsoft.EntityFrameworkCore;

namespace HackatonAPI.Extension
{
    public static class Middleware
    {
        public static void AddDBConTextes(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                 options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        }

        public static void AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IGenericRepository<Food>, GenericRepository<Food>>();
            services.AddTransient<IGenericRepository<Order>, GenericRepository<Order>>();
            services.AddTransient<IGenericRepository<OrderInFood>, GenericRepository<OrderInFood>>();
            services.AddTransient<IGenericRepository<Table>, GenericRepository<Table>>();
        }

        public static void AddService(this IServiceCollection services)
        {
            services.AddTransient<IFoodService, FoodService>();
            services.AddTransient<IOrderInFoodService, OrderInFoodService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<ITableService, TableService>();
        }
    }
}
