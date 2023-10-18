using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaConsultorio
{
    public class CS_registro_personal_administrativo
    {
        private CP_registro_personal_administrativo capaDeDatos = new CP_registro_personal_administrativo();

        public void InsertarPersonal_admin(Personal personal)
        {
            capaDeDatos.InsertarPersonal(personal);
        }
    }

}
