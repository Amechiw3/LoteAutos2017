using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LoteAutos2017.Controladores.Helpers;
using LoteAutos2017.Controladores;
namespace LoteAutos2017
{
    public partial class frmLogincs : Form
    {
        UsuarioHelper uHelper;
        public frmLogincs()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            uHelper = UsuarioManeger.Autentificar(txtUsuario.Text,
                txtPassword.Text);
            if (uHelper.esValido)
            {
                frmMain.uHelper = uHelper;
                this.Close();
            }
            else {
                MessageBox.Show(uHelper.sMensaje,"Autentificacion",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUsuario.Text="";
                txtUsuario.Focus();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
