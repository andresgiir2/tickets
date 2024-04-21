namespace Empleados
{
    partial class Form1
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
            this.txtOpcion = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txtNempleados = new System.Windows.Forms.TextBox();
            this.lbEmpleados = new System.Windows.Forms.Label();
            this.btnSobre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Ingresar información de un empleado\r\n2. Mostrar información de todos los emple" +
    "ados\r\n3. Consultar información de un empleado\r\n4. Salir\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la opción";
            // 
            // txtOpcion
            // 
            this.txtOpcion.Location = new System.Drawing.Point(227, 133);
            this.txtOpcion.Name = "txtOpcion";
            this.txtOpcion.Size = new System.Drawing.Size(100, 20);
            this.txtOpcion.TabIndex = 2;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(227, 231);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 3;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txtNempleados
            // 
            this.txtNempleados.Location = new System.Drawing.Point(227, 175);
            this.txtNempleados.Name = "txtNempleados";
            this.txtNempleados.Size = new System.Drawing.Size(100, 20);
            this.txtNempleados.TabIndex = 4;
            // 
            // lbEmpleados
            // 
            this.lbEmpleados.AutoSize = true;
            this.lbEmpleados.Location = new System.Drawing.Point(39, 178);
            this.lbEmpleados.Name = "lbEmpleados";
            this.lbEmpleados.Size = new System.Drawing.Size(173, 13);
            this.lbEmpleados.TabIndex = 5;
            this.lbEmpleados.Text = "Ingrese la cantidad de trabajadores";
            // 
            // btnSobre
            // 
            this.btnSobre.Location = new System.Drawing.Point(227, 231);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(75, 23);
            this.btnSobre.TabIndex = 6;
            this.btnSobre.Text = "Continuar";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 318);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.lbEmpleados);
            this.Controls.Add(this.txtNempleados);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.txtOpcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOpcion;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txtNempleados;
        public System.Windows.Forms.Label lbEmpleados;
        private System.Windows.Forms.Button btnSobre;
    }
}

