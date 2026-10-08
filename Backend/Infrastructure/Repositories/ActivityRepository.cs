using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Application.Interfaces;

namespace Infrastructure.Repositories
{
    public class ActivityRepository
        : GenericRepository<Activity>, IActivityRepository
    {
        public ActivityRepository(AppDbContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<Activity>> GetByApplicationIdAsync(
            Guid applicationId,
            CancellationToken cancellationToken)
        {
            return await _dbSet
                .Where(x => x.ApplicationRequestId == applicationId)
                .ToListAsync(cancellationToken);
        }
    }
}