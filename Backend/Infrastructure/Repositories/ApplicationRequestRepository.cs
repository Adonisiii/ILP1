using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ApplicationRequestRepository
        : GenericRepository<ApplicationRequest>,
          IApplicationRequestRepository
    {
        public ApplicationRequestRepository(AppDbContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<ApplicationRequest>> GetByUserIdAsync(
            Guid userId,
            CancellationToken cancellationToken)
        {
            return await _dbSet
                .Where(x => x.UserId == userId)
                .ToListAsync(cancellationToken);
        }
    }
}