using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploDos
{
    abstract class  Persona:Humano
    {
        public abstract void dormir();
        public override void comer()
        {
            throw new NotImplementedException();
        }
    }
}
