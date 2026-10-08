using Domain.Entities;

namespace Infrastructure.Repositories.Interfaces
{
    public interface IApplicationRequestRepository
        : IGenericRepository<ApplicationRequest>
    {
        Task<IEnumerable<ApplicationRequest>> GetByUserIdAsync(
            Guid userId,
            CancellationToken cancellationToken);
    }
}