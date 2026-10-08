using Domain.Entities;

namespace Infrastructure.Repositories.Interfaces
{
    public interface IApplicationDocumentRepository
        : IGenericRepository<ApplicationDocument>
    {
        Task<IEnumerable<ApplicationDocument>> GetByApplicationIdAsync(
            Guid applicationId,
            CancellationToken cancellationToken);
    }
}