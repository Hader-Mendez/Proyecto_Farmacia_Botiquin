using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmaciaBotiquin.Clases;

namespace FarmaciaBotiquin
{
    public partial class FrmCliente : Form
    {
        Clientes cliente = new Clientes();
        Puesto puesto = new Puesto();
        Estado estado = new Estado();
        Validaciones validaciones = new Validaciones();

        private string telefono, correo;
        bool seleccionActiva = false;
        public FrmCliente()
        {
            InitializeComponent();
            estado.CargarComboboxEstado(cmbEstado);
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmPrincipal();
            this.Close();
            this.Show();
        }

        private void pnRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void lbEstado_Click(object sender, EventArgs e)
        {

        }

        private void lbTelefono_Click(object sender, EventArgs e)
        {

        }

        private void lbCorreo_Click(object sender, EventArgs e)
        {

        }

        private void lbApellido_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreoClientes_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidosCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnleft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

        private void gbEmpleado_Enter(object sender, EventArgs e)
        {

        }

        private void lbNombre_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaNacClientes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDniCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
