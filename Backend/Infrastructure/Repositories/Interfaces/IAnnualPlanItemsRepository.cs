using Domain.Entities;

namespace Infrastructure.Repositories.Interfaces
{
    public interface IAnnualPlanItemsRepository
        : IGenericRepository<AnnualPlanItems>
    {
        Task<IEnumerable<AnnualPlanItems>> GetByAnnualPlanIdAsync(
            Guid annualPlanId,
            CancellationToken cancellationToken);
    }
}
