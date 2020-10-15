namespace CuentaGanadoForm
{
    partial class CuentaGanadoraForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nUDEmpleados = new System.Windows.Forms.NumericUpDown();
            this.nUDGente = new System.Windows.Forms.NumericUpDown();
            this.Informe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDGente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gente";
            // 
            // nUDEmpleados
            // 
            this.nUDEmpleados.BackColor = System.Drawing.Color.White;
            this.nUDEmpleados.Location = new System.Drawing.Point(156, 60);
            this.nUDEmpleados.Name = "nUDEmpleados";
            this.nUDEmpleados.Size = new System.Drawing.Size(120, 20);
            this.nUDEmpleados.TabIndex = 2;
            this.nUDEmpleados.ValueChanged += new System.EventHandler(this.nUDEmpleados_ValueChanged);
            // 
            // nUDGente
            // 
            this.nUDGente.Location = new System.Drawing.Point(156, 124);
            this.nUDGente.Name = "nUDGente";
            this.nUDGente.Size = new System.Drawing.Size(120, 20);
            this.nUDGente.TabIndex = 3;
            this.nUDGente.ValueChanged += new System.EventHandler(this.nUDGente_ValueChanged);
            // 
            // Informe
            // 
            this.Informe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Informe.Location = new System.Drawing.Point(156, 204);
            this.Informe.Name = "Informe";
            this.Informe.Size = new System.Drawing.Size(162, 65);
            this.Informe.TabIndex = 4;
            this.Informe.Text = "Informe";
            this.Informe.UseVisualStyleBackColor = true;
            this.Informe.Click += new System.EventHandler(this.btn_Informe_Click);
            // 
            // CuentaGanadoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Informe);
            this.Controls.Add(this.nUDGente);
            this.Controls.Add(this.nUDEmpleados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CuentaGanadoraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador de Natalia Fernandez";
            ((System.ComponentModel.ISupportInitialize)(this.nUDEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDGente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUDEmpleados;
        private System.Windows.Forms.NumericUpDown nUDGente;
        private System.Windows.Forms.Button Informe;
    }
}

