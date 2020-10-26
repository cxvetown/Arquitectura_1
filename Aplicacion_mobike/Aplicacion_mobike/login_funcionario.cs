using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Biblioteca;

namespace Aplicacion_mobike
{
    public partial class login_funcionario : Form
    {
        public login_funcionario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        public void login()
        {
            using (SqlConnection conn = new SqlConnection(Conexion.connectionstring))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT rut, contraseña FROM funcionario WHERE rut ='" + funcionario_rut_txt.Text + "' AND contraseña ='" + funcionario_pass_txt.Text + "'", conn);

                    SqlDataReader dr = command.ExecuteReader();

                    if (dr.Read())
                    {
                        MessageBox.Show("Login exitoso");
                        Funcionario fun = new Funcionario();
                        fun.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error en los datos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }
            }

        }
    }
}
