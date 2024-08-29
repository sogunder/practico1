using Infolutions.http;
using Infolutions.modelos;
using practico1.modelos;
using System.Text.Json;
using System.Threading.Tasks;

namespace practico1.servicios
{
    internal class EndPointUsuario : ConexionAApi
    {
        private readonly string global = "/p9J0k1L2";

        // Método para obtener un usuario específico por ID
        public async Task<Usuario> Get(int userId)
        {
            Usuario usuario = null;
            string path = $"/users/{userId}{global}";
            string body = "";

            try
            {
                var jsonRespuestaApi = await SendTransaction(path, body, "GET");
                RespuestaUsuario RespuestaApi = JsonSerializer.Deserialize<RespuestaUsuario>(jsonRespuestaApi.Data.ToString());
                usuario = RespuestaApi.Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return usuario;
        }
    }
}
