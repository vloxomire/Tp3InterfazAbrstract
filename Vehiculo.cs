using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3InterfazAbrstract
{
    class Vehiculo
    {
        /*Puede prenderse, y explotar.
Cuenta con un bool para saber si esta prendido o no y puntos de vida.*/
        public int Vida { get; set; }
        public bool Prenderse { get; set; }
        public bool Explotar { get; set; }
        public Vehiculo() 
        {
            Vida = 100;
            Prenderse = true;
            Explotar = true;
        }
    }
}
