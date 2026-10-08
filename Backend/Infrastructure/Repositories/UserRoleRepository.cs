using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class UserRoleRepository
        : GenericRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(AppDbContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<UserRole>> GetByUserIdAsync(
            Guid userId,
            CancellationToken cancellationToken)
        {
            return await _dbSet
                .Where(x => x.UserId == userId)
                .Include(x => x.Role)
                .ToListAsync(cancellationToken);
        }
    }
}