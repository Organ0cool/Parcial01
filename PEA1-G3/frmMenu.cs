using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void mnuCerrarSesion_Click(object sender, EventArgs e)
        {            
            MessageBox.Show("Sesión Cerrada!!!!");
            this.Hide();
            frmAcceso ac1 = new frmAcceso();
            ac1.Show();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mnuFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuTarifa_Click(object sender, EventArgs e)
        {
            FrmTarifa t = new FrmTarifa();
            t.MdiParent = this;
            t.Show();
        }
    }
}
