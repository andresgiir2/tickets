using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DiseñoUi
{
    public partial class Ventas : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UR38VU6\\SQLEXPRESS;Initial Catalog=SUPERMERCADITO;Integrated Security=True");

        public Ventas()
        {
            InitializeComponent();
            diseñoData();
            diseñoVentaData();
            dtgProductos1.AllowUserToAddRows = false;
            
            
        }
        
        private void diseñoVentaData()
        {
            dtgVenta.Columns.Add("Nombre", "Nombre");
            dtgVenta.Columns.Add("Cantidad", "Cantidad");
            dtgVenta.Columns.Add("Precio Unidad", "Precio Unidad");
            dtgVenta.Columns.Add("Total", "Total");
            dtgVenta.ForeColor = Color.Black;
            dtgVenta.AutoGenerateColumns = false;
        }

        private void diseñoData()
        {
            dtgProductos1.Columns.Add("Codigo", "Código");
            dtgProductos1.Columns.Add("Nombre", "Nombre");
            dtgProductos1.Columns.Add("Categoria", "Categoría");
            dtgProductos1.Columns.Add("PrecioVenta", "Precio de Venta");
            dtgProductos1.ForeColor = Color.Black;
            dtgProductos1.AutoGenerateColumns = false;
        }
        private void dtgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar Producto")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.FromArgb(49, 66, 82);
                txtBuscar.ForeColor = Color.White;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar Producto";
                txtBuscar.ForeColor = Color.White;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT Codigo, Nombre, Categoria, Cantidad, FechaVenc, PrecioCompra, PrecioVenta FROM Producto", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dtgProductos1.Rows.Clear(); 

                string searchTerm = txtBuscar.Text.Trim();
                bool productoEncontrado = false;

                foreach (DataRow row in table.Rows)
                {
                    if (searchTerm == "" || row["Nombre"].ToString().Contains(searchTerm) || row["Codigo"].ToString().Contains(searchTerm))
                    {
                        dtgProductos1.Rows.Add(row["Codigo"], row["Nombre"], row["Categoria"], Convert.ToDouble(row["PrecioVenta"]));
                        productoEncontrado = true;
                    }
                    
                }
                if (!productoEncontrado)
                {
                    MessageBox.Show("Su producto no se encuentra en su inventario", "Mensaje");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private double totalVenta = 0.0;
        private double totalIva = 0.0;
        private double total = 0.0;
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgProductos1.CurrentRow != null)
                {
                    
                    string nombreProducto = dtgProductos1.CurrentRow.Cells["Nombre"].Value.ToString();
                    double precioVenta = Convert.ToDouble(dtgProductos1.CurrentRow.Cells["PrecioVenta"].Value);
                    int cantidad = int.Parse(txtCantidad.Text);

                    
                    double total = cantidad * precioVenta;

                   
                    dtgVenta.Rows.Add(nombreProducto, cantidad, precioVenta, total);

                    
                    totalVenta += total;
                    totalIva = totalVenta * 0.19;
                    total = totalVenta + totalIva;

                    lbSubTotal.Text = totalVenta.ToString("0.00");
                    lbIVA.Text = totalIva.ToString("0.00");
                    lbTotal.Text = total.ToString("0.00");
                }
                else
                {
                    MessageBox.Show("Seleccione un producto antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "Cantidad")
            {
                txtCantidad.Text = "";
                txtBuscar.ForeColor = Color.FromArgb(49, 66, 82);
                txtBuscar.ForeColor = Color.White;
            }

        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if(txtCantidad.Text == "")
            {
                txtCantidad.Text = "Cantidad";
                txtBuscar.ForeColor = Color.White;
            }
        }

      

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                if (dtgVenta.CurrentRow != null)
                {
                    
                    int indiceFilaSeleccionada = dtgVenta.CurrentRow.Index;

                    
                    double totalFilaSeleccionada = Convert.ToDouble(dtgVenta.Rows[indiceFilaSeleccionada].Cells["Total"].Value);

                    
                    dtgVenta.Rows.RemoveAt(indiceFilaSeleccionada);

                    
                    totalVenta -= totalFilaSeleccionada;
                    totalIva = totalVenta * 0.19;
                    double total = totalVenta + totalIva;

                    lbSubTotal.Text = totalVenta.ToString("0.00");
                    lbIVA.Text = totalIva.ToString("0.00");
                    lbTotal.Text = total.ToString("0.00");
                }
                else
                {
                    MessageBox.Show("Seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seleccione el método de pago:", "Seleccionar Método de Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) // Si elige sí, significa que va a pagar en efectivo
            {
                // Mostrar el formulario para pago en efectivo
                FormEfectivo formEfectivo = new FormEfectivo(totalVenta); // Pasar el total de la venta al formulario de efectivo
                formEfectivo.ShowDialog();

                // Verificar si se completó la operación en el formulario de efectivo
                if (formEfectivo.PagoCompletado)
                {
                    // Si se completó la operación, agregar la venta a la base de datos con el método de pago "Efectivo"
                    AgregarVenta("Efectivo");
                }
            }
            else // Si elige no, significa que va a pagar por transferencia
            {
                // Agregar la venta a la base de datos con el método de pago "Transferencia"
                AgregarVenta("Transferencia");
            }
        }

        private void AgregarVenta(string metodoPago)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Venta (NombreProducto, Cantidad, PrecioUnidad, Total, MetodoPago) VALUES (@nombreProducto, @cantidad, @precioUnidad, @total, @metodoPago)", connection);
                // Aquí deberías reemplazar los valores con los adecuados, dependiendo de cómo obtengas la información de la venta
                cmd.Parameters.AddWithValue("@nombreProducto", "NombreProducto");
                cmd.Parameters.AddWithValue("@cantidad", "Cantidad");
                cmd.Parameters.AddWithValue("@precioUnidad", "PrecioUnidad");
                cmd.Parameters.AddWithValue("@total", "Total");
                cmd.Parameters.AddWithValue("@metodoPago", metodoPago);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Venta agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            FormEfectivo efectivo = new FormEfectivo(totalVenta);
            efectivo.Show();
        }
    }
}
