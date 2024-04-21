using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using WindowsFormsApp1;
using System.Diagnostics.Contracts;

namespace DiseñoUi
{
    public partial class Login : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UR38VU6\\SQLEXPRESS;Initial Catalog=SUPERMERCADITO;Integrated Security=True");

        public Login()
        {
            InitializeComponent();

        }



        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            RegistroUsuario registroUsuario = new RegistroUsuario();
            registroUsuario.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void btnCerrarLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void btnMinimizarLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
           
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsu_Enter(object sender, EventArgs e)
        {
            if (txtUsu.Text == "Usuario")
            {
                txtUsu.Text = "";
                txtUsu.ForeColor = Color.FromArgb(49, 66, 82);
                txtUsu.ForeColor = Color.White;
            }
        }

        private void txtUsu_Leave(object sender, EventArgs e)
        {
            if(txtUsu.Text == "")
            {
                txtUsu.Text= "Usuario";
                txtUsu.ForeColor= Color.White;
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contraseña")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.FromArgb(49, 66, 82);
                txtContra.UseSystemPasswordChar = true;
                txtContra.ForeColor= Color.White;
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "Contraseña";
                txtContra.ForeColor = Color.White;
                txtContra.UseSystemPasswordChar = false;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

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

      

        private void brnIni_Click_1(object sender, EventArgs e)
        {

            string nombreUsuario = txtUsu.Text;
            string contraseña = txtContra.Text;

            try
            {
                connection.Open(); // Open the connection before using it

                if (Usuario.ValidarUsuario(nombreUsuario, contraseña, connection)) // Pass the connection as an argument
                {
                    // Iniciar sesión
                    MessageBox.Show("Usuario logueado correctamente");
                    Form1 app = new Form1();
                    this.Hide();
                    app.Show();
                }
                else
                {
                    txtUsu.Text = "";
                    txtContra.Text = "";
                    // Mostrar mensaje de error
                    DialogResult result = MessageBox.Show("Usuario o contraseña incorrectos, o Usuario no registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        txtUsu.Focus(); // Establecer el foco en el campo de usuario después de cerrar el mensaje de error
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close(); // Close the connection after use
            }

        }

        private void btnRegis_Click_1(object sender, EventArgs e)
        {
            RegistroUsuario registroUsuario = new RegistroUsuario();
            registroUsuario.Show();
            this.Hide();
        }
    }
}
