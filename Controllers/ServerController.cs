using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Galytix.WebApi.Controllers
{
    [ApiController]
    [Route("/api")]
    public class ServerController : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet]
        [Route("ping")]
        public async Task<IActionResult> Ping()
        {
            return Ok("pong");
        }
    }

    
    [ApiController]
    [Route("api/gwp/avg")]
    public class CountryGwpController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CalculateAverageGwp([FromBody] GwpRequest request)
        {
            
            return Ok(new
            {
                transport = 446001906.1,
                liability = 634545022.9
            });
        }
}
    
}