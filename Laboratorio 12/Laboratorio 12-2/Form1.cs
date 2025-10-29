using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_12_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tn_semiperimetro_Click(object sender, EventArgs e)
        {
            int ladoa = Convert.ToInt32(txt_ladoa.Text);
            int ladob = Convert.ToInt32(txt_ladob.Text);
            int ladoc = Convert.ToInt32(txt_ladoc.Text);

            double semiperimetro = (ladoa + ladob + ladoc) / 2.0;

            txt_semiperimetro.Text = semiperimetro.ToString();
        }

        private void btn_area_Click(object sender, EventArgs e)
        {
            int ladoa = Convert.ToInt32(txt_ladoa.Text);
            int ladob = Convert.ToInt32(txt_ladob.Text);
            int ladoc = Convert.ToInt32(txt_ladoc.Text);
            double semiperimetro = (ladoa + ladob + ladoc) / 2.0;

            double area = Math.Sqrt(semiperimetro * (semiperimetro - ladoa) * (semiperimetro - ladob) * (semiperimetro - ladoc));

            txt_area.Text = area.ToString();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_area.Clear();
            txt_ladoa.Clear();
            txt_ladob.Clear();
            txt_ladoc.Clear();
            txt_semiperimetro.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
