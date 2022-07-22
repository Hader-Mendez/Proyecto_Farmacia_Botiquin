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
    public partial class FrmUsuario : Form
    {
        Usuarios usuarios = new Usuarios();
        bool seleccionActiva = false;
        Validaciones validaciones = new Validaciones();
        Estado estado = new Estado();
        public FrmUsuario()
        {
            InitializeComponent();
            estado.CargarComboboxEstado(cmbEstado);
            usuarios.CargarComboboxUsuarios(cmbEmpleado);
            Inicializar();
        }
        private void Inicializar()
        {
            usuarios.MostrarUsuario(dgvUsuarios);
            dgvUsuarios.Columns["IdUsuario"].Visible = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            usuarios.BuscarUsuario(dgvUsuarios, txtBuscar.Text);
        }
        
        private bool VerificarParametros()
        {

            if (!validaciones.verificarTextoLargo(txtUsuario.Text, 30))
            {
                MessageBox.Show("Por favor, ingrese el usuario del empleado");
                return false;
            }

            if (!validaciones.verificarTextoLargo(txtContraseña.Text, 25))
            {
                MessageBox.Show("Por favor, ingrese una contraseña, para el usuario");
                return false;
            }

            return true;
        }
        private void limpieza()
        {
            foreach (Control ctr in gbUsuario.Controls)
            {
                if (ctr is TextBox)
                    ctr.Text = "";
            }
            Inicializar();
            cmbEmpleado.SelectedValue = 1;
            cmbEstado.SelectedValue = 1;
            txtContraseña.Text = "";
            txtUsuario.Text = "";
        }
        private void limpiezaMax()
        {
            limpieza();
            seleccionActiva = false;
        }
        private void ObtenerParametros()
        {
            usuarios.Usuario = txtUsuario.Text;
            usuarios.Contra = txtContraseña.Text;
            usuarios.IdEmpleado = (int)cmbEmpleado.SelectedValue;
            usuarios.IdEstado = (int)cmbEstado.SelectedValue;
        }

        private void dgvUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];
                txtUsuario.Text = row.Cells["Usuario"].Value.ToString();
                txtContraseña.Text = row.Cells["Contra"].Value.ToString();
                cmbEmpleado.Text = row.Cells["Empleado"].Value.ToString();
                cmbEstado.Text = row.Cells["Estado"].Value.ToString();
                seleccionActiva = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificarParametros())
                {
                    ObtenerParametros();
                    usuarios.AgregarUsuario(usuarios);
                    usuarios.MostrarUsuario(dgvUsuarios);
                    limpieza();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!seleccionActiva)
            {
                MessageBox.Show("Por favor, selecione un usuario para editarlo.");
            }
            else
            {
                if (VerificarParametros())
                {
                    ObtenerParametros();
                    usuarios.EditarUsuario(usuarios);
                    usuarios.MostrarUsuario(dgvUsuarios);
                    limpiezaMax();
                }
            }
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmPrincipal();
            this.Close();
            this.Show();
        }
    }
}
