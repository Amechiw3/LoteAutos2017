using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LoteAutos2017.Modelo;
using LoteAutos2017.Comun;

namespace LoteAutos2017.UserControls
{
    public partial class ucFichaAuto : UserControl
    {
        Auto automovil;

        public ucFichaAuto(Auto auto)
        {
            InitializeComponent();
            automovil = auto;
        }       

        private void ucFichaAuto_Load(object sender, EventArgs e)
        {
            imgPrincipal.Image = ToolImagen.Base64StringToBitmap(automovil.sFotoPrincipal);
            imgSecutandaria.Image = ToolImagen.Base64StringToBitmap(automovil.sFotoSecundaria);
            imgTercearia.Image = ToolImagen.Base64StringToBitmap(automovil.sFotoTercearia);
        }
    }
}
