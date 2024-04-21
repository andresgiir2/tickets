using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Registro_Parqueadero
{
    public partial class Form1 : Form
    {
        private string[,] usuarios = new string[100, 2];
        private int count = 0;

        public Form1()
        {
            InitializeComponent();

        }



        private void btnRegistro_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            string usuario = txtUsu.Text;
            string contrasena = txtContra.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Ningún campo puede estar vacío");
                return;
            }

            string[] lines = File.ReadAllLines(@"C:\\Users\\Andres\\source\\repos\\Registro Parqueadero\\Registro Parqueadero\\Contraseñas.txt");
            for (int i = 0; i < lines.Length; i += 2)
            {
                if (lines[i] == usuario && lines[i + 1] == contrasena)
                {
                    MessageBox.Show("Inicio de sesión exitoso", "Éxito");
                    AccesoParqueo parqueadero = new AccesoParqueo();
                    parqueadero.Show();
                    this.Hide();
                    return;
                }
            }

            MessageBox.Show("Usuario o contraseña incorrecta, o usuario no registrado", "Error");
            txtUsu.Text = "";
            txtContra.Text = "";
        }

        private void BtnRegistro_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUsu.Text;
            string contrasena = txtContra.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Ningún campo puede estar vacío");
                return;
            }

            string[] lines = File.ReadAllLines(@"C:\\Users\\Andres\\source\\repos\\Registro Parqueadero\\Registro Parqueadero\\Contraseñas.txt");
            for (int i = 0; i < lines.Length; i += 2)
            {
                if (lines[i] == usuario)
                {
                    MessageBox.Show("El usuario ya está registrado");
                    return;
                }
            }

            using (StreamWriter sw = new StreamWriter(@"C:\\Users\\Andres\\source\\repos\\Registro Parqueadero\\Registro Parqueadero\\Contraseñas.txt", true))
            {
                sw.WriteLine(usuario);
                sw.WriteLine(contrasena);
            }

            MessageBox.Show("Usuario registrado correctamente", "Éxito");
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

 