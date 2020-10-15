using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        private int dni;

        /// <summary>
        /// constructor que invoca al constructor de esta clase, si no recibe un dni por parametro, le asigna un -1
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        public Empleado(string nombre, short edad)
            :this(nombre, edad, -1)
        {

        }

        /// <summary>
        /// constructor que llama al constructor de la clase base
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        public Empleado(string nombre, short edad, int dni)
           : base(nombre,edad)
        {
            this.dni = dni;
        }

        /// <summary>
        /// muestra datos de empleado
        /// </summary>
        /// <returns></returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Datos del empleado:\n");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("DNI: {0} \n", this.dni);

            return sb.ToString();
        }

        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }

        public static bool operator ==(Empleado e1, Empleado e2)
        {
            return e1.Nombre == e2.Nombre && e1.Edad == e2.Edad;
        }

        /// <summary>
        /// valida que sea mayor a 21 y que el nombre tenga mas de 2 caracteres
        /// </summary>
        /// <returns></returns>
        public override bool Validar()
        {
            if(Edad<21 && Nombre.Length>=2)
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
