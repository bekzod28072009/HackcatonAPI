using Hackaton.Domain.Entity.Foods;
using Hackaton.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Service.IService
{
    public interface IFoodService
    {
        IQueryable<Food> GetAll(Expression<Func<Food, bool>> expression, string[] includes = null);
        ValueTask<FoodDto> GetAsync(Expression<Func<Food, bool>> expression, string[] includes = null);
        ValueTask<FoodDto> CreateAsync(FoodDto entity);
        ValueTask<bool> DeleteAsync(Expression<Func<Food, bool>> expression);
        FoodDto Update(int id, FoodDto entity);
    }
}
