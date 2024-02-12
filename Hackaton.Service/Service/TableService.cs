using AutoMapper;
using Hackaton.DataAcces.IRepository;
using Hackaton.Domain.Entity.Tables;
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
    public class TableService : ITableService
    {
        private readonly IGenericRepository<Table> repository;
        private readonly IMapper mapper;

        public TableService(IGenericRepository<Table> repository,
            IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async ValueTask<TableDto> CreateAsync(TableDto entity)
        {
            var table = new Table();
            if (entity is not null)
            {
                var newTable = mapper.Map<Table>(entity);
                table = await repository.CreateAsync(newTable);
            }
            await repository.SaveChangesAsync();
            return mapper.Map<TableDto>(table);
        }

        public async ValueTask<bool> DeleteAsync(Expression<Func<Table, bool>> expression)
        {
            bool result = await repository.DeleteAsync(expression);
            await repository.SaveChangesAsync();
            return result;
        }

        public IQueryable<Table> GetAll(Expression<Func<Table, bool>> expression, string[] includes = null)
            => repository.GetAll(expression, includes);

        public async ValueTask<TableDto> GetAsync(Expression<Func<Table, bool>> expression, string[] includes = null)
        {
            var table = await repository.GetAsync(expression, includes);
            return mapper.Map<TableDto>(table);
        }

        public TableDto Update(int id, TableDto entity)
        {
            var table = mapper.Map<Table>(entity);
            table.Id = id;
            var newTable = repository.Update(table);
            return mapper.Map<TableDto>(newTable);
        }
    }
}
