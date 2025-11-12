using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_16
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static float a, c, d;
        static char b;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_1_Click(object sender, EventArgs e)
        {
            if ((txt.Text == "+") || (txt.Text == "-") || (txt.Text == "*") || (txt.Text == "/"))
            {
                txt.Text = "";
                txt.Text = txt.Text + btn_1.Text;
            }
            else
            {
                txt.Text = txt.Text + btn_1.Text;
            }
        }

        protected void btn_2_Click(object sender, EventArgs e)
        {
            if ((txt.Text == "+") || (txt.Text == "-") || (txt.Text == "*") || (txt.Text == "/"))
            {
                txt.Text = "";
                txt.Text = txt.Text + btn_2.Text;
            }
            else
            {
                txt.Text = txt.Text + btn_2.Text;
            }

        }

        protected void btn_3_Click(object sender, EventArgs e)
        {
            if ((txt.Text == "+") || (txt.Text == "-") || (txt.Text == "*") || (txt.Text == "/"))
            {
                txt.Text = "";
                txt.Text = txt.Text + btn_3.Text;
            }
            else
            {
                txt.Text = txt.Text + btn_3.Text;
            }
        }

        protected void btn_4_Click(object sender, EventArgs e)
        {
            if ((txt.Text == "+") || (txt.Text == "-") || (txt.Text == "*") || (txt.Text == "/"))
            {
                txt.Text = "";
                txt.Text = txt.Text + btn_4.Text;
            }
            else
            {
                txt.Text = txt.Text + btn_4.Text;
            }
        }

        protected void btn_5_Click(object sender, EventArgs e)
        {
            if ((txt.Text == "+") || (txt.Text == "-") || (txt.Text == "*") || (txt.Text == "/"))
            {
                txt.Text = "";
                txt.Text = txt.Text + btn_5.Text;
            }
            else
            {
                txt.Text = txt.Text + btn_5.Text;
            }
        }

        protected void btn_6_Click(object sender, EventArgs e)
        {
            if ((txt.Text == "+") || (txt.Text == "-") || (txt.Text == "*") || (txt.Text == "/"))
            {
                txt.Text = "";
                txt.Text = txt.Text + btn_6.Text;
            }
            else
            {
                txt.Text = txt.Text + btn_6.Text;
            }
        }

        protected void btn_7_Click(object sender, EventArgs e)
        {
            if ((txt.Text == "+") || (txt.Text == "-") || (txt.Text == "*") || (txt.Text == "/"))
            {
                txt.Text = "";
                txt.Text = txt.Text + btn_7.Text;
            }
            else
            {
                txt.Text = txt.Text + btn_7.Text;
            }
        }

        protected void btn_8_Click(object sender, EventArgs e)
        {
            if ((txt.Text == "+") || (txt.Text == "-") || (txt.Text == "*") || (txt.Text == "/"))
            {
                txt.Text = "";
                txt.Text = txt.Text + btn_8.Text;
            }
            else
            {
                txt.Text = txt.Text + btn_8.Text;
            }
        }

        protected void btn_9_Click(object sender, EventArgs e)
        {
            if ((txt.Text == "+") || (txt.Text == "-") || (txt.Text == "*") || (txt.Text == "/"))
            {
                txt.Text = "";
                txt.Text = txt.Text + btn_9.Text;
            }
            else
            {
                txt.Text = txt.Text + btn_9.Text;
            }
        }

        protected void btn_0_Click(object sender, EventArgs e)
        {
            if ((txt.Text == "+") || (txt.Text == "-") || (txt.Text == "*") || (txt.Text == "/"))
            {
                txt.Text = "";
                txt.Text = txt.Text + btn_0.Text;
            }
            else
            {
                txt.Text = txt.Text + btn_0.Text;
            }
        }

        protected void btn_suma_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txt.Text);
            txt.Text = "";
            b = '+';
            txt.Text += b;
        }

        protected void btn_resta_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txt.Text);
            txt.Text = "";
            b = '-';
            txt.Text += b;
        }

        protected void btn_multiplicacion_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txt.Text);
            txt.Text = "";
            b = '*';
            txt.Text += b;
        }

        protected void btn_division_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txt.Text);
            txt.Text = "";
            b = '/';
            txt.Text += b;
        }

        protected void btn_igual_Click(object sender, EventArgs e)
        {
            c = Convert.ToInt32(txt.Text);

            txt.Text = "";

            if (b == '/')
            {
                d = a / c;
                txt.Text += d;
                a = d;
            }
            else if (b == '+')
            {
                d = a + c;
                txt.Text += d;
                a = d;
            }
            else if (b == '-')
            {
                d = a - c;
                txt.Text += d;
                a = d;
            }
            else
            {
                d = a * c;
                txt.Text += d;
                a = d;
            }
        }

        protected void btn_clear_Click(object sender, EventArgs e)
        {
            txt.Text = "";
        }
    }
}