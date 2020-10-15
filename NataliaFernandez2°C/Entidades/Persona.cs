using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private short edad;
        private string nombre;

        /// <summary>
        /// Descriptor de acceso con get y set
        /// </summary>
        public short Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }

        /// <summary>
        /// Descriptor de acceso con get y set
        /// </summary>
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        /// <summary>
        /// evalua si es un string
        /// </summary>
        /// <param name="persona"></param>

        public static explicit operator string(Persona persona)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nombre: {0}\n", persona.Nombre);
            sb.AppendFormat("Edad: {0}\n", persona.Edad);

            return sb.ToString();


        }
        /// <summary>
        /// muestra datos de la persona
        /// </summary>
        /// <returns></returns>
        protected virtual string Mostrar()
        {
            return (string)this;
        }

        /// <summary>
        /// constructor de persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        protected  Persona(string nombre, short edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        /// <summary>
        /// metodo abstracto
        /// </summary>
        /// <returns></returns>
        public abstract bool Validar();
    }
}
