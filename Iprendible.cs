using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3InterfazAbrstract
{
    class Datos
    {
        public string Nombre{get;set;}
        public Datos() 
        {
            Nombre="Objeto Padre";
        }
    }
    public interface Iprendible
    {
        /*Se puede prender y apagar.*/
        void PrendidoFuego(bool prendido);

    }
    public interface IExpotable
    {
        /*Puede recibir daño y explotar.*/
        void Explotar(int daño);
    }
    public interface IEmpujable
    {
        /*Puede empujarse.*/
        void Empujar(int distancia);
    }
}
