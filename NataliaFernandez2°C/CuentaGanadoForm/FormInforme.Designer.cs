namespace CuentaGanadoForm
{
    partial class FormInforme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbSalidaDeTest = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbSalidaDeTest
            // 
            this.rtbSalidaDeTest.Location = new System.Drawing.Point(52, 29);
            this.rtbSalidaDeTest.Name = "rtbSalidaDeTest";
            this.rtbSalidaDeTest.Size = new System.Drawing.Size(638, 366);
            this.rtbSalidaDeTest.TabIndex = 0;
            this.rtbSalidaDeTest.Text = "";
            // 
            // FormInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbSalidaDeTest);
            this.Name = "FormInforme";
            this.Text = "FormInforme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSalidaDeTest;
    }
}