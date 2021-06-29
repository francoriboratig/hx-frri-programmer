
namespace HX_Ferrari_Programmer
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxSerialNumber = new System.Windows.Forms.CheckBox();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxSerialNumber);
            this.panel1.Location = new System.Drawing.Point(42, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 81);
            this.panel1.TabIndex = 0;
            // 
            // checkBoxSerialNumber
            // 
            this.checkBoxSerialNumber.AutoSize = true;
            this.checkBoxSerialNumber.Location = new System.Drawing.Point(20, 47);
            this.checkBoxSerialNumber.Name = "checkBoxSerialNumber";
            this.checkBoxSerialNumber.Size = new System.Drawing.Size(146, 17);
            this.checkBoxSerialNumber.TabIndex = 1;
            this.checkBoxSerialNumber.Text = "Cambiar Número de Serie";
            this.checkBoxSerialNumber.UseVisualStyleBackColor = true;
            this.checkBoxSerialNumber.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Location = new System.Drawing.Point(3, 27);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(355, 20);
            this.textBoxSerialNumber.TabIndex = 0;
            this.textBoxSerialNumber.Tag = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.checkBoxSerialNumber);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxSerialNumber;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
    }
}

