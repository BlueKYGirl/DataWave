using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;



using Microsoft.AspNetCore.JsonPatch;

namespace DataWave.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IServiceManager _service;

        public UserController(IServiceManager serviceManager) => _service = serviceManager;

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _service.User.GetAllUsersAsync(trackChanges: false);
            return Ok(users);
        }
        [HttpGet("{id:guid}", Name = "UserById")]
        public async Task<IActionResult> GetUser(Guid id)
        {
            var user = await _service.User.GetUserAsync(id, trackChanges: false);
            return Ok(user);
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserForCreationDto user)
        
        {
            if (user == null)
                return BadRequest("UserForCreationDto object is null");
            Console.WriteLine("Is it getting here");

           // if (!ModelState.IsValid)
                
               // return UnprocessableEntity(ModelState);
                

            var createdUser = await _service.User.CreateUserAsync(user);
            return CreatedAtRoute("UserById", new { id = createdUser.Id }, createdUser);
        }
        // [HttpGet("{id:guid}/device")]
        // public async Task<IActionResult> GetUserDevices(Guid id)
        // {
        //     var devices = await _service.User.GetUserDevicesAsync(id, trackChanges: false);
        //     return Ok(devices);
        // }
    }
}
