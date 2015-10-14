using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploUno
{
    class Estacionamiento
    {
        protected List<Vehiculo> MiLista;

        public Estacionamiento()
        {
            this.MiLista = new List<Vehiculo>();

        }
        public void mostrar()
        {
           
            foreach (Vehiculo item in MiLista)
            {
                item.ToString();

            }
        
        }


    }
}
