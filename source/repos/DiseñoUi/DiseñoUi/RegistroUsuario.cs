using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace DiseñoUi
{
    
    public partial class RegistroUsuario : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UR38VU6\\SQLEXPRESS;Initial Catalog=SUPERMERCADITO;Integrated Security=True");
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login abrir = new Login();
            abrir.Show();
            this.Hide();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                txtContra.UseSystemPasswordChar = false;
            }
            else
            {
                txtContra.UseSystemPasswordChar = true;
            }
        }
      

        private void brnIni_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string contraseña = txtContra.Text;


            try
            {



                if (Usuario.RegistrarUsuario(nombreUsuario, contraseña, connection))
                {
                    MessageBox.Show("Usuario registrado correctamente");
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error al registrar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con su base de datos SQL: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

           
        }

        private void txtNombre_Enter_1(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.FromArgb(49, 66, 82);
                txtNombre.UseSystemPasswordChar = true;
                txtNombre.ForeColor = Color.White;
            }
        }

        private void txtNombre_Leave_1(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.White;
                txtNombre.UseSystemPasswordChar = false;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.FromArgb(49, 66, 82);
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtContra_Enter_1(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contraseña")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.FromArgb(49, 66, 82);
                txtContra.UseSystemPasswordChar = true;
                txtContra.ForeColor = Color.White;
            }
        }

        private void txtContra_Leave_1(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "Contraseña";
                txtContra.ForeColor = Color.White;
                txtContra.UseSystemPasswordChar = false;
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
