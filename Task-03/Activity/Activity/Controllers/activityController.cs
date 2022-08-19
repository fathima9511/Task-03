using Activity.Models;
using Activity.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class activityController : ControllerBase
    {
        private IactivityRepository _activityRepository;

        public activityController(IactivityRepository activityRepository)
        {
            this._activityRepository = activityRepository;
        }

        [HttpGet]

        public async Task<IEnumerable<activity>> GetActivity()
        {
            return await _activityRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<activity>> GetActivity(Guid id)
        {
            return await _activityRepository.Get(id);
        }

        [HttpPost]

        public async Task<ActionResult<activity>> Postactivity([FromBody] activity activity)
        {
            var newActivity = await _activityRepository.Create(activity);
            return CreatedAtAction(nameof(GetActivity), new { id = newActivity.Id }, newActivity);
        }
    }
}
