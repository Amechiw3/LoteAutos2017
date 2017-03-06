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
    public partial class frmCatalogoAutos : Form
    {
        public frmCatalogoAutos()
        {
            InitializeComponent();
        }

        private void frmCatalogoAutos_Load(object sender, EventArgs e)
        {
            int left = 10;
            int top = 50;
            List<Auto> autos = AutoManager.ListarContenido();
            foreach (Auto item in autos) {
                UserControls.ucFichaAuto nControl = new UserControls.ucFichaAuto(item);                
                nControl.Left = left;
                nControl.Top = top;
                left += nControl.Width + 10;
                if ((left+ nControl.Width) > this.Width) {
                    top += 10 + nControl.Height;
                    left = 10;
                }
                this.Controls.Add(nControl);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
