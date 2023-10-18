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
    public partial class Sel_tipo_personal : Form
    {
        public Sel_tipo_personal()
        {
            InitializeComponent();
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {

            this.Show();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            //form.Show();
            this.Close();
            form.FormClosing += frm_closing;


        }


        private void iconButton2_Click(object sender, EventArgs e)
        {
            Registro_Personal frm = new Registro_Personal();
            frm.Show();
            this.Hide();
            frm.FormClosing += frm_closing;


        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

            registro_personal_administrativo frm = new registro_personal_administrativo();
            frm.Show();
            this.Hide();
            frm.FormClosing += frm_closing;

        }
    }
}
