using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LoteAutos2017.Controladores;
using LoteAutos2017.Modelo;
namespace LoteAutos2017
{
    public partial class frmVentaAuto : Form
    {
        Cliente nCliente = null;

        public void MostrarDatosCliente(int IdCliente) {
            if (IdCliente > 0)
            {
                nCliente = ClienteManager.BuscarPorID(IdCliente);
                txtNombre.Text = nCliente.sNombre;
                txtApellidos.Text = nCliente.sApellidos;
                txtTelefono.Text = nCliente.sTelefono;
                txtEmail.Text = nCliente.sEmail;
                DesactivarControlesDeCliente(true);
            }
            else {
                DesactivarControlesDeCliente(false);
                nCliente = null;
            }
        }

        private void DesactivarControlesDeCliente(bool v)
        {
            foreach (object obj in this.groupBox1.Controls) {
                if (obj is TextBox) {
                    TextBox txt = (TextBox)obj;
                    txt.ReadOnly = v;
                    if (!v) {
                        txt.Text = "";
                    }
                }
            }
        }

        public frmVentaAuto()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (!txtNombre.ReadOnly)
            {
                frmBuscarCliente vHija = new frmBuscarCliente(this);
                vHija.ShowDialog();
            }
            else {
                MostrarDatosCliente(0);
            }
        }
    }
}
