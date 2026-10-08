using Domain.Entities;

namespace Infrastructure.Repositories.Interfaces
{
    public interface IRoleRepository : IGenericRepository<Role>
    {
        Task<Role?> GetByNameAsync(
            string name,
            CancellationToken cancellationToken);
    }
}
