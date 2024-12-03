using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;
using Microsoft.VisualBasic;

namespace Capa_Presentacion
{
    public partial class FrmTarifa : Form
    {
        private TarifaDAO u1;
        public FrmTarifa()
        {
            InitializeComponent();
        }


        private void FrmTarifa_Load(object sender, EventArgs e)
        {
            u1 = new TarifaDAO("PEA1G3");
            u1.listar(tblResultado);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Tarifa f = new Tarifa(int.Parse(txtTarif.Text), txtClase.Text, double.Parse(txtPrec.Text), double.Parse(txtImp.Text));
            u1.Agregar(f);
            u1.listar(tblResultado);
            Limpiar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string tarifbus;
            Tarifa f = new Tarifa();

            if (btnConsultar.Text.Equals("Consultar"))
            {
                tarifbus = Interaction.InputBox("Ingrese tarifa a buscar", "Consulta de Tarifas");
                if (!string.IsNullOrEmpty(tarifbus))
                {
                    if (u1.buscar(tarifbus, f))
                    {
                        btnModificar.Enabled = true;
                        btnConsultar.Text = "Cancelar";
                        txtTarif.Text = f.Idtarifa.ToString();
                        txtClase.Text = f.Clase.ToString();
                        txtPrec.Text = f.Precio.ToString();
                        txtImp.Text = f.Impuesto.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Debe de ingresar una tarifa");
                }
            }
            else
            {
                btnConsultar.Text = "Consultar";
                btnModificar.Enabled=false;
                Limpiar();
            }
        }

        private void Limpiar()
        {
            txtTarif.Clear();
            txtClase.Clear();
            txtPrec.Clear();
            txtImp.Clear();
            txtTarif.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string codigo;            
            Tarifa f = new Tarifa();
            codigo = Interaction.InputBox("Ingrese tarifa a eliminar", "Eliminar Tarifa");            
            u1.Eliminar(codigo);
            u1.listar(tblResultado);            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtClase.Text) && !string.IsNullOrEmpty(txtImp.Text) && !string.IsNullOrEmpty(txtPrec.Text) && !string.IsNullOrEmpty(txtTarif.Text))
            {
                Tarifa f = new Tarifa(int.Parse(txtTarif.Text), txtClase.Text, double.Parse(txtPrec.Text), double.Parse(txtImp.Text));
                u1.modificar(int.Parse(txtTarif.Text), f);
                u1.listar(tblResultado);
                btnConsultar.Text = "Consultar";
                btnModificar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Todos los campos deben de estar completos.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
