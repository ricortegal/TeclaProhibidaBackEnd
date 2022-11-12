using Microsoft.AspNetCore.SignalR;
using TeclaProhibidaBackEnd.Enum;
using TeclaProhibidaBackEnd.Interfaces;
using TeclaProhibidaBackEnd.Modelo;
using TeclaProhibidaBackEnd.Servicios;

namespace TeclaProhibidaBackEnd.Hubs
{
    public class IntentoHub : Hub<IIntentoRespuestaCallbacks>
    {
        private JuegoServicio Servicio { get; }

        public IntentoHub(JuegoServicio servicio)
        {
            Servicio = servicio;
        }

        public async Task Intento(IntentoPeticion intento)
        {

            if (!Servicio.Jugando())
            {
                await Clients.Caller.IntentoRespuestaCallback(
                    new IntentoResponse(Servicio.Contexto,
                                        intento.IdJugador,
                                        IntentoEstadoRespuesta.KoJuegoNoComenzado));
            }

            if (!Servicio.EstaRegistradoJugador(intento.IdJugador))
            {
                await Clients.Caller.IntentoRespuestaCallback(
                    new IntentoResponse(Servicio.Contexto, 
                                        intento.IdJugador, 
                                        IntentoEstadoRespuesta.KoJugadorErroneo));
            }


            if(!Servicio.TurnoOk(intento.IdJugador))
            {
                await Clients.Caller.IntentoRespuestaCallback(
                    new IntentoResponse(Servicio.Contexto,
                                        intento.IdJugador,
                                        IntentoEstadoRespuesta.KoNoTurno));
            }

          
            if(Servicio.Intento(intento.IdJugador,intento.Tecla))
            {
                await Clients.All.IntentoRespuestaCallback(
                    new IntentoResponse(Servicio.Contexto,
                                        intento.IdJugador,
                                        IntentoEstadoRespuesta.OkTurnoCompletadoTeclaAdmitida));
            }
            else
            {
                await Clients.All.IntentoRespuestaCallback(
                    new IntentoResponse(Servicio.Contexto,
                                        intento.IdJugador,
                                        IntentoEstadoRespuesta.OkTurnoCompletadoTeclaErronea));
            }

        }


    }
}
