using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }

        public Usuario(int idUsuario, string nombreUsuario, string contraseña)
        {
            IdUsuario = idUsuario;
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
        }

        public static bool RegistrarUsuario(string nombreUsuario, string contraseña, SqlConnection connection)
        {
            try
            {
                connection.Open();
                string contraseñaHasheada = CalcularHash(contraseña);

                using (SqlCommand comando = new SqlCommand("INSERT INTO Usuarios (Usuario, Contraseña) VALUES (@NombreUsuario, @Contraseña)", connection))
                {
                    comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    comando.Parameters.AddWithValue("@Contraseña", contraseñaHasheada);

                    int filasAfectadas = comando.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool ValidarUsuario(string nombreUsuario, string contraseña, SqlConnection connection)
        {
            string contraseñaHasheada = CalcularHash(contraseña);

            using (SqlCommand comando = new SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE Usuario = @NombreUsuario AND Contraseña = @Contraseña", connection))
            {
                comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                comando.Parameters.AddWithValue("@Contraseña", contraseñaHasheada);

                int count = (int)comando.ExecuteScalar();
                return count > 0;
            }
        }

        public static string CalcularHash(string contraseña)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(contraseña));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
