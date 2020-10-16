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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
            comboBox1.Items.Add("Si");
            comboBox1.Items.Add("No");
            nombre_txt.MaxLength = 50;
            mail_txt.MaxLength = 60;
            Rut_txt.MaxLength = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pass_register_txt.UseSystemPasswordChar = false;
        }

        private void Rut_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario creado con exito", "Registrarse", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cuenta_bancaria_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
