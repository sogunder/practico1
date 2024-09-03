using Infolutions.http;
using Infolutions.modelos;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Infolutions.services
{
    public class ProyectoServicio : ConexionAApi
    {
        private readonly string global = "/p9J0k1L2";

        // Método para obtener la lista de proyectos 
        public async Task<List<Proyecto>> Index()
        {
            //declarar una variable para almacenar la respuesta de la API
            //la variable debe ser del tipo de la respuesta esperada
            //en este caso, la respuesta es una lista de proyectos
            RespuestaListaDeProyectos respuestaApi; 
            try
            {
                string path = $"/projects{global}";
                string body = "";
                var response = await SendTransaction(path, body, "GET");

                // Convertir Data a cadena JSON
                string jsonRespuestaApi = response.Data.ToString();

                // Deserializar la respuesta de la API a un objeto de tipo RespuestaListaDeProyectos          
                respuestaApi = JsonSerializer.Deserialize<RespuestaListaDeProyectos>(jsonRespuestaApi);

                /* Aquí podrías validar si hay algun error con la respuesta según su código*/
                if (respuestaApi.Code != 200)
                {
                    /* cualquier cosa que quieras hacer pa mostrar el error*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return respuestaApi.Data;
        }

        // Método para obtener un proyecto específico por ID (Read)
        public async Task<Proyecto> Show(int projectId)
        {
            //no agregué el try catch porque ya está en el método Index el ejemplo
            //no seas flojo, implementa el try catch en este método también
            //si no lo haces, el programa se caerá si hay un error y no tendrás idea de qué pasó

            string path = $"/projects/{projectId}{global}";
            string body = "";
            var jsonRespuestaApi = await SendTransaction(path, body, "GET");

            RespuestaProyecto RespuestaApi = JsonSerializer.Deserialize<RespuestaProyecto>(jsonRespuestaApi.Data.ToString());

            return RespuestaApi.Data;
        }

        // Método para crear un nuevo proyecto (Create)
        public async Task<String> Create(object nuevoProyecto)
        {
            string respuestaApi = null;
            string path = $"/projects{global}";

            try
            {
                // Serializar el objeto anónimo a JSON, ya que la api debe recibir ese formato, no un obj de .net
                string proyectoJson = JsonSerializer.Serialize(nuevoProyecto);
                var jsonRespuestaApi = await SendTransaction(path, proyectoJson, "POST");

               if (jsonRespuestaApi.Code == 201) //codigo http quiere decir que se creó el proyecto
                {
                    respuestaApi = jsonRespuestaApi.Message;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return respuestaApi;
        }


        //implementa los métodos Update y Delete siguiendo el mismo patrón de los métodos anteriores

        // Método para actualizar un proyecto existente (Update)
        public async Task<string> Update(int projectId, object proyectoActualizado)
        {
            string respuestaApi = null;
            string path = $"/projects/{projectId}{global}";

            try
            {
                // Serializar el objeto actualizado a JSON
                string proyectoJson = JsonSerializer.Serialize(proyectoActualizado);
                var jsonRespuestaApi = await SendTransaction(path, proyectoJson, "PUT");

                if (jsonRespuestaApi.Code == 203) // Código HTTP que indica que la actualización fue exitosa
                {
                    respuestaApi = jsonRespuestaApi.Message;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return respuestaApi;
        }

        // Método para eliminar un proyecto existente (Delete)
        public async Task<string> Delete(int projectId)
        {
            string respuestaApi = null;
            string path = $"/projects/{projectId}{global}";

            try
            {
                var jsonRespuestaApi = await SendTransaction(path, string.Empty, "DELETE");

                if (jsonRespuestaApi.Code == 205) // Código HTTP que indica que la eliminación fue exitosa
                {
                    respuestaApi = jsonRespuestaApi.Message;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return respuestaApi;
        }
    }

  
}
