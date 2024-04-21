using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiseñoUi
{
    public partial class FormEfectivo : Form
    {
        public FormEfectivo(double totalVenta)
        {
            InitializeComponent();
            lbTotal.Text = totalVenta.ToString();
            lbDevuelta.Text = totalVenta.ToString();
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            if (txtDinero.Text == "Dinero Recibido")
            {
                txtDinero.Text = "";
                txtDinero.ForeColor = Color.FromArgb(49, 66, 82);
                txtDinero.ForeColor = Color.White;
            }
        }

        private void txtDinero_Leave(object sender, EventArgs e)
        {
            if (txtDinero.Text == "")
            {
                txtDinero.Text = "Dinero Recibido";
                txtDinero.ForeColor = Color.White;
            }
        }
    }
}
