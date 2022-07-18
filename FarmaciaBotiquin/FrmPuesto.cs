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
            //puesto.MostrarPuestos(dgvPuestos);
            dgvPuestos.Columns["IdPuesto"].Visible = false;
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
            puesto.puesto = txtNombreE.Text;
            
        }
    }
}
