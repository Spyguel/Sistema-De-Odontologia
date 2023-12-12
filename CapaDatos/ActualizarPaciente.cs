using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ActualizarPaciente
    {
        public bool Actualizarpaciente(Paciente paciente)
        {
            bool actualizacionExitosa = false;
            string query = "UPDATE paciente SET Telefono = @Telefono, Email = @Email WHERE DNI = @DNI";

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Telefono", paciente.telefono_paciente);
                    command.Parameters.AddWithValue("@Email", paciente.email_paciente);
                    command.Parameters.AddWithValue("@DNI", paciente.dni_paciente);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    actualizacionExitosa = rowsAffected > 0;
                }
            }

            return actualizacionExitosa;
        }

    }
}
