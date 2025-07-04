using Microsoft.EntityFrameworkCore;
using ShowTime.Data;
using static ShowTime.Data.ShowTimeContext;
using ShowTime.Data;
using ShowTime.Models;
using ShowTime.Repositories.Interfaces;


namespace ShowTime.Repositories.Implementation{

    public class RepositoryBase<T>:IRepositoryBase<T> where T:class
    {
        protected readonly ShowTimeContext Context;
        protected readonly DbSet<T> DbSet;

        public RepositoryBase(ShowTimeContext context)
        {
            Context = context;
            DbSet = Context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await DbSet.AddAsync(entity);
        }
        
        public void Delete(T entity)
        {
           DbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            DbSet.Update(entity);
        }
        
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task SaveChangesAsync()
        {
            await Context.SaveChangesAsync();
        }
        
        
    }
}