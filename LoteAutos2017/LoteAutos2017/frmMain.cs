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
namespace LoteAutos2017
{
    public partial class frmMain : Form
    {
        public static UsuarioHelper uHelper;

        public frmMain()
        {
            InitializeComponent();
        }

        

        private void tooVenta_Click(object sender, EventArgs e)
        {
            frmVentaAuto nVentana = new frmVentaAuto();
            nVentana.Show();
        }

        private void tooIngreso_Click(object sender, EventArgs e)
        {
            frmRecepcionAutos nVentana = new frmRecepcionAutos();
            nVentana.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (uHelper == null) {
                frmLogincs vLogin = new frmLogincs();
                vLogin.ShowDialog();
            }
            if (uHelper.esValido && uHelper!=null)
            {
                //TODO: ACTIVAR TODOS LOS CONTROLES SEGUN EL PERMISO
            }
            else {
                MessageBox.Show("Se require se autentifique","Eror..",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uHelper == null)
            {
                frmLogincs vLogin = new frmLogincs();
                vLogin.ShowDialog();
            }
            if (uHelper.esValido)
            {
                //TODO: ACTIVAR TODOS LOS CONTROLES SEGUN EL PERMISO
            }
            else
            {
                MessageBox.Show("Se require se autentifique", "Eror..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
