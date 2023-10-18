using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CP_registro_paciente
    {
        public void InsertarPaciente(Paciente paciente)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                conexion.Open();
                String consultaTabla1 = "INSERT INTO [paciente](DNI, Nombre, Apellido, Telefono, Fecha_nacimiento, Genero, Ciudad, EMail) VALUES (@DNI, @Nombre, @Apellido, @Telefono, @Fecha_nacimiento, @Genero, @Ciudad, @EMail)";
                using (SqlCommand comandoTabla1 = new SqlCommand(consultaTabla1, conexion))
                {
                    comandoTabla1.Parameters.AddWithValue("@DNI", paciente.dni_paciente);
                    comandoTabla1.Parameters.AddWithValue("@Nombre", paciente.nombre_paciente);
                    comandoTabla1.Parameters.AddWithValue("@Apellido", paciente.apellido_paciente);
                    comandoTabla1.Parameters.AddWithValue("@Telefono", paciente.telefono_paciente);
                    comandoTabla1.Parameters.AddWithValue("@Fecha_nacimiento", paciente.fecha_nacimiento_paciente);
                    comandoTabla1.Parameters.AddWithValue("@Genero", paciente.genero_paciente);
                    comandoTabla1.Parameters.AddWithValue("@Ciudad", paciente.ciudad_paciente);
                    comandoTabla1.Parameters.AddWithValue("@Email", paciente.email_paciente);
                    comandoTabla1.ExecuteNonQuery();
                }
            }
        }

        public bool validarDNIPaciente(Paciente paciente)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                conexion.Open();
                string consulta = "SELECT COUNT (*) FROM paciente WHERE DNI = @DNI";

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@DNI", paciente.dni_paciente);
                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }

            }
        }
    }

}
