using Microsoft.EntityFrameworkCore;
using ShowTime.Data;
using static ShowTime.Data.ShowTimeContext;
using ShowTime.Data;
using ShowTime.Models;
using ShowTime.Repositories.Interfaces;


namespace ShowTime.Repositories.Implementation{

    public class RepositoryBase<T>:IRepositoryBase<T> where T:class
    {
        protected readonly ShowTimeContext _context;
        protected readonly DbSet<T> _dbSet;

        public RepositoryBase(ShowTimeContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }
        
        public void Delete(T entity)
        {
           _dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
        
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
        
        
    }
}