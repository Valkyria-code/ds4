using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_16
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_mensaje_Click(object sender, EventArgs e)
        {
            lbl_mensaje.Text = "¡Hola, Mundo en ASP.NET!";
        }
    }
}