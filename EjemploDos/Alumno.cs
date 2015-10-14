using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploDos
{
    class Alumno:Persona
    {
        public override void comer()
        {
            base.comer();
        }
        public override void dormir()
        {
            throw new NotImplementedException();
        }
    }
}
