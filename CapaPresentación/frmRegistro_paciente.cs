using CapaConsultorio;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación
{
    public partial class frmRegistro_paciente : Form
    {
        public CS_registro_paciente servicio_paciente = new CS_registro_paciente();
        private BindingSource originalBindingSource;


        public frmRegistro_paciente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistro_paciente_Load(object sender, EventArgs e)
        {
            this.pacienteTableAdapter2.Fill(this.sistema_odontologiaDataSet5.paciente);
            originalBindingSource = (BindingSource)datos_paciente.DataSource;


            var provinciasArgentina = new[]
            {
                new { Display = "Buenos Aires", Value = 1 },
                new { Display = "Córdoba", Value = 2 },
                new { Display = "Santa Fe", Value = 3 },
                new { Display = "Mendoza", Value = 4 },
                new { Display = "Tucumán", Value = 5 },
                new { Display = "Entre Ríos", Value = 6 },
                new { Display = "Salta", Value = 7 },
                new { Display = "Chaco", Value = 8 },
                new { Display = "Corrientes", Value = 9 },
                new { Display = "Santiago del Estero", Value = 10 },
                new { Display = "San Juan", Value = 11 },
                new { Display = "Jujuy", Value = 12 },
                new { Display = "Río Negro", Value = 13 },
                new { Display = "Neuquén", Value = 14 },
                new { Display = "Formosa", Value = 15 },
                new { Display = "Chubut", Value = 16 },
                new { Display = "San Luis", Value = 17 },
                new { Display = "La Pampa", Value = 18 },
                new { Display = "La Rioja", Value = 19 },
                new { Display = "Catamarca", Value = 20 },
                new { Display = "Santa Cruz", Value = 21 },
                new { Display = "Tierra del Fuego", Value = 22 }
            };

            ciudad_paciente.DataSource = provinciasArgentina;
            ciudad_paciente.DisplayMember = "Display";
            ciudad_paciente.ValueMember = "Value";

            var items_genero = new[]
{
                new { Display = "Másculino", Value = 1 },
                new { Display = "Femenino", Value = 2 },
            };

            genero_paciente.DataSource = items_genero;
            genero_paciente.DisplayMember = "Display";
            genero_paciente.ValueMember = "Value";
        }

        private void boton_registrar_paciente_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente paciente = new Paciente();

                // Validación del DNI (obligatorio y máximo 8 caracteres)
                if (string.IsNullOrEmpty(txt_DNI_paciente.Text) || txt_DNI_paciente.Text.Length > 8)
                {
                    MessageBox.Show("Por favor, ingrese un DNI válido (máximo 8 caracteres).", "Error al ingresar DNI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Detener el proceso de registro si la validación falla.
                }

                paciente.dni_paciente = Convert.ToInt32(txt_DNI_paciente.Text);

                // Validación del nombre (obligatorio y máximo 20 caracteres)
                if (string.IsNullOrEmpty(txt_nombre_paciente.Text) || txt_nombre_paciente.Text.Length > 20)
                {
                    MessageBox.Show("Por favor, ingrese un nombre válido (máximo 20 caracteres).", "Error al ingresar nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                paciente.nombre_paciente = txt_nombre_paciente.Text;

                // Validación del apellido (obligatorio y máximo 20 caracteres)
                if (string.IsNullOrEmpty(txt_apellido_paciente.Text) || txt_apellido_paciente.Text.Length > 20)
                {
                    MessageBox.Show("Por favor, ingrese un apellido válido (máximo 20 caracteres).", "Error al ingresar apellido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                paciente.apellido_paciente = txt_apellido_paciente.Text;

                // Validar si ya existe un paciente con el mismo DNI
                if (servicio_paciente.ValidarDNIPaciente(paciente))
                {
                    MessageBox.Show("Ya existe un paciente con el mismo DNI.", "Error al ingresar DNI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                paciente.fecha_nacimiento_paciente = fechaNacimientoPaciente.Value;
                paciente.genero_paciente = (int)genero_paciente.SelectedValue;
                paciente.ciudad_paciente = (int)ciudad_paciente.SelectedValue;

                if (!string.IsNullOrEmpty(txt_telefono_paciente.Text))
                {
                    // Validación del número de teléfono (máximo 10 caracteres)
                    if (txt_telefono_paciente.Text.Length > 10)
                    {
                        MessageBox.Show("El número de teléfono no puede tener más de 10 caracteres.", "Error al ingresar teléfono", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    paciente.telefono_paciente = Convert.ToInt32(txt_telefono_paciente.Text);
                }

                // Validación del correo electrónico (si se proporciona)
                if (!string.IsNullOrEmpty(txt_email_paciente.Text))
                {
                    if (!EsCorreoElectronicoValido(txt_email_paciente.Text))
                    {
                        MessageBox.Show("Por favor, ingrese una dirección de correo electrónico válida.", "Error al ingresar email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                paciente.email_paciente = txt_email_paciente.Text;

                servicio_paciente.InsertarPaciente(paciente);
                MessageBox.Show("Registro guardado correctamente.");
                // Llenar el DataSet con datos actualizados desde la base de datos
                this.pacienteTableAdapter2.Fill(this.sistema_odontologiaDataSet5.paciente);

                // Actualizar el DataGridView
                this.datos_paciente.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el registro: " + ex.Message);
            }
        }


        private bool EsCorreoElectronicoValido(string email)
        {
            // Utiliza una expresión regular o una biblioteca de validación de correo electrónico
            // para una validación más rigurosa si es necesario.
            // Aquí se realiza una validación básica.
            return Regex.IsMatch(email, @"^\S+@\S+\.\S+$");
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buscarpaciente_Click(object sender, EventArgs e)
        {

            string claveprimaria = txt_buscarPaciente.Text.Trim();

            if (!string.IsNullOrEmpty(claveprimaria) && claveprimaria.Length >= 8)
            {

                // Filtra el BindingSource
                ((BindingSource)datos_paciente.DataSource).Filter = "DNI = '" + claveprimaria + "'";


                if (((BindingSource)datos_paciente.DataSource).Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados de pacientes");
                    ((BindingSource)datos_paciente.DataSource).RemoveFilter();
                    datos_paciente.DataSource = null;
                    this.pacienteTableAdapter2.Fill(this.sistema_odontologiaDataSet5.paciente);
                    datos_paciente.DataSource = originalBindingSource;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese al menos 8 caracteres para buscar un DNI.");
                ((BindingSource)datos_paciente.DataSource).RemoveFilter();
                datos_paciente.DataSource = null;
                this.pacienteTableAdapter2.Fill(this.sistema_odontologiaDataSet5.paciente);
                datos_paciente.DataSource = originalBindingSource;
            }
        }

        public void recargardataviewgrid()
        {
            this.pacienteTableAdapter2.Fill(this.sistema_odontologiaDataSet5.paciente);

            datos_paciente.Refresh();

        }
    }
}
