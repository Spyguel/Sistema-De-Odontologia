using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CP_registro_personal
    {
        public void InsertarPersonal (Personal personal)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                conexion.Open();
                String consultaTabla1 = "INSERT INTO [personal] (DNI, Tipo, Especialidad, Nombre, Apellido, Fecha_nacimiento, Genero, Direccion, Telefono, Email, Contrasena, horario_inicio, horario_fin) VALUES (@DNI, @Tipo, @Especialidad, @Nombre, @Apellido, @Fecha_nacimiento, @Genero, @Direccion, @Telefono, @Email, @Contrasena, @horario_inicio, @horario_fin)";

                using (SqlCommand comandoTabla1 = new SqlCommand(consultaTabla1, conexion))
                {
                    comandoTabla1.Parameters.AddWithValue("@DNI", personal.dni_personal);
                    comandoTabla1.Parameters.AddWithValue("@Tipo", personal.idTipoPersonal);
                    comandoTabla1.Parameters.AddWithValue("@Especialidad", personal.oID_especialidad);
                    comandoTabla1.Parameters.AddWithValue("@Nombre", personal.nombre_personal);
                    comandoTabla1.Parameters.AddWithValue("@Apellido", personal.apellido_personal);
                    comandoTabla1.Parameters.AddWithValue("@Fecha_nacimiento", personal.fecha_nacimiento_personal);
                    comandoTabla1.Parameters.AddWithValue("@Genero", personal.oID_genero);
                    comandoTabla1.Parameters.AddWithValue("@Direccion", personal.direccion_personal);
                    comandoTabla1.Parameters.AddWithValue("@Telefono", personal.telefono_personal);
                    comandoTabla1.Parameters.AddWithValue("@Email", personal.email_personal);
                    comandoTabla1.Parameters.AddWithValue("@Contrasena", personal.contrasena_personal);
                    comandoTabla1.Parameters.AddWithValue("@horario_inicio", personal.horario_inicio);
                    comandoTabla1.Parameters.AddWithValue("@horario_fin", personal.horario_fin);

                    comandoTabla1.ExecuteNonQuery();


                }
            }

        }
    }
}
