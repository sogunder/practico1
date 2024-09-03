using Infolutions.http;
using practico1.modelo;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infolutions.services
{
    public class TareaServicio : ConexionAApi
    {
        private readonly string global = "/p9J0k1L2"; // Asegúrate de que este valor sea correcto

        // Método para obtener la lista de tareas (Index)
        public async Task<List<Tarea>> Index()
        {
            RespuestaListaDeTareas respuestaApi = null;
            try
            {
                string path = $"/tasks{global}";
                string body = "";
                var response = await SendTransaction(path, body, "GET");

                if (response?.Data == null)
                {
                    throw new Exception($"Error en la API: Código {response?.Code}, Mensaje: {response?.Message}");
                }

                respuestaApi = JsonSerializer.Deserialize<RespuestaListaDeTareas>(response.Data.ToString());

                if (respuestaApi == null || respuestaApi.Code != 200)
                {
                    throw new Exception($"Error al obtener la lista de tareas: {respuestaApi?.Message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener la lista de tareas: {ex.Message}");
                return null;
            }
            return respuestaApi.Data;
        }

        // Método para obtener una tarea específica por ID
        public async Task<Tarea> Show(int tareaId)
        {
            try
            {
                string path = $"/tasks/{tareaId}{global}";
                var response = await SendTransaction(path, "", "GET");
                var respuestaApi = JsonSerializer.Deserialize<RespuestaTarea>(response.Data.ToString());

                if (respuestaApi == null || respuestaApi.Code != 200)
                {
                    throw new Exception($"Error al obtener la tarea: {respuestaApi?.Message}");
                }

                return respuestaApi.Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener la tarea: {ex.Message}");
                return null;
            }
        }

        // Método para actualizar una tarea existente
        public async Task<string> Update(int tareaId, Tarea tareaActualizada)
        {
            try
            {
                string path = $"/tasks/{tareaId}{global}";
                string tareaJson = JsonSerializer.Serialize(tareaActualizada);
                var response = await SendTransaction(path, tareaJson, "PUT");

                if (response.Code == 200)
                {
                    return response.Message;
                }
                else
                {
                    throw new Exception($"Error al actualizar la tarea: {response.Message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la tarea: {ex.Message}");
                return null;
            }
        }

        // Método para eliminar una tarea existente
        public async Task<string> Delete(int tareaId)
        {
            try
            {
                string path = $"/tasks/{tareaId}{global}";
                var response = await SendTransaction(path, "", "DELETE");

                if (response.Code == 200)
                {
                    return response.Message;
                }
                else
                {
                    throw new Exception($"Error al eliminar la tarea: {response.Message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la tarea: {ex.Message}");
                return null;
            }
        }

        // Método para crear una nueva tarea
        public async Task<string> Create(Tarea nuevaTarea)
        {
            try
            {
                string path = $"/tasks{global}";
                string tareaJson = JsonSerializer.Serialize(nuevaTarea);
                var response = await SendTransaction(path, tareaJson, "POST");

                if (response.Code == 201)
                {
                    return response.Message;
                }
                else
                {
                    throw new Exception($"Error al crear la tarea: {response.Message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la tarea: {ex.Message}");
                return null;
            }
        }
    }

    // Clases para las respuestas de la API
    public class RespuestaListaDeTareas
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public List<Tarea> Data { get; set; }
    }

    public class RespuestaTarea
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public Tarea Data { get; set; }
    }
}