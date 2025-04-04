using SerialMakerBlazor.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SerialMakerBlazor.Repositories
{
    public interface IGenericRepo<TEntity> where TEntity : class
    {

        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression);
        Task<IQueryable<TEntity>> GetAllAsync();
        Task<IQueryable<TEntity>> GetAllAsync(int takeCount);
        Task<IQueryable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression);
        Task<TEntity> GetByIdAsync(object id);
        Task AddAsync(TEntity entity);
        void Add(TEntity entity);
        void DeleteAll(List<TEntity> entities);
        void UpdateAll(List<TEntity> entity);
        Task<TEntity> InsertAsync(TEntity entity);
        Task UpdateAsync(int id, TEntity entity);
        Task UpdateAsync(object id, TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(object id);
        Task<IQueryable<TEntity>> GetAllWithIncludesAsync(params Expression<Func<TEntity, object>>[] includes);
        Task<IQueryable<TEntity>> GetAllWithIncludesAsync(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] includes);
        Task<IQueryable<TEntity>> GetAllWithIncludesWithOrderByAsync(Expression<Func<TEntity, bool>> expression, Expression<Func<TEntity, object>> orderby = null, params Expression<Func<TEntity, object>>[] includes);
        IQueryable<TEntity> GetAllWithIncludes(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] includes);
        Task<IQueryable<TEntity>> SearchAsync(Expression<Func<TEntity, bool>> expression);
        Task BulkInsert(string sql);
        Task<PaginatedListDto<TEntity>> GetPaginatedAsync(IQueryable<TEntity> userQuery, int pageIndex, int pageSize);
        Task<PaginatedListDto<TEntity>> GetPaginatedAsync(Expression<Func<TEntity, bool>> expression, int pageIndex, int pageSize);
        Task<int> GetCountAsync(IQueryable<TEntity> entities);
    }
}
