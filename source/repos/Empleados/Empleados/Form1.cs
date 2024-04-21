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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            lbEmpleados.Visible = false;
            txtNempleados.Visible=false;
            btnSobre.Visible=false;

        }

        private void btnContinuar_Click(object sender, EventArgs e)

        {
            if (txtOpcion != null) { 

                switch(txtOpcion.Text)
                {
                    case "1":
                        txtOpcion.Visible = false;
                        label2.Visible = false;
                        label1.Visible = false;
                        lbEmpleados.Visible = true;
                        txtNempleados.Visible = true;
                        btnSobre .Visible = true;


                        break;
                    case "2":
                        break;
                }
            }
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            CrearEmpleado crearEmpleado = new CrearEmpleado(txtNempleados.Text);
            crearEmpleado.Show();
            this.Visible = false;
            
        }
    }
}
