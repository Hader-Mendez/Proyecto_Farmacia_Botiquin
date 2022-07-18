using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using FarmaciaBotiquin.Clases;

namespace FarmaciaBotiquin
{
    public partial class FrmCliente : Form
    {
        Clientes cliente = new Clientes();
        Estado estado = new Estado();
        Validaciones validaciones = new Validaciones();

        private string telefono, correo;
        bool seleccionActiva = false;
        public FrmCliente()
        {
            InitializeComponent();
            estado.CargarComboboxEstado(cmbEstado);
            inicializarDatagrid();
        }

        private void inicializarDatagrid()
        {
            cliente.MostrarCliente(dgvClientes);
            dgvClientes.Columns["IdCliente"].Visible = false;

        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmPrincipal();
            this.Close();
            this.Show();
        }

        private bool VerificarParametros()
        {
            if (!validaciones.verificarTextoLargo(txtDniCliente.Text, 13))
            {
                MessageBox.Show("Por favor, ingrese el DNI del cliente");
                return false;
            }
            if (!validaciones.verificarTextoLargo(txtNombreCliente.Text, 30))
            {
                MessageBox.Show("Por favor, ingrese el nombre del cliente.");
                return false;
            }

            if (!validaciones.verificarTextoLargo(txtApellidosCliente.Text, 30))
            {
                MessageBox.Show("Por favor, ingrese el apellido del cliente");
                return false;
            }

            if (!validaciones.verificarTextoLargo(txtCorreoClientes.Text, 25))
            {
                MessageBox.Show("Ingrese un correo para el cliente");
                return false;
            }

            return true;
        }

        private void ObtenerParametros()
        {
            cliente.DNICliente = txtDniCliente.Text;
            cliente.NombreCliente = txtNombreCliente.Text;
            cliente.ApellidoCliente = txtApellidosCliente.Text;
            cliente.Email = txtCorreoClientes.Text;
            cliente.FechaNacimiento = dtpFechaNacClientes.Value;
            cliente.IdEstado = (int)cmbEstado.SelectedValue;
        }
        private void limpieza()
        {
            foreach (Control ctr in gbEmpleado.Controls)
            {
                if (ctr is TextBox)
                    ctr.Text = "";
            }
            inicializarDatagrid();
            cmbEstado.SelectedValue = 1;
            telefono = "";
            correo = "";
        }

        private void limpiezaMax()
        {
            limpieza();
            seleccionActiva = false;
        }

        private void pnRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cliente.BuscarCliente(dgvClientes, txtBuscar.Text);
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (VerificarParametros())
            {
                ObtenerParametros();
                cliente.AgregarCliente(cliente);
                limpieza();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!seleccionActiva)
            {
                MessageBox.Show("Por favor, selecione un cliente para editarlo");
            }
            else
            {
                if (VerificarParametros())
                {

                    ObtenerParametros();
                    cliente.EditarCliente(cliente);
                    limpiezaMax();
                }
            }
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

        private void txtDniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtApellidosCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void dgvClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];
                cliente.IdCliente = int.Parse(row.Cells["IdCliente"].Value.ToString());

                txtDniCliente.Text = row.Cells["DNICliente"].Value.ToString();
                txtNombreCliente.Text = row.Cells["Nombre"].Value.ToString();
                txtApellidosCliente.Text = row.Cells["Apellidos"].Value.ToString();
                txtCorreoClientes.Text = row.Cells["Email"].Value.ToString();
                dtpFechaNacClientes.Value = Convert.ToDateTime(dgvClientes.Rows[e.RowIndex].Cells["FechaNacimiento"].Value.ToString());
                cmbEstado.Text = row.Cells["Estado"].Value.ToString();

                correo = row.Cells["Email"].Value.ToString();
                seleccionActiva = true;
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
