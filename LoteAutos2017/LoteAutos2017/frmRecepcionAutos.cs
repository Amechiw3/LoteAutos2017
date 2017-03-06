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
                    String[] arr= { };
                    switch (t.Tag.ToString()) {
                        case "COLONIA":
                            arr = ClienteVendedorManager.getColoniasRegistradas(t.Text).ToArray();
                            break;
                        case "CIUDAD":
                            arr = ClienteVendedorManager.getCiudadesRegistradas(t.Text).ToArray();
                            break;
                        case "ESTADO":
                            arr = ClienteVendedorManager.getEstadoRegistradas(t.Text).ToArray();
                            break;
                    }
                    
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClienteVendedor nCliente = new ClienteVendedor();
            nCliente.sNombre = txtNombre.Text;
            nCliente.sApellidos = txtApellidos.Text;
            nCliente.sINE = txtINE.Text;
            nCliente.sTelefono = txtTelefono.Text;
            nCliente.sCalle = txtCalle.Text;
            nCliente.sNumero = txtNumero.Text;
            nCliente.sEntreCalle = txtEntre.Text;
            nCliente.sColonia = txtColonia.Text;
            nCliente.sCiudad = txtCiudad.Text;
            nCliente.sEstado = txtEstado.Text;
            nCliente.sImagen = ucFotoCliente.ImagenString;

            int pkCliente=ClienteVendedorManager.GuardarNuevoCV(nCliente);

            Auto nAuto = new Auto();
            nAuto.sFotoPrincipal = ucFotoPrincipal.ImagenString;
            nAuto.sFotoSecundaria = ucFotoSecundaria.ImagenString;
            nAuto.sFotoTercearia = ucFotoTercearia.ImagenString;

            nAuto.sMarca = txtMarca.Text;
            nAuto.sModelo = txtModelo.Text;
            nAuto.sNumeroSerie = txtNumeroSerie.Text;
            nAuto.iAnio =Convert.ToInt32( txtAnio.Text);
            nAuto.sDescripcion = txtComentario.Text;

            AutoManager.GuardarNuevoAuto(nAuto, pkCliente);
            int x = 0;



        }
    }
}
