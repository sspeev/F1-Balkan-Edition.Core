namespace F1_Balkan_Edition.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController(NeuroF1RacingDbContext context) : ControllerBase
{
    private readonly NeuroF1RacingDbContext context = context;

    [HttpGet]
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
            
        return Ok(data);
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
