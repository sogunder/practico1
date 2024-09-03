using Infolutions.modelos;
using practico1.modelo;
using practico1.modelos;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Infolutions.http
{
    public class RespuestaBase<T>
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("message")]
        public string? Message { get; set; }

        [JsonPropertyName("data")]
        public T Data { get; set; }
    }

    public class RespuestaApi : RespuestaBase<object>
    {
    }

    public class RespuestaListaDeProyectos : RespuestaBase<List<Proyecto>>
    {
    }

    public class RespuestaProyecto : RespuestaBase<Proyecto>
    {
    }

    public class RespuestaCreacionProyecto : RespuestaBase<Proyecto>
    {
    }

    // Nuevas clases de respuesta para Usuarios
    public class RespuestaListaDeUsuarios : RespuestaBase<List<Usuario>>
    {
    }

    public class RespuestaUsuario : RespuestaBase<Usuario>
    {
    }

    // Nuevas clases de respuesta para Tareas
    public class RespuestaListaDeTareas : RespuestaBase<List<Tarea>>
    {
    }

    public class RespuestaTarea : RespuestaBase<Tarea>
    {
    }

    public class RespuestaCreacionTarea : RespuestaBase<Tarea>
    {
    }
}

