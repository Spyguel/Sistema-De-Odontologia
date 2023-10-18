using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaConsultorio
{
    public class CS_registro_personal
    {
        private CP_registro_personal capaDatos = new CP_registro_personal();

        public void InsertarPersonal(Personal personal)
        {
            capaDatos.InsertarPersonal(personal);
        }
    }

}
