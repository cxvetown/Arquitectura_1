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
    public partial class testbd : Form
    {
        public testbd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test_bd_txt.Text = Biblioteca.Conexion.test().ToString();
        }
    }
}
