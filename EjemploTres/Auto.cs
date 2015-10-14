using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploTres
{
    class Auto:Vehiculo,Iestacionable
    {
        public void Estacionar()
        {
            throw new NotImplementedException();
        }

        public int CostoTotal
        {
            get { throw new NotImplementedException(); }
        }
    }
}
