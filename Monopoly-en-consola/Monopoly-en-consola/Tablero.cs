using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_en_consola
{
    public class Tablero
    {
        private sbyte tamañoTablero = 10;
        Pieza[] casillero;
        Jugador jugador1 = new Jugador();
        public void Inicio()
        {
            casillero = new Pieza[tamañoTablero];
            ArmarTableroBase();
            CargarPiezasAlCasillero();
            CargarPosicion();
            CambiarPosicion();
            MostrarTablero();
        }
        private void ArmarTableroBase()
        {
            for (sbyte posicion = 0; posicion < tamañoTablero; posicion++)
            {
                casillero[posicion] = new Suelo();
            }
        }
        private void CargarPiezasAlCasillero()
        {
            casillero[0] = jugador1;
        }
        private void CargarPosicion()
        {
            jugador1.MiPosicion = new Posicion(0); 
        }
        private void CambiarPosicion()
        {
            jugador1.MiPosicion.NuevaPosicion = jugador1.MiPosicion.CargarNuevaPosicion(jugador1.MiPosicion, 12, tamañoTablero);
            ArmarTableroBase();
            casillero[jugador1.MiPosicion.NuevaPosicion] = jugador1;
        }
        public void MostrarTablero()
        {
            for (sbyte posicion = 0; posicion < tamañoTablero; posicion++)
            {
                Console.Write(casillero[posicion].DibujarElemento());
            }     
        }
    }
}
