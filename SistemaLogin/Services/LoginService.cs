using SistemaLogin.Models;
namespace SistemaLogin.Services
{
    public class LoginService
    { private readonly List<Usuario> usuarios;
        public LoginService(List<Usuario> usuarios)
        {
            this.usuarios = usuarios;
        }

        public ResultadoLogin IniciarSesion(string email, string password)
        {

           if (usuario.Password != password)
            {return new ResultadoLogin(false, "Contraseña incorrecta"); }
        }
    }
}