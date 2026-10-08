using Domain.Entities;

namespace Infrastructure.Repositories.Interfaces
{
    public interface IAnnexRepository : IGenericRepository<Annex>
    {
        Task<IEnumerable<Annex>> GetByApplicationIdAsync(
            Guid applicationId,
            CancellationToken cancellationToken);
    }
}