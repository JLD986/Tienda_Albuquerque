﻿using Capa_Entidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Registro_Producto : Form
    {
        ProductoLog _productoLog;
        MarcaLog _marcaLog;
        CategoriaLog categoriaLog;
        int _id=0;
        public Registro_Producto(int id=0)
        {
            _id = id;
            InitializeComponent();

            if (_id > 0)
            {
                this.Text = "Tienda Albuquerque | Edicion de Productos";
                Guardar.Text = "Update";
                Titulo.Text = "Edicion de Productos";
                CargarDatosProdutos(_id);
            }
            else
            {
                CargarMarcas();
                CargarCategorias();
                ProductoBindingSource.MoveLast();
                ProductoBindingSource.AddNew();
            }
        }

        private void CargarDatosProdutos(int id)
        {
            _productoLog = new ProductoLog();
            ProductoBindingSource.DataSource = _productoLog.ObtenerProductoPorId(id);
            CargarMarcas();
            CargarCategorias();
        }

        private void CargarMarcas()
        {
            _marcaLog = new MarcaLog();
            List<Marca> marcas = _marcaLog.ObtenerMarcas();
            marcas.Insert(0, new Marca { idMarca = 0, Nombre = "--- Selecciona una Opción ---" });
            cbxMarca.DataSource = marcas;
            cbxMarca.SelectedIndex = 0;

        }
        private void CargarCategorias()
        {
            categoriaLog = new CategoriaLog();
            List<Categoria> categorys = categoriaLog.ObtenerCategorias();
            categorys.Insert(0, new Categoria { idCategoria = 0, Nombre = "--- Selecciona una Opción ---" });
            cbxCategoria.DataSource = categorys;
            cbxCategoria.SelectedIndex = 0;

        }
        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Guardarproducto()
        {
            try
            {
                _productoLog = new ProductoLog();

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Se Requiere Nombre del Producto", "Tienda Albuquerque | Registro Producto",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(DescripcionProducto.Text))
                {
                    MessageBox.Show("Se Requiere Descripcion del Producto", "Tienda Albuquerque | Registro Producto",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DescripcionProducto.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(Stock.Text) || Convert.ToDecimal(Stock.Text) == 0)
                {
                    MessageBox.Show("Se Requiere Existencias del Producto", "Tienda Albuquerque | Registro Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Stock.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(PrecioUni.Text) || Convert.ToDecimal(PrecioUni.Text) == 0)
                {
                    MessageBox.Show("Se Requiere Precio del Producto", "Tienda Albuquerque | Registro Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PrecioUni.Focus();
                    return;
                }
                if (!Activo.Checked)
                {
                    var dialogo = MessageBox.Show("¿Deseas Dejar El Producto Inactivo?", "Tienda Albuquerque | Registro Producto",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogo != DialogResult.Yes)
                    {
                        MessageBox.Show("Selecciona el estado como ACTIVO", "Tienda  Albuquerque | Registro Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                if (cbxMarca.SelectedIndex==0)
                {
                    MessageBox.Show("Selecciona una Marca del Producto", "Tienda Albuquerque | Registro Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cbxCategoria.SelectedIndex == 0)
                {
                    MessageBox.Show("Selecciona una Categoria del Producto", "Tienda Albuquerque | Registro Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int resultado;

                if (_id > 0)
                {
                    Producto producto;
                    producto = (Producto)ProductoBindingSource.Current;

                    resultado = _productoLog.ActualizarProducto(producto,_id);

                    if (resultado > 0)
                    {
                        MessageBox.Show("¡ EL Producto se Actualizo Exitosamente !", "Tienda Albuquerque | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error! El producto no se actualizo", "Tienda Albuquerque | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                    Producto producto;
                    producto = (Producto)ProductoBindingSource.Current;
                    resultado = _productoLog.SaveProducto(producto);

                    if (resultado > 0)
                    {
                        MessageBox.Show("¡ EL Producto se añadió Exitosamente !", "Tienda Albuquerque | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error! El producto no se guardo", "Tienda Albuquerque | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Ocurrio un error {ex.Message} :(", "Tienda Albuquerque | Registro Productos",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            Guardarproducto();
        }
    }
}
