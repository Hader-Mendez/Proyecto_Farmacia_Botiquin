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
    class Clientes
    {
        public int IdCliente { get; set; }
        public string DNICliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdEstado { get; set; }

        Conexion conexion = new Conexion();

        public void MostrarCliente(DataGridView dataGrid)
        {
            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Cliente", conexion.sqlConnection);
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
        public void BuscarCliente(DataGridView dataGrid, string valorBuscado)
        {

            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Cliente", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlCommand.Parameters.AddWithValue("@BuscarCliente", valorBuscado);
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
        
 
        public void AgregarCliente(Clientes cliente)
        {
            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("Sp_Cliente", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@DNICliente", cliente.DNICliente);
                sqlCommand.Parameters.AddWithValue("@NombreCliente", cliente.NombreCliente);
                sqlCommand.Parameters.AddWithValue("@ApellidoCliente", cliente.ApellidoCliente);
                sqlCommand.Parameters.AddWithValue("@Email", cliente.Email);
                sqlCommand.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                sqlCommand.Parameters.AddWithValue("@IdEstado", cliente.IdEstado);
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
        public void EditarCliente(Clientes cliente)
        {
            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Cliente", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                sqlCommand.Parameters.AddWithValue("@DNICliente", cliente.DNICliente);
                sqlCommand.Parameters.AddWithValue("@NombreCliente", cliente.NombreCliente);
                sqlCommand.Parameters.AddWithValue("@ApellidoCliente", cliente.ApellidoCliente);
                sqlCommand.Parameters.AddWithValue("@Email", cliente.Email);
                sqlCommand.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                sqlCommand.Parameters.AddWithValue("@IdEstado", cliente.IdEstado);

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
