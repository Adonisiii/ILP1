using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ApplicationDocumentRepository
        : GenericRepository<ApplicationDocument>,
          IApplicationDocumentRepository
    {
        public ApplicationDocumentRepository(AppDbContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<ApplicationDocument>>
            GetByApplicationIdAsync(
                Guid applicationId,
                CancellationToken cancellationToken)
        {
            return await _dbSet
                .Where(x => x.ApplicationRequestId == applicationId)
                .ToListAsync(cancellationToken);
        }
    }
}