using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_20_3
{
    public partial class Default : System.Web.UI.Page
    {
        string connectionString = @"Server=.\sqlexpress;Database=productos;Integrated Security=True;";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarProductos();
            }
        }

        private void CargarProductos()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Laptops ORDER BY id";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    gvProductos.DataSource = dt;
                    gvProductos.DataBind();
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";

            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;
            btnGuardar.Enabled = true;
            lblMensaje.Text = "";
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(txtStock.Text))
            {
                lblMensaje.Text = "Complete todos los campos";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd;

                    if (string.IsNullOrEmpty(txtId.Text))
                    {
                        // INSERT
                        string query = "INSERT INTO Laptops (nombre, precio, stock) VALUES (@nombre, @precio, @stock)";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@precio", decimal.Parse(txtPrecio.Text));
                        cmd.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));
                        cmd.ExecuteNonQuery();
                        lblMensaje.Text = "Producto guardado";
                    }
                    else
                    {
                        // UPDATE
                        string query = "UPDATE Laptops SET nombre=@nombre, precio=@precio, stock=@stock WHERE id=@id";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@precio", decimal.Parse(txtPrecio.Text));
                        cmd.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));
                        cmd.ExecuteNonQuery();
                        lblMensaje.Text = "Producto actualizado";
                    }

                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                }

                CargarProductos();
                txtId.Text = "";
                txtNombre.Text = "";
                txtPrecio.Text = "";
                txtStock.Text = "";
                txtNombre.Enabled = false;
                txtPrecio.Enabled = false;
                txtStock.Enabled = false;
                btnGuardar.Enabled = false;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            btnGuardar.Enabled = false;
            lblMensaje.Text = "";
        }

        protected void gvProductos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Editar")
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT * FROM Laptops WHERE id=@id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", id);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtId.Text = reader["id"].ToString();
                            txtNombre.Text = reader["nombre"].ToString();
                            txtPrecio.Text = reader["precio"].ToString();
                            txtStock.Text = reader["stock"].ToString();

                            txtNombre.Enabled = true;
                            txtPrecio.Enabled = true;
                            txtStock.Enabled = true;
                            btnGuardar.Enabled = true;
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = "Error: " + ex.Message;
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                }
            }
            else if (e.CommandName == "Eliminar")
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Laptops WHERE id=@id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        lblMensaje.Text = "Producto eliminado";
                        lblMensaje.ForeColor = System.Drawing.Color.Green;
                    }

                    CargarProductos();
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = "Error: " + ex.Message;
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}