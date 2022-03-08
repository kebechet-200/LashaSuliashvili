using Microsoft.EntityFrameworkCore;
using Practice_1.PersistanceDB.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EstateManagement.Data.EF
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {

        protected readonly DbContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(EstateManagementContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public IQueryable<T> Table => _dbSet;

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            _context.SaveChanges();
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AnyAsync(expression);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
             return await _dbSet.SingleOrDefaultAsync(expression);
        }

        public async Task<T> GetAsync(int key)
        {
            return await _dbSet.FindAsync(key);
        }

        public async Task<List<T>> GetFilteredAsync(Expression<Func<T,bool>> expression)
        {
            return await _dbSet.Where(expression).ToListAsync();
        }

        public async Task RemoveAsync(int id)
        {
            var entity = await GetAsync(id);
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            if (entity == null) return;

            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
