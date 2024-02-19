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
        private readonly NeuroF1RacingDbContext context;
        public CarController(NeuroF1RacingDbContext context) => this.context = context;

        /// <summary>
        /// From the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await context.Cars
                .FirstOrDefaultAsync(c => c.Id == id);

            return Ok(JsonConvert.SerializeObject(data));
        }

        /// <summary>
        /// To the database
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("post")]
        public async Task<IActionResult> Post([FromBody] Car car)
        {
            await context.Cars.AddAsync(car);
            await context.SaveChangesAsync();
            return Ok("Added to Database");
        }
    }
}
