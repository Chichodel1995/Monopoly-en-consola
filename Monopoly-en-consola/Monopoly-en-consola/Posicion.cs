using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_en_consola
{
    public class Posicion
    {
        private sbyte miPosicion = 0;
        public Posicion(){}
        public Posicion(sbyte pMiPosicion) { miPosicion = pMiPosicion; }
        public sbyte NuevaPosicion { get => miPosicion; set => miPosicion = value; }
        public sbyte CargarNuevaPosicion(Posicion pPosicion, sbyte pCantidadMovimiento, sbyte pTamañoTablero)
        {
            for (sbyte contador = 0; contador < pCantidadMovimiento; contador++)
            {
                pPosicion.miPosicion++;
                if (pPosicion.miPosicion == pTamañoTablero)
                {
                    pPosicion.miPosicion = 0;
                }
            }
            return pPosicion.miPosicion;
        }
    }
}
