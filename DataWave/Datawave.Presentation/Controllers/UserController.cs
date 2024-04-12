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
        [HttpGet("{userId:guid}/bill")]
        public async Task<IActionResult> GetUserBill(Guid userId)
        {
            Console.WriteLine("Is it getting here");
            // Retrieve all plan users of the user
            var planUsers = await _service.PlanUser.GetAllPlanUsersByUserIdAsync(userId, trackChanges: false);

            // Initialize a list to store plan details
            var planDetails = new List<PlanDetailDto>();

            // Initialize total cost
            decimal totalCost = 0;

            // Iterate through each plan user to get the cost of each plan
            foreach (var planUser in planUsers)
            {
                // Retrieve the corresponding plan
                var plan = await _service.Plan.GetPlanAsync(planUser.PlanId, trackChanges: false);

                // Add plan details to the list
                planDetails.Add(new PlanDetailDto
                {
                    PlanUserId = planUser.Id,
                    PlanName = plan.PlanName,
                    Price = plan.Price
                });

                // Add the cost of the plan to the total cost
                totalCost += plan.Price;
            }

            // Create an object containing both the list of plans with their individual prices and the total price
            var userBill = new
            {
                PlanDetails = planDetails,
                TotalCost = totalCost
            };

            // Return the user bill
            return Ok(userBill);
        }
    }
}
