using System;
using System.Text.Json.Serialization;

namespace practico1.modelo
{
    public class Tarea
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("titulo")]
        public string Titulo { get; set; }

        [JsonPropertyName("descripcion")]
        public string Descripcion { get; set; }

        [JsonPropertyName("estado")]
        public string Estado { get; set; }

        [JsonPropertyName("fecha_creacion")]
        public DateTime FechaCreacion { get; set; }

        [JsonPropertyName("fecha_vencimiento")]
        public DateTime FechaVencimiento { get; set; }

        [JsonPropertyName("proyecto_id")]
        public int ProyectoId { get; set; }

        [JsonPropertyName("horas_estimadas")]
        public int HorasEstimadas { get; set; }

        [JsonPropertyName("horas_trabajadas")]
        public int HorasTrabajadas { get; set; }

        [JsonPropertyName("responsable")]
        public string Responsable { get; set; }
    }
}
