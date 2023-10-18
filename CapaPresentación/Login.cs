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
            Personal opersonal = TEST
                .FirstOrDefault(u => u.dni_personal == (int.TryParse(txtUsuario.Text, out int dni_personal) ? dni_personal : -1));

            if (opersonal != null)
            {
                if (opersonal.contrasena_personal == txtClave.Text)
                {
                    Inicio form = new Inicio(opersonal);
                    form.Show();
                    this.Hide();
                    form.FormClosing += frm_closing;
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No se encontró el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        private void frm_closing(object sender, FormClosingEventArgs e) {


                txtUsuario.Text = "";
                txtClave.Text = "";

                this.Show(); // Muestra nuevamente el formulario actual
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sel_tipo_personal frm  = new Sel_tipo_personal();  
            frm.Show();
            this.Hide();

            frm.FormClosing += frm_closing;

        }
    }
}
