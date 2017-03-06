namespace LoteAutos2017.UserControls
{
    partial class ucFichaAuto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgPrincipal = new System.Windows.Forms.PictureBox();
            this.imgSecutandaria = new System.Windows.Forms.PictureBox();
            this.imgTercearia = new System.Windows.Forms.PictureBox();
            this.btnVerMas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSecutandaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTercearia)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPrincipal
            // 
            this.imgPrincipal.Location = new System.Drawing.Point(3, 3);
            this.imgPrincipal.Name = "imgPrincipal";
            this.imgPrincipal.Size = new System.Drawing.Size(215, 154);
            this.imgPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPrincipal.TabIndex = 0;
            this.imgPrincipal.TabStop = false;
            // 
            // imgSecutandaria
            // 
            this.imgSecutandaria.Location = new System.Drawing.Point(4, 163);
            this.imgSecutandaria.Name = "imgSecutandaria";
            this.imgSecutandaria.Size = new System.Drawing.Size(104, 62);
            this.imgSecutandaria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSecutandaria.TabIndex = 1;
            this.imgSecutandaria.TabStop = false;
            // 
            // imgTercearia
            // 
            this.imgTercearia.Location = new System.Drawing.Point(114, 163);
            this.imgTercearia.Name = "imgTercearia";
            this.imgTercearia.Size = new System.Drawing.Size(104, 62);
            this.imgTercearia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTercearia.TabIndex = 2;
            this.imgTercearia.TabStop = false;
            // 
            // btnVerMas
            // 
            this.btnVerMas.Location = new System.Drawing.Point(4, 231);
            this.btnVerMas.Name = "btnVerMas";
            this.btnVerMas.Size = new System.Drawing.Size(214, 36);
            this.btnVerMas.TabIndex = 3;
            this.btnVerMas.Text = "Ver más...";
            this.btnVerMas.UseVisualStyleBackColor = true;
            // 
            // ucFichaAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnVerMas);
            this.Controls.Add(this.imgTercearia);
            this.Controls.Add(this.imgSecutandaria);
            this.Controls.Add(this.imgPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucFichaAuto";
            this.Size = new System.Drawing.Size(222, 273);
            this.Load += new System.EventHandler(this.ucFichaAuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSecutandaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTercearia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPrincipal;
        private System.Windows.Forms.PictureBox imgSecutandaria;
        private System.Windows.Forms.PictureBox imgTercearia;
        private System.Windows.Forms.Button btnVerMas;
    }
}
