using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class ventana : Form
    {

        string connectionString = @"Server=.;Database=ConversorNumerico;TrustServerCertificate=true;Integrated Security=SSPI;";

        public ventana()
        {
            InitializeComponent();
            CargarHistorial();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GuardarConversion(string tipoConversion, string valorEntrada, string valorSalida)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO Historial (TipoConversion, ValorEntrada, ValorSalida, FechaHora) VALUES (@Tipo, @Entrada, @Salida, @Fecha)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Tipo", tipoConversion);
                        cmd.Parameters.AddWithValue("@Entrada", valorEntrada);
                        cmd.Parameters.AddWithValue("@Salida", valorSalida);
                        cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }
                }

                CargarHistorial();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar en la base de datos:\n{ex.Message}", "Error de BD");
            }
        }

        private void CargarHistorial()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT Id, TipoConversion, ValorEntrada, ValorSalida, FechaHora FROM Historial ORDER BY FechaHora DESC";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvHistorial.DataSource = dt;

                        if (dgvHistorial.Columns.Count > 0)
                        {
                            dgvHistorial.Columns["Id"].HeaderText = "ID";
                            dgvHistorial.Columns["TipoConversion"].HeaderText = "Tipo";
                            dgvHistorial.Columns["ValorEntrada"].HeaderText = "Entrada";
                            dgvHistorial.Columns["ValorSalida"].HeaderText = "Salida";
                            dgvHistorial.Columns["FechaHora"].HeaderText = "Fecha y Hora";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el historial:\n{ex.Message}", "Error de BD");
            }
        }

        private void btn_hecdec_Click(object sender, EventArgs e)
        {
            string valorHexadecimal = tbx_hex.Text;

            if (string.IsNullOrWhiteSpace(valorHexadecimal))
            {
                MessageBox.Show("Por favor ingresa un valor hexadecimal.", "Campo vacío");

                return;
            }

            try
            {
                int resultado = Convert.ToInt32(valorHexadecimal, 16);
                tbx_messagehex.Text = resultado.ToString();

                GuardarConversion("Hexadecimal a Decimal", valorHexadecimal.ToUpper(), resultado.ToString());
            }
            catch (FormatException)
            {
                MessageBox.Show("El valor ingresado no es un hexadecimal válido.\n" + "Usa solo: 0-9, A-F", "Error de formato");

                // Limpiar el TextBox
                tbx_hex.Clear();
                tbx_hex.Focus();
            }
            catch (OverflowException)
            {
                MessageBox.Show("El número es demasiado grande.", "Error");
            }
        }

        private void btn_dechec_Click(object sender, EventArgs e)
        {
            string valorDecimal = tbx_dec1.Text;

            if (string.IsNullOrWhiteSpace(valorDecimal))
            {
                MessageBox.Show("Por favor ingresa un valor decimal.", "Campo vacío");

                return;
            }

            try
            {
                int valorDec = int.Parse(valorDecimal);
                string resultado = Convert.ToString(valorDec, 16).ToUpper();

                tbx_messagedec1.Text = resultado;

                GuardarConversion("Decimal a Hexadecimal", valorDecimal.ToUpper(), resultado.ToString());
            }
            catch (FormatException)
            {
                MessageBox.Show("El valor ingresado no es un número decimal válido.\n" + "Usa solo: 0-9", "Error de formato");
                
                tbx_dec1.Clear();
                tbx_dec1.Focus();
            }
            catch (OverflowException)
            {
                MessageBox.Show("El número está fuera del rango permitido.", "Error");
            }
        }

        private void btn_ocdec_Click(object sender, EventArgs e)
        {
            string valorOctal = tbx_oc.Text;

            if (string.IsNullOrWhiteSpace(valorOctal))
            {
                MessageBox.Show("Por favor ingresa un valor octal.", "Campo vacío");
                
                return;
            }

            try
            {
                int resultado = Convert.ToInt32(valorOctal, 8);

                tbx_messageoc.Text = resultado.ToString();

                GuardarConversion("Octal a Decimal", valorOctal.ToUpper(), resultado.ToString());
            }
            catch (FormatException)
            {
                MessageBox.Show("El valor ingresado no es un octal válido.\n" + "Usa solo: 0-7", "Error de formato");
                
                tbx_oc.Clear();
                tbx_oc.Focus();
            }
            catch (OverflowException)
            {
                MessageBox.Show("El número es demasiado grande.", "Error");
            }
        }

        private void btn_decoc_Click(object sender, EventArgs e)
        {
            string valorDecimal2 = tbx_dec2.Text;

            if (string.IsNullOrWhiteSpace(valorDecimal2))
            {
                MessageBox.Show("Por favor ingresa un valor decimal.", "Campo vacío");
                
                return;
            }

            try
            {
                int numero = int.Parse(valorDecimal2);
                string resultado = Convert.ToString(numero, 8);
                tbx_messagedec2.Text = resultado;

                GuardarConversion("Decimal a Octal", valorDecimal2, resultado);
            }
            catch (FormatException)
            {
                MessageBox.Show("El valor ingresado no es un número decimal válido.\nUsa solo: 0-9", "Error de formato");
                
                tbx_dec2.Clear();
                tbx_dec2.Focus();
            }
            catch (OverflowException)
            {
                MessageBox.Show("El número está fuera del rango permitido.", "Error");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
