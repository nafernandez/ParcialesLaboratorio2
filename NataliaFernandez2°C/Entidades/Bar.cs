using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bar
    {
        public static int CAPACIDAD_MAXIMA_POR_EMPLEADO = 10;
        private List<Empleado> empleados;
        private List<Gente> gente;
        private static Bar singleton;

        public List<Empleado> Empleados
        {
            get
            {
                return empleados;
            }
        }

        public List<Gente> Gente
        {
            get
            {
                return gente;
            }
        }

        private Bar()
        {
            gente = new List<Gente>();
            empleados = new List<Empleado>();
        }

        public static Bar GetBar()
        {
            if(singleton == null)
            {
                singleton = new Bar();
            }
            return singleton;
        }

        public static bool operator +(Bar bar, Empleado empleado)
        {
            if(!(empleado.Validar()))
            {
                return false;
            }
            foreach(Empleado empleadoAAgregar in bar.empleados)
            {
                if(empleadoAAgregar == empleado)
                {
                    return false;
                }
            }
            bar.empleados.Add(empleado);
            return true;
        }
        public static bool operator +(Bar bar, Gente gente)
        {
            if (!(bar is null) && !(gente is null))
            {
                    int nuevaCantidadDeGente = bar.gente.Count + 1;
                    if (nuevaCantidadDeGente < bar.CapacidadMaximaDeGente())
                    {
                        if (gente.Validar())
                        {
                            bar.gente.Add(gente);
                            return true;
                         }
                        
                    }
                
            }
            return false;
            }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Gente gente in gente)
            {
                sb.AppendFormat((string)gente);
            }
            foreach (Empleado empleado in empleados)
            {
                sb.AppendFormat((string)empleado);
            }
            return sb.ToString();
        }

        public int CapacidadMaximaDeGente()
        {
            return this.empleados.Count * CAPACIDAD_MAXIMA_POR_EMPLEADO;
        }
    }
}
