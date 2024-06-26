﻿namespace CapaVista
{
    partial class Ventas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.Regresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.productoBinding = new System.Windows.Forms.BindingSource(this.components);
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.VentabindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.DetalleVentaData = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.ProcesarVenta = new System.Windows.Forms.Button();
            this.comboBoxNombrePro = new System.Windows.Forms.ComboBox();
            this.añadirVenta = new System.Windows.Forms.Button();
            this.comboPagos = new System.Windows.Forms.ComboBox();
            this.detalleVentaBinding = new System.Windows.Forms.BindingSource(this.components);
            this.metodoBinding = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.productoBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentabindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleVentaData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // Regresar
            // 
            this.Regresar.BackColor = System.Drawing.Color.SlateGray;
            this.Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Regresar.FlatAppearance.BorderSize = 0;
            this.Regresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.Regresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Regresar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresar.ForeColor = System.Drawing.Color.SlateGray;
            this.Regresar.Image = global::CapaVista.Properties.Resources.papelera_deshacer;
            this.Regresar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Regresar.Location = new System.Drawing.Point(23, 15);
            this.Regresar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(43, 49);
            this.Regresar.TabIndex = 13;
            this.Regresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Regresar.UseVisualStyleBackColor = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(156, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cod. Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(552, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(278, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(629, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Existencias";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(30, 526);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Monto total";
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.White;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBinding, "Stock", true));
            this.txtStock.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(610, 141);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(115, 17);
            this.txtStock.TabIndex = 20;
            // 
            // productoBinding
            // 
            this.productoBinding.DataSource = typeof(Capa_Entidades.Producto);
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.White;
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VentabindingSource, "Total", true));
            this.txtMonto.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(116, 526);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.Size = new System.Drawing.Size(125, 17);
            this.txtMonto.TabIndex = 21;
            // 
            // VentabindingSource
            // 
            this.VentabindingSource.DataSource = typeof(Capa_Entidades.Venta);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(529, 57);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(117, 17);
            this.txtCantidad.TabIndex = 22;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBinding, "idProducto", true));
            this.txtCodigo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(140, 137);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(128, 17);
            this.txtCodigo.TabIndex = 24;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // DetalleVentaData
            // 
            this.DetalleVentaData.AllowUserToAddRows = false;
            this.DetalleVentaData.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.DetalleVentaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleVentaData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Productos,
            this.Precio,
            this.Cantidad,
            this.SubTotal,
            this.Eliminar});
            this.DetalleVentaData.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DetalleVentaData.Location = new System.Drawing.Point(32, 205);
            this.DetalleVentaData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DetalleVentaData.Name = "DetalleVentaData";
            this.DetalleVentaData.Size = new System.Drawing.Size(850, 307);
            this.DetalleVentaData.TabIndex = 25;
            this.DetalleVentaData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetalleVentaData_CellClick);
            this.DetalleVentaData.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DetalleVentaData_CellValidating);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 57;
            // 
            // Productos
            // 
            this.Productos.DataPropertyName = "Productos";
            this.Productos.HeaderText = "Producto";
            this.Productos.Name = "Productos";
            this.Productos.ReadOnly = true;
            this.Productos.Width = 300;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 125;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::CapaVista.Properties.Resources.delete;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 75;
            // 
            // ProcesarVenta
            // 
            this.ProcesarVenta.BackgroundImage = global::CapaVista.Properties.Resources.texbox;
            this.ProcesarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProcesarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProcesarVenta.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.ProcesarVenta.FlatAppearance.BorderSize = 0;
            this.ProcesarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.ProcesarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.ProcesarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcesarVenta.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcesarVenta.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ProcesarVenta.Image = global::CapaVista.Properties.Resources.venta;
            this.ProcesarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProcesarVenta.Location = new System.Drawing.Point(372, 572);
            this.ProcesarVenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ProcesarVenta.Name = "ProcesarVenta";
            this.ProcesarVenta.Size = new System.Drawing.Size(95, 60);
            this.ProcesarVenta.TabIndex = 26;
            this.ProcesarVenta.Text = "Procesar";
            this.ProcesarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProcesarVenta.UseVisualStyleBackColor = false;
            this.ProcesarVenta.Click += new System.EventHandler(this.ProcesarVenta_Click);
            // 
            // comboBoxNombrePro
            // 
            this.comboBoxNombrePro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxNombrePro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxNombrePro.BackColor = System.Drawing.Color.White;
            this.comboBoxNombrePro.DataSource = this.productoBinding;
            this.comboBoxNombrePro.DisplayMember = "Nombre";
            this.comboBoxNombrePro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNombrePro.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNombrePro.FormattingEnabled = true;
            this.comboBoxNombrePro.Location = new System.Drawing.Point(211, 54);
            this.comboBoxNombrePro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxNombrePro.Name = "comboBoxNombrePro";
            this.comboBoxNombrePro.Size = new System.Drawing.Size(205, 25);
            this.comboBoxNombrePro.TabIndex = 29;
            this.comboBoxNombrePro.ValueMember = "idProducto";
            this.comboBoxNombrePro.SelectedIndexChanged += new System.EventHandler(this.comboBoxNombrePro_SelectedIndexChanged);
            // 
            // añadirVenta
            // 
            this.añadirVenta.BackColor = System.Drawing.Color.SlateGray;
            this.añadirVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.añadirVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.añadirVenta.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.añadirVenta.ForeColor = System.Drawing.SystemColors.Info;
            this.añadirVenta.Image = global::CapaVista.Properties.Resources.plaza_mas;
            this.añadirVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.añadirVenta.Location = new System.Drawing.Point(729, 46);
            this.añadirVenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.añadirVenta.Name = "añadirVenta";
            this.añadirVenta.Size = new System.Drawing.Size(39, 37);
            this.añadirVenta.TabIndex = 30;
            this.añadirVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.añadirVenta.UseVisualStyleBackColor = false;
            this.añadirVenta.Click += new System.EventHandler(this.añadirVenta_Click);
            // 
            // comboPagos
            // 
            this.comboPagos.BackColor = System.Drawing.Color.White;
            this.comboPagos.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.detalleVentaBinding, "idMetodoPago", true));
            this.comboPagos.DataSource = this.metodoBinding;
            this.comboPagos.DisplayMember = "FormaDePago";
            this.comboPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboPagos.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPagos.FormattingEnabled = true;
            this.comboPagos.Location = new System.Drawing.Point(706, 524);
            this.comboPagos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboPagos.Name = "comboPagos";
            this.comboPagos.Size = new System.Drawing.Size(170, 25);
            this.comboPagos.TabIndex = 31;
            this.comboPagos.ValueMember = "idMetodoPago";
            // 
            // detalleVentaBinding
            // 
            this.detalleVentaBinding.DataSource = typeof(Capa_Entidades.Detalle_Venta);
            // 
            // metodoBinding
            // 
            this.metodoBinding.DataSource = typeof(Capa_Entidades.MetodoPago);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(585, 526);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Metodo de Pago";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBinding, "Precio", true));
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(377, 142);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(132, 17);
            this.textBox1.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(419, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Precio";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaVista.Properties.Resources.texbox;
            this.pictureBox3.Location = new System.Drawing.Point(523, 51);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(129, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaVista.Properties.Resources.texbox;
            this.pictureBox1.Location = new System.Drawing.Point(605, 136);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaVista.Properties.Resources.texbox;
            this.pictureBox2.Location = new System.Drawing.Point(137, 133);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CapaVista.Properties.Resources.texbox;
            this.pictureBox4.Location = new System.Drawing.Point(372, 137);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(141, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CapaVista.Properties.Resources.texbox;
            this.pictureBox5.Location = new System.Drawing.Point(203, 50);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(222, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 39;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CapaVista.Properties.Resources.texbox;
            this.pictureBox6.Location = new System.Drawing.Point(111, 522);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(135, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 40;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::CapaVista.Properties.Resources.texbox;
            this.pictureBox7.Location = new System.Drawing.Point(701, 519);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(180, 33);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 41;
            this.pictureBox7.TabStop = false;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(905, 659);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboPagos);
            this.Controls.Add(this.añadirVenta);
            this.Controls.Add(this.comboBoxNombrePro);
            this.Controls.Add(this.ProcesarVenta);
            this.Controls.Add(this.DetalleVentaData);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda Albuquerque | Venta";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentabindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleVentaData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView DetalleVentaData;
        private System.Windows.Forms.Button ProcesarVenta;
        private System.Windows.Forms.ComboBox comboBoxNombrePro;
        private System.Windows.Forms.Button añadirVenta;
        private System.Windows.Forms.ComboBox comboPagos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource VentabindingSource;
        private System.Windows.Forms.BindingSource productoBinding;
        private System.Windows.Forms.BindingSource metodoBinding;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource detalleVentaBinding;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}