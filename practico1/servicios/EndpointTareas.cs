using Infolutions.http;
using Infolutions.modelos;
using practico1.modelo;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infolutions.services
{
    public class EndpointTareas : ConexionAApi
    {
        private readonly string global = "/tareas";

        // Método para obtener la lista de tareas (GET, lista)
        public async Task<List<Tarea>> Index()
        {
            RespuestaListaDeTareas respuestaApi;
            try
            {
                string path = $"/tasks{global}";
                string body = "";
                var response = await SendTransaction(path, body, "GET");

                string jsonRespuestaApi = response.Data.ToString();
                respuestaApi = JsonSerializer.Deserialize<RespuestaListaDeTareas>(jsonRespuestaApi);

                if (respuestaApi.Code != 200)
                {
                    // Manejo de errores según código de respuesta
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener la lista de tareas: {ex.Message}");
                throw;
            }
            return respuestaApi.Data;
        }

        // Método para obtener una tarea específica por ID (GET, show)
        public async Task<Tarea> Show(int taskId)
        {
            try
            {
                string path = $"/tasks/{taskId}{global}";
                string body = "";
                var response = await SendTransaction(path, body, "GET");

                string jsonRespuestaApi = response.Data.ToString();
                RespuestaTarea respuestaApi = JsonSerializer.Deserialize<RespuestaTarea>(jsonRespuestaApi);

                return respuestaApi.Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener la tarea: {ex.Message}");
                throw;
            }
        }

        // Método para crear una nueva tarea (POST, nuevo)
        public async Task<string> Create(object nuevaTarea)
        {
            string respuestaApi = null;
            string path = $"/tasks{global}";

            try
            {
                string tareaJson = JsonSerializer.Serialize(nuevaTarea);
                var response = await SendTransaction(path, tareaJson, "POST");

                if (response.Code == 201) // Código HTTP que indica creación exitosa
                {
                    respuestaApi = response.Message;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la tarea: {ex.Message}");
                throw;
            }

            return respuestaApi;
        }

        // Método para actualizar una tarea existente (PUT, actualizar)
        public async Task<string> Update(int taskId, object tareaActualizada)
        {
            string respuestaApi = null;
            string path = $"/tasks/{taskId}{global}";

            try
            {
                string tareaJson = JsonSerializer.Serialize(tareaActualizada);
                var response = await SendTransaction(path, tareaJson, "PUT");

                if (response.Code == 203) // Código HTTP que indica actualización exitosa
                {
                    respuestaApi = response.Message;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la tarea: {ex.Message}");
                throw;
            }

            return respuestaApi;
        }

        // Método para eliminar una tarea existente (DEL, eliminar)
        public async Task<string> Delete(int taskId)
        {
            string respuestaApi = null;
            string path = $"/tasks/{taskId}{global}";

            try
            {
                var response = await SendTransaction(path, string.Empty, "DELETE");

                if (response.Code == 205) // Código HTTP que indica eliminación exitosa
                {
                    respuestaApi = response.Message;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la tarea: {ex.Message}");
                throw;
            }

            return respuestaApi;
        }
    }
}
