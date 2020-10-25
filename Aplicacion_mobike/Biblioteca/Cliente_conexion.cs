using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Mobike_data;


namespace Biblioteca
{
    public class Cliente_conexion
    {
        public static int InsertarSQL(Cliente newcliente)
        {
            Int32 rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(Conexion.connectionstring))
            {
                SqlCommand command = new SqlCommand(null, conn);

                command.CommandText = "INSERT INTO usuario (rut, nombre, email, direccion, trabaja_comuna, cuenta_bancaria, contraseña)" +
                    "VALUES (@rut_cli, @nombre, @email, @direccion, @trabaja, @cuenta_bancaria, @contraseña)";
                command.Parameters.AddWithValue("@rut_cli", newcliente.Rut_cliente);
                command.Parameters.AddWithValue("@nombre", newcliente.Nombre_cliente);
                command.Parameters.AddWithValue("@email", newcliente.Email_cliente);
                command.Parameters.AddWithValue("@direccion", newcliente.Direccion_cliente);
                command.Parameters.AddWithValue("@trabaja", newcliente.Trabaja_comuna);
                command.Parameters.AddWithValue("@cuenta_bancaria", newcliente.cuenta_bancaria);
                command.Parameters.AddWithValue("@contraseña", newcliente.Contraseña_cliente);

                try
                {
                    conn.Open();
                    rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"rowsaffected: {rowsAffected}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(">>>Error en Cliente_Conexion/Insertar\n" + ex.Message);
                }

            }
            return rowsAffected;
        }
    }
}
