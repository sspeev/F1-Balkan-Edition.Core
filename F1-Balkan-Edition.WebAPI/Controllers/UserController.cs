using F1_Balkan_Edition.Infrastrucure.Data;
using F1_Balkan_Edition.Infrastrucure.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace F1_Balkan_Edition.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly F1BalkanEditionContext context;
        public UserController(F1BalkanEditionContext context)
        {
            this.context = context;
        }
        [HttpGet]//From the database
        public async Task<IActionResult> Get()
        {
            var data = await context.Users
                .OrderBy(u => u.LapTime)
                .Select(u => new
                {
                    Car = u.Car.CarBrand + u.Car.Model,
                    u.LapTime,
                    u.Track
                })
                .Take(3)
                .ToListAsync();
            var serialized = JsonConvert.SerializeObject(data, Formatting.Indented);

            return Ok(serialized);
        }

        [HttpPost]//To the database
        [Route("post")]
        public async Task<IActionResult> Post([FromBody] User user)
        {
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
            return Ok("Added to the Database");
        }
    }
}
