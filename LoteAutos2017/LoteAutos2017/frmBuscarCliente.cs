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
    }
}
