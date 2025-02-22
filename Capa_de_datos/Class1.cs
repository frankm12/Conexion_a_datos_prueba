using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Capa_de_datos
{
    public class Class1
    {
        private string connectionString = "Server=.; Database = Prueba_con_ramon; Integrated Security =true";

        public void InsertarPersona(string nombre, string apellido)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Nombre (Nombre, Apellido) VALUES (@Nombre, @Apellido)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellido", apellido);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al insertar persona: " + ex.Message);
                }
            }
        }
    }
}
