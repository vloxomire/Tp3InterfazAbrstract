using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3InterfazAbrstract
{
    class Caja:Datos,IEmpujable
    {
        /*Puede empujarse.
Cuenta con una posición (X)*/
        public int X { get; set; }
        public Caja()
        {
            X = 0;
            Nombre = "Caja";
        }
        public void Empujar(int distancia) 
        {
            X = distancia;
            Console.WriteLine("LA CAJA SE A MOVIDO {0} METROS", X);
        }
    }
}
