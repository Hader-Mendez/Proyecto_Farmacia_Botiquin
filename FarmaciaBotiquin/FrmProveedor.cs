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
    public partial class FrmProveedor : Form
    {
        Proveedor proveedor = new Proveedor();
        bool seleccionActiva = false;
        Validaciones validaciones = new Validaciones();
        Estado estado = new Estado();
        public FrmProveedor()
        {
            InitializeComponent();
            estado.CargarComboboxEstado(cmbEstadoProveedor);
            Inicializar();
        }
        private void Inicializar()
        {
            proveedor.MostrarProveedor(dgvProveedor);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            proveedor.BuscarProveedor(dgvProveedor, txtBuscar.Text);
        }

        private void txtRTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void pbCerrarProveedor_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmPrincipal();
            this.Close();
            this.Show();
        }
        private bool VerificarParametros()
        {
            if (!validaciones.verificarTextoLargo(txtCodigoProveedot.Text, 13))
            {
                MessageBox.Show("Por favor, ingrese el nombre del empleado.");
                return false;
            }

            if (!validaciones.verificarTextoLargo(txtNombreProveedor.Text, 30))
            {
                MessageBox.Show("Por favor, ingrese el apellido del empleado");
                return false;
            }

            if (!validaciones.verificarTextoLargo(txtCorreoProveedor.Text, 25))
            {
                MessageBox.Show("Ingrese un correo para el empleado");
                return false;
            }
            if (!validaciones.verificarTextoLargo(txtDireccion.Text, 50))
            {
                MessageBox.Show("Ingrese un correo para el empleado");
                return false;
            }

            if (!validaciones.verificarTextoLargo(txtTelefono.Text, 8))
            {
                MessageBox.Show("Ingrese un numero de telefono para el empleado");
                return false;
            }

            return true;
        }
        private void limpieza()
        {
            foreach (Control ctr in gbProvedor.Controls)
            {
                if (ctr is TextBox)
                    ctr.Text = "";
            }
            Inicializar();
            cmbEstadoProveedor.SelectedValue = 1;
            txtTelefono.Text = "";
            txtCorreoProveedor.Text = "";
        }
        private void limpiezaMax()
        {
            limpieza();
            seleccionActiva = false;
        }
        private void ObtenerParametros()
        {
            proveedor.CodProveedor = txtCodigoProveedot.Text;
            proveedor.RTN = txtRTN.Text;
            proveedor.NombreProveedor = txtNombreProveedor.Text;
            proveedor.Telefono = txtTelefono.Text;
            proveedor.Email = txtCorreoProveedor.Text;
            proveedor.Direccion = txtDireccion.Text;
            proveedor.IdEstado = (int)cmbEstadoProveedor.SelectedValue;
        }
        private void dgvProveedor_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProveedor.Rows[e.RowIndex];
                txtCodigoProveedot.Text = row.Cells[0].Value.ToString();
                txtRTN.Text = row.Cells[1].Value.ToString();
                txtNombreProveedor.Text = row.Cells[2].Value.ToString();
                txtCorreoProveedor.Text = row.Cells[3].Value.ToString();
                txtTelefono.Text = row.Cells[5].Value.ToString();
                txtDireccion.Text = row.Cells[4].Value.ToString();
                cmbEstadoProveedor.Text = row.Cells[6].Value.ToString();
                seleccionActiva = true;
            }
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificarParametros())
                {
                    ObtenerParametros();
                    proveedor.AgregarProveedor(proveedor);
                    proveedor.MostrarProveedor(dgvProveedor);
                    limpieza();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            if (seleccionActiva == false)
            {
                MessageBox.Show("Por favor, selecione un puesto para editarlo");
            }
            else
            {
                if (VerificarParametros())
                {
                    ObtenerParametros();
                    proveedor.EditarProveedor(proveedor);
                    proveedor.MostrarProveedor(dgvProveedor);
                    limpiezaMax();
                }
            }
        }
    }
}
