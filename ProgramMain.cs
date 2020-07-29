using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3InterfazAbrstract
{
    class ProgramMain
    {
        static void Main(string[] args)
        {
            GestorEventos gestor = new GestorEventos();
            char salida;
            do
            {
                gestor.Interaccione(gestor.Menu());
                Console.WriteLine("Desea salir(\"s\") o continuar(\"c\")");
                salida = char.Parse(Console.ReadLine());
            } while (salida=='c');
        }
    }
}
