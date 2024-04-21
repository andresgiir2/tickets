using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Vehicu
{
    public partial class Ventas : Form
    {
        int N1;
        string[,] Matriz;
        public Ventas(int N)
        {
            InitializeComponent();
            N1 = N;
            txtMod1.Visible = false;
            txtmod2.Visible = false;
            txtmod3.Visible = false;
            txtmod4.Visible = false;
            Matriz = new string[N, 13];

        }

       
        int fila =0;
        int columna =0;
        double Total = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (fila < Matriz.GetLength(0) && columna < Matriz.GetLength(1))
            {
                double ventmercedez = 0;
                double ventBMW = 0;
                double ventoyota = 0;
                double ventporche = 0;

                Matriz[fila, columna] = txtNombre.Text;

                if (checkBox1.Checked == true)
                {
                    Matriz[fila, columna + 1] = "|✓|";
                }
                else
                {
                    Matriz[fila, columna + 1] = "|X|";
                }

                Matriz[fila, columna + 2] = txtMod1.Text;
                if (checkBox2.Checked == true)
                {
                    Matriz[fila, columna + 3] = "|✓|";
                }
                else
                {

                    Matriz[fila, columna + 3] = "|X|";
                }


                Matriz[fila, columna + 4] = txtmod2.Text;
                if (checkBox3.Checked == true)
                {
                    Matriz[fila, columna + 5] = "|✓|";
                }
                else
                {
                    Matriz[fila, columna + 5] = "|X|";
                }

                Matriz[fila, columna + 6] = txtmod3.Text;
                if (checkBox4.Checked == true)
                {
                    Matriz[fila, columna + 7] = "|✓|";
                }
                else
                {
                    Matriz[fila, columna + 7] = "|X|";
                }
                Matriz[fila, columna + 8] = txtmod4.Text;
                Matriz[fila, columna + 9] = lbbase.Text;

                if (txtMod1.Text != "")
                {
                    ventmercedez = 70000000 * (int.Parse(txtMod1.Text));
                }
                if (txtmod2.Text != "")
                {
                    ventBMW = 74000000 * (int.Parse(txtmod2.Text));
                }
                if (txtmod3.Text != "")
                {
                    ventoyota = 60000000 * (int.Parse(txtmod3.Text));

                }
                if (txtmod4.Text != "")
                {
                    ventporche = 80000000 * (int.Parse(txtmod4.Text));
                }

                
                Total = int.Parse((ventmercedez + ventBMW + ventoyota + ventporche).ToString());

                Matriz[fila, columna + 10] = ((ventmercedez + ventBMW + ventoyota + ventporche) * 0.02).ToString();
                Matriz[fila, columna + 11] = (3000000 + (ventmercedez + ventBMW + ventoyota + ventporche) * 0.02).ToString();
                Matriz[fila, columna + 12] = Total.ToString();
                txtNombre.Text = "";
                txtMod1.Text = "";
                txtmod2.Text = "";
                txtmod3.Text = "";
                txtmod4.Text = "";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;



                columna += 13;
                if (columna >= Matriz.GetLength(1))
                {

                    columna = 0;
                    fila++;
                }
            }
            else
            {
                MessageBox.Show("Has terminado de ingresar los trabajadores");
            }
            DataGridViewRow Crear = new DataGridViewRow();
            Crear.CreateCells(dtgMatriz);
            dtgMatriz.RowCount = N1;
            dtgMatriz.ColumnCount = 13;

            dtgMatriz.Columns[0].HeaderText = "Nombre";
            dtgMatriz.Columns[1].HeaderText = "MERCEDEZ";
            dtgMatriz.Columns[2].HeaderText = "CANTIDAD"; 
            dtgMatriz.Columns[3].HeaderText = "BMW";
            dtgMatriz.Columns[4].HeaderText = "CANTIDAD";
            dtgMatriz.Columns[5].HeaderText = "TOYOTA";
            dtgMatriz.Columns[6].HeaderText = "CANTIDAD";
            dtgMatriz.Columns[7].HeaderText = "PORCHE";
            dtgMatriz.Columns[8].HeaderText = "CANTIDAD";
            dtgMatriz.Columns[9].HeaderText = "SALARIO BASE";
            dtgMatriz.Columns[10].HeaderText = "COMISION";
            dtgMatriz.Columns[11].HeaderText = "SALARIO TOTAL";
            dtgMatriz.Columns[12].HeaderText = "TOTAL VENTAS";



            for (int i = 0; i< Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    dtgMatriz.Rows[i].Cells[j].Value = Matriz[i, j];
                }
            }
        }
            
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked == false)
            {
                txtMod1.Visible = false;
            }
            else
            {
                txtMod1.Visible = true;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                txtmod2.Visible = false;
            }
            else
            {
                txtmod2.Visible = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == false)
            {
                txtmod3.Visible = false;
            }
            else
            {
                txtmod3.Visible = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == false)
            {
                txtmod4.Visible = false;
            }
            else
            {
                txtmod4.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnImpri_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        public void Imprimir()
        {
            lbImprimir.Text = "Registro de Ventas \n";
            lbImprimir.Text += "Nombre\tMercedez\tCantidad\tBMW\tCantidad\tTOYOTA\tCantidad\tPORCHE\tCantidad\tSalario Base\tComisión\tSalario Total\tTotal Ventas\n";

            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                lbImprimir.Text += Matriz[i, 0] + "\t" + Matriz[i, 1] + "\t" + Matriz[i, 2] + "\t" + Matriz[i, 3] + "\t" + Matriz[i, 4] + "\t" + Matriz[i, 5] + "\t" + Matriz[i, 6] + "\t" + Matriz[i, 7] + "\t" + Matriz[i, 8] + "\t" + Matriz[i, 9] + "\t" + Matriz[i, 10] + "\t" + Matriz[i, 11] + "\t" + Matriz[i, 12] + "\n";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
{
    double TotalEmpresa = 0;

    for (int i = 0; i < Matriz.GetLength(0); i++)
    {
        TotalEmpresa += double.Parse(Matriz[i, 12]);
    }

    MessageBox.Show("El total vendido por la empresa es: " + TotalEmpresa);
}

        private void Ventas_Load(object sender, EventArgs e)
        {

        }
    }

}
