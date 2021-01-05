using Microsoft.EntityFrameworkCore;
using Service.Data;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Resposition
{
    public class BaseRespository<T> : IRespositony<T> where T : class
    {
        private readonly HotelDbContext _context;

        public BaseRespository(HotelDbContext context)
        {
            _context = context;
        }

        public virtual async Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            var result = await _context.Set<T>().AddAsync(entity, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return result.Entity;
        }

        public virtual async Task<bool> DeleteAsync(object id, CancellationToken cancellationToken = default)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity == null)
            {
                return false;
            }

            _context.Set<T>().Remove(entity);
            return await _context.SaveChangesAsync(cancellationToken) > 0;
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(object id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public virtual async Task<bool> UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            _context.Entry(entity).State = EntityState.Modified;

            return await _context.SaveChangesAsync(cancellationToken) > 0;
        }
    }
}