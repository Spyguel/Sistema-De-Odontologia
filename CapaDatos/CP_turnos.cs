using CapaEntidad;
using System;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CP_turnos
    {
        public bool TurnoExiste(Turnos turnos)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                conexion.Open();
                string consultaExiste = "SELECT COUNT(*) FROM turnos WHERE personalID = @personalID AND Fecha = @fecha AND Hora = @hora";
                using (SqlCommand comandoExiste = new SqlCommand(consultaExiste, conexion))
                {
                    comandoExiste.Parameters.AddWithValue("@personalID", turnos.personalID);
                    comandoExiste.Parameters.AddWithValue("@hora", turnos.hora);
                    comandoExiste.Parameters.AddWithValue("@fecha", turnos.fecha.Date); // Usamos .Date para ignorar la parte de tiempo

                    int count = (int)comandoExiste.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public void InsertarTurno(Turnos turnos)
        {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string consultaTabla1 = "INSERT INTO [turnos](pacienteID, personalID, Observaciones, Fecha, Hora) VALUES (@pacienteID, @personalID, @Observaciones, @Fecha, @Hora)";
                    using (SqlCommand comandoTabla1 = new SqlCommand(consultaTabla1, conexion))
                    {
                        comandoTabla1.Parameters.AddWithValue("@pacienteID", turnos.pacienteID);
                        comandoTabla1.Parameters.AddWithValue("@personalID", turnos.personalID);
                        comandoTabla1.Parameters.AddWithValue("@Observaciones", turnos.Observaciones);
                        comandoTabla1.Parameters.AddWithValue("@Fecha", turnos.fecha);
                        comandoTabla1.Parameters.AddWithValue("@Hora", turnos.hora);
                        comandoTabla1.ExecuteNonQuery();
                    }
                }
        }
    }
}
