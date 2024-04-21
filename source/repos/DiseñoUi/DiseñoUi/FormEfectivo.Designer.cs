namespace DiseñoUi
{
    partial class FormEfectivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEfectivo));
            this.label6 = new System.Windows.Forms.Label();
            this.txtDinero = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbDevuelta = new System.Windows.Forms.Label();
            this.btnFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(164, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 96;
            this.label6.Text = "____________________";
            // 
            // txtDinero
            // 
            this.txtDinero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtDinero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDinero.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtDinero.ForeColor = System.Drawing.Color.White;
            this.txtDinero.Location = new System.Drawing.Point(167, 85);
            this.txtDinero.Name = "txtDinero";
            this.txtDinero.Size = new System.Drawing.Size(129, 19);
            this.txtDinero.TabIndex = 95;
            this.txtDinero.Text = "Dinero Recibido";
            this.txtDinero.Enter += new System.EventHandler(this.txtCantidad_Enter);
            this.txtDinero.Leave += new System.EventHandler(this.txtDinero_Leave);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.ForeColor = System.Drawing.Color.White;
            this.lbTotal.Location = new System.Drawing.Point(203, 45);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 13);
            this.lbTotal.TabIndex = 97;
            // 
            // lbDevuelta
            // 
            this.lbDevuelta.AutoSize = true;
            this.lbDevuelta.ForeColor = System.Drawing.Color.White;
            this.lbDevuelta.Location = new System.Drawing.Point(203, 144);
            this.lbDevuelta.Name = "lbDevuelta";
            this.lbDevuelta.Size = new System.Drawing.Size(0, 13);
            this.lbDevuelta.TabIndex = 98;
            // 
            // btnFin
            // 
            this.btnFin.FlatAppearance.BorderSize = 0;
            this.btnFin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnFin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFin.ForeColor = System.Drawing.Color.White;
            this.btnFin.Image = ((System.Drawing.Image)(resources.GetObject("btnFin.Image")));
            this.btnFin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFin.Location = new System.Drawing.Point(197, 182);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(60, 34);
            this.btnFin.TabIndex = 99;
            this.btnFin.Text = "OK";
            this.btnFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFin.UseVisualStyleBackColor = true;
            // 
            // FormEfectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(436, 248);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.lbDevuelta);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDinero);
            this.Name = "FormEfectivo";
            this.Text = "FormEfectivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDinero;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbDevuelta;
        private System.Windows.Forms.Button btnFin;
    }
}