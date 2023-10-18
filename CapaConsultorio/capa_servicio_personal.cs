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

    public class PersonalService
    {
        private Capa_datos_personal usuarioNegocio = new Capa_datos_personal();

        public List<Personal> ListarEmpleadosTipo1()
        {
            // Aquí puedes realizar lógica adicional antes de llamar a la capa de negocios si es necesario.
            return usuarioNegocio.ListarEmpleadosTipo1();
        }
    }

    public class HorarioNegocio
    {
        private Capa_datos_personal capaDatos;

        public HorarioNegocio()
        {
            capaDatos = new Capa_datos_personal();
        }

        public List<Personal> ObtenerHorarios(int dniUsuario)
        {
            try
            {
                // Obtener los horarios desde la capa de datos
                List<Personal> horariosPersonal = capaDatos.ListaDehorariosPersonal(new Personal { dni_personal = dniUsuario });

                // Convertir los resultados a una lista de objetos Horario
                List<Personal> listaHorarios = new List<Personal>();

                foreach (Personal personal in horariosPersonal)
                {
                    listaHorarios.Add(new Personal
                    {
                        horario_inicio = personal.horario_inicio,
                        horario_fin = personal.horario_fin
                    });
                }

                return listaHorarios;
            }
            catch (Exception)
            {
                // Manejar excepciones aquí, si es necesario.
                throw;
            }
        }
    }



}
