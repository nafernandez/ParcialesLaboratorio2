using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace CuentaGanadoForm
{
    public partial class CuentaGanadoraForm : Form
    {
        Bar bar = Bar.GetBar();
        FormularioPersona form = new FormularioPersona();

        public CuentaGanadoraForm()
        {
            InitializeComponent();
        }

        private void btn_Informe_Click(object sender, EventArgs e)
        {
            FormInforme formDeImforme = new FormInforme();
            formDeImforme.ShowDialog();
        }

        private void nUDEmpleados_ValueChanged(object sender, EventArgs e)
        {

            if (bar.Empleados.Count < nUDEmpleados.Value)
            {
                form.EsEmpleado = true;
                form.ShowDialog();
   
            }
            if (bar.Empleados.Count > nUDEmpleados.Value)
            {
                Bar.GetBar().Empleados.RemoveAt(bar.Empleados.Count-1);
            }
        }

        private void nUDGente_ValueChanged(object sender, EventArgs e)
        {
            if (bar.Gente.Count < nUDGente.Value)
            {
                form.EsEmpleado = false;
                form.ShowDialog();
            }
            if (bar.Empleados.Count > nUDEmpleados.Value)
            {
                Bar.GetBar().Gente.RemoveAt(bar.Gente.Count - 1);
            }
        }
    }
}
