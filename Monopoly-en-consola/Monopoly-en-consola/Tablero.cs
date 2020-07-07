using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_en_consola
{
    public class Tablero
    {
        private bool partidaFinalizada = false;
        private sbyte valorDado = 0;
        private sbyte tamañoTablero = 10;
        Pieza[] casillero;
        Jugador jugador1 = new Jugador();
        Dado dado = new Dado();
        private void Inicio()
        {
            casillero = new Pieza[tamañoTablero];
            ArmarTableroBase();
            CargarPiezasAlCasillero();
            CargarPosicion();
            MostrarTablero();
        }
        private void ActualizarTablero()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
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
        private void CambiarPosicion(sbyte pCantidadMovimiento)
        {
            jugador1.MiPosicion.NuevaPosicion = jugador1.MiPosicion.CargarNuevaPosicion(jugador1.MiPosicion, pCantidadMovimiento, tamañoTablero);
            ArmarTableroBase();
            casillero[jugador1.MiPosicion.PosicionActual] = jugador1;
        }
        private void MostrarTablero()
        {
            for (sbyte posicion = 0; posicion < tamañoTablero; posicion++)
            {
                Console.Write(casillero[posicion].DibujarElemento());
            }     
        }
        public void ComenzarPartida()
        {
            Inicio();
            do
            {
                
                if (jugador1.MiPosicion.PosicionActual == 0)
                {
                    Accion();
                    ActualizarTablero();
                }
                if (jugador1.MiPosicion.PosicionActual >= 1)
                {
                    Accion();
                    ActualizarTablero();
                }

            } while (partidaFinalizada == false);
        }
        private void Accion()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nElija una opción:");
            Console.WriteLine("0) Tirar dos dados.\n");
            Console.Write("Opción: ");
            try
            {
                sbyte opcion = Convert.ToSByte(Console.ReadLine());
                switch (opcion)
                {
                    case 0:
                        sbyte valorDado = dado.TirarDosDados();
                        CambiarPosicion(valorDado);
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }   
        }
    }
}
