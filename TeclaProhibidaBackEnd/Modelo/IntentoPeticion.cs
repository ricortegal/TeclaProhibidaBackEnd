using TeclaProhibidaBackEnd.Enum;

namespace TeclaProhibidaBackEnd.Modelo
{
    public class IntentoPeticion
    {
        public int IdJugador { get; set; }
        public string Tecla { get; set; } = string.Empty;
        public IntentoEstadoRespuesta Respuesta { get; set; }

    }
}
