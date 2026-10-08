using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class UserRepository
        : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context)
            : base(context)
        {
        }

        public async Task<User?> GetByPersonalNumberAsync(
            string personalNumber,
            CancellationToken cancellationToken)
        {
            return await _dbSet
                .FirstOrDefaultAsync(
                    x => x.PersonalNumber == personalNumber,
                    cancellationToken);
        }
    }
}