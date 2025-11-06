using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_15_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_igual_Click(object sender, EventArgs e)
        {
            int num_uno = Convert.ToInt32(txt_uno.Text);
            int num_dos = Convert.ToInt32(txt_dos.Text);

            int respuesta = num_uno + num_dos;

            txt_respuesta.Text = "La suma es: " + respuesta.ToString();
        }
    }
}