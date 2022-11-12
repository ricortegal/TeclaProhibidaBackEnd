using TeclaProhibidaBackEnd.Enum;

namespace TeclaProhibidaBackEnd.Modelo
{
    public class IntentoResponse
    {
        JuegoContexto Contexto { get; }
        public int Jugador { get;  }
        public IntentoEstadoRespuesta Respuesta { get; set; }

        public IntentoResponse(JuegoContexto contexto,
                                int jugador,
                                IntentoEstadoRespuesta respuesta)
        {
            Contexto = contexto;
            Jugador = jugador;
            Respuesta = respuesta;
        }
    }
}
