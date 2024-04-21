using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicioSesion
{
    public partial class Form2 : Form
    {
        private List<string> Compra = new List<string>();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

     

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Compra.Add(txtProducto.Text);
            Compra.Add(txtValorP.Text);
            if (Compra.Count >= 2)
            {
               
                    dtgCompra.DataSource = ObtenerListaDeCompras();
                    dtgCompra.Columns[0].HeaderText = "Producto";
                    dtgCompra.Columns[1].HeaderText = "Precio";
                
                
            }
            else
            {
                MessageBox.Show("Debe cargar ambos campos para calcular la venta", "Error");
            }
               

            txtProducto.Text = "";
            txtValorP.Text = "";

        }
        private List<string> ObtenerListaDeCompras()
        {
         
            List<string> listaDeCompras = new List<string>();
            for (int i = 0; i < Compra.Count; i += 2)
            {
                listaDeCompras.Add(Compra[i]);
                listaDeCompras.Add(Compra[i + 1]);
            }

            return listaDeCompras;
        }


    }
}
