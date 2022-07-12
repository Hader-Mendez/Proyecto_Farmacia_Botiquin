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
    class Producto
    {
        public string CodProducto { get; set; }
        public string NombreProducto { get; set; }
        public string  Descripcion { get; set; }
        public int Existencia { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int IdEstado { get; set; }

        Conexion conexion = new Conexion();

        public void MostrarProductos(DataGridView dataGrid)
        {
            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Producto", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlCommand.Parameters.AddWithValue("@accion", "mostrar");
                using (sqlDataAdapter)
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dataGrid.DataSource = dataTable;
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

        public void BuscarProducto(DataGridView dataGrid, string valorBuscado)
        {

            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Producto", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlCommand.Parameters.AddWithValue("@BuscarProducto", valorBuscado);
                sqlCommand.Parameters.AddWithValue("@accion", "buscar");

                using (sqlDataAdapter)
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dataGrid.DataSource = dataTable;
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
        public void AgregarProducto(Producto producto)
        {
            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("Sp_Producto", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@CodProducto", producto.CodProducto);
                sqlCommand.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto);
                sqlCommand.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                sqlCommand.Parameters.AddWithValue("@Existencia", producto.Existencia);
                sqlCommand.Parameters.AddWithValue("@FechaVencimiento", producto.FechaVencimiento);
                sqlCommand.Parameters.AddWithValue("@IdEstado", producto.IdEstado);
                sqlCommand.Parameters.AddWithValue("@accion", "insertar");
                sqlCommand.ExecuteNonQuery();
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
        public void EditarProducto(Producto producto)
        {
            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Producto", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@CodProducto", producto.CodProducto);
                sqlCommand.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto);
                sqlCommand.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                sqlCommand.Parameters.AddWithValue("@Existencia", producto.Existencia);
                sqlCommand.Parameters.AddWithValue("@FechaVencimiento", producto.FechaVencimiento);
                sqlCommand.Parameters.AddWithValue("@IdEstado", producto.IdEstado);
                sqlCommand.Parameters.AddWithValue("@accion", "editar");
                sqlCommand.ExecuteNonQuery();
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
