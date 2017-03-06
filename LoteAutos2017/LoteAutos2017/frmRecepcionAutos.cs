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
    public partial class frmRecepcionAutos : Form
    {
        public frmRecepcionAutos()
        {
            InitializeComponent();

            //CODIGO PARA PONER EL AUTO-COMPLETAR DE LOS CONTROLES
            this.txtColonia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txtColonia.AutoCompleteSource = AutoCompleteSource.CustomSource;

            this.txtCiudad.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txtCiudad.AutoCompleteSource = AutoCompleteSource.CustomSource;

            this.txtEstado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txtEstado.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void txtColonia_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t != null) {
               if (t.Text.Length >= 3) {
                    String[] arr =ClienteVendedorManager.getColoniasRegistradas(t.Text).ToArray();
                    AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                    collection.AddRange(arr);
                    t.AutoCompleteCustomSource = collection;
                }
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {                
                e.Handled = true;
                return;
            }
        }
    }
}
