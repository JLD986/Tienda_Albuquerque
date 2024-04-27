namespace Vista
{
    partial class MantenimientoProduto
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
            this.GpbxFiltro = new System.Windows.Forms.GroupBox();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.BttnnuevoProducto = new System.Windows.Forms.Button();
            this.bttnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // GpbxFiltro
            // 
            this.GpbxFiltro.Location = new System.Drawing.Point(13, 13);
            this.GpbxFiltro.Name = "GpbxFiltro";
            this.GpbxFiltro.Size = new System.Drawing.Size(520, 100);
            this.GpbxFiltro.TabIndex = 0;
            this.GpbxFiltro.TabStop = false;
            this.GpbxFiltro.Text = "Filtro por producto";
            // 
            // dgvProducto
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(13, 120);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.Size = new System.Drawing.Size(907, 387);
            this.dgvProducto.TabIndex = 1;
            // 
            // BttnnuevoProducto
            // 
            this.BttnnuevoProducto.Location = new System.Drawing.Point(33, 585);
            this.BttnnuevoProducto.Name = "BttnnuevoProducto";
            this.BttnnuevoProducto.Size = new System.Drawing.Size(101, 50);
            this.BttnnuevoProducto.TabIndex = 2;
            this.BttnnuevoProducto.Text = "Nuevo";
            this.BttnnuevoProducto.UseVisualStyleBackColor = true;
            this.BttnnuevoProducto.Click += new System.EventHandler(this.BttnnuevoProducto_Click);
            // 
            // bttnVolver
            // 
            this.bttnVolver.Location = new System.Drawing.Point(831, 585);
            this.bttnVolver.Name = "bttnVolver";
            this.bttnVolver.Size = new System.Drawing.Size(89, 47);
            this.bttnVolver.TabIndex = 3;
            this.bttnVolver.Text = "atras";
            this.bttnVolver.UseVisualStyleBackColor = true;
            this.bttnVolver.Click += new System.EventHandler(this.bttnVolver_Click);
            // 
            // MantenimientoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.bttnVolver);
            this.Controls.Add(this.BttnnuevoProducto);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.GpbxFiltro);
            this.Name = "MantenimientoProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda  Albuquerque | Mantenimiento Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GpbxFiltro;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.Button BttnnuevoProducto;
        private System.Windows.Forms.Button bttnVolver;
    }
}