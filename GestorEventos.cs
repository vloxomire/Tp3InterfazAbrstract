using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tp3InterfazAbrstract
{
    class GestorEventos
    {
        private Datos datos;
        public GestorEventos()
        {
            datos = new Datos();
        }
        public Datos Menu()
        {
            //elija el objeto a interactuar
            int menu;
            Console.WriteLine("Elija el objeto a trabajar: ");
                Console.WriteLine("1)Caja\n2)Vehiculo\n3)Barril");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        //Como hago downcast y que no quede nulo el valor?
                        datos = new Caja();
                        Console.WriteLine("Usted eligio un/a {0}", datos.Nombre);
                        return datos;
                    case 2:
                        datos = new Vehiculo();
                        Console.WriteLine("Usted eligio un/a {0}", datos.Nombre);
                        return datos;
                    case 3:
                        datos = new Barril();
                        Console.WriteLine("Usted eligio un/a {0}", datos.Nombre);
                        return datos;
                    default:
                        Console.WriteLine("Elija un valor valido");
                        return datos;
                }
        }
        public void Interaccione(Datos d)
        {
            if (d is Caja)
            {
                MenuCaja((Caja)d);
            }
            else if (d is Vehiculo)
            {
                MenuVehiculo((Vehiculo)d);
            }
            else
            {
                MenuBarril((Barril)d);
            }
        }
        private void MenuCaja(Caja d)
        {
            int distancia = 0;
            Console.WriteLine("Cuantos metros desea arrojar la caja?");
            distancia = int.Parse(Console.ReadLine());
            d.Empujar(distancia);
        }
        private void MenuVehiculo(Vehiculo d)
        {
            char molotov;
            Console.WriteLine("Quiere arrojar una molotov al vehiculo?\npresione \"y\" o \"n\"");
            molotov = char.Parse(Console.ReadLine());
            if (molotov != 'y')
            {
                return;
            }
            d.Prendido = true;
            d.PrendidoFuego(d.Prendido);
        }
        private void MenuBarril(Barril d)
        {
            int distancia = 0;
            Console.WriteLine("Cuantos metros desea arrojar el barril?");
            distancia = int.Parse(Console.ReadLine());
            d.Empujar(distancia);
            if (distancia > 50)
            {
                d.Explotar(distancia);
                return;
            }
            d.X= distancia;
            Console.WriteLine("El barril se a movida {0} metros",d.X);
        }
    }
}
