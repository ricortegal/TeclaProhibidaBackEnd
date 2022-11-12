using TeclaProhibidaBackEnd.Modelo;

namespace TeclaProhibidaBackEnd.Interfaces
{
    public interface IIntentoRespuestaCallbacks
    {
        public Task IntentoRespuestaCallback(IntentoResponse peticion);
    }
}
