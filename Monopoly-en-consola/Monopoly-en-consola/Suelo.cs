using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_en_consola
{
    // Suelo va a tener los comportamientos de Pieza.
    class Suelo : Pieza
    {
        public override char DibujarElemento()
        {
            return 'º';
        }
    }
}
