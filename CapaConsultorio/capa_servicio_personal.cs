using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaConsultorio
{
    public class capa_servicio_personal
    {
        private Capa_datos_personal objcd_personal = new Capa_datos_personal();

        public List<Personal> Listar()
        {
            return objcd_personal.Listar();
        }
    }
}
