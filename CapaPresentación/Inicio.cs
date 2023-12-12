using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaPresentación
{
    public partial class Inicio : Form
    {
        public static IconMenuItem MenuACtivo = null;
        public static Form FormularioActivo = null;

        private static Personal usuarioActual;
        public Inicio(Personal objusuario)
        {
            usuarioActual = objusuario;
            InitializeComponent();
        }


        public void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuACtivo != null) {
                MenuACtivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuACtivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.CornflowerBlue;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void turnos_Click(object sender, EventArgs e)
        {
            
        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

            if (usuarioActual.idTipoPersonal == 2)
            {
                agregar_paciente.Visible = false;
            }

            txt_nombre_usuario.Text = usuarioActual.nombre_personal;
        }

        public void agregarAUnNuevoPaccienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(pacientesmenu, new frmRegistro_paciente());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void asignarTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(turnos, new frmTurnos());
        }

        private void promedioDeTurnosRegistradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(estadisticas, new frmEstadisticas());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombre_usuario_Click(object sender, EventArgs e)
        {

        }

        private void altaDeMédicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(recursos_humanos, new Registro_Personal());
        }

        private void alta_personal_administrativo_Click(object sender, EventArgs e)
        {
            AbrirFormulario(recursos_humanos, new registro_personal_administrativo());
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void consultarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void consultaPacientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(pacientesmenu, new frm_Consulta_de_pacientes());
        }
    }
}
