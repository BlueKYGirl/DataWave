using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;

using Microsoft.AspNetCore.JsonPatch;


namespace DataWave.Presentation.Controllers
{
    [Route("api/")]
    [ApiController]
    public class DeviceController : ControllerBase
    { 
        private readonly IServiceManager _service;

        public DeviceController(IServiceManager serviceManager) => _service = serviceManager;

        [HttpGet("device")]
        public async Task<IActionResult> GetAllDevices()
        {
            var devices = await _service.Device.GetAllDevicesAsync(trackChanges: false);
            return Ok(devices);
        }
        [HttpGet("device/{id:guid}", Name = "DeviceById")]
        public async Task<IActionResult> GetDevice(Guid id)
        {
            var device = await _service.Device.GetDeviceAsync(id, trackChanges: false);
            return Ok(device);
        }
        [HttpPost("user/{userId:guid}/device")]
        public async Task<IActionResult> CreateDevice(Guid userId, [FromBody] DeviceForCreationDto device)
        {
            if (device == null)
            {
                return BadRequest("DeviceForCreationDto object is null");
            }

            var createdDevice = await _service.Device.CreateDeviceAsync(userId, device);
            return CreatedAtRoute("DeviceById", new { id = createdDevice.Id }, createdDevice);
        }

    }
}
