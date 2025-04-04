using Microsoft.EntityFrameworkCore;
using SerialMakerBlazor.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SerialMakerBlazor.Repositories
{
    public class GenericRepo<TEntity> : IGenericRepo<TEntity> where TEntity : class
    {
        private readonly Data.ApplicationDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepo(Data.ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        protected Data.ApplicationDbContext DbContext => _context;
        public async Task<PaginatedListDto<TEntity>> GetPaginatedAsync(IQueryable<TEntity> userQuery, int pageIndex, int pageSize)
        {
            var count = 100000;// await userQuery.CountAsync();
            if (pageIndex <= 0)
                pageIndex = 1;
            var items = await userQuery.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PaginatedListDto<TEntity>(items, count, pageIndex, pageSize);
        }
        public async Task<int> GetCountAsync(IQueryable<TEntity> entities)
        {
            var count = await entities.CountAsync();
            return count;
        }
        public async Task<PaginatedListDto<TEntity>> GetPaginatedAsync(Expression<Func<TEntity, bool>> expression, int pageIndex, int pageSize)
        {
            var qry = await Task.FromResult(_dbSet?.AsNoTracking());
            if (expression != null)
                qry = qry?.Where(expression);
            var rtv = await GetPaginatedAsync(qry, pageIndex, pageSize);
            return rtv;
        }
        public IQueryable<TEntity> GetAll()
        {
            return _dbSet.AsNoTracking();
        }
        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression)
        {
            return _dbSet?.Where(expression).AsNoTracking();
        }

        public async Task<IQueryable<TEntity>> GetAllAsync()
        {
            return await Task.FromResult(_dbSet.AsNoTracking());
        }
        public async Task<IQueryable<TEntity>> GetAllAsync(int takeCount)
        {
            if (takeCount > 0)
                return await Task.FromResult(_dbSet?.Take(takeCount).AsNoTracking());
            else
                return await Task.FromResult(_dbSet?.Take(takeCount).AsNoTracking());
        }
        public async Task<IQueryable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await Task.FromResult(_dbSet?.Where(expression).AsNoTracking());
        }
        protected async Task<IEnumerable<TEntity>> GetAllWithIncludesAsync(params string[] includes)
        {
            IQueryable<TEntity> query = _dbSet;

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return await query?.AsNoTracking()?.ToListAsync();
        }

        public async Task<IQueryable<TEntity>> GetAllWithIncludesAsync(params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _dbSet;

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return await Task.FromResult(query?.AsNoTracking());
        }
        public async Task<IQueryable<TEntity>> GetAllWithIncludesAsync(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _dbSet?.AsNoTrackingWithIdentityResolution();

            foreach (var include in includes)
            {
                query = query.Include(include).AsNoTrackingWithIdentityResolution();
            }

            return await Task.FromResult(query?.Where(expression)?.AsNoTrackingWithIdentityResolution());
        }
        public async Task<IQueryable<TEntity>> GetAllWithIncludesWithOrderByAsync(Expression<Func<TEntity, bool>> expression, Expression<Func<TEntity, object>> orderBy, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _dbSet?.AsNoTrackingWithIdentityResolution();

            foreach (var include in includes)
            {
                query = query.Include(include).AsNoTrackingWithIdentityResolution();

            }
            if (orderBy != null)
                query = query.OrderByDescending(orderBy);
            return await Task.FromResult(query?.Where(expression)?.AsNoTrackingWithIdentityResolution());
        }
        public IQueryable<TEntity> GetAllWithIncludes(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _dbSet;

            foreach (var include in includes)
            {
                query = query.Include(include).AsNoTracking();
            }

            return query?.Where(expression)?.AsNoTracking();
        }
       
        public async Task<TEntity> GetByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }
       
        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        public void DeleteAll(List<TEntity> entity)
        {
            _dbSet.RemoveRange(entity);
            _context.SaveChanges();
        }
        public void UpdateAll(List<TEntity> entity)
        {
            _dbSet.UpdateRange(entity);
            _context.SaveChanges();
        }
        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            await _context.Entry(entity).ReloadAsync();
            return entity;
        }
       
        public async Task UpdateAsync(int Id, TEntity entity)
        {

            //_dbSet.Update(entity);
            //await _context.SaveChangesAsync();
            var existingEntity = await _dbSet.FindAsync(Id);
            if (existingEntity != null)
            {
                _context.Entry(existingEntity).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync();
            }
        }
        public async Task UpdateAsync(object Id, TEntity entity)
        {
            //_dbSet.Update(entity);
            //await _context.SaveChangesAsync();
            var existingEntity = await _dbSet.FindAsync(Id);
            if (existingEntity != null)
            {
                _context.Entry(existingEntity).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync();
            }
        }
        public async Task UpdateAsync(TEntity entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }
      
        public async Task DeleteAsync(object id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
        async Task IGenericRepo<TEntity>.BulkInsert(string sql)
        {
            try
            {
                var rtv = await _context.Database.ExecuteSqlRawAsync(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex?.Message + " ### " + ex?.InnerException?.Message);
            }
        }
       
        async Task<IQueryable<TEntity>> IGenericRepo<TEntity>.SearchAsync(Expression<Func<TEntity, bool>> expression)
        {
            var rtv = await Task.FromResult(_dbSet.Where(expression)?.AsNoTracking());
            return rtv;
        }
    }
}
