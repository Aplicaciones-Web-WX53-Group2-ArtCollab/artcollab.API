namespace Infraestructure;

public class SubscriptionData:ISubscriptionData
{
    
}
using Infraestructure.Context;
using Infraestructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.MySql
{
    public class SubscriptionData<TEntity>(TemplateDBContext context) : IRepository<TEntity> where TEntity : class
    {
        private readonly TemplateDBContext _context = context;
        private readonly DbSet<TEntity> _dbSet = context.Set<TEntity>();
        
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task Add(TEntity entity)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                await _dbSet.AddAsync(entity);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
            }
        }

        public async Task Update(TEntity entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            _dbSet.Remove(entity);
            
            await _context.SaveChangesAsync();
        }
    }
}