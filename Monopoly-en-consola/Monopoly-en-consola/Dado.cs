using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_en_consola
{
    public class Dado
    {
        Random numeroRandom;
        int numeroDado = 0;
        public void TirarDado()
        {
           numeroDado = numeroRandom.Next(1,6);
        }
        public void MostrarDado()
        {
            Console.WriteLine("El número del dado es {0}", numeroDado);
        }
    }
}
