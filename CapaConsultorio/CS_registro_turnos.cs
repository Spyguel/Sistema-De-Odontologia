using CapaDatos;
using CapaEntidad;
using System;

namespace CapaServicio
{
    public class TurnosService
    {
        private CP_turnos turnosData = new CP_turnos();

        //public event Action<string> OnTurnoInsertado; // Evento para notificar inserción exitosa
        //public event Action<string> OnErrorTurnoInsertado; // Evento para notificar error

        public bool InsertarTurno(Turnos turno)
        {
            if (!turnosData.TurnoExiste(turno))
            {
                turnosData.InsertarTurno(turno);
                return true; // Inserción exitosa
            }
            else
            {
                return false;
            }
        }
    }
}
