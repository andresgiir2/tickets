using System;
using System.Data;
using System.Data.SqlClient;

namespace DiseñoUi
{
    internal class Inventario
    {
        private SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UR38VU6\\SQLEXPRESS;Initial Catalog=SUPERMERCADITO;Integrated Security=True");
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }

        public Inventario(int cantidad, string nombre, string codigo, string categoria, DateTime fechaVencimiento, decimal costo, decimal precioVenta)
        {
            Codigo = codigo;
            Nombre = nombre;
            Categoria = categoria;
            Cantidad = cantidad;
            FechaVencimiento = fechaVencimiento;
            Costo = costo;
            PrecioVenta = precioVenta;

        }

        public static bool RegistrarProducto(string codigo, string nombre, string categoria, int cantidad, DateTime fechaVencimiento, decimal costo, decimal precioVenta, SqlConnection connection)
        {
            try
            {
                connection.Open();
                

                using (SqlCommand comando = new SqlCommand("INSERT INTO Producto (codigo, Nombre, Categoria, Cantidad, FechaVenc, PrecioCompra, PrecioVenta) VALUES (@Codigo, @Nombre, @Categoria, @Cantidad, @FechaVencimiento, @Costo, @PrecioVenta)", connection))
                {
                    comando.Parameters.AddWithValue("@Codigo", codigo);
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Categoria", categoria);
                    comando.Parameters.AddWithValue("@Cantidad", cantidad);
                    comando.Parameters.AddWithValue("@FechaVencimiento", fechaVencimiento);
                    comando.Parameters.AddWithValue("@Costo", costo);
                    comando.Parameters.AddWithValue("@PrecioVenta", precioVenta);

                    int filasAfectadas = comando.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
           
            finally
            {
                connection.Close();
            }
        }

        public static bool editarProdcutos(string nuevoCodigo, string nuevoNombre, string nuevaCategoria, int nuevaCantidad, DateTime nuevaFechaVencimiento, decimal nuevoCosto, decimal nuevoPrecioVenta, SqlConnection connection)
        {

            try
            {
                connection.Open();

                using (SqlCommand editar = new SqlCommand("UPDATE Producto SET Nombre = @Nombre, Categoria = @Categoria, Cantidad = @Cantidad, FechaVenc = @FechaVencimiento, PrecioCompra = @Costo, PrecioVenta = @PrecioVenta WHERE codigo = @Codigo", connection))
                {
                    editar.Parameters.AddWithValue("@Codigo", nuevoCodigo);
                    editar.Parameters.AddWithValue("@Nombre", nuevoNombre);
                    editar.Parameters.AddWithValue("@Categoria",nuevaCategoria);
                    editar.Parameters.AddWithValue("@Cantidad", nuevaCantidad);
                    editar.Parameters.AddWithValue("@FechaVencimiento", nuevaFechaVencimiento);
                    editar.Parameters.AddWithValue("@Costo", nuevoCosto);
                    editar.Parameters.AddWithValue("@PrecioVenta", nuevoPrecioVenta);

                    int filasAfectadas = editar.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool eliminarProducto(string codigo, SqlConnection connection)
        {

            try
            {
                if (string.IsNullOrEmpty(codigo))
                {
                    throw new ArgumentNullException(nameof(codigo), "El código del producto no puede ser nulo ni vacío.");
                }

                connection.Open();
                using (SqlCommand eliminar = new SqlCommand("DELETE FROM Producto WHERE Codigo = @codigo", connection))
                {
                    eliminar.Parameters.Add("@codigo", SqlDbType.VarChar).Value = codigo;
                    int filasAfectadas = eliminar.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error eliminando el producto: {0}", ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
