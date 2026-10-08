using Domain.Entities;

namespace Infrastructure.Repositories.Interfaces
{
    public interface IAnnualPlanRepository
        : IGenericRepository<AnnualPlan>
    {
        Task<AnnualPlan?> GetByApplicationIdAsync(
            Guid applicationId,
            CancellationToken cancellationToken);
    }
}