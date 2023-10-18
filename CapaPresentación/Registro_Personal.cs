using CapaConsultorio;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación
{
    public partial class Registro_Personal : Form
    {

        public CS_registro_personal servicio_Personal = new CS_registro_personal();
        public Registro_Personal()
        {
            InitializeComponent();
        }

        public void boton_registrar_Click(object sender, EventArgs e)
        {

            try
            {
                Personal personal = new Personal();
                personal.idTipoPersonal = 1;
                personal.nombre_personal = txtNombrePersonal.Text;
                personal.apellido_personal = txtApellidoPersonal.Text;
                personal.oID_genero = (int)selGenero.SelectedValue;
                personal.fecha_nacimiento_personal = fechaNacimientoPersonal.Value;
                personal.dni_personal = Convert.ToInt32(txtDNIpersonal.Text);
                personal.telefono_personal = Convert.ToInt32(txtTelefonoPersonal.Text);
                personal.direccion_personal = txtDireccionPersonal.Text;
                personal.email_personal = txtEmailPersonal.Text;
                personal.oID_especialidad = (int)selEspecialidad.SelectedValue;
                personal.contrasena_personal = txtContrasenaPersonal.Text;
                personal.horario_inicio = (TimeSpan)horario_inicio.SelectedItem;
                personal.horario_fin = (TimeSpan)horario_fin.SelectedItem;


                servicio_Personal.InsertarPersonal(personal);
                MessageBox.Show("Registro guardado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el registro: " + ex.Message);
            }
        }

        private void Registro_Personal_Load(object sender, EventArgs e)
        {

            var items_genero = new[]
            {
                new { Display = "Másculino", Value = 1 },
                new { Display = "Femenino", Value = 2 },
            };

            selGenero.DataSource = items_genero;
            selGenero.DisplayMember = "Display";
            selGenero.ValueMember = "Value";

            var items_especialidad = new[]
            {
                new { Display = "Ortodoncia", Value = 1 },
                new { Display = "Endodoncia", Value = 2 },
                new { Display = "Cirugía Oral", Value = 3},
            };

            selEspecialidad.DataSource = items_especialidad;
            selEspecialidad.DisplayMember = "Display";
            selEspecialidad.ValueMember = "Value";

            int valorNoVisible = 0;
            selEspecialidad.SelectedValue = valorNoVisible;

            List<TimeSpan> horarios_inicio_personal = new List<TimeSpan>()
            {
                    TimeSpan.Parse("08:00:00"),
                    TimeSpan.Parse("09:00:00"),
                    TimeSpan.Parse("11:00:00"),
                    TimeSpan.Parse("12:00:00"),
                    TimeSpan.Parse("13:00:00"),
                    TimeSpan.Parse("14:00:00"),
                    TimeSpan.Parse("15:00:00"),
                    TimeSpan.Parse("16:00:00"),
                    TimeSpan.Parse("17:00:00"),
                    TimeSpan.Parse("18:00:00"),
                    TimeSpan.Parse("19:00:00"),
                    TimeSpan.Parse("20:00:00"),
            };

            List<TimeSpan> horarios_fin_personal = new List<TimeSpan>()
            {
                    TimeSpan.Parse("08:00:00"),
                    TimeSpan.Parse("09:00:00"),
                    TimeSpan.Parse("11:00:00"),
                    TimeSpan.Parse("12:00:00"),
                    TimeSpan.Parse("13:00:00"),
                    TimeSpan.Parse("14:00:00"),
                    TimeSpan.Parse("15:00:00"),
                    TimeSpan.Parse("16:00:00"),
                    TimeSpan.Parse("17:00:00"),
                    TimeSpan.Parse("18:00:00"),
                    TimeSpan.Parse("19:00:00"),
                    TimeSpan.Parse("20:00:00"),
            };


            horario_inicio.DataSource = horarios_inicio_personal;
            horario_fin.DataSource = horarios_fin_personal;
            horario_inicio.DisplayMember = "CustomFormat";
            horario_inicio.FormatString = "HH:mm";

        }

        private void selGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

