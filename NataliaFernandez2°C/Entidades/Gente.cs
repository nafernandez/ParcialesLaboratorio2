using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gente : Persona
    {
        public Gente(short edad)
            :base(null, edad)
        {

        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            //El método Mostrar deberá indicar que es GENTE y luego imprimir su información.
            
            sb.Append("\nGENTE:");
            sb.AppendFormat(base.Mostrar());

            return sb.ToString();
        }

        public override bool Validar()
        {
            if(Edad>18)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
