using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_en_consola
{
    // Pieza se va encargar de tener el mismo comportamientos similar para cada uno.
    public class Pieza
    {
        public Posicion miPosicion;
        public virtual char DibujarElemento() { return ' '; }
    }
}
