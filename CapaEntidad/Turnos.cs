using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class Turnos
    {
        public int turnoID { get; set; }
        public Paciente pacienteID { get; set; }
        public Dias diaID { get; set; }
        public bool estado_turno { get; set; }
        public string observaciones_turno { get; set; }

    }
}
