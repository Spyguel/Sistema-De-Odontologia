    using CapaConsultorio;
    using CapaEntidad;
using CapaServicio;
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
        public partial class frmTurnos : Form
        {
            public TurnosService servicio_turnos = new TurnosService();
            public CS_registro_paciente servicio_validar = new CS_registro_paciente();
            public frmTurnos()
            {
                InitializeComponent();
            }

            private void frmTurnos_Load(object sender, EventArgs e)
            {
                // TODO: This line of code loads data into the 'sistema_odontologiaDataSet4.paciente' table. You can move, or remove it, as needed.
                this.pacienteTableAdapter1.Fill(this.sistema_odontologiaDataSet4.paciente);
                // TODO: This line of code loads data into the 'sistema_odontologiaDataSet3.paciente' table. You can move, or remove it, as needed.
                this.pacienteTableAdapter.Fill(this.sistema_odontologiaDataSet3.paciente);
                // TODO: This line of code loads data into the 'sistema_odontologiaDataSet1.turnos' table. You can move, or remove it, as needed.
                this.turnosTableAdapter.Fill(this.sistema_odontologiaDataSet1.turnos);

                List<Personal> empleadosTipo1 = new PersonalService().ListarEmpleadosTipo1();

                // Configura el combo box para mostrar el nombre y usar el DNI como valor
                sel_odontologo.DataSource = empleadosTipo1;
                sel_odontologo.DisplayMember = "nombre_personal";
                sel_odontologo.ValueMember = "dni_personal";
                


            }


            private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void sel_odontologo_SelectedIndexChanged(object sender, EventArgs e)
            {
                // Verifica si hay un ítem seleccionado
                if (sel_odontologo.SelectedItem != null)
                {
                    // Intenta obtener el valor DNI del ítem seleccionado
                    if (sel_odontologo.SelectedValue is int dniUsuario)
                    {
                        // Llama al método para obtener los horarios
                        List<Personal> horarios = new HorarioNegocio().ObtenerHorarios(dniUsuario);

                        // Configura el control donde mostrarás los horarios (por ejemplo, una lista o grid)
                        lista_horarios.DataSource = horarios;
                        // Configura cómo se mostrarán los horarios en el control
                        lista_horarios.DisplayMember = "horario_inicio"; // Cambia esto al campo que deseas mostrar
                        lista_horarios.ValueMember = "horario_inicio";
                    }
                }
            }

        private void btn_registrar_turno_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente paciente = new Paciente();
                Turnos turnos = new Turnos();
                turnos.pacienteID = Convert.ToInt32(textBox1.Text);
                turnos.personalID = (int)sel_odontologo.SelectedValue;
                DateTime fechaActual = DateTime.Now.Date;
                turnos.fecha = fecha_turno.Value.Date;
                if (turnos.fecha < fechaActual)
                {
                    MessageBox.Show("No se pueden registrar turnos con fechas anteriores a la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Sale del evento sin registrar el turno
                }

                string dniIngresado = textBox1.Text.Trim();
                if (!Regex.IsMatch(dniIngresado, @"^\d{7,8}[A-Za-z]?$"))
                {
                    MessageBox.Show("El formato del DNI ingresado no es válido. Debe contener 7 u 8 dígitos seguidos opcionalmente por una letra.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Sale del evento sin registrar el turno
                }

                paciente.dni_paciente = Convert.ToInt32(dniIngresado);

                if (!servicio_validar.ValidarDNIPaciente(paciente))
                {
                    MessageBox.Show("El paciente con el DNI ingresado no existe.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Sale del evento sin registrar el turno
                }

                Console.WriteLine(lista_horarios.SelectedItem);
                turnos.hora = (TimeSpan)lista_horarios.SelectedValue;
                turnos.Observaciones = txt_observaciones.Text.ToString();

                bool insercionExitosa = servicio_turnos.InsertarTurno(turnos);

                if (insercionExitosa)
                {
                    MessageBox.Show("Turno registrado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ya existe un turno para el mismo personal en la misma fecha y hora.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("El formato del DNI ingresado no es válido. Debe contener exactamente 8 dígitos numéricos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                // Captura excepciones generales
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fecha_turno_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
