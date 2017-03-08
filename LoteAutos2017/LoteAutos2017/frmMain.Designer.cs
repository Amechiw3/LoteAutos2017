namespace LoteAutos2017
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tooVenta = new System.Windows.Forms.ToolStripButton();
            this.tooIngreso = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tooVenta
            // 
            this.tooVenta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tooVenta.Image = ((System.Drawing.Image)(resources.GetObject("tooVenta.Image")));
            this.tooVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tooVenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tooVenta.Name = "tooVenta";
            this.tooVenta.Size = new System.Drawing.Size(68, 68);
            this.tooVenta.Text = "Venta";
            this.tooVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tooVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tooVenta.Click += new System.EventHandler(this.tooVenta_Click);
            // 
            // tooIngreso
            // 
            this.tooIngreso.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tooIngreso.Image = ((System.Drawing.Image)(resources.GetObject("tooIngreso.Image")));
            this.tooIngreso.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tooIngreso.Name = "tooIngreso";
            this.tooIngreso.Size = new System.Drawing.Size(68, 68);
            this.tooIngreso.Text = "Recepción";
            this.tooIngreso.Click += new System.EventHandler(this.tooIngreso_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.autosToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(77, 68);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.porVendedorToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // porVendedorToolStripMenuItem
            // 
            this.porVendedorToolStripMenuItem.Name = "porVendedorToolStripMenuItem";
            this.porVendedorToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.porVendedorToolStripMenuItem.Text = "Por Vendedor";
            // 
            // autosToolStripMenuItem
            // 
            this.autosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem1,
            this.porClienteToolStripMenuItem});
            this.autosToolStripMenuItem.Name = "autosToolStripMenuItem";
            this.autosToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.autosToolStripMenuItem.Text = "Autos";
            // 
            // generalToolStripMenuItem1
            // 
            this.generalToolStripMenuItem1.Name = "generalToolStripMenuItem1";
            this.generalToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.generalToolStripMenuItem1.Text = "General";
            // 
            // porClienteToolStripMenuItem
            // 
            this.porClienteToolStripMenuItem.Name = "porClienteToolStripMenuItem";
            this.porClienteToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.porClienteToolStripMenuItem.Text = "Por Cliente";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 71);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(77, 68);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // ingresarToolStripMenuItem
            // 
            this.ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            this.ingresarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ingresarToolStripMenuItem.Text = "&Ingresar";
            this.ingresarToolStripMenuItem.Click += new System.EventHandler(this.ingresarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tooVenta,
            this.tooIngreso,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1,
            this.toolStripSeparator2,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(902, 71);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 86);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lote de Autos";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tooVenta;
        private System.Windows.Forms.ToolStripButton tooIngreso;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem ingresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}