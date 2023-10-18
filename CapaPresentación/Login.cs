using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaConsultorio;
using CapaEntidad;

namespace CapaPresentación
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
            
        {
            List<Personal> TEST = new capa_servicio_personal().Listar();
            Personal opersonal = new capa_servicio_personal().Listar()
                .Where(u => u.dni_personal == (int.TryParse(txtUsuario.Text, out int dni_personal) ? dni_personal : -1) && u.contrasena_personal == txtClave.Text)
                .FirstOrDefault();

            if (opersonal != null)
            {
                Inicio form = new Inicio();
                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;

            }
            else
            {
                MessageBox.Show("No se encontró el usuario", "mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }



        }

        private void frm_closing(object sender, FormClosingEventArgs e) {

            txtUsuario.Text = "";
            txtClave.Text = "";

            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro_Personal form = new Registro_Personal();
            form.Show();
            this.Hide();

            form.FormClosing += frm_closing;

        }
    }
}
