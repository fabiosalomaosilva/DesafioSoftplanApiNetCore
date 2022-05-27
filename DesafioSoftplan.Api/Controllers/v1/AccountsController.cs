using DesafioSoftplan.Services.Dtos;
using DesafioSoftplan.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DesafioSoftplan.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private IAuthService _authService;

        public AccountsController(IAuthService authService)
        {
            _authService = authService;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto model)
        {
            var user = await _authService.Authenticate(model);

            if (user == null)
                return BadRequest(new { message = "E-mail ou senha errados" });

            return Ok(user);
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto model)
        {
            await _authService.Register(model);

            return Ok("Usuário criado com sucesso");
        }
    }
}