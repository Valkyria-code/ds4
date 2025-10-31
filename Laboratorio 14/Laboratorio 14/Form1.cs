using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_14
{
    public partial class frm_productos : Form
    {
        string connectionString = @"Server=.;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";
        bool nuevo;

        public frm_productos()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frm_productos_Load(object sender, EventArgs e)
        {
            tsb_nuevo.Enabled = true;
            tsb_guardar.Enabled = false;
            tsb_cancelar.Enabled = false;
            tsb_eliminar.Enabled = false;
            txt_id.Enabled = false;
            tsb_buscar.Enabled = true;
            txt_nombre.Enabled = false;
            txt_precio.Enabled = false;
            txt_stock.Enabled = false;
        }

        private void tsb_nuevo_Click(object sender, EventArgs e)
        {
            tsb_nuevo.Enabled = false;
            tsb_guardar.Enabled = true;
            tsb_cancelar.Enabled = true;
            tsb_eliminar.Enabled = false;
            txt_id.Enabled = false;
            tsb_buscar.Enabled = false;
            txt_nombre.Enabled = true;
            txt_precio.Enabled = true;
            txt_stock.Enabled = true;
            txt_nombre.Focus();
            nuevo = true;
        }

        private void tsb_guardar_Click(object sender, EventArgs e)
        {
            if (nuevo)
            {
                string sql = "INSERT INTO LAPTOPS (NOMBRE, PRECIO, STOCK)" + "VALUES ('" + txt_nombre.Text + "', '" + txt_precio.Text + "', '" + txt_stock.Text + "')";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show("Registro ingresado correctamente !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                string sql = "UPDATE LAPTOPS SET NOMBRE='" + txt_nombre.Text + "', PRECIO='" + txt_precio.Text + "', " + "STOCK='" + txt_stock.Text + "' WHERE id=" + txt_id.Text + "";
                
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show("Registro actualizado correctamente !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }

            tsb_nuevo.Enabled = true;
            tsb_guardar.Enabled = false;
            tsb_cancelar.Enabled = false;
            tsb_eliminar.Enabled = false;
            tst_id.Enabled = true;
            tsb_buscar.Enabled = true;
            txt_nombre.Enabled = false;
            txt_precio.Enabled = false;
            txt_stock.Enabled = false;
            txt_id.Text = "";
            txt_nombre.Text = "";
            txt_precio.Text = "";
            txt_stock.Text = "";
        }

        private void tsb_cancelar_Click(object sender, EventArgs e)
        {
            tsb_nuevo.Enabled = true;
            tsb_guardar.Enabled = false;
            tsb_cancelar.Enabled = false;
            tsb_eliminar.Enabled = false;
            tst_id.Enabled = true;
            tsb_buscar.Enabled = true;
            txt_nombre.Enabled = false;
            txt_precio.Enabled = false;
            txt_stock.Enabled = false;
            txt_id.Text = "";
            txt_nombre.Text = "";
            txt_precio.Text = "";
            txt_stock.Text = "";
        }

        private void tsb_eliminar_Click(object sender, EventArgs e)
        {
            string sql = "delete from LAPTOPS where id='" + this.txt_id.Text + "';";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Registro actualizado correctamente !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            tsb_nuevo.Enabled = true;
            tsb_guardar.Enabled = false;
            tsb_cancelar.Enabled = false;
            tsb_eliminar.Enabled = false;
            tst_id.Enabled = true;
            tsb_buscar.Enabled = true;
            txt_nombre.Enabled = false;
            txt_precio.Enabled = false;
            txt_stock.Enabled = false;
            txt_id.Text = "";
            txt_nombre.Text = "";
            txt_precio.Text = "";
            txt_stock.Text = "";
        }

        private void tsb_buscar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM LAPTOPS WHERE ID=" + tst_id.Text;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;

            con.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tsb_nuevo.Enabled = false;
                    tsb_guardar.Enabled = true;
                    tsb_cancelar.Enabled = true;
                    tsb_eliminar.Enabled = true;
                    tst_id.Enabled = false;
                    tsb_buscar.Enabled = false;
                    txt_nombre.Enabled = true;
                    txt_precio.Enabled = true;
                    txt_stock.Enabled = true;
                    txt_nombre.Focus();
                    txt_id.Text = reader[0].ToString();
                    txt_nombre.Text = reader[1].ToString();
                    txt_precio.Text = reader[2].ToString();
                    txt_stock.Text = reader[3].ToString();
                    nuevo = false;
                }
                else
                {
                    MessageBox.Show("Ningún registro encontrado con el ID ingresado !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            tst_id.Text = "";
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
