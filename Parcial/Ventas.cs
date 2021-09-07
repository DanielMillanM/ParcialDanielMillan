using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void aliñado_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ali = Convert.ToDouble(textBox1.Text);
            double noali = Convert.ToDouble(textBox2.Text);
            double esp = Convert.ToDouble(textBox3.Text);

            double tot = (ali * 1000) + (noali * 500) + (esp * 2000);

            textBox4.Text = "Total: " + tot.ToString();

            Resultados.Items.Add("Nombre: " + name.Text);
            Resultados.Items.Add("Cédula: " + cedula.Text);
            Resultados.Items.Add("Fecha: " + fecha.Text);
            Resultados.Items.Add("Panes Aliñados: " + textBox1.Text);
            Resultados.Items.Add("Panes no Aliñados: " + textBox2.Text);
            Resultados.Items.Add("Panes Especiales: " + textBox3.Text + "\r\n");
            Resultados.Items.Add(textBox4.Text + "\r\n");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
           

        }
    }
}
