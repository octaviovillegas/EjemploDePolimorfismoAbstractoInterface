using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploUno
{
    class Auto:Vehiculo
    {

         protected int _cantidadDePuertas;
         protected int _precio;
         public override int Precio
         {
             get
             {
                 return this._precio;
             }
             set
             {
                this._precio=value;
             }
         }

         public Auto(int CantidadDePuertas, string patente)
            : base(patente)
        {
            this._cantidadDePuertas = CantidadDePuertas;
        }

         public override void Mostrar()
         {
             base.Mostrar();
         }
         public override void MostrarAbstracto()
         {
             Console.WriteLine(this._cantidadDePuertas);
             Console.WriteLine(this._patente);
         }

    }
}
