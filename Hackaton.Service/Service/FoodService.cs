using AutoMapper;
using Hackaton.DataAcces.IRepository;
using Hackaton.Domain.Entity.Foods;
using Hackaton.Service.DTOs;
using Hackaton.Service.IService;
using System.Linq.Expressions;

namespace Hackaton.Service.Service
{
    public class FoodService : IFoodService
    {
        private readonly IGenericRepository<Food> repository;

        private readonly IMapper mapper;

        public FoodService(IGenericRepository<Food> repository,
            IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async ValueTask<FoodDto> CreateAsync(FoodDto entity)
        {
            var food = new Food();
            if (entity is not null)
            {
                var newFood = mapper.Map<Food>(entity);
                food = await repository.CreateAsync(newFood);
            }
            repository.SaveChangesAsync();
            return mapper.Map<FoodDto>(food);
        }

        public async ValueTask<bool> DeleteAsync(Expression<Func<Food, bool>> expression)
        {
            bool result = await repository.DeleteAsync(expression);
            await repository.SaveChangesAsync();
            return result;
        }

        public IQueryable<Food> GetAll(Expression<Func<Food, bool>> expression, string[] includes = null)
            => repository.GetAll(expression, includes);

        public async ValueTask<FoodDto> GetAsync(Expression<Func<Food, bool>> expression, string[] includes = null)
        {
            var food = await repository.GetAsync(expression, includes);
            return mapper.Map<FoodDto>(food);
        }

        public FoodDto Update(int id, FoodDto entity)
        {
            var food = mapper.Map<Food>(entity);
            food.Id = id;
            var newFood = repository.Update(food);
            return mapper.Map<FoodDto>(newFood);

        }
    }
}
