using CapaConsultorio;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación
{
    public partial class frm_Consulta_de_pacientes : Form
    {
        private BindingSource originalBindingSource;
        private readonly CS_ActualizarPaciente _pacienteService;
        private Paciente _pacienteSeleccionado;
        public frm_Consulta_de_pacientes()
        {
            InitializeComponent();
            //dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
            _pacienteService = new CS_ActualizarPaciente();
            dataGridView1.CellClick += dataGridView1_CellContentClick_1;
            actualizardatos.Click += actualizardatos_Click;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }
        private void frm_Consulta_de_pacientes_Load(object sender, EventArgs e)
        {
            this.pacienteTableAdapter.Fill(this.sistema_odontologiaDataSet7.paciente);
            originalBindingSource = (BindingSource)dataGridView1.DataSource;

        }

       


        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void buscarDNI_Click(object sender, EventArgs e)
        {
            string claveprimaria = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(claveprimaria) && claveprimaria.Length >= 8)
            {

                // Filtra el BindingSource
                ((BindingSource)dataGridView1.DataSource).Filter = "DNI = '" + claveprimaria + "'";


                if (((BindingSource)dataGridView1.DataSource).Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados de pacientes");
                    ((BindingSource)dataGridView1.DataSource).RemoveFilter();
                    dataGridView1.DataSource = null;
                    this.pacienteTableAdapter.Fill(this.sistema_odontologiaDataSet7.paciente);
                    dataGridView1.DataSource = originalBindingSource;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese al menos 8 caracteres para buscar un DNI.");
                ((BindingSource)dataGridView1.DataSource).RemoveFilter();
                dataGridView1.DataSource = null;
                this.pacienteTableAdapter.Fill(this.sistema_odontologiaDataSet7.paciente);
                dataGridView1.DataSource = originalBindingSource;
            }
        }


            /*private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
            {
                DataGridView dgv = (DataGridView)sender;

                // Verifica si la edición fue en una celda válida
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    DialogResult result = MessageBox.Show("¿Deseas guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Guarda los cambios en tu base de datos
                        try
                        {
                            // Obtén el origen de datos (DataSet)
                            sistema_odontologiaDataSet7 dataSet = (sistema_odontologiaDataSet7)((BindingSource)dataGridView1.DataSource).DataSource;

                            // Actualiza cada adaptador de tabla individualmente
                            pacienteTableAdapter.Update(dataSet.paciente);
                            // Actualiza otros adaptadores de tabla aquí según sea necesario

                            // Esto es solo un ejemplo, asegúrate de usar los nombres correctos según tu configuración
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al guardar los cambios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Descarta los cambios hechos en la celda
                        dgv.CancelEdit();
                    }
                }
            }
            */

            private void buscarApellido_Click(object sender, EventArgs e)
        {

            string apellidoABuscar = textBox2.Text.Trim();

            if (!string.IsNullOrEmpty(apellidoABuscar) && apellidoABuscar.Length >= 2) // Cambiado a al menos 2 caracteres para buscar un apellido
            {
                // Filtra el BindingSource por el campo 'apellido_paciente'
                ((BindingSource)dataGridView1.DataSource).Filter = "Apellido LIKE '%" + apellidoABuscar + "%'";

                if (((BindingSource)dataGridView1.DataSource).Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados para el apellido ingresado.");
                    ((BindingSource)dataGridView1.DataSource).RemoveFilter();
                    dataGridView1.DataSource = null;
                    this.pacienteTableAdapter.Fill(this.sistema_odontologiaDataSet7.paciente);
                    dataGridView1.DataSource = originalBindingSource;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese al menos 2 caracteres para buscar un apellido.");
                ((BindingSource)dataGridView1.DataSource).RemoveFilter();
                dataGridView1.DataSource = null;
                this.pacienteTableAdapter.Fill(this.sistema_odontologiaDataSet7.paciente);
                dataGridView1.DataSource = originalBindingSource;
            }

        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void actualizardatos_Click(object sender, EventArgs e)
        {
            string nuevoTelefono = txtTelefono.Text;
            string nuevoEmail = txtEmail.Text;
            int dniPaciente = ObtenerDNIPacienteSeleccionado();
            CapaConsultorio.CS_ActualizarPaciente servicioPaciente = new CapaConsultorio.CS_ActualizarPaciente();

            Paciente paciente = new Paciente();
            paciente.telefono_paciente = nuevoTelefono;
            paciente.email_paciente = nuevoEmail;
            paciente.dni_paciente = dniPaciente;

            bool actualizacionExitosa = servicioPaciente.ActualizarDatosPaciente(paciente);

            if (actualizacionExitosa)
            {
                MessageBox.Show("Los datos del paciente se actualizaron correctamente.");
                // Asignar los nuevos valores solo si la actualización es exitosa
                txtTelefono.Text = nuevoTelefono;
                txtEmail.Text = nuevoEmail;
            }
            else
            {
                MessageBox.Show("Hubo un problema al actualizar los datos del paciente.");
            }
        }



        private int ObtenerDNIPacienteSeleccionado()
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Obtener la fila actualmente seleccionada en el DataGridView
                DataRowView selectedRow = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;

                // Obtener el valor del DNI del paciente de la fila seleccionada en el DataGridView
                // Asumiendo que el campo DNI está en la columna con el nombre "DNI" en el DataSet
                int dni = Convert.ToInt32(selectedRow["DNI"]);
                return dni;
            }
            else
            {
                // Manejo si no hay filas seleccionadas o no se puede obtener el DNI
                // Aquí podrías lanzar una excepción, retornar un valor predeterminado o realizar algún manejo de error
                return 0; // Por ejemplo, se retorna 0 si no se pudo obtener el DNI
            }
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataRowView selectedRow = (DataRowView)dataGridView1.SelectedRows[0].DataBoundItem;

                if (selectedRow != null)
                {
                    // Reemplaza "NombreColumna" por el nombre real de la columna en tu DataSet
                    string telefono = selectedRow["Telefono"].ToString();
                    string email = selectedRow["Email"].ToString();

                    // Asigna los valores a los TextBox correspondientes
                    txtTelefono.Text = telefono;
                    txtEmail.Text = email;
                }
            }
        }




    }
}
