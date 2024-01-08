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
        [Route("get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await context.Users
                .FirstOrDefaultAsync(u => u.Id == id);

            return Ok(JsonConvert.SerializeObject(data));
        }

        [HttpPost]//To the database
        [Route("post")]
        public async Task<IActionResult> Post(User user)
        {
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
            return Ok("Added to the Database");
        }
    }
}
