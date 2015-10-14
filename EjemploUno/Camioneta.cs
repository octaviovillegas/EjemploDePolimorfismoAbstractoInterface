using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploUno
{
    class Camioneta:Vehiculo
    {
        protected int _altura;
        protected int _precio;



        public override string Patente
        {
            get
            {
                return base.Patente;
            }
            set
            {
                base.Patente = value;
            }
        }
        public override int Precio
        {
            get
            {
                return this._precio;
            }
            set
            {
                this._precio = value;
            }
        }






        public Camioneta(int altura, string patente)
            : base(patente)
        {
            this._altura = altura;
        }
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine(this._altura);
        }
        public override void MostrarAbstracto()
        {
            Console.WriteLine(this._altura);
            Console.WriteLine(this._patente);
        }
    }
}
