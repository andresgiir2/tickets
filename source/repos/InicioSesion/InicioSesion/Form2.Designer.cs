namespace InicioSesion
{
    partial class Form2
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
            this.txtValorP = new System.Windows.Forms.TextBox();
            this.dtgCompra = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValorP
            // 
            this.txtValorP.Location = new System.Drawing.Point(232, 25);
            this.txtValorP.Name = "txtValorP";
            this.txtValorP.Size = new System.Drawing.Size(100, 20);
            this.txtValorP.TabIndex = 0;
            // 
            // dtgCompra
            // 
            this.dtgCompra.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCompra.Location = new System.Drawing.Point(33, 54);
            this.dtgCompra.Name = "dtgCompra";
            this.dtgCompra.Size = new System.Drawing.Size(567, 185);
            this.dtgCompra.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Valor del producto";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(399, 22);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Registrar venta";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(168, 292);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 13);
            this.lbTotal.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Total";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(341, 258);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(67, 25);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(100, 20);
            this.txtProducto.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Porducto";
            // 
            // Form2
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(630, 324);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtgCompra);
            this.Controls.Add(this.txtValorP);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtIngresos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Estadisticas;
        private System.Windows.Forms.ComboBox cbEstrato;
        private System.Windows.Forms.ComboBox cbEmpleo;
        private System.Windows.Forms.ComboBox cbIngresos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEsta;
        private System.Windows.Forms.TextBox txtValorP;
        private System.Windows.Forms.DataGridView dtgCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label9;
    }
}