namespace CapaVista
{
    partial class Store_AS
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store_AS));
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Producto = new System.Windows.Forms.ToolStripMenuItem();
            this.AdmonProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.verRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mas = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admónMetodosDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(339, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.menuStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ventas,
            this.Producto,
            this.RegistroVentas,
            this.Mas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(819, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Ventas
            // 
            this.Ventas.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.Ventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarVentaToolStripMenuItem});
            this.Ventas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ventas.ForeColor = System.Drawing.Color.White;
            this.Ventas.Name = "Ventas";
            this.Ventas.Size = new System.Drawing.Size(61, 21);
            this.Ventas.Text = "Ventas";
            this.Ventas.Click += new System.EventHandler(this.Ventas_Click);
            // 
            // realizarVentaToolStripMenuItem
            // 
            this.realizarVentaToolStripMenuItem.Name = "realizarVentaToolStripMenuItem";
            this.realizarVentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.realizarVentaToolStripMenuItem.Text = "Hacer Venta";
            this.realizarVentaToolStripMenuItem.Click += new System.EventHandler(this.realizarVentaToolStripMenuItem_Click);
            // 
            // Producto
            // 
            this.Producto.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.Producto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdmonProducto});
            this.Producto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Producto.ForeColor = System.Drawing.Color.White;
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(76, 21);
            this.Producto.Text = "Producto";
            // 
            // AdmonProducto
            // 
            this.AdmonProducto.Name = "AdmonProducto";
            this.AdmonProducto.Size = new System.Drawing.Size(161, 22);
            this.AdmonProducto.Text = "Add Producto";
            this.AdmonProducto.Click += new System.EventHandler(this.AdmonProducto_Click_1);
            // 
            // RegistroVentas
            // 
            this.RegistroVentas.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.RegistroVentas.BackColor = System.Drawing.Color.SlateGray;
            this.RegistroVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verRegistroToolStripMenuItem});
            this.RegistroVentas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistroVentas.ForeColor = System.Drawing.Color.White;
            this.RegistroVentas.Name = "RegistroVentas";
            this.RegistroVentas.Size = new System.Drawing.Size(116, 21);
            this.RegistroVentas.Text = "Registro Ventas";
            // 
            // verRegistroToolStripMenuItem
            // 
            this.verRegistroToolStripMenuItem.Name = "verRegistroToolStripMenuItem";
            this.verRegistroToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.verRegistroToolStripMenuItem.Text = "Registro de Ventas";
            this.verRegistroToolStripMenuItem.Click += new System.EventHandler(this.verRegistroToolStripMenuItem_Click);
            // 
            // Mas
            // 
            this.Mas.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.Mas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirMarcasToolStripMenuItem,
            this.añadirCategoriasToolStripMenuItem,
            this.admónMetodosDePagoToolStripMenuItem});
            this.Mas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Mas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mas.Name = "Mas";
            this.Mas.Size = new System.Drawing.Size(57, 21);
            this.Mas.Text = "Extras";
            // 
            // añadirMarcasToolStripMenuItem
            // 
            this.añadirMarcasToolStripMenuItem.Name = "añadirMarcasToolStripMenuItem";
            this.añadirMarcasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.añadirMarcasToolStripMenuItem.Text = "Add Marca";
            this.añadirMarcasToolStripMenuItem.Click += new System.EventHandler(this.MarcasToolStripMenuItem_Click);
            // 
            // añadirCategoriasToolStripMenuItem
            // 
            this.añadirCategoriasToolStripMenuItem.Name = "añadirCategoriasToolStripMenuItem";
            this.añadirCategoriasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.añadirCategoriasToolStripMenuItem.Text = "Add Categoria";
            this.añadirCategoriasToolStripMenuItem.Click += new System.EventHandler(this.CategoriasToolStripMenuItem_Click);
            // 
            // admónMetodosDePagoToolStripMenuItem
            // 
            this.admónMetodosDePagoToolStripMenuItem.Name = "admónMetodosDePagoToolStripMenuItem";
            this.admónMetodosDePagoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.admónMetodosDePagoToolStripMenuItem.Text = "Add MetodoPago";
            this.admónMetodosDePagoToolStripMenuItem.Click += new System.EventHandler(this.admónMetodosDePagoToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(819, 484);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Store_AS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(819, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Store_AS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda Albuquerque";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Ventas;
        private System.Windows.Forms.ToolStripMenuItem realizarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Producto;
        private System.Windows.Forms.ToolStripMenuItem AdmonProducto;
        private System.Windows.Forms.ToolStripMenuItem RegistroVentas;
        private System.Windows.Forms.ToolStripMenuItem verRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Mas;
        private System.Windows.Forms.ToolStripMenuItem añadirMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admónMetodosDePagoToolStripMenuItem;
    }
}

