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
    public partial class FrmEmpleado : Form
    {
        Empleado empleado = new Empleado();
        Puesto puesto = new Puesto();
        Estado estado = new Estado();
        Validaciones validaciones = new Validaciones();

        private string telefono, correo;
        bool seleccionActiva = false;
        public FrmEmpleado()
        {
            InitializeComponent();
            puesto.CargarComboboxPuesto(cmbPuesto, 1);
            estado.CargarComboboxEstado(cmbEstado);
            inicializarDatagrid();
        }
        private void inicializarDatagrid()
        {
            empleado.MostrarEmpleados(dgvEmpleados);
            dgvEmpleados.Columns["IdEmpleado"].Visible = false;
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            empleado.BuscarEmpleados(dgvEmpleados, txtBuscar.Text);
        }
        private bool VerificarParametros()
        {
            if (!validaciones.verificarTextoLargo(txtNombreE.Text, 30))
            {
                MessageBox.Show("Por favor, ingrese el nombre del empleado.");
                return false;
            }

            if (!validaciones.verificarTextoLargo(txtApellidoE.Text, 30))
            {
                MessageBox.Show("Por favor, ingrese el apellido del empleado");
                return false;
            }

            if (!validaciones.verificarTextoLargo(txtCorreoE.Text, 25))
            {
                MessageBox.Show("Ingrese un correo para el empleado");
                return false;
            }

            if (!validaciones.verificarTextoLargo(txtTelefonoE.Text, 8))
            {
                MessageBox.Show("Ingrese un numero de telefono para el empleado");
                return false;
            }

            return true;
        }
        private void ObtenerParametros()
        {
            empleado.NombreEmpleado = txtNombreE.Text;
            empleado.ApellidoEmpleado = txtApellidoE.Text;
            empleado.Email = txtCorreoE.Text;
            empleado.Telefono = txtTelefonoE.Text;
            empleado.IdPuesto = (int)cmbPuesto.SelectedValue;
            empleado.IdEstado = (int)cmbEstado.SelectedValue;
        }
        private void limpieza()
        {
            foreach (Control ctr in gbEmpleado.Controls)
            {
                if (ctr is TextBox)
                    ctr.Text = "";
            }
            inicializarDatagrid();
            cmbPuesto.SelectedValue = 1;
            cmbEstado.SelectedValue = 1;
            telefono = "";
            correo = "";
        }
        private void limpiezaMax()
        {
            limpieza();
            seleccionActiva = false;
        }
        private void txtNombreE_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }
        private void txtApellidoE_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }
        private void txtTelefonoE_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(VerificarParametros())
            {
                if(!empleado.ExisteTelefono(txtTelefonoE.Text))
                {
                    if(!empleado.ExtisteCorreo(txtCorreoE.Text))
                    {
                        ObtenerParametros();
                        empleado.AgregarEmpleado(empleado);
                        limpieza();
                    }
                    else
                    {
                        MessageBox.Show("El correo ya existe en otro empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("El telefono ya existe en otro empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvEmpleados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmpleados.Rows[e.RowIndex];
                empleado.IdEmpleado = int.Parse(row.Cells["IdEmpleado"].Value.ToString());
                
                txtNombreE.Text = row.Cells["Nombre"].Value.ToString();
                txtApellidoE.Text = row.Cells["Apellido"].Value.ToString();
                txtCorreoE.Text = row.Cells["Email"].Value.ToString();
                txtTelefonoE.Text = row.Cells["Telefono"].Value.ToString();
                cmbPuesto.Text = row.Cells["Puesto"].Value.ToString();
                cmbEstado.Text = row.Cells["Estado"].Value.ToString();

                telefono = row.Cells["Telefono"].Value.ToString();
                correo = row.Cells["Email"].Value.ToString();
                seleccionActiva = true;
            }
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmPrincipal();
            this.Close();
            this.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!seleccionActiva)
            {
                MessageBox.Show("Por favor, selecione un empleado para editarlo");
            }
            else
            {
                if (VerificarParametros())
                {
                    if (!empleado.ExtisteCorreo(txtCorreoE.Text) || txtCorreoE.Text == correo)
                    {
                        if (!empleado.ExisteTelefono(txtTelefonoE.Text) || txtTelefonoE.Text == telefono)
                        {
                            ObtenerParametros();
                            empleado.EditarEmpleado(empleado);
                            limpiezaMax();
                        }
                        else
                        {
                            MessageBox.Show("El telefono ya esta registrado en otro empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El correo ya esta registrado en otro empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
