using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Personal
    {
        public int dni_personal { get; set; }
        public string nombre_personal { get; set; }
        public string apellido_personal { get; set; }
        public string fecha_nacimiento_personal { get; set; }
        public Genero oID_genero { get; set; }
        public string direccion_personal { get; set; }
        public int telefono_personal { get; set; }
        public string email_personal { get; set; }
        public string contrasena_personal { get; set; }


    }
}
