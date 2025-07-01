using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api.Services.Common;
using log4net;
using api.Models.ViewModels;
using api.Controllers;
using api.Models.Common;
using api.Persistence;
using Microsoft.AspNetCore.Authorization;
namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        private static readonly ILog log = LogMaster.GetLogger("user", "user");
        private static string functionCode = "QLND";
        private readonly IConfiguration _configuration;

        private readonly CDHDbContext _context;

        public UserController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult> Login([FromBody] LoginModel loginModel)
        {
            DefaultResponse def = new DefaultResponse();
            return Ok(def);
        }
    }
}
