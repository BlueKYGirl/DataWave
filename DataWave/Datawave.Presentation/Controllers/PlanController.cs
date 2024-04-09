using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;

using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace DataWave.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanController : ControllerBase
    {
        private readonly IServiceManager _service;

        public PlanController(IServiceManager serviceManager) => _service = serviceManager;

        [HttpGet]
        public async Task<IActionResult> GetAllPlans()
        {
            var plans = await _service.Plan.GetAllPlansAsync(trackChanges: false);
            return Ok(plans);
        }
        [HttpGet("{id:guid}", Name = "PlanById")]
        public async Task<IActionResult> GetPlan(Guid id)
        {
            var plan = await _service.Plan.GetPlanAsync(id, trackChanges: false);
            return Ok(plan);
        }
    }
}
