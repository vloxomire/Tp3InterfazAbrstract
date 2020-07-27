using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3InterfazAbrstract
{
    class Barril
    {
        /*Puede empujarse, y explotar.
Cuenta con un una posición (X) y puntos de vida*/
        public int Vida { get; set; }
        public int X { get; set; }
        public bool Empujarse { get; set; }
        public bool Explotar { get; set; }
        public Barril()
        {
            Vida = 50;
            Empujarse = true;
            Explotar = true;
        }
    }
}
