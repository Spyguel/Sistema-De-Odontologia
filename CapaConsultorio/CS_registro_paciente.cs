using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaConsultorio
{
    public class CS_registro_paciente
    {
        private CP_registro_paciente capaDatos = new CP_registro_paciente();
        public void InsertarPaciente(Paciente paciente)
        {
            capaDatos.InsertarPaciente(paciente);
        }

        private CP_registro_paciente pacienteDAL;

        public bool ValidarDNIPaciente(Paciente paciente)
        {
            try
            {
                return capaDatos.validarDNIPaciente(paciente);
            }
            catch (Exception)
            {
                // Manejo de excepciones
                return false;
            }
        }

    }
}
