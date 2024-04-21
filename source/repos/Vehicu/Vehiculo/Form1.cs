using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTraba.Text !="" & int.TryParse(txtTraba.Text, out int b))
            {
                Ventas V = new Ventas(int.Parse(txtTraba.Text));
                V.Show();
                this.Hide();
            }
            else
            {
                txtTraba.Text = "";
                MessageBox.Show("Debes ingresar un dato valido (debe ser un numero entero)", "ERROR");
            }
        }
    }
}
