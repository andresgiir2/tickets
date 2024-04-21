using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace DiseñoUi
{
    public partial class Productos : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UR38VU6\\SQLEXPRESS;Initial Catalog=SUPERMERCADITO;Integrated Security=True");
       
        public Productos()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CargarProductos();
        }


        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "Codigo")
            {
                txtCodigo.Text = "";
                txtCodigo.ForeColor = Color.FromArgb(49, 66, 82);
                txtCodigo.ForeColor = Color.White;
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                txtCodigo.Text = "Codigo";
                txtCodigo.ForeColor = Color.White;
            }
        }

        private void txtNombreProducto_Enter(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text == "Nombre Producto")
            {
                txtNombreProducto.Text = "";
                txtCodigo.ForeColor = Color.FromArgb(49, 66, 82);
                txtCodigo.ForeColor = Color.White;
            }

        }

        private void txtNombreProducto_Leave(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text == "")
            {
                txtNombreProducto.Text = "Nombre Producto";
                txtCodigo.ForeColor = Color.White;
            }
        }

        private void txtCategoria_Enter(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "Categoria")
            {
                txtCategoria.Text = "";
                txtCodigo.ForeColor = Color.FromArgb(49, 66, 82);
                txtCodigo.ForeColor = Color.White;
            }
        }

        private void txtCategoria_Leave(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "")
            {
                txtCategoria.Text = "Categoria";
                txtCodigo.ForeColor = Color.White;
            }
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "Cantidad")
            {
                txtCantidad.Text = "";
                txtCodigo.ForeColor = Color.FromArgb(49, 66, 82);
                txtCodigo.ForeColor = Color.White;
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                txtCantidad.Text = "Cantidad";
                txtCodigo.ForeColor = Color.White;
            }
        }

        private void txtPrecioCompra_Enter(object sender, EventArgs e)
        {
            if (txtPrecioCompra.Text == "Precio Compra")
            {
                txtPrecioCompra.Text = "";
                txtCodigo.ForeColor = Color.FromArgb(49, 66, 82);
                txtCodigo.ForeColor = Color.White;
            }

        }

        private void txtPrecioCompra_Leave(object sender, EventArgs e)
        {
            if (txtPrecioCompra.Text == "")
            {
                txtPrecioCompra.Text = "Precio Compra";
                txtCodigo.ForeColor = Color.White;
            }
        }

        private void txtPrecioVenta_Enter(object sender, EventArgs e)
        {
            if (txtPrecioVenta.Text == "Precio Venta")
            {
                txtPrecioVenta.Text = "";
                txtCodigo.ForeColor = Color.FromArgb(49, 66, 82);
                txtCodigo.ForeColor = Color.White;
            }
        }

        private void txtPrecioVenta_Leave(object sender, EventArgs e)
        {
            if (txtPrecioVenta.Text == "")
            {
                txtPrecioVenta.Text = "Precio Venta";
                txtCodigo.ForeColor = Color.White;
            }
        }

        private void brnAgregar_Click(object sender, EventArgs e)
        {
            int cantidad;
            if (!int.TryParse(txtCantidad.Text, out cantidad))
            {
                MessageBox.Show("Invalid quantity entered.", "Error");
                return;
            }

            string nombre = txtNombreProducto.Text;
            string codigo = txtCodigo.Text;
            string categoria = txtCategoria.Text;
            DateTime fechaVencimiento = dTFechaV.Value;
            decimal costo;
            if (!decimal.TryParse(txtPrecioCompra.Text, out costo))
            {
                MessageBox.Show("Invalid cost entered.", "Error");
                return;
            }
            decimal precioVenta;
            if (!decimal.TryParse(txtPrecioVenta.Text, out precioVenta))
            {
                MessageBox.Show("Invalid selling price entered.", "Error");
                return;
            }


            try
            {

                if (Inventario.RegistrarProducto(codigo, nombre, categoria, cantidad, fechaVencimiento, costo, precioVenta, connection))
                {
                    MessageBox.Show("Producto Registrado Correctamente");
                    var newProduct = new
                    {
                        Codigo = codigo,
                        Nombre = nombre,
                        Categoria = categoria,
                        Cantidad = cantidad,
                        FechaVencimiento = fechaVencimiento.ToShortDateString(),
                        Costo = costo.ToString("C2"),
                        PrecioVenta = precioVenta.ToString("C2")
                    };
                    dtgProductos.Rows.Add(newProduct.Codigo, newProduct.Nombre, newProduct.Categoria, newProduct.Cantidad, newProduct.FechaVencimiento, newProduct.Costo, newProduct.PrecioVenta);
                }
                else
                {
                    MessageBox.Show("Error al registrar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ConfigurarDataGridView()
        {
            dtgProductos.Columns.Add("Codigo", "Código");
            dtgProductos.Columns.Add("Nombre", "Nombre");
            dtgProductos.Columns.Add("Categoria", "Categoría");
            dtgProductos.Columns.Add("Cantidad", "Cantidad");
            dtgProductos.Columns.Add("FechaVencimiento", "Fecha de Vencimiento");
            dtgProductos.Columns.Add("Costo", "Costo");
            dtgProductos.Columns.Add("PrecioVenta", "Precio de Venta");
            dtgProductos.AutoGenerateColumns = false;
        }

        private void CargarProductos()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT Codigo, Nombre, Categoria, Cantidad, FechaVenc, PrecioCompra, PrecioVenta FROM Producto", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    dtgProductos.Rows.Add(row["Codigo"], row["Nombre"], row["Categoria"], row["Cantidad"], row["FechaVenc"], Convert.ToDouble(row["PrecioCompra"]), Convert.ToDouble(row["PrecioVenta"]));
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

        private void Productos_Load(object sender, EventArgs e)
        {

        }



        private void dtgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dtgProductos.Rows[e.RowIndex];
                txtCodigo.Text = row.Cells["Codigo"].Value.ToString();
                txtNombreProducto.Text = row.Cells["Nombre"].Value.ToString();
                txtCategoria.Text = row.Cells["Categoria"].Value.ToString();
                txtCantidad.Text = row.Cells["Cantidad"].Value.ToString();
                dTFechaV.Value = Convert.ToDateTime(row.Cells["FechaVencimiento"].Value);
                txtPrecioCompra.Text = row.Cells["Costo"].Value.ToString();
                txtPrecioVenta.Text = row.Cells["PrecioVenta"].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dtgProductos.CurrentRow != null)
                {
                    string nuevoCodigo = txtCodigo.Text;
                    string nuevoNombre = txtNombreProducto.Text;
                    string nuevaCategoria = txtCategoria.Text;
                    int nuevaCantidad = Convert.ToInt32(txtCantidad.Text);
                    DateTime nuevaFechaVencimiento = dTFechaV.Value;
                    decimal nuevoCosto = Convert.ToDecimal(txtPrecioCompra.Text);
                    decimal nuevoPrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);

                    if (Inventario.editarProdcutos(nuevoCodigo, nuevoNombre, nuevaCategoria, nuevaCantidad, nuevaFechaVencimiento, nuevoCosto, nuevoPrecioVenta, connection))
                    {
                        MessageBox.Show("Producto editado correctamente");
                        var editedProduct = new
                        {
                            Codigo = nuevoCodigo,
                            Nombre = nuevoNombre,
                            Categoria = nuevaCategoria,
                            Cantidad = nuevaCantidad,
                            FechaVencimiento = nuevaFechaVencimiento.ToShortDateString(),
                            Costo = nuevoCosto,
                            PrecioVenta = nuevoPrecioVenta
                        };

                        dtgProductos.Rows.Add(editedProduct.Codigo, editedProduct.Nombre, editedProduct.Categoria, editedProduct.Cantidad, editedProduct.FechaVencimiento, editedProduct.Costo, editedProduct.PrecioVenta);
                    }
                    else
                    {
                        MessageBox.Show("Error al editar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
               
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dtgProductos.SelectedRows.Count > 0)
                {
                    string codigo = dtgProductos.SelectedRows[0].Cells["Codigo"].Value.ToString();

                    if (string.IsNullOrEmpty(codigo))
                    {
                        MessageBox.Show("Error: El código del producto seleccionado es nulo o vacío.");
                        return;
                    }

                    if (Inventario.eliminarProducto(codigo, connection))
                    {
                        MessageBox.Show("Producto Eliminado Correctamente");
                        int rowIndex = dtgProductos.SelectedRows[0].Index;
                        dtgProductos.Rows.RemoveAt(rowIndex);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el producto de la base de datos");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un producto para eliminar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
         
    }
}
