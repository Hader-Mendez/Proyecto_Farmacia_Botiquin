using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FarmaciaBotiquin.Clases;

namespace FarmaciaBotiquin
{
    public partial class FrmLogin : Form
    {
        Login Login = new Login();
        public FrmLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pbCerrarLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login.ObtenerUsuario(txtUsuario.Text.ToLower(), Login);
            if(Login.Usuario != null)
            {
                if (Login.Usuario == txtUsuario.Text && Login.Contra == txtContra.Text)
                {
                    FrmPrincipal frmPrincipal = new FrmPrincipal();
                    frmPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario y/o la contraseña no es correcta. Favor verificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El usuario y/o la contraseña no es correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llbRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
