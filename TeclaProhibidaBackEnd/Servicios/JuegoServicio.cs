using TeclaProhibidaBackEnd.Enum;
using TeclaProhibidaBackEnd.Modelo;

namespace TeclaProhibidaBackEnd.Servicios
{
    public class JuegoServicio
    {
        private JuegoContexto _contexto;

        public JuegoContexto Contexto
        {
            get { return _contexto; }
        }


        public JuegoServicio(JuegoContexto contexto)
        {
            _contexto = new JuegoContexto();
        }


        public bool EstaRegistradoJugador(int idJugador)
        {
            return _contexto.Jugadores.Any(j => j.NumeroJugador == idJugador);
        } 


        public bool Jugando()
        {
            return _contexto.Jugando;
        }


        public bool TurnoOk(int idTurno)
        {
            return _contexto.JugadorActual == idTurno;
        }

        public bool Intento(int jugador, string tecla)
        {
            if (Contexto.TeclasProhibidas.Any(j => j.Equals(tecla, StringComparison.InvariantCultureIgnoreCase))
                || Teclado.EsTeclaAdyacente(Contexto.UltimaTeclaPulsada))
            {
                Contexto.Jugando = false;
                Contexto.UltimaTeclaPulsada = "";
                Contexto.ProximoJugador = Contexto.Jugadores.OrderBy(j => j.NumeroJugador).FirstOrDefault()?.NumeroJugador ?? 0;
                return false;
            }

            Contexto.UltimaTeclaPulsada = tecla;
            Contexto.TeclasProhibidas.Add(tecla);
            return true;
       }


    }
}
