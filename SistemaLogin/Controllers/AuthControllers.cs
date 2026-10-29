using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace SistemaLogin.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public async Task<IActionResult> Login(
            string email, string password)
        {
            if (email != " " || password != " ")
                return Unauthorized("Credenciales incorrectas.");

            var claims = new List<Claim>
            {
               new Claim(ClaimTypes.NameIdentifier, resultado.UsuarioId.ToString()!)
            }
            await HttpContext.SignInAsync(" ", usuario);

            return Ok("Inicio de sesión correcto.");
        }

        [Authorize]
        [HttpGet("perfil")]
        public IActionResult Perfil()
        {
            var id = User.FindFirst( ClaimTypes.NameIdentifier:)?.Value;

            return Ok(new { IdUsuario = id });
        }

        [Authorize]
        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(" ");

            return Ok("Sesión cerrada.");
        }
    }
}