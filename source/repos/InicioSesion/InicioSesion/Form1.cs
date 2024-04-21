using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicioSesion
{
    public partial class Form1 : Form
    {
        private List<string> nombres = new List<string>(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
           
           
            if (txtContra.Text == "" || txtUsu.Text == "")
            {
                MessageBox.Show("Ningun campo puede estar vacio");
            }
            else 
            {
                if (nombres.Contains(txtUsu.Text))
                {
                    MessageBox.Show("El usuario ya esta registrado");
                }
                else
                {
                    MessageBox.Show("Usuario Registrado Correctamente", "Exito");
                    nombres.Add(txtUsu.Text);
                    nombres.Add(txtContra.Text);
                }
                
            }
            txtUsu.Text = "";
            txtContra.Text = "";
        }   

        private bool ValidarInicioSesion(string usuario, string contrasena)
        {
            for (int i = 0; i < nombres.Count; i += 2)
            {
                if (nombres[i] == usuario && nombres[i + 1] == contrasena)
                {
                    return true;
                }
            }

            return false;
        }
            
        private void btnInicio_Click(object sender, EventArgs e)
        {
            string usuario = txtUsu.Text;
            string contra = txtContra.Text;

            if (txtUsu.Text != "" && txtContra.Text != "")
            {
                if (ValidarInicioSesion(usuario, contra) == true)
                {
                    Form2 llamar = new Form2();
                    llamar.Show();
                }
                else if (ValidarInicioSesion(usuario, contra) == false)
                {
                    MessageBox.Show("Usuario o Contraseña Incorrecta, O usuario no registrado", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Ningun campo puede estar vacío");
            }
           


            txtUsu.Text = "";
            txtContra.Text = "";
        }

        private void checkBoxContra_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxContra.Checked)
            {
              
                txtContra.PasswordChar = '\0';
            }
            else
            {
                txtContra.PasswordChar = '*';
            }
        }
    }
}

