using AutoMapper;
using Hackaton.DataAcces.IRepository;
using Hackaton.Domain.Entity.Orders;
using Hackaton.Service.DTOs;
using Hackaton.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Service.Service
{
    public class OrderInFoodService : IOrderInFoodService
    {
        private readonly IGenericRepository<OrderInFood> repository;
        private readonly IMapper mapper;

        public OrderInFoodService(IGenericRepository<OrderInFood> repository,
            IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async ValueTask<OrderInFoodDto> CreateAsync(OrderInFoodDto entity)
        {
            var orderInFood = new OrderInFood();
            if (entity is not null)
            {

                var orderFood = mapper.Map<OrderInFood>(entity);
                var newOrderInFood = await repository.CreateAsync(orderFood);
            }
            repository.SaveChangesAsync();
            return mapper.Map<OrderInFoodDto>(orderInFood);
        }

        public async ValueTask<bool> DeleteAsync(Expression<Func<OrderInFood, bool>> expression)
        {
            bool res = await repository.DeleteAsync(expression);
            await repository.SaveChangesAsync();
            return res;
        }

        public IQueryable<OrderInFood> GetAll(Expression<Func<OrderInFood, bool>> expression, string[] includes = null)
            => repository.GetAll(expression, includes);

        public async ValueTask<OrderInFoodDto> GetAsync(Expression<Func<OrderInFood, bool>> expression, string[] includes = null)
        {
            var orderInFood = repository.GetAsync(expression, includes);
            return mapper.Map<OrderInFoodDto>(orderInFood);
        }

        public OrderInFoodDto Update(int id, OrderInFoodDto entity)
        {
            var orderInFood = mapper.Map<OrderInFood>(entity);
            orderInFood.Id = id;
            var UpdateUser = repository.Update(orderInFood);
            repository.SaveChangesAsync();
            return mapper.Map<OrderInFoodDto>(UpdateUser);
        }
    }
}
