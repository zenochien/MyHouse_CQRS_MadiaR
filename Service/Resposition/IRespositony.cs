using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Resposition
{
    public interface IRespositony<T>
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(object id);

        Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);

        Task<bool> UpdateAsync(T entity, CancellationToken cancellationToken = default);

        Task<bool> DeleteAsync(object id, CancellationToken cancellationToken = default);
    }
}