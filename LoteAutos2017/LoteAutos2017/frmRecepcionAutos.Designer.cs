namespace LoteAutos2017
{
    partial class frmRecepcionAutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEntre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtINE = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNumeroSerie = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ucFotoTercearia = new LoteAutos2017.UserControls.ucWebCam();
            this.ucFotoSecundaria = new LoteAutos2017.UserControls.ucWebCam();
            this.ucFotoPrincipal = new LoteAutos2017.UserControls.ucWebCam();
            this.ucFotoCliente = new LoteAutos2017.UserControls.ucWebCam();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOMBRE (S)";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(276, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(235, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // txtApellidos
            // 
            this.txtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidos.Location = new System.Drawing.Point(517, 64);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(317, 22);
            this.txtApellidos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "APELLIDOS";
            // 
            // txtCalle
            // 
            this.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCalle.Location = new System.Drawing.Point(276, 153);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(475, 22);
            this.txtCalle.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "CALLE";
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Location = new System.Drawing.Point(757, 153);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(77, 22);
            this.txtNumero.TabIndex = 13;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(757, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "NUMERO";
            // 
            // txtEntre
            // 
            this.txtEntre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEntre.Location = new System.Drawing.Point(276, 198);
            this.txtEntre.Name = "txtEntre";
            this.txtEntre.Size = new System.Drawing.Size(558, 22);
            this.txtEntre.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "ENTRE CALLES";
            // 
            // txtColonia
            // 
            this.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColonia.Location = new System.Drawing.Point(276, 244);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(192, 22);
            this.txtColonia.TabIndex = 17;
            this.txtColonia.Tag = "COLONIA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "COLONIA";
            // 
            // txtCiudad
            // 
            this.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCiudad.Location = new System.Drawing.Point(474, 244);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(180, 22);
            this.txtCiudad.TabIndex = 19;
            this.txtCiudad.Tag = "CIUDAD";
            this.txtCiudad.TextChanged += new System.EventHandler(this.txtColonia_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(474, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "CIUDAD";
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Location = new System.Drawing.Point(660, 244);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(174, 22);
            this.txtEstado.TabIndex = 21;
            this.txtEstado.Tag = "ESTADO";
            this.txtEstado.TextChanged += new System.EventHandler(this.txtColonia_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(660, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "ESTADO";
            // 
            // txtINE
            // 
            this.txtINE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtINE.Location = new System.Drawing.Point(276, 109);
            this.txtINE.Name = "txtINE";
            this.txtINE.Size = new System.Drawing.Size(235, 22);
            this.txtINE.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "INE";
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Location = new System.Drawing.Point(599, 109);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(235, 22);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(599, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "TELEFONO";
            // 
            // txtAnio
            // 
            this.txtAnio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAnio.Location = new System.Drawing.Point(396, 335);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(174, 22);
            this.txtAnio.TabIndex = 28;
            this.txtAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(396, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "AÑO";
            // 
            // txtModelo
            // 
            this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModelo.Location = new System.Drawing.Point(210, 335);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(180, 22);
            this.txtModelo.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(210, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "MODELO";
            // 
            // txtMarca
            // 
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Location = new System.Drawing.Point(12, 335);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(192, 22);
            this.txtMarca.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 316);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "MARCA";
            // 
            // txtNumeroSerie
            // 
            this.txtNumeroSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroSerie.Location = new System.Drawing.Point(576, 335);
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.Size = new System.Drawing.Size(258, 22);
            this.txtNumeroSerie.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(576, 316);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 16);
            this.label14.TabIndex = 29;
            this.label14.Text = "NUMERO DE SERIE";
            // 
            // txtComentario
            // 
            this.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComentario.Location = new System.Drawing.Point(12, 384);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(822, 102);
            this.txtComentario.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 365);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 16);
            this.label15.TabIndex = 31;
            this.label15.Text = "DESCRIPCION:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 283);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(872, 16);
            this.label16.TabIndex = 22;
            this.label16.Text = "-- DATOS DE LA UNIDAD -----------------------------------------------------------" +
    "------------------------------------------------------------------------------";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(9, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(842, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "-- DATOS DEL PROPIETARIO --------------------------------------------------------" +
    "---------------------------------------------------------------------";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardar.Location = new System.Drawing.Point(690, 726);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 58);
            this.btnGuardar.TabIndex = 36;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCancelar.Location = new System.Drawing.Point(544, 726);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 58);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // ucFotoTercearia
            // 
            this.ucFotoTercearia.ImagenBitmap = null;
            this.ucFotoTercearia.ImagenString = null;
            this.ucFotoTercearia.Location = new System.Drawing.Point(563, 493);
            this.ucFotoTercearia.Margin = new System.Windows.Forms.Padding(4);
            this.ucFotoTercearia.Name = "ucFotoTercearia";
            this.ucFotoTercearia.Size = new System.Drawing.Size(268, 226);
            this.ucFotoTercearia.TabIndex = 35;
            // 
            // ucFotoSecundaria
            // 
            this.ucFotoSecundaria.ImagenBitmap = null;
            this.ucFotoSecundaria.ImagenString = null;
            this.ucFotoSecundaria.Location = new System.Drawing.Point(288, 493);
            this.ucFotoSecundaria.Margin = new System.Windows.Forms.Padding(4);
            this.ucFotoSecundaria.Name = "ucFotoSecundaria";
            this.ucFotoSecundaria.Size = new System.Drawing.Size(268, 226);
            this.ucFotoSecundaria.TabIndex = 34;
            // 
            // ucFotoPrincipal
            // 
            this.ucFotoPrincipal.ImagenBitmap = null;
            this.ucFotoPrincipal.ImagenString = null;
            this.ucFotoPrincipal.Location = new System.Drawing.Point(15, 493);
            this.ucFotoPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.ucFotoPrincipal.Name = "ucFotoPrincipal";
            this.ucFotoPrincipal.Size = new System.Drawing.Size(268, 226);
            this.ucFotoPrincipal.TabIndex = 33;
            // 
            // ucFotoCliente
            // 
            this.ucFotoCliente.ImagenBitmap = null;
            this.ucFotoCliente.ImagenString = null;
            this.ucFotoCliente.Location = new System.Drawing.Point(3, 36);
            this.ucFotoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.ucFotoCliente.Name = "ucFotoCliente";
            this.ucFotoCliente.Size = new System.Drawing.Size(267, 230);
            this.ucFotoCliente.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(288, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 22);
            this.textBox1.TabIndex = 38;
            // 
            // frmRecepcionAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 0);
            this.ClientSize = new System.Drawing.Size(804, 585);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ucFotoTercearia);
            this.Controls.Add(this.ucFotoSecundaria);
            this.Controls.Add(this.ucFotoPrincipal);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtNumeroSerie);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtINE);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtColonia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEntre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucFotoCliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRecepcionAutos";
            this.Text = "Registro de Entrada de Unidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.ucWebCam ucFotoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEntre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtINE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNumeroSerie;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label15;
        private UserControls.ucWebCam ucFotoPrincipal;
        private UserControls.ucWebCam ucFotoSecundaria;
        private UserControls.ucWebCam ucFotoTercearia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox textBox1;
    }
}