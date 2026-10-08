using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class AnnualPlanRepository
        : GenericRepository<AnnualPlan>, IAnnualPlanRepository
    {
        public AnnualPlanRepository(AppDbContext context)
            : base(context)
        {
        }

        public async Task<AnnualPlan?> GetByApplicationIdAsync(
            Guid applicationId,
            CancellationToken cancellationToken)
        {
            return await _dbSet
                .FirstOrDefaultAsync(
                    x => x.ApplicationRequestId == applicationId,
                    cancellationToken);
        }
    }
}