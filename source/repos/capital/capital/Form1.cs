using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double interes = 0.002;
            double valor;
            if(Double.TryParse(txtDinero.Text, out valor)){
                MessageBox.Show($"Su capital a calcular es: {valor}", "Exito");
                double capitalTotal = valor + (valor * interes);
                double capitalFinalAno = capitalTotal * 12;
                lbCapitalTotal.Text = capitalTotal.ToString();
                lbFinalAno.Text = capitalFinalAno.ToString();
            }
            else
            {
                MessageBox.Show("El numero que ingreso  no es de tipo numerico, por favor ingrese uno valido", "Error!!!!"); ;
            }
        }
    }
}
