using System.Threading.Tasks;
using Dating.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dating.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestingController:ControllerBase
    {
        private readonly DataContext dataContext;

        public TestingController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values = await dataContext.Values.ToListAsync();
            return Ok(values);
        }
        
    }
}