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
                    string query = "select DNI, Tipo, Nombre, Apellido, Genero, Fecha_nacimiento, Email, Contrasena from personal";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;
                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Personal {
                                dni_personal = Convert.ToInt32(dr["DNI"]),
                                idTipoPersonal = Convert.ToInt32(dr["Tipo"]),
                                nombre_personal = dr["Nombre"].ToString(),
                                apellido_personal = dr["Apellido"].ToString(),
                                oID_genero = Convert.ToInt32(dr["Genero"]),
                                fecha_nacimiento_personal = Convert.ToDateTime(dr["Fecha_nacimiento"]),
                                email_personal = dr["Email"].ToString(),
                                contrasena_personal = dr["Contrasena"].ToString()

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

        public List<Personal> ListarEmpleadosTipo1()
        {
            List<Personal> lista = new List<Personal>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT DNI, Nombre FROM Personal WHERE Tipo = 1";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;
                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Personal
                            {
                                dni_personal = Convert.ToInt32(dr["DNI"]),
                                nombre_personal = dr["Nombre"].ToString()
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

        public List<Personal> ListaDehorariosPersonal(Personal personal)
        {
            List<Personal> listahorarios = new List<Personal>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT horario_inicio, horario_fin FROM personal WHERE DNI = @DNI";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@DNI", personal.dni_personal);
                    conexion.Open ();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    { while (dr.Read())
                        {
                            TimeSpan inicio = dr.GetTimeSpan(0);
                            TimeSpan fin = dr.GetTimeSpan(1);

                            while (inicio < fin)
                            {
                                listahorarios.Add(new Personal
                                {
                                    horario_inicio = inicio,
                                    horario_fin = inicio.Add(new TimeSpan(0,30,0))

                                });

                                inicio = inicio.Add(new TimeSpan(0, 30, 0));
                            }

                        }

                        
                    }
                }
                catch(Exception)
                {
                    listahorarios = new List<Personal>();
                }
            }
            return listahorarios;
        }
    }


}
