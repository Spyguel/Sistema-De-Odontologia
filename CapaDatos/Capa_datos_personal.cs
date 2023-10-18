using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class Capa_datos_personal
    {
        public List<Personal> Listar()
        {
            List<Personal> lista = new List<Personal>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select DNI, ID_categoria, Nombre, Apellido, Genero, Fecha_nacimiento, Email, Contraseña from personal";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;
                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Personal {
                                dni_personal = Convert.ToInt32(dr["DNI"]),
                                oID_categoria = new categoría() {id_categoria = Convert.ToInt32(dr["ID_categoria"])},
                                nombre_personal = dr["Nombre"].ToString(),
                                apellido_personal = dr["Apellido"].ToString(),
                                oID_genero = new Genero() { genero_ID = Convert.ToInt32(dr["Genero"])},
                                fecha_nacimiento_personal = dr["Fecha_nacimiento"].ToString(),
                                email_personal = dr["Email"].ToString(),
                                contrasena_personal = dr["Contraseña"].ToString()

                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<Personal>();
                }
            }
            return lista;
        }
    }
}
