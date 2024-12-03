using Capa_Logica;
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
    public partial class frmAcceso : Form
    {
        private UsuariosDAO u1;
        private int intMax;
        public frmAcceso()
        {
            InitializeComponent();
            u1 = new UsuariosDAO("PEA1G3");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {            
            if (u1.validarUsuario(txtUsu.Text, txtClave.Text, cboNivel.Text) == true)
            {
                frmMenu m1 = new frmMenu();
                m1.Show();
                this.Hide();
            }
            else
            {
                intMax++;
                if (intMax < 3)
                {
                    MessageBox.Show("ERROR: Usuario, Clave o Nivel Incorrecto. Intentos restantes: " + (3 - intMax));
                }
                else
                {
                    MessageBox.Show("Ha alcanzado el limite de intentos!!!!!!");
                    Application.Exit();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAcceso_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {
            chkContra.Text = "Mostrar Contraseña";
            cboNivel.Items.Add("Administrador");
            cboNivel.Items.Add("Ventas");
            cboNivel.Items.Add("Marketing");
            cboNivel.Items.Add("Soporte");
            intMax = 0;
        }

        private void chkContra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContra.Checked == true)
            {
                chkContra.Text = "Ocultar Contraseña";
                txtClave.PasswordChar = '\0';
            }
            else
            {
                chkContra.Text = "Mostrar Contraseña";
                txtClave.PasswordChar = '*';
            }
        }
    }
}
