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
using LoteAutos2017.Comun;
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

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (textBox4.Text.Length > 0) { 
                    Auto auto=AutoManager.BuscarPorId(Convert.ToInt32(textBox4.Text));
                    txtMarca.Text = auto.sMarca;
                    txtModelo.Text = auto.sModelo;
                    txtAnio.Text = auto.iAnio.ToString();
                    txtNoSerie.Text = auto.sNumeroSerie;
                    txtDescripcion.Text = auto.sDescripcion;
                    picAuto.Image = ToolImagen.Base64StringToBitmap(auto.sFotoPrincipal);

                    txtSubTotal.Text =String.Format("{0:00.00}", auto.PrecioVenta);
                    txtIva.Text = String.Format("{0:0.00}",auto.PrecioVenta * 0.16);
                    txtTotal.Text = String.Format( "{0:0.00}",auto.PrecioVenta * 1.16);
                }
            }
        }
    }
}
