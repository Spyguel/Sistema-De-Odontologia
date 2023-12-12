using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Paciente
    {
        public int dni_paciente { get; set; }

        public string nombre_paciente { get; set; }

        public string apellido_paciente { get; set; }

        public string telefono_paciente { get; set; }

        public DateTime fecha_nacimiento_paciente { get; set; }

        public int ciudad_paciente { get; set; }

        public string convenio_paciente { get; set; }

        public string email_paciente { get; set; }

        public int genero_paciente { get; set; }
    }
}
