using Domain.Entities;

namespace Infrastructure.Repositories.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User?> GetByPersonalNumberAsync(
            string personalNumber,
            CancellationToken cancellationToken);
    }
}