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
    public class OrderService : IOrderService
    {
        private readonly IGenericRepository<Order> repository;
        private readonly IMapper mapper;

        public OrderService(IGenericRepository<Order> repository,
            IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public IQueryable<Order> GetAll(Expression<Func<Order, bool>> expression, string[] includes = null)
           => repository.GetAll(expression, includes);

        public async ValueTask<OrderDto> GetAsync(Expression<Func<Order, bool>> expression, string[] includes = null)
        {
            var AllOrder = await repository.GetAsync(expression, includes);
            return mapper.Map<OrderDto>(AllOrder);
        }

        public async ValueTask<OrderDto> CreateAsync(OrderDto entity)
        {
            var order = new Order();
            if (entity is not null)
            {
                var NewOrder = mapper.Map<Order>(entity);

                order = await repository.CreateAsync(NewOrder);
            }
            repository.SaveChangesAsync();
            return mapper.Map<OrderDto>(order);
        }

        public async ValueTask<bool> DeleteAsync(Expression<Func<Order, bool>> expression)
        {
            bool res = await repository.DeleteAsync(expression);
            await repository.SaveChangesAsync();
            return res;
        }

        public OrderDto Update(int id, OrderDto entity)
        {
            var upOrder = mapper.Map<Order>(entity);
            upOrder.Id = id;
            var UpdateUser = repository.Update(upOrder);
            repository.SaveChangesAsync();
            return mapper.Map<OrderDto>(UpdateUser);
        }
    }
}
