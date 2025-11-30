using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Labratorio_20_2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            int n;

            if (!int.TryParse(txtDimension.Text, out n))
            {
                litResultado.Text = "<p style='color:red;'>Por favor ingrese un número válido</p>";
                return;
            }

            if (n <= 0 || n > 20)
            {
                litResultado.Text = "<p style='color:red;'>Por favor ingrese un número entre 1 y 20</p>";
                return;
            }

            // Generar la matriz
            string tabla = "<table border='1'>";

            for (int i = 0; i < n; i++)
            {
                tabla += "<tr>";

                for (int j = 0; j < n; j++)
                {
                    // La diagonal inversa es cuando i + j = n - 1
                    if (i + j == n - 1)
                    {
                        tabla += "<td style='padding:10px; text-align:center;'><b>1</b></td>";
                    }
                    else
                    {
                        int valor = i + j + 2;
                        tabla += "<td style='padding:10px; text-align:center;'>" + valor + "</td>";
                    }
                }

                tabla += "</tr>";
            }

            tabla += "</table>";
            litResultado.Text = tabla;
        }
    }
}