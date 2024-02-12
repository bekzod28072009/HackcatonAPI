using Hackaton.Domain.Entity.Orders;
using Hackaton.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Service.IService
{
    public interface IOrderInFoodService
    {
        IQueryable<OrderInFood> GetAll(Expression<Func<OrderInFood, bool>> expression, string[] includes = null);
        ValueTask<OrderInFoodDto> GetAsync(Expression<Func<OrderInFood, bool>> expression, string[] includes = null);
        ValueTask<OrderInFoodDto> CreateAsync(OrderInFoodDto entity);
        ValueTask<bool> DeleteAsync(Expression<Func<OrderInFood, bool>> expression);
        OrderInFoodDto Update(int id, OrderInFoodDto entity);
    }
}
