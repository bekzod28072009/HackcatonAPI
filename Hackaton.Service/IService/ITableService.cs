using Hackaton.Domain.Entity.Tables;
using Hackaton.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Service.IService
{
    public interface ITableService
    {
        IQueryable<Table> GetAll(Expression<Func<Table, bool>> expression, string[] includes = null);
        ValueTask<TableDto> GetAsync(Expression<Func<Table, bool>> expression, string[] includes = null);
        ValueTask<TableDto> CreateAsync(TableDto entity);
        ValueTask<bool> DeleteAsync(Expression<Func<Table, bool>> expression);
        TableDto Update(int id, TableDto entity);
    }
}
