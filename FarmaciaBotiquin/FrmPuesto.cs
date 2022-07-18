using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FarmaciaBotiquin.Clases;

namespace FarmaciaBotiquin
{
    public partial class FrmPuesto : Form
    {
        Puesto puesto = new Puesto();
        Validaciones validaciones = new Validaciones();

        bool seleccionActiva = false;
        public FrmPuesto()
        {
            InitializeComponent();
            inicializarDatagrid();
        }
        private void inicializarDatagrid()
        {
            puesto.MostrarPuestos(dgvPuestos);
            dgvPuestos.Columns["IdPuesto"].Visible = true;
        }
        private bool VerificarParametros()
        {
            if (!validaciones.verificarTextoLargo(txtPuesto.Text, 15))
            {
                MessageBox.Show("Por favor, ingrese el nombre del puesto.");
                return false;
            }

            return true;
        }
        private void ObtenerParametros()
        {
            puesto.Puestos = txtPuesto.Text;

        }
        private void limpieza()
        {
            foreach (Control ctr in gbPuesto.Controls)
            {
                if (ctr is TextBox)
                    ctr.Text = "";
            }
            inicializarDatagrid();
        }
        private void limpiezaMax()
        {
            limpieza();
            seleccionActiva = false;
        }
        private void txtPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void dgvPuestos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPuestos.Rows[e.RowIndex];
                puesto.IdPuesto = int.Parse(row.Cells["IdPuesto"].Value.ToString());

                txtPuesto.Text = row.Cells["Puesto"].Value.ToString();
                seleccionActiva = true;
            }
        }

        private void pbCerrarPue_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmPrincipal();
            this.Close();
            this.Show();
        }


        private void btnAgregarPue_Click_1(object sender, EventArgs e)
        {
            if (VerificarParametros())
            {

                ObtenerParametros();
                puesto.AgregarPuesto(puesto);
                limpieza();
            }
        }

        private void btnEditarPue_Click_1(object sender, EventArgs e)
        {
            if (!seleccionActiva)
            {
                MessageBox.Show("Por favor, selecione un puesto para editarlo");
            }
            else
            {
                if (VerificarParametros())
                {
                    ObtenerParametros();
                    puesto.EditarPuesto(puesto);
                    limpiezaMax();
                }
            }
        }
    }
}
