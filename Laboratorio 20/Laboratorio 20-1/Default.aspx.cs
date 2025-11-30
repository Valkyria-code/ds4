using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_20_1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            int numero;

            if (int.TryParse(txtNumero.Text, out numero))
            {
                string tabla = "<table border='1'>";
                tabla += "<tr><th>Multiplicación</th><th>Resultado</th></tr>";

                for (int i = 1; i <= 25; i++)
                {
                    int resultado = numero * i;
                    tabla += "<tr>";
                    tabla += "<td>" + numero + " x " + i + "</td>";
                    tabla += "<td>" + resultado + "</td>";
                    tabla += "</tr>";
                }

                tabla += "</table>";
                litResultado.Text = tabla;
            }
            else
            {
                litResultado.Text = "<p style='color:red;'>Por favor ingrese un número válido</p>";
            }
        }
    }
}