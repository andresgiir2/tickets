using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Parqueadero
{
    
    public partial class AccesoParqueo : Form
    {
        string[,] NumPlaza = new string[3, 50];
        
        public AccesoParqueo()
        {
            InitializeComponent();
            for (int i = 0; i < NumPlaza.GetLength(0); i++)
            {
                for (int j = 0; j < NumPlaza.GetLength(1); j++)
                {
                    NumPlaza[i, j] = "-1";
                }
            }
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            Random plaza = new Random();

            if (string.IsNullOrEmpty(placa))
            {
                MessageBox.Show("El campo Placa no puede estar vacío");
                
                return;
            }

          
            for (int i = 0; i < NumPlaza.GetLength(1); i++)
            {
                if (NumPlaza[1, i] == placa)
                {
                    MessageBox.Show("La placa ya se encuentra registrada");
                    txtPlaca.Text = "";
                    return;
                }
            }

            int Aleatorio;
            int intentos = 0;
            do
            {
                Aleatorio = plaza.Next(1, 51);
                MessageBox.Show($"La Placa: {placa}, debe parquear en la plaza {Aleatorio}");
                intentos++;
            } while (NumPlaza[0, Aleatorio - 1] != "-1" && intentos < 50);

            if (intentos == 50)
            {
                MessageBox.Show("Todas las plazas están ocupadas");
                return;
            }

            NumPlaza[0, Aleatorio - 1] = Aleatorio.ToString();
            NumPlaza[1, Aleatorio - 1] = placa;
            NumPlaza[2, Aleatorio - 1] = DateTime.Now.ToString("HH:mm:ss");

          
            using (StreamWriter sw = new StreamWriter(@"C:\\Users\\Andres\\source\\repos\\Registro Parqueadero\\Registro Parqueadero\\Parqueadero.txt", true))
            {
                sw.WriteLine($"Plaza: {NumPlaza[0, Aleatorio - 1]}, Placa: {NumPlaza[1, Aleatorio - 1]}, Hora de entrada: {NumPlaza[2, Aleatorio - 1]}");
            }

            MessageBox.Show("Placa registrada correctamente");
            txtPlaca.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text; 
            string plaza = "";

            if (txtPlaca.Text == "")
            {
                MessageBox.Show("El campo Placa no puede estar vacio");
            }

            for (int i = 0; i<NumPlaza.GetLength(1); i++)
            {
                if (NumPlaza[1, i] == placa)
                {
                    plaza = NumPlaza[0, i];
                    break;
                }
            }
            if (plaza != "")
            {
                lbUbicacion.Text = $"Placa: {placa}, Plaza: {plaza}";
            }
            else
            {
                lbUbicacion.Text = $"La placa {placa} no se encuentra en el parqueadero.";
            }
            txtPlaca.Text = "";
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            string plaza = "";
            string horaEntrada = "";
            string tiempoEstacionado = "";
            int valorDia = 25000;
            int valorHora = 6000;
            int costo = 0;

            if (txtPlaca.Text == "")
            {
                MessageBox.Show("El campo Placa no puede estar vacio");
            }

            for (int i = 0; i < NumPlaza.GetLength(1); i++)
            {
                if (NumPlaza[1, i] == placa)
                {
                    plaza = NumPlaza[0, i];
                    horaEntrada = NumPlaza[2, i];
                    NumPlaza[0, i] = "-1";
                    NumPlaza[1, i] = "-1";
                    NumPlaza[2, i] = "-1";
                    break;  
                }
            }

            if (plaza != "")
            {
                DateTime entrada = DateTime.Parse(horaEntrada);
                DateTime salida = DateTime.Now;
                TimeSpan diferencia = salida - entrada;
                tiempoEstacionado = $"{diferencia.Days} días, {diferencia.Hours} horas, {diferencia.Minutes} minutos";
                costo = (diferencia.Days * valorDia) + (diferencia.Hours * valorHora);

                lbUbicacion.Text = $"Placa: {placa}, Plaza: {plaza}, Tiempo estacionado: {tiempoEstacionado}, Costo: {costo}";

                
                string[] lineas = File.ReadAllLines(@"C:\\Users\\Andres\\source\\repos\\Registro Parqueadero\\Registro Parqueadero\\Parqueadero.txt");

                
                int indice = Array.FindIndex(lineas, linea => linea.Contains($"Placa: {placa}"));
                if (indice != -1)
                {
                    lineas[indice] = null;
                }

                
                File.WriteAllLines("parqueadero.txt", lineas.Where(linea => linea != null));
            }
            else
            {
                lbUbicacion.Text = $"La placa {placa} no se encuentra en el parqueadero.";
            }
            txtPlaca.Text = "";

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVer_Click_1(object sender, EventArgs e)
        {
            int Ocupadas = 0;
            for (int i = 0; i < NumPlaza.GetLength(1); i++)
            {
                if (NumPlaza[0, i] != "-1")
                {
                    Ocupadas++;
                    lbUbicacion.Text = $"Plaza: {NumPlaza[0, i]}, Placa: {NumPlaza[1, i]}, Hora de entrada: {NumPlaza[2, i]}";
                }
            }
            int Disponibilidad = 50 - Ocupadas;
            lbUbicacion.Text = $"Plazas disponibles: {Disponibilidad}, Plazas ocupadas: {Ocupadas} ";

            txtPlaca.Text = "";
        }
    }
}
