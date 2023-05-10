using AspFinalProject.Models.Contexts;
using AspFinalProject.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AspFinalProject.Repositories
{
    public abstract class AccountRepository<TEntity> where TEntity : class
    {
        private readonly AppDbContext _context;

        protected AccountRepository(AppDbContext context)
        {
            _context = context;
        }

        //Skapa en användare
        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        //Hämta en användare
        public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
        {
            var entity =await _context.Set<TEntity>().FirstOrDefaultAsync(expression);
            if (entity != null)
                return entity;

            return null;
        }

        //Hämta alla användare
        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
           
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _context.Set<TEntity>().Where(expression).ToListAsync();

        }

        //Uppdatera en användare

        public virtual async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<bool> DeleteAsync(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

    }
}
