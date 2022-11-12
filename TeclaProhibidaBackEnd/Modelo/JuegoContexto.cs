using System.Text.Json.Serialization;

namespace TeclaProhibidaBackEnd.Modelo
{
    public class JuegoContexto
    {
        [JsonPropertyName("jugadores")]
        public List<Jugador> Jugadores { get; set; }

        [JsonPropertyName("teclasProhibidas")]
        public List<string> TeclasProhibidas { get; set; }

        [JsonPropertyName("jugando")]
        public bool Jugando { get; set; }

        [JsonPropertyName("ronda")]
        public int Ronda { get; set; }

        [JsonPropertyName("jugadorActual")]
        public int JugadorActual { get; set; } //nummero del jugador que tiene el turno

        [JsonPropertyName("proximoJugador")]
        public int ProximoJugador { get; set; }

        [JsonPropertyName("ultimaTeclaPulsada")]
        public string UltimaTeclaPulsada { get; set; }

        public JuegoContexto()
        {
            Jugadores = new List<Jugador>();
            TeclasProhibidas = new List<string>();
        }
    }
}