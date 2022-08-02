using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FarmaciaBotiquin.Clases
{
    class Detalle
    {
        Conexion conexion = new Conexion();
        public int Id_Detall_Factura { get; set; }
        public int Id_Factura { get; set; }
        public int CodProducto { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }

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
        public void EditarDetalleFactura(Detalle detalle)
        {
            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SP_DetalleFactura", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@Id_Detall_Factura", detalle.Id_Detall_Factura);
                sqlCommand.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                sqlCommand.Parameters.AddWithValue("@Precio", detalle.Precio);
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

    }
}




