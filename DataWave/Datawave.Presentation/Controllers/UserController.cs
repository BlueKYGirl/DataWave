using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;


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
    }
}
