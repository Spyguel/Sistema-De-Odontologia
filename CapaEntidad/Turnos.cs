using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Turnos
    {
        public int turnoID { get; set; }
        public int pacienteID { get; set; }
        public int personalID { get; set; }
        public bool estado { get; set; }
        public string Observaciones { get; set; }
        public DateTime fecha { get; set; }
        public TimeSpan hora { get; set; }

    }
}
