using System;
using System.Text.Json.Serialization;

namespace TeclaProhibidaBackEnd.Modelo
{
    public class Jugador
    {
        [JsonPropertyName("numeroJugador")]
        public int NumeroJugador { get; set; }

        [JsonPropertyName("nombre")]
        public string? Nombre { get; set; }

        [JsonPropertyName("puntuacion")]
        public decimal Puntuacion {get; set;}

        [JsonPropertyName("puntuacionGlobal")]
        public decimal PuntuacionGlobal { get; set; }

        [JsonPropertyName("activo")]
        public bool Activo { get; set; }

        [JsonPropertyName("vidas")]
        public int Vidas { get; set; }
    }
}
