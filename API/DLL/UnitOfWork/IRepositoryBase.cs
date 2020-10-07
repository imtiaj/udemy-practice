using DLL.DbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DLL.UnitOfWork
{
    public interface IRepositoryBase <T> where T:class
    {
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression=null);
        Task<T> GetAAsync(Expression<Func<T, bool>> expression=null);
        Task CreateAsync(T entity);
        void Update(T entity);
        void Delete(T entity);

        Task<bool> EntitySaveChangeAsync();
    }

    public class RepositoryBase <T> : IRepositoryBase <T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public RepositoryBase(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public async Task<bool> EntitySaveChangeAsync()
        {
            return await _context.SaveChangesAsync() > 0 ? true : false;
        }

        public async Task<T> GetAAsync(Expression<Func<T, bool>> expression = null)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(expression);
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression = null)
        {
            if(expression == null)
            {
                return await _context.Set<T>().ToListAsync();
            }
            return await _context.Set<T>().Where(expression).ToListAsync();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
