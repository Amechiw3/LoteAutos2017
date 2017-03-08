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

namespace LoteAutos2017
{
    public partial class frmBuscarCliente : Form
    {
        frmVentaAuto vPadre;

        public frmBuscarCliente(frmVentaAuto Ventana)
        {
            InitializeComponent();
            this.grdDatos.AutoGenerateColumns = false;
            this.vPadre = Ventana;
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            this.grdDatos.DataSource = ClienteManager
                    .BuscarPorApellidos(txtApellidos.Text);

        }

        private void grdDatos_DataSourceChanged(object sender, EventArgs e)
        {
            lblRegistros.Text = "Registros: " 
                + grdDatos.Rows.Count;
        }

        private void grdDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String idCliente = grdDatos.Rows[e.RowIndex]
                .Cells[0].Value.ToString();

            vPadre.MostrarDatosCliente(Convert.ToInt32( idCliente));
            this.Close();
        }
    }
}
