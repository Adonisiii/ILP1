using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class AnnexRepository
        : GenericRepository<Annex>, IAnnexRepository
    {
        public AnnexRepository(AppDbContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<Annex>> GetByApplicationIdAsync(
            Guid applicationId,
            CancellationToken cancellationToken)
        {
            return await _dbSet
                .Where(x => x.ApplicationRequestId == applicationId)
                .ToListAsync(cancellationToken);
        }
    }
}