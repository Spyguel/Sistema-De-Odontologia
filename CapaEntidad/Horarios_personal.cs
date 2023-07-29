using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class Horarios_personal
    {
        public int id_horarios { get; set; }
        public Dias diaID { get; set; }
        public Personal dni_personal { get; set; }

        public TimeSpan horario_inicio { get; set; }

        public TimeSpan horario_fin { get; set; }
    }
}
