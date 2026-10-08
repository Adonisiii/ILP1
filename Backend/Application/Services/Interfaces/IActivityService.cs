using Application.DTOs.Activity;

namespace Application.Interfaces
{
    public interface IActivityService
    {
        Task AddActivityAsync(
            Guid applicationId,
            AddActivityRequestDto model,
            CancellationToken cancellationToken);

        Task<IEnumerable<ActivityResponseDto>>
            GetByApplicationIdAsync(
                Guid applicationId,
                CancellationToken cancellationToken);

        Task<ActivityResponseDto?> GetByIdAsync(
            Guid id,
            CancellationToken cancellationToken);

        Task UpdateActivityAsync(
            Guid id,
            UpdateActivityRequestDto model,
            CancellationToken cancellationToken);

        Task DeleteActivityAsync(
            Guid id,
            CancellationToken cancellationToken);
    }
}