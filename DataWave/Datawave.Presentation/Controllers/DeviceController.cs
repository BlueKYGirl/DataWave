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
        [HttpGet("device/planuser/{planUserId:guid}")]
        public async Task<IActionResult> GetAllDevicesByPlanUser(Guid planUserId)
        {
            var devices = await _service.Device.GetAllDevicesByPlanUserAsync(planUserId, trackChanges: false);
            return Ok(devices);
        }
        [HttpGet("device/user/{userId:guid}")]
        public async Task<IActionResult> GetAllDevicesByUser(Guid userId)
        {
            var devices = await _service.Device.GetAllDevicesByUserAsync(userId, trackChanges: false);
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

            var existingDevice = await _service.Device.GetDeviceByPhoneNumberAsync(device.PhoneNumber, trackChanges: false);
            if (existingDevice != null)
            {
                return Conflict($"A device with phone number '{device.PhoneNumber}' already exists");
            }

            var createdDevice = await _service.Device.CreateDeviceAsync(userId, device);
            return CreatedAtRoute("DeviceById", new { id = createdDevice.Id }, createdDevice);
        }
        [HttpDelete("device/{id:guid}")]
        public async Task<IActionResult> DeleteDevice(Guid id)
        {
            await _service.Device.DeleteDeviceAsync(id, trackChanges: false);
            return NoContent();
        }

        [HttpPut("device/{id:guid}")]
        public async Task<IActionResult> UpdateDevice(Guid id, [FromBody] DeviceForUpdateDto device)
        {
            if (device == null)
            {
                return BadRequest("DeviceForUpdateDto object is null");
            }

            await _service.Device.UpdateDeviceAsync(id, device, trackChanges: true);
            return NoContent();
        }
        [HttpPut("device/swap")]
        public async Task<IActionResult> SwapPhoneNumber([FromBody] SwapPhoneNumberRequestDto swapRequest)
        {
            if (swapRequest == null)
            {
                return BadRequest("SwapPhoneNumberRequestDto object is null");
            }

            var response = await _service.Device.SwapPhoneNumberAsync(swapRequest.Device1, swapRequest.Device2, trackChanges: true);
            return Ok(response);
        }



    }
    
}
