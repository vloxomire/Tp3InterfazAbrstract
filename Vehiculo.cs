using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3InterfazAbrstract
{
    class Vehiculo: Datos, Iprendible,IExpotable
    {
        /*Puede prenderse, y explotar.
Cuenta con un bool para saber si esta prendido o no y puntos de vida.*/
        public int Vida { get; set; }
        public bool Prendido { get; set; }
        public Vehiculo() 
        {
            Vida = 100;
            Prendido = false;
            Nombre = "Vehiculo";
        }
        public void Explotar(int daño) 
        {
            if (daño < Vida) 
            {
                return;
            }
            Prendido = true;
            Console.WriteLine("A EXPLOTADO EL AUTO");
        }

        public void PrendidoFuego(bool prendido)
        {
            if (!prendido)
            {
                return;
            }
            Console.WriteLine("SE HA PRENDIDO FUEGO");
        }
    }
}
