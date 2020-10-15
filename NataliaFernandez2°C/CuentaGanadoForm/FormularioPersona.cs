using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentaGanadoForm
{
    public partial class FormularioPersona : Form
    {
        private bool esEmpleado;

        public bool EsEmpleado
        {
            set
            {
                esEmpleado = value;
            }
        }
        //Hacer una variable flag que diga si metes un empelado o gente.
        //Instanciar el formulario de persona donde se necesite y setear ese flag segun que
        //tipo de persona se necesite.

        

        public FormularioPersona()
        {
            InitializeComponent();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int dni;
            short edad;
            bool sePudo;

            int.TryParse(txtDni.Text.ToString(), out dni);
            short.TryParse(txtEdad.Text.ToString(), out edad);

            if(esEmpleado== true)
            {
                if(string.IsNullOrEmpty(txtDni.Text.ToString()))
                {
                    Empleado nuevoEmpleado = new Empleado(txtNombre.Text.ToString(), edad);
                    sePudo = Bar.GetBar() + nuevoEmpleado;
                }
                else
                {
                    Empleado nuevoEmpleado = new Empleado(txtNombre.Text.ToString(), edad, dni);
                    sePudo = Bar.GetBar() + nuevoEmpleado;
                }
            }else
            {
                Gente nuevaGente = new Gente(edad);
                sePudo = Bar.GetBar() + nuevaGente;
            }
            
                
     

            Close();

        }

        
    }
}
