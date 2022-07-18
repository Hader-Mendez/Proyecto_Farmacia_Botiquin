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
    class Proveedor
    {

        Conexion conexion = new Conexion();
        public string CodProveedor { get; set; }
        public string RTN { get; set; }
        public string NombreProveedor { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public int IdEstado { get; set; }

        public void MostrarProveedor(DataGridView dataGridView)
        {
            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Proveedor", conexion.sqlConnection);
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
        public void BuscarProveedor(DataGridView dataGridView, string buscarTexto)
        {
            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Proveedor", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlCommand.Parameters.AddWithValue("@BuscarProveedor", buscarTexto);
                sqlCommand.Parameters.AddWithValue("@accion", "buscar");
            
                using (sqlDataAdapter)
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.sqlConnection.Close();
            }
        }
        public void AgregarProveedor(Proveedor proveedor)
        {
            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Proveedor", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@CodProveedor", proveedor.CodProveedor);
                sqlCommand.Parameters.AddWithValue("@RTN", proveedor.RTN);
                sqlCommand.Parameters.AddWithValue("@NombreProveedor", proveedor.NombreProveedor);
                sqlCommand.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                sqlCommand.Parameters.AddWithValue("@Email", proveedor.Email);
                sqlCommand.Parameters.AddWithValue("@Direccion", proveedor.Direccion);
                sqlCommand.Parameters.AddWithValue("@IdEstado", proveedor.IdEstado);
                sqlCommand.Parameters.AddWithValue("@accion", "insertar");
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.sqlConnection.Close();
            }
        }
        public void EditarProveedor(Proveedor proveedor)
        {
            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Proveedor", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@CodProveedor", proveedor.CodProveedor);
                sqlCommand.Parameters.AddWithValue("@RTN", proveedor.RTN);
                sqlCommand.Parameters.AddWithValue("@NombreProveedor", proveedor.NombreProveedor);
                sqlCommand.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                sqlCommand.Parameters.AddWithValue("@Email", proveedor.Email);
                sqlCommand.Parameters.AddWithValue("@Direccion", proveedor.Direccion);
                sqlCommand.Parameters.AddWithValue("@IdEstado", proveedor.IdEstado);
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
