using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploTres
{
    interface Iestacionable
    {
        void Estacionar();

        int CostoTotal
        { 
            get;
        }
    }
}
