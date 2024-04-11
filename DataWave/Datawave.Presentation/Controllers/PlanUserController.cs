using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Microsoft.AspNetCore.JsonPatch;
using Shared.DataTransferObjects;

namespace DataWave.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanUserController : ControllerBase
    {
        private readonly IServiceManager _service;

        public PlanUserController(IServiceManager serviceManager) => _service = serviceManager;

        [HttpGet]
        public async Task<IActionResult> GetAllPlanUsers()
        {
            var planUsers = await _service.PlanUser.GetAllPlanUsersAsync(trackChanges: false);
            return Ok(planUsers);
        }
        [HttpGet("{id:guid}", Name = "PlanUserById")]
        public async Task<IActionResult> GetPlanUser(Guid id)
        {
            var planUser = await _service.PlanUser.GetPlanUserAsync(id, trackChanges: false);
            return Ok(planUser);
        }
        [HttpGet("user/{userId:guid}")]
        public async Task<IActionResult> GetAllPlanUsersByUserId(Guid userId)
        {
            var planUsers =  await _service.PlanUser.GetAllPlanUsersByUserIdAsync(userId, trackChanges: false);
            return Ok(planUsers);
        }
        [HttpPost]
        public async Task<IActionResult> CreatePlanUser([FromBody] PlanUserForCreationDto planUser)
        {
            var createdPlanUser = await _service.PlanUser.CreatePlanUserAsync(planUser);
            return CreatedAtRoute("PlanUserById", new {id = createdPlanUser.Id }, createdPlanUser);
        }
    }
}
