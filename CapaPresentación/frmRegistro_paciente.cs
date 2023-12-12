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
                // Restricción para el DNI: debe ser solo números y 8 caracteres
                if (!System.Text.RegularExpressions.Regex.IsMatch(txt_DNI_paciente.Text, @"^\d{8}$"))
                {
                    MessageBox.Show("El DNI debe contener solo 8 dígitos numéricos.");
                    return; // Detiene la ejecución si el DNI no cumple con la restricción
                }

                // Restricción para nombre y apellido: solo letras
                if (!System.Text.RegularExpressions.Regex.IsMatch(txt_nombre_paciente.Text, @"^[A-Za-zÁÉÍÓÚáéíóúÑñ\s]+$") ||
                    !System.Text.RegularExpressions.Regex.IsMatch(txt_apellido_paciente.Text, @"^[A-Za-zÁÉÍÓÚáéíóúÑñ\s]+$"))
                {
                    MessageBox.Show("El nombre y apellido deben contener solo letras.");
                    return; // Detiene la ejecución si nombre o apellido no cumplen con la restricción
                }

                // Restricción para el número de teléfono: no admite letras y deben ser 10 caracteres
                if (!System.Text.RegularExpressions.Regex.IsMatch(txt_telefono_paciente.Text, @"^\d{10}$"))
                {
                    MessageBox.Show("El número de teléfono debe contener solo 10 dígitos numéricos.");
                    return; // Detiene la ejecución si el teléfono no cumple con la restricción
                }

                Paciente paciente = new Paciente();

                paciente.dni_paciente = Convert.ToInt32(txt_DNI_paciente.Text);
                paciente.nombre_paciente = txt_nombre_paciente.Text;
                paciente.apellido_paciente = txt_apellido_paciente.Text;
                paciente.fecha_nacimiento_paciente = fechaNacimientoPaciente.Value;
                paciente.genero_paciente = (int)genero_paciente.SelectedValue;
                paciente.ciudad_paciente = (int)ciudad_paciente.SelectedValue;
                paciente.telefono_paciente = txt_telefono_paciente.Text;
                paciente.email_paciente = txt_email_paciente.Text;

                servicio_paciente.InsertarPaciente(paciente);
                MessageBox.Show("Registro guardado correctamente.");
                this.pacienteTableAdapter2.Fill(this.sistema_odontologiaDataSet5.paciente);
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

        private void iconButton1_Click(object sender, EventArgs e)
        {

            string apellidoABuscar = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(apellidoABuscar) && apellidoABuscar.Length >= 2) // Cambiado a al menos 2 caracteres para buscar un apellido
            {
                // Filtra el BindingSource por el campo 'apellido_paciente'
                ((BindingSource)datos_paciente.DataSource).Filter = "Apellido LIKE '%" + apellidoABuscar + "%'";

                if (((BindingSource)datos_paciente.DataSource).Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados para el apellido ingresado.");
                    ((BindingSource)datos_paciente.DataSource).RemoveFilter();
                    datos_paciente.DataSource = null;
                    this.pacienteTableAdapter2.Fill(this.sistema_odontologiaDataSet5.paciente);
                    datos_paciente.DataSource = originalBindingSource;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese al menos 2 caracteres para buscar un apellido.");
                ((BindingSource)datos_paciente.DataSource).RemoveFilter();
                datos_paciente.DataSource = null;
                this.pacienteTableAdapter2.Fill(this.sistema_odontologiaDataSet5.paciente);
                datos_paciente.DataSource = originalBindingSource;
            }

        }
    }
}
