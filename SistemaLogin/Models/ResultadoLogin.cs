namespace SistemaLogin.Models
{
    public class ResultadoLogin
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

        public ResultadoLogin(bool exitoso, string mensaje)
        {
            Exitoso = exitoso;
            Mensaje = mensaje;
        }
    }
}