using System;
using System.Text.Json.Serialization;

namespace practico1.modelo
{
    public class Tarea
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("description")]
        public string Descripcion { get; set; }

        [JsonPropertyName("area")]
        public string Area { get; set; } // Esta propiedad debería reflejar correctamente la estructura esperada por la API

        [JsonPropertyName("status")]
        public string Estado { get; set; }

        [JsonPropertyName("start_date")]
        public DateTime FechaCreacion { get; set; }

        [JsonPropertyName("end_date")]
        public DateTime FechaVencimiento { get; set; }

        [JsonPropertyName("project_id")]
        public int ProyectoId { get; set; }

        [JsonPropertyName("user_id")]
        public string Responsable { get; set; }
    }
}