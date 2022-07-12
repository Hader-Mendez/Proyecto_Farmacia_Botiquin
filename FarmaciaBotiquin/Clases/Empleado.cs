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
    class Empleado
    {
        public int IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int IdPuesto { get; set; }
        public int IdEstado { get; set; }

        Conexion conexion = new Conexion();
        public void MostrarEmpleados(DataGridView dataGrid)
        {
            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Empleados", conexion.sqlConnection);
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
        public void BuscarEmpleados(DataGridView dataGrid, string valorBuscado)
        {

            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Empleados", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlCommand.Parameters.AddWithValue("@BuscarEmpleado", valorBuscado);
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
        public bool ExisteTelefono(string Telefono)
        {
            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Empleados", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@Telefono", Telefono);
                    sqlCommand.Parameters.AddWithValue("@accion", "obtenerTelefono");
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    if (dataTable.Rows.Count == 1)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.sqlConnection.Close();
            }
        }
        public bool ExtisteCorreo(string Email)
        {
            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Empleados", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@Email", Email);
                    sqlCommand.Parameters.AddWithValue("@accion", "obtenerCorreo");
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    if (dataTable.Rows.Count == 1)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.sqlConnection.Close();
            }
        }
        public void AgregarEmpleado(Empleado empleado)
        {
            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("Sp_Empleados", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@NombreEmpleado", empleado.NombreEmpleado);
                sqlCommand.Parameters.AddWithValue("@ApellidoEmpleado", empleado.ApellidoEmpleado);
                sqlCommand.Parameters.AddWithValue("@Email", empleado.Email);
                sqlCommand.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                sqlCommand.Parameters.AddWithValue("@IdPuesto", empleado.IdPuesto);
                sqlCommand.Parameters.AddWithValue("@IdEstado", empleado.IdEstado);
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
        public void EditarEmpleado(Empleado empleado)
        {
            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Empleados", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado);
                sqlCommand.Parameters.AddWithValue("@NombreEmpleado", empleado.NombreEmpleado);
                sqlCommand.Parameters.AddWithValue("@ApellidoEmpleado", empleado.ApellidoEmpleado);
                sqlCommand.Parameters.AddWithValue("@Email", empleado.Email);
                sqlCommand.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                sqlCommand.Parameters.AddWithValue("@IdPuesto", empleado.IdPuesto);
                sqlCommand.Parameters.AddWithValue("@IdEstado", empleado.IdEstado);
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
