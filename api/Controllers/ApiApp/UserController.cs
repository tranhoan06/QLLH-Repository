using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api.Services.Common;
using log4net;
using api.Models.ViewModels;
namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static readonly ILog log = LogMaster.GetLogger("user", "user");
        private static string functionCode = "QLND";
        private readonly IConfiguration _configuration;

        // private readonly HPSDbContext _context;

        public UserController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] LoginModel loginModel)
        {
            return Ok(null);
        }
    }
}
