namespace Vehicu
{
    partial class Ventas
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.txtMod1 = new System.Windows.Forms.TextBox();
            this.txtmod2 = new System.Windows.Forms.TextBox();
            this.txtmod3 = new System.Windows.Forms.TextBox();
            this.txtmod4 = new System.Windows.Forms.TextBox();
            this.lbbase = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbImprimir = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dtgMatriz = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(58, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Trabajador";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(41, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Registrar Venta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(56, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(38, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "VENTAS POR MODELO";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox1.Location = new System.Drawing.Point(61, 148);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "MERCEDEZ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox2.Location = new System.Drawing.Point(61, 194);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(53, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "BMW";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox3.Location = new System.Drawing.Point(61, 243);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(70, 17);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "TOYOTA";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox4.Location = new System.Drawing.Point(61, 292);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(71, 17);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "PORCHE";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // txtMod1
            // 
            this.txtMod1.Location = new System.Drawing.Point(51, 168);
            this.txtMod1.Name = "txtMod1";
            this.txtMod1.Size = new System.Drawing.Size(100, 20);
            this.txtMod1.TabIndex = 9;
            this.txtMod1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtmod2
            // 
            this.txtmod2.Location = new System.Drawing.Point(51, 217);
            this.txtmod2.Name = "txtmod2";
            this.txtmod2.Size = new System.Drawing.Size(100, 20);
            this.txtmod2.TabIndex = 10;
            this.txtmod2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtmod3
            // 
            this.txtmod3.Location = new System.Drawing.Point(51, 266);
            this.txtmod3.Name = "txtmod3";
            this.txtmod3.Size = new System.Drawing.Size(100, 20);
            this.txtmod3.TabIndex = 11;
            // 
            // txtmod4
            // 
            this.txtmod4.Location = new System.Drawing.Point(51, 315);
            this.txtmod4.Name = "txtmod4";
            this.txtmod4.Size = new System.Drawing.Size(100, 20);
            this.txtmod4.TabIndex = 12;
            // 
            // lbbase
            // 
            this.lbbase.AutoSize = true;
            this.lbbase.ForeColor = System.Drawing.Color.Green;
            this.lbbase.Location = new System.Drawing.Point(210, 53);
            this.lbbase.Name = "lbbase";
            this.lbbase.Size = new System.Drawing.Size(49, 13);
            this.lbbase.TabIndex = 15;
            this.lbbase.Text = "3000000";
            this.lbbase.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(210, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Salario";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // lbImprimir
            // 
            this.lbImprimir.AutoSize = true;
            this.lbImprimir.Location = new System.Drawing.Point(265, 53);
            this.lbImprimir.Name = "lbImprimir";
            this.lbImprimir.Size = new System.Drawing.Size(0, 13);
            this.lbImprimir.TabIndex = 16;
            this.lbImprimir.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(268, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 33);
            this.button2.TabIndex = 18;
            this.button2.Text = "Total Empresa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtgMatriz
            // 
            this.dtgMatriz.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMatriz.Location = new System.Drawing.Point(258, 15);
            this.dtgMatriz.Name = "dtgMatriz";
            this.dtgMatriz.Size = new System.Drawing.Size(545, 222);
            this.dtgMatriz.TabIndex = 19;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.dtgMatriz);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbImprimir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbbase);
            this.Controls.Add(this.txtmod4);
            this.Controls.Add(this.txtmod3);
            this.Controls.Add(this.txtmod2);
            this.Controls.Add(this.txtMod1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox txtMod1;
        private System.Windows.Forms.TextBox txtmod2;
        private System.Windows.Forms.TextBox txtmod3;
        private System.Windows.Forms.TextBox txtmod4;
        private System.Windows.Forms.Label lbbase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbImprimir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtgMatriz;
    }
}