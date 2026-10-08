using Application.DTOs.Activity;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IActivityRepository _activityRepository;

        public ActivityService(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }

        // CREATE
        public async Task AddActivityAsync(
            Guid applicationId,
            AddActivityRequestDto model,
            CancellationToken cancellationToken)
        {
            var activity = new Activity
            {
                Code = model.Code,
                Description = model.Description,
                ApplicationRequestId = applicationId
            };

            await _activityRepository.AddAsync(
                activity, cancellationToken);
        }

        // READ - BY APPLICATION ID
        public async Task<IEnumerable<ActivityResponseDto>>
            GetByApplicationIdAsync(
                Guid applicationId,
                CancellationToken cancellationToken)
        {
            var activities =
                await _activityRepository.GetByApplicationIdAsync(
                    applicationId, cancellationToken);

            return activities.Select(x => new ActivityResponseDto
            {
                Id = x.Id,
                Code = x.Code,
                Description = x.Description,
                ApplicationRequestId = x.ApplicationRequestId
            });
        }

        // READ - BY ID
        public async Task<ActivityResponseDto?> GetByIdAsync(
            Guid id,
            CancellationToken cancellationToken)
        {
            var activity = await _activityRepository.GetByIdAsync(
                id, cancellationToken);

            if (activity == null)
                return null;

            return new ActivityResponseDto
            {
                Id = activity.Id,
                Code = activity.Code,
                Description = activity.Description,
                ApplicationRequestId = activity.ApplicationRequestId
            };
        }

        // UPDATE
        public async Task UpdateActivityAsync(
            Guid id,
            UpdateActivityRequestDto model,
            CancellationToken cancellationToken)
        {
            var activity = await _activityRepository.GetByIdAsync(
                id, cancellationToken);

            if (activity == null)
                throw new KeyNotFoundException("Activity not found.");

            activity.Code = model.Code;
            activity.Description = model.Description;

            await _activityRepository.UpdateAsync(
                activity, cancellationToken);
        }

        // DELETE
        public async Task DeleteActivityAsync(
            Guid id,
            CancellationToken cancellationToken)
        {
            var activity = await _activityRepository.GetByIdAsync(
                id, cancellationToken);

            if (activity == null)
                throw new KeyNotFoundException("Activity not found.");

            await _activityRepository.DeleteAsync(
                activity, cancellationToken);
        }
    }
}