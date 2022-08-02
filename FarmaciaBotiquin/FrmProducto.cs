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
    public partial class FrmProducto : Form
    {
        Producto producto = new Producto();
        Estado estado = new Estado();
        Validaciones validaciones = new Validaciones();

        bool seleccionActiva = false;
        public FrmProducto()
        {
            InitializeComponent();
            estado.CargarComboboxEstado(cmbEstado);
            inicializarDatagrid();
        }
        private void inicializarDatagrid()
        {
            producto.MostrarProductos(dgvProductos);
        }
    

        private bool VerificarParametros()
        {
            if (!validaciones.verificarTextoLargo(txtCodPro.Text, 20))
            {
                MessageBox.Show("Por favor, ingrese el Codigo del Producto.");
                return false;
            }
            if (!validaciones.verificarTextoLargo(txtNombrePro.Text, 30))
            {
                MessageBox.Show("Por favor, ingrese el nombre del Producto.");
                return false;
            }

            if (!validaciones.verificarTextoLargo(txtDescripcion.Text, 40))
            {
                MessageBox.Show("Por favor, ingrese la descripcion");
                return false;
            }

            return true;
        }
        private void ObtenerParametros()
        {
            producto.CodProducto = txtCodPro.Text;
            producto.NombreProducto = txtNombrePro.Text;
            producto.Descripcion = txtDescripcion.Text;
            producto.Existencia = Convert.ToInt32(txtExistenciaPro.Text);
            producto.FechaVencimiento = dtpVencimientoPro.Value;
            producto.IdEstado = (int)cmbEstado.SelectedValue;
        }
        private void limpieza()
        {
            foreach (Control ctr in gbProducto.Controls)
            {
                if (ctr is TextBox)
                    ctr.Text = "";
            }
            inicializarDatagrid();
            cmbEstado.SelectedValue = 0;
            dtpVencimientoPro.ResetText();
        }
        private void limpiezaMax()
        {
            limpieza();
            seleccionActiva = false;
        }
        private void txtNombrePro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }
        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }
        private void pbCerrarPro_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmPrincipal();
            this.Close();
            this.Show();
        }
        private void btnAgregarPro_Click(object sender, EventArgs e)
        {
            if (VerificarParametros())
            {  
               ObtenerParametros();
               producto.AgregarProducto(producto);
               limpieza();
            }
        }

        private void dgvProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];
                txtCodPro.Text = row.Cells["CodProducto"].Value.ToString();

                txtNombrePro.Text = row.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                txtExistenciaPro.Text = row.Cells["Existencia"].Value.ToString();
                dtpVencimientoPro.Value = Convert.ToDateTime(dgvProductos.Rows[e.RowIndex].Cells["FechaVencimiento"].Value.ToString());
                cmbEstado.Text = row.Cells["Estado"].Value.ToString(); // NO COPIAR Y PEGAR SOLO BASARSE    

                seleccionActiva = true;
            }
        }

        private void txtBuscarPro_TextChanged(object sender, EventArgs e)
        {
            producto.BuscarProducto(dgvProductos, txtBuscarPro.Text);
        }

        private void btnEditarPro_Click_1(object sender, EventArgs e)
        {
            if (!seleccionActiva)
            {
                MessageBox.Show("Por favor, selecione un Producto para editarlo");
            }
            else
            {
                if (VerificarParametros())
                {
                    ObtenerParametros();
                    producto.EditarProducto(producto);
                    limpiezaMax();
                }
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
