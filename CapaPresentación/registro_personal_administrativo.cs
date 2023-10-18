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
    public partial class registro_personal_administrativo : Form
    {
        public CS_registro_personal_administrativo servicio_personal = new CS_registro_personal_administrativo();
        public registro_personal_administrativo()
        {
            InitializeComponent();
        }

        public void boton_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                Personal personal = new Personal();
                personal.idTipoPersonal = 2;
                personal.nombre_personal = txtNombrePersonal.Text;
                personal.apellido_personal = txtApellidoPersonal.Text;
                personal.oID_genero = (int)selGenero.SelectedValue;
                personal.fecha_nacimiento_personal = fechaNacimientoPersonal.Value;
                personal.dni_personal = Convert.ToInt32(txtDNIpersonal.Text);
                personal.telefono_personal = Convert.ToInt32(txtTelefonoPersonal.Text);
                personal.direccion_personal = txtDireccionPersonal.Text;
                personal.email_personal = txtEmailPersonal.Text;
                personal.contrasena_personal = txtContrasenaPersonal.Text;

                servicio_personal.InsertarPersonal_admin(personal);
                MessageBox.Show("Registro guardado correctamente.");



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el registro: " + ex.Message);

            }
        }

        private void registro_personal_administrativo_Load(object sender, EventArgs e)
        {
            var items_genero = new[]
{
                new { Display = "Másculino", Value = 1 },
                new { Display = "Femenino", Value = 2 },

            };
            selGenero.DataSource = items_genero;
            selGenero.DisplayMember = "Display";
            selGenero.ValueMember = "Value";
        }
    }
}
