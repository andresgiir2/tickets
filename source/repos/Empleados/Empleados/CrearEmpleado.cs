using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class CrearEmpleado : Form
    {
        int NEmpleados;

        public CrearEmpleado(int N)
        {

            InitializeComponent();
            NEmpleados = N;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        int fila = 0;   
        int columna = 0;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (fila < N1) // Verifica que no se haya superado el límite de filas.
            {
                // Inserta los datos en la columna actual.
                Empleados[fila, columna] = fila;
                Empleados[fila, columna + 1] = TxtNum.Text;
                Empleados[fila, columna + 2] = cbNivel.Text;
                Empleados[fila, columna + 3] = TxtSueldo.Text;
                Empleados[fila, columna + 4] = TxtExepcion.Text;
                Empleados[fila, columna + 5] = txtantiguedad.Text;

                // Limpia los campos de entrada.
                TxtNom.Text = "";
                TxtNum.Text = "";
                cbNivel.Text = "";
                TxtSueldo.Text = "";
                TxtExepcion.Text = "";
                txtantiguedad.Text = "";

                columna += 6; // Avanza a la siguiente columna.

                if (columna >= Empleados.GetLength(1))
                {
                    // Si hemos llegado al final de las columnas, avanzamos a la siguiente fila.
                    columna = 0;
                    fila++;
                }
            }
            else
            {
                MessageBox.Show("La cantidad de empleados ha sido superada.");

            }
        }
    }
}
