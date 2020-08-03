namespace AdministracionFacturas
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresoDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anularFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoDeFacturasToolStripMenuItem,
            this.anularFacturaToolStripMenuItem,
            this.buscarFacturaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresoDeFacturasToolStripMenuItem
            // 
            this.ingresoDeFacturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.individualToolStripMenuItem,
            this.masivaToolStripMenuItem});
            this.ingresoDeFacturasToolStripMenuItem.Name = "ingresoDeFacturasToolStripMenuItem";
            this.ingresoDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.ingresoDeFacturasToolStripMenuItem.Text = "Ingreso de facturas";
            // 
            // individualToolStripMenuItem
            // 
            this.individualToolStripMenuItem.Name = "individualToolStripMenuItem";
            this.individualToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.individualToolStripMenuItem.Text = "Individual";
            // 
            // masivaToolStripMenuItem
            // 
            this.masivaToolStripMenuItem.Name = "masivaToolStripMenuItem";
            this.masivaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.masivaToolStripMenuItem.Text = "Masiva";
            // 
            // anularFacturaToolStripMenuItem
            // 
            this.anularFacturaToolStripMenuItem.Name = "anularFacturaToolStripMenuItem";
            this.anularFacturaToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.anularFacturaToolStripMenuItem.Text = "Anular factura";
            // 
            // buscarFacturaToolStripMenuItem
            // 
            this.buscarFacturaToolStripMenuItem.Name = "buscarFacturaToolStripMenuItem";
            this.buscarFacturaToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.buscarFacturaToolStripMenuItem.Text = "Buscar factura";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masivaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anularFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarFacturaToolStripMenuItem;
    }
}