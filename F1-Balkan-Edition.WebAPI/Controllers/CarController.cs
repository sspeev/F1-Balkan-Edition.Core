using F1_Balkan_Edition.Infrastrucure.Data.Models;
using F1_Balkan_Edition.Infrastrucure.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace F1_Balkan_Edition.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private readonly F1BalkanEditionContext context;
        public CarController(F1BalkanEditionContext context) => this.context = context;

        [HttpGet]//From the database
        public async Task<IActionResult> Get(int id)
        {
            var data = await context.Cars
                .FirstOrDefaultAsync(c => c.Id == id);

            return Ok(JsonConvert.SerializeObject(data));
        }

        [HttpPost]//To the database
        public async Task<IActionResult> Post(Car car)
        {
            await context.Cars.AddAsync(car);
            await context.SaveChangesAsync();
            return Ok("Added to Database");
        }
    }
}
