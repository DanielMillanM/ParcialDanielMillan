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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var User = "daniel";
            var admn = "felipe";
            var contrauser = "0209";
            var contradmn = "2003";
            if (usuario.Text == User && contraseña.Text==contrauser)
            {
                Ventas newtrabajo  = new Ventas();
                newtrabajo.Show(this);
                
            }
            if (usuario.Text==admn && contraseña.Text==contradmn)
            {
                Admin newadmin = new Admin();
                newadmin.Show(this);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
