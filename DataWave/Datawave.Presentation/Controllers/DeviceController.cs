using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

using Microsoft.AspNetCore.JsonPatch;


namespace DataWave.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    { 
        private readonly IServiceManager _service;

        public DeviceController(IServiceManager serviceManager) => _service = serviceManager;

        [HttpGet]
        public async Task<IActionResult> GetAllDevices()
        {
            var devices = await _service.Device.GetAllDevicesAsync(trackChanges: false);
            return Ok(devices);
        }
        [HttpGet("{id:guid}", Name = "DeviceById")]
        public async Task<IActionResult> GetDevice(Guid id)
        {
            var device = await _service.Device.GetDeviceAsync(id, trackChanges: false);
            return Ok(device);
        }
    }
}
