using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_en_consola
{
    //El Tablero se va a encargar de contener todo.
    public class Tablero
    {
        readonly sbyte fila = 2;
        readonly sbyte columna = 2;

        Pieza[,] piezas;

        public void Comenzar()
        {
            ArmarTablero();
            MostrarTablero();
        }

        private void ArmarTablero()
        {
            piezas = new Pieza[fila, columna];

            piezas[0, 0] = new Suelo(); piezas[0, 1] = new Suelo();
            piezas[1, 0] = new Suelo(); piezas[1, 1] = new Suelo();
        }
        private void CargarPosicion()
        {
            for (sbyte fila = 0; fila < this.fila; fila++)
            {
                for (sbyte columna = 0; columna < this.columna; columna++)
                {
                    piezas[fila, columna].miPosicion = new Posicion();
                }
            }
        }
        private void MostrarTablero()
        {
            for (sbyte fila = 0; fila < this.fila; fila++)
            {   
                for (sbyte columna = 0; columna < this.columna; columna++)
                {
                    Console.Write(piezas[fila,columna].DibujarElemento());
                }
                Console.WriteLine();
            }
        }
    }
}
