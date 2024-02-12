using AutoMapper;
using Hackaton.Domain.Entity.Foods;
using Hackaton.Domain.Entity.Orders;
using Hackaton.Domain.Entity.Tables;
using Hackaton.Service.DTOs;

namespace HackatonAPI.Configurations
{
    public class MapConfiguration : Profile
    {
        public MapConfiguration()
        {
            CreateMap<Table, TableDto>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<OrderInFood, OrderInFoodDto>().ReverseMap();
            CreateMap<Food, FoodDto>().ReverseMap();
        }
    }
}
