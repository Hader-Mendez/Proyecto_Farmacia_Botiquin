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
    public partial class DetalleFactura : Form
    {

        bool seleccionActiva = false;

        Conexion conexion = new Conexion();
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public int Id_Detall_Factura { get; set; }


        public DetalleFactura()
        {
            InitializeComponent();
            Mostrar(dgvDetalleFactura);
            
        }
        private void inicializardatagrid()
        {
            
        }
        public void Mostrar(DataGridView dataGridView)
        {
            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_DetalleFactura", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlCommand.Parameters.AddWithValue("@accion", "mostrar");
                using (sqlDataAdapter)
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.sqlConnection.Close();
            }

        }
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmPrincipal();
            this.Close();
            formulario.ShowDialog();
        }
        
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            FrmFactura frmFactura = new FrmFactura();
            this.Hide();
            frmFactura.ShowDialog();
            this.Show();
        }

        public void EditarBFactura()
        {
            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SP_DetalleFactura", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Cantidad", Cantidad);
                sqlCommand.Parameters.AddWithValue("@Precio", Precio);
                sqlCommand.Parameters.AddWithValue("@Id_Detall_Factura", Id_Detall_Factura);
                sqlCommand.Parameters.AddWithValue("@accion", "editar");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.sqlConnection.Close();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ObtenerParametro();
            EditarBFactura();
        }

        private void ObtenerParametro()
        {
            Cantidad = int.Parse(txtCant.Text);
            Precio = float.Parse(txtPrecio.Text);
        }

        private void dgvDetalleFactura_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDetalleFactura.Rows[e.RowIndex];
                Id_Detall_Factura = int.Parse(row.Cells["Id Detalle Factura"].Value.ToString());

                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
                txtCant.Text = row.Cells["Cantidad"].Value.ToString();

                seleccionActiva = true;
            }

        }
    }
}
