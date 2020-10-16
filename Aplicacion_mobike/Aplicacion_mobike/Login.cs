using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_mobike
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contraseña_txt.UseSystemPasswordChar = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registrarse reg = new Registrarse();
            reg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu_usuario usu = new Menu_usuario();
            usu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Selector_administracion sel = new Selector_administracion();
            sel.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            testbd bd = new testbd();
            bd.Show();
        }
    }
}
