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

                // Validar el DNI debe tener exactamente 8 caracteres
                if (txtDNIpersonal.Text.Length != 8)
                {
                    MessageBox.Show("El DNI debe tener 8 caracteres.");
                    return; // Detener la ejecución del método si la restricción no se cumple
                }

                personal.dni_personal = Convert.ToInt32(txtDNIpersonal.Text);
                personal.telefono_personal = txtTelefonoPersonal.Text;

                // Validar que el número de teléfono tenga exactamente 10 dígitos
                if (txtTelefonoPersonal.Text.Length != 10)
                {
                    MessageBox.Show("El número de teléfono debe tener 10 dígitos.");
                    return; // Detener la ejecución del método si la restricción no se cumple
                }

                personal.direccion_personal = txtDireccionPersonal.Text;

                // Validar el formato del correo electrónico
                if (!EsFormatoEmailValido(txtEmailPersonal.Text))
                {
                    MessageBox.Show("El formato del correo electrónico no es válido.");
                    return; // Detener la ejecución del método si la restricción no se cumple
                }

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

        // Función para validar el formato del correo electrónico
        private bool EsFormatoEmailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
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

        private void txtDireccionPersonal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
