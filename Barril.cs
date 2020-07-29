using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3InterfazAbrstract
{
    class Barril: Datos, IEmpujable,IExpotable
    {
        /*Puede empujarse, y explotar.
Cuenta con un una posición (X) y puntos de vida*/
        public int Vida { get; set; }
        public int X { get; set; }
        public Barril()
        {
            Vida = 40;
            Nombre = "Barril";
        }

        public void Empujar(int distancia)
        {
            X=distancia;
        }

        public void Explotar(int daño)
        {
            if (Vida<0)
            {
                return;
            }
            Console.WriteLine("EXPLOTO EL BARRIL");
        }
    }
}
