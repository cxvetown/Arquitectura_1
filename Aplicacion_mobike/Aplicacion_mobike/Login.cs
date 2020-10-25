﻿using System;
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
            login();
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
        public void login()
        {
            using (SqlConnection conn = new SqlConnection(Conexion.connectionstring))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT rut, contraseña FROM usuario WHERE rut ='" + rut_txt.Text + "' AND contraseña ='" + contraseña_txt.Text + "'", conn);

                    SqlDataReader dr = command.ExecuteReader();

                    if (dr.Read())
                    {
                        MessageBox.Show("Login exitoso");
                        Menu_usuario usu = new Menu_usuario();
                        usu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error en los datos");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }
            }

        }
    }
}
