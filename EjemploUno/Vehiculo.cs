using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploUno
{
    abstract class Vehiculo
    {
        protected string _patente;

        public virtual string Patente
        {
            get { return this._patente; }
            set { this._patente = value; }
        }
        public abstract int Precio
        {
            get;
            set;
        }



        public Vehiculo(string patente)
        {
            this._patente = patente;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine(this._patente);
        
        }

        public abstract void MostrarAbstracto();

    }
}
