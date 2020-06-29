using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_en_consola
{
    public class Dado
    {
        private readonly Random dado1 = new Random();
        private readonly Random dado2 = new Random();
        private sbyte valorDado1 = 0;
        private sbyte valorDado2 = 0;
        public Dado(){}
        public sbyte TirarDosDados()
        {
            valorDado1 = (sbyte)dado1.Next(1, 6);
            valorDado2 = (sbyte)dado2.Next(1, 6);
            return (sbyte)(valorDado1 + valorDado2);
        }
    }
}
