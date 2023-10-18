using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaConsultorio
{
    public class CS_estadistica
    {
        private CP_estadistica estadistica;

        public CS_estadistica()
        {
            estadistica = new CP_estadistica();
        }

        public DataTable GetTurnosEnIntervalo(DateTime fechaInicio, DateTime fechaFin)
        {
            return estadistica.GetTurnosEnIntervalo(fechaInicio, fechaFin);
        }
    }
}
