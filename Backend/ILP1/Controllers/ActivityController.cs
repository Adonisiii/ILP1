using Application.DTOs.Activity;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ILP1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityService _activityService;

        public ActivityController(IActivityService activityService)
        {
            _activityService = activityService;
        }

        // POST: api/Activity/{applicationId}
        [HttpPost("{applicationId:guid}")]
        public async Task<IActionResult> AddActivity(
            Guid applicationId,
            [FromBody] AddActivityRequestDto model,
            CancellationToken cancellationToken)
        {
            await _activityService.AddActivityAsync(
                applicationId,
                model,
                cancellationToken);

            return NoContent();
        }

        // GET: api/Activity/applicationId/{applicationId}
        [HttpGet("applicationId/{applicationId:guid}")]
        public async Task<IActionResult> GetByApplicationId(
            Guid applicationId,
            CancellationToken cancellationToken)
        {
            var activities =
                await _activityService.GetByApplicationIdAsync(
                    applicationId,
                    cancellationToken);

            return Ok(activities);
        }

        // GET: api/Activity/{id}
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(
            Guid id,
            CancellationToken cancellationToken)
        {
            var activity =
                await _activityService.GetByIdAsync(
                    id,
                    cancellationToken);

            if (activity == null)
                return NotFound();

            return Ok(activity);
        }

        // PUT: api/Activity/{id}
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateActivity(
            Guid id,
            [FromBody] UpdateActivityRequestDto model,
            CancellationToken cancellationToken)
        {
            await _activityService.UpdateActivityAsync(
                id,
                model,
                cancellationToken);

            return NoContent();
        }

        // DELETE: api/Activity/{id}
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteActivity(
            Guid id,
            CancellationToken cancellationToken)
        {
            await _activityService.DeleteActivityAsync(
                id,
                cancellationToken);

            return NoContent();
        }
    }
}