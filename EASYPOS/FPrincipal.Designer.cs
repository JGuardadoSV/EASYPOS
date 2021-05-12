
namespace EASYPOS
{
    partial class FPrincipal
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
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoContratoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratosVigentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosVigentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosPendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosEnMoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteFinancieroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoDeCuotaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.creditosToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.catálogoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaVentaToolStripMenuItem,
            this.reportesDeVentaToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaVentaToolStripMenuItem.Text = "Nueva venta";
            this.nuevaVentaToolStripMenuItem.Click += new System.EventHandler(this.nuevaVentaToolStripMenuItem_Click);
            // 
            // creditosToolStripMenuItem
            // 
            this.creditosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagoDeCuotaToolStripMenuItem1,
            this.nuevoContratoToolStripMenuItem,
            this.contratosVigentesToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.creditosToolStripMenuItem.Name = "creditosToolStripMenuItem";
            this.creditosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.creditosToolStripMenuItem.Text = "Creditos";
            // 
            // nuevoContratoToolStripMenuItem
            // 
            this.nuevoContratoToolStripMenuItem.Name = "nuevoContratoToolStripMenuItem";
            this.nuevoContratoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoContratoToolStripMenuItem.Text = "Nuevo contrato";
            // 
            // contratosVigentesToolStripMenuItem
            // 
            this.contratosVigentesToolStripMenuItem.Name = "contratosVigentesToolStripMenuItem";
            this.contratosVigentesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contratosVigentesToolStripMenuItem.Text = "Contratos vigentes";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verInventarioToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // verInventarioToolStripMenuItem
            // 
            this.verInventarioToolStripMenuItem.Name = "verInventarioToolStripMenuItem";
            this.verInventarioToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.verInventarioToolStripMenuItem.Text = "Ver inventario";
            this.verInventarioToolStripMenuItem.Click += new System.EventHandler(this.verInventarioToolStripMenuItem_Click);
            // 
            // reportesDeVentaToolStripMenuItem
            // 
            this.reportesDeVentaToolStripMenuItem.Name = "reportesDeVentaToolStripMenuItem";
            this.reportesDeVentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportesDeVentaToolStripMenuItem.Text = "Reportes de venta";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditosVigentesToolStripMenuItem,
            this.creditosPendientesToolStripMenuItem,
            this.creditosEnMoraToolStripMenuItem,
            this.reporteFinancieroToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // creditosVigentesToolStripMenuItem
            // 
            this.creditosVigentesToolStripMenuItem.Name = "creditosVigentesToolStripMenuItem";
            this.creditosVigentesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.creditosVigentesToolStripMenuItem.Text = "Creditos vigentes";
            // 
            // creditosPendientesToolStripMenuItem
            // 
            this.creditosPendientesToolStripMenuItem.Name = "creditosPendientesToolStripMenuItem";
            this.creditosPendientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.creditosPendientesToolStripMenuItem.Text = "Creditos pendientes";
            // 
            // creditosEnMoraToolStripMenuItem
            // 
            this.creditosEnMoraToolStripMenuItem.Name = "creditosEnMoraToolStripMenuItem";
            this.creditosEnMoraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.creditosEnMoraToolStripMenuItem.Text = "Creditos en mora";
            // 
            // reporteFinancieroToolStripMenuItem
            // 
            this.reporteFinancieroToolStripMenuItem.Name = "reporteFinancieroToolStripMenuItem";
            this.reporteFinancieroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reporteFinancieroToolStripMenuItem.Text = "Reporte financiero ";
            // 
            // pagoDeCuotaToolStripMenuItem1
            // 
            this.pagoDeCuotaToolStripMenuItem1.Name = "pagoDeCuotaToolStripMenuItem1";
            this.pagoDeCuotaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pagoDeCuotaToolStripMenuItem1.Text = "Pago de cuota";
            // 
            // catálogoToolStripMenuItem
            // 
            this.catálogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriasToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.catálogoToolStripMenuItem.Name = "catálogoToolStripMenuItem";
            this.catálogoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.catálogoToolStripMenuItem.Text = "Catálogo";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoContratoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratosVigentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoDeCuotaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditosVigentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditosPendientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditosEnMoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteFinancieroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
    }
}