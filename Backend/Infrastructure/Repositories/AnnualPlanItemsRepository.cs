using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class AnnualPlanItemsRepository
        : GenericRepository<AnnualPlanItems>,
          IAnnualPlanItemsRepository
    {
        public AnnualPlanItemsRepository(AppDbContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<AnnualPlanItems>>
            GetByAnnualPlanIdAsync(
                Guid annualPlanId,
                CancellationToken cancellationToken)
        {
            return await _dbSet
                .Where(x => x.AnnualPlanId == annualPlanId)
                .ToListAsync(cancellationToken);
        }
    }
}
