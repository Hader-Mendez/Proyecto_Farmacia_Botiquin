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
    public partial class DetalleFactura : Form
    {

        Detalle detalle = new Detalle();
        bool seleccionActiva = false;


        public DetalleFactura()
        {
            InitializeComponent();
            inicializardatagrid();
        }
        private void inicializardatagrid()
        {
            detalle.Mostrar(dgvDetalleFactura);
            dgvDetalleFactura.Columns["Id_Detall_Factura"].Visible = false;
        }
        private void limpieza()
        {
            
            txtCant.Text = "";
            txtPrecio.Text = "";
        }
        private void limpiezaMax()
        {
            limpieza();
            seleccionActiva = false;
        }


        private void btnFacturar_Click(object sender, EventArgs e)
        {
            FrmFactura frmFactura = new FrmFactura();
            this.Hide();
            frmFactura.ShowDialog();
            this.Show();
        }

        private void ObtenerParametro()
        {
            detalle.Cantidad = int.Parse(txtCant.Text);
            detalle.Precio = float.Parse(txtPrecio.Text);
        }

        private void dgvDetalleFactura_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDetalleFactura.Rows[e.RowIndex];
                detalle.Id_Detall_Factura = int.Parse(row.Cells["Id_Detall_Factura"].Value.ToString());

                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
                txtCant.Text = row.Cells["Cantidad"].Value.ToString();

                seleccionActiva = true;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmPrincipal();
            this.Close();
            this.Show();
        }

        private void btnEditardetalle_Click(object sender, EventArgs e)
        {
            if (!seleccionActiva)
            {
                MessageBox.Show("Por favor, selecione un empleado para editarlo");
            }
            else
            {
                ObtenerParametro();
                detalle.EditarDetalleFactura(detalle);
                limpiezaMax();
            }
        }
    }
}
