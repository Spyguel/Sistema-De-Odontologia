using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaConsultorio
{
    public class CS_ActualizarPaciente
    {
        private CapaDatos.ActualizarPaciente _actualizarPaciente;

        public CS_ActualizarPaciente()
        {
            _actualizarPaciente = new CapaDatos.ActualizarPaciente();
        }

        public bool ActualizarDatosPaciente(Paciente paciente)
        {
            return _actualizarPaciente.Actualizarpaciente(paciente);
        }
    }
}
