using Domain.Entities;

namespace Application.Interfaces
{
    public interface IActivityRepository
    {
        Task AddAsync(
            Activity activity,
            CancellationToken cancellationToken);

        Task UpdateAsync(
            Activity activity,
            CancellationToken cancellationToken);

        Task DeleteAsync(
            Activity activity,
            CancellationToken cancellationToken);

        Task<Activity?> GetByIdAsync(
            Guid id,
            CancellationToken cancellationToken);

        Task<IEnumerable<Activity>> GetByApplicationIdAsync(
            Guid applicationId,
            CancellationToken cancellationToken);
    }
}