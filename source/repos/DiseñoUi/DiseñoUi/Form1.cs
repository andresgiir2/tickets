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

namespace DiseñoUi
{
    
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

      

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

            private void btnMaximinzar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximinzar.Visible = false;
            btnRestaurar.Visible = true;
            
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximinzar.Visible = true;

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      

        private void Form1_Load(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubmenuAdmin.Visible = false;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            SubmenuAdmin.Visible = true;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            SubmenuAdmin.Visible = false;
        }

        private void AbrirFormProducto(object formProducto)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fp = formProducto as Form;
            fp.TopLevel = false;
            fp.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fp);
            this.panelContenedor.Tag= fp;
            fp.Show();
        }

        private void AbrirVentas(object formVentas)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fv = formVentas as Form;
            fv.TopLevel = false;
            fv.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fv);
            this.panelContenedor.Tag = fv;
            fv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirVentas(new Ventas());
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormProducto(new Productos());
        }
    }
}
