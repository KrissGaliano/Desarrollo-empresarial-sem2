
namespace Lab02_01
{
    partial class PrincipalMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalMDI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimeintoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManRegistrarVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManRegistrarCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManReporteDeVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManReporteDeCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManInventarioDeProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManReporteDeProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManReporteDeUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManReporteDeClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManSalirDelSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.V = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimeintoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimeintoToolStripMenuItem
            // 
            this.mantenimeintoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManUsuarios,
            this.mnuManProductos,
            this.mnuManCategorias,
            this.mnuManProveedores,
            this.mnuManClientes});
            this.mantenimeintoToolStripMenuItem.Name = "mantenimeintoToolStripMenuItem";
            this.mantenimeintoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimeintoToolStripMenuItem.Text = "Mantenimeinto";
            // 
            // mnuManUsuarios
            // 
            this.mnuManUsuarios.Name = "mnuManUsuarios";
            this.mnuManUsuarios.Size = new System.Drawing.Size(139, 22);
            this.mnuManUsuarios.Text = "Usuarios";
            this.mnuManUsuarios.Click += new System.EventHandler(this.mnuManUsuarios_Click);
            // 
            // mnuManProductos
            // 
            this.mnuManProductos.Name = "mnuManProductos";
            this.mnuManProductos.Size = new System.Drawing.Size(139, 22);
            this.mnuManProductos.Text = "Productos";
            // 
            // mnuManCategorias
            // 
            this.mnuManCategorias.Name = "mnuManCategorias";
            this.mnuManCategorias.Size = new System.Drawing.Size(139, 22);
            this.mnuManCategorias.Text = "Categorías";
            // 
            // mnuManProveedores
            // 
            this.mnuManProveedores.Name = "mnuManProveedores";
            this.mnuManProveedores.Size = new System.Drawing.Size(139, 22);
            this.mnuManProveedores.Text = "Proveedores";
            // 
            // mnuManClientes
            // 
            this.mnuManClientes.Name = "mnuManClientes";
            this.mnuManClientes.Size = new System.Drawing.Size(139, 22);
            this.mnuManClientes.Text = "Clientes";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManRegistrarVenta,
            this.mnuManRegistrarCompra});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // mnuManRegistrarVenta
            // 
            this.mnuManRegistrarVenta.Name = "mnuManRegistrarVenta";
            this.mnuManRegistrarVenta.Size = new System.Drawing.Size(166, 22);
            this.mnuManRegistrarVenta.Text = "Registrar Venta";
            // 
            // mnuManRegistrarCompra
            // 
            this.mnuManRegistrarCompra.Name = "mnuManRegistrarCompra";
            this.mnuManRegistrarCompra.Size = new System.Drawing.Size(166, 22);
            this.mnuManRegistrarCompra.Text = "Registrar Compra";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManReporteDeVentas,
            this.mnuManReporteDeCompras,
            this.mnuManInventarioDeProductos,
            this.mnuManReporteDeProveedores,
            this.mnuManReporteDeUsuarios,
            this.mnuManReporteDeClientes});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // mnuManReporteDeVentas
            // 
            this.mnuManReporteDeVentas.Name = "mnuManReporteDeVentas";
            this.mnuManReporteDeVentas.Size = new System.Drawing.Size(200, 22);
            this.mnuManReporteDeVentas.Text = "Reporte de Ventas";
            // 
            // mnuManReporteDeCompras
            // 
            this.mnuManReporteDeCompras.Name = "mnuManReporteDeCompras";
            this.mnuManReporteDeCompras.Size = new System.Drawing.Size(200, 22);
            this.mnuManReporteDeCompras.Text = "Reporte de Compras";
            // 
            // mnuManInventarioDeProductos
            // 
            this.mnuManInventarioDeProductos.Name = "mnuManInventarioDeProductos";
            this.mnuManInventarioDeProductos.Size = new System.Drawing.Size(200, 22);
            this.mnuManInventarioDeProductos.Text = "Inventario de Productos";
            // 
            // mnuManReporteDeProveedores
            // 
            this.mnuManReporteDeProveedores.Name = "mnuManReporteDeProveedores";
            this.mnuManReporteDeProveedores.Size = new System.Drawing.Size(200, 22);
            this.mnuManReporteDeProveedores.Text = "Reporte de Proveedores";
            // 
            // mnuManReporteDeUsuarios
            // 
            this.mnuManReporteDeUsuarios.Name = "mnuManReporteDeUsuarios";
            this.mnuManReporteDeUsuarios.Size = new System.Drawing.Size(200, 22);
            this.mnuManReporteDeUsuarios.Text = "Reporte de Usuarios";
            // 
            // mnuManReporteDeClientes
            // 
            this.mnuManReporteDeClientes.Name = "mnuManReporteDeClientes";
            this.mnuManReporteDeClientes.Size = new System.Drawing.Size(200, 22);
            this.mnuManReporteDeClientes.Text = "Reporte de Clientes";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManSalirDelSistema});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // mnuManSalirDelSistema
            // 
            this.mnuManSalirDelSistema.Name = "mnuManSalirDelSistema";
            this.mnuManSalirDelSistema.Size = new System.Drawing.Size(156, 22);
            this.mnuManSalirDelSistema.Text = "Salir de Sistema";
            this.mnuManSalirDelSistema.Click += new System.EventHandler(this.mnuManSalirDelSistema_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // V
            // 
            this.V.AutoSize = true;
            this.V.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V.Location = new System.Drawing.Point(77, 324);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(423, 32);
            this.V.TabIndex = 4;
            this.V.Text = "GRACIAS POR ACCEDER!!!!!!!";
            // 
            // PrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.V);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimeintoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuManProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuManCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuManProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuManClientes;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManRegistrarVenta;
        private System.Windows.Forms.ToolStripMenuItem mnuManRegistrarCompra;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManReporteDeVentas;
        private System.Windows.Forms.ToolStripMenuItem mnuManReporteDeCompras;
        private System.Windows.Forms.ToolStripMenuItem mnuManInventarioDeProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuManReporteDeProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuManReporteDeUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuManReporteDeClientes;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManSalirDelSistema;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label V;
    }
}