using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3InterfazAbrstract
{
    class Caja
    {
        /*Puede empujarse.
Cuenta con una posición (X)*/
        public int X { get; set; }
        public bool Empujarse { get; set; }
        public Caja()
        {
            X = 0;
            Empujarse = true;
        }
    }
}
