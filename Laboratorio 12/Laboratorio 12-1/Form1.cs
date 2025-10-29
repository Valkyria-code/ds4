using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_12_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_promedio_Click(object sender, EventArgs e)
        {
            int nota1 = Convert.ToInt32(txt_nota1.Text);
            int nota2 = Convert.ToInt32(txt_nota2.Text);
            int nota3 = Convert.ToInt32(txt_nota3.Text);

            int promedio = (nota1 + nota2 + nota3) / 3;

            txt_promedio.Text = promedio.ToString();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_nota1.Clear();
            txt_nota2.Clear();
            txt_nota3.Clear();
            txt_promedio.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
