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
    public partial class login_admin : Form
    {
        public login_admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void login()
        {
            using (SqlConnection conn = new SqlConnection(Conexion.connectionstring))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT rut, contraseña FROM administrador WHERE rut ='" + rut_txt.Text + "' AND contraseña ='" + pass_txt.Text + "'", conn);

                    SqlDataReader dr = command.ExecuteReader();

                    if (dr.Read())
                    {
                        MessageBox.Show("Login exitoso");
                        Administrador ad = new Administrador();
                        this.Close();
                        ad.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (pass_txt.PasswordChar == '*')
            {
                pass_txt.PasswordChar = '\0';
            }
            else
            {
                pass_txt.PasswordChar = '*';
            }
        }
    }
}
