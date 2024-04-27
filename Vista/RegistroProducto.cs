using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class RegistroProducto : Form
    {
        public RegistroProducto()
        {
            InitializeComponent();
        }

        private void BttnGuardarProducto_Click(object sender, EventArgs e)
        {
            GuardarProducto();
        }

        private void bttnCancelarProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarProducto()
        {
            try
            {
                if(string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Se requiere nombre del producto", "Tienda Albuquerque | Registro Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    txtNombre.BackColor = Color.LightYellow;
                    return;
                }
                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("Se requiere Descripcion del producto", "Tienda Albuquerque | Registro Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescripcion.Focus();
                    txtNombre.BackColor = Color.LightYellow;
                    return;
                }
                if (string.IsNullOrEmpty(txtPrecio.Text) || Convert .ToDecimal(txtPrecio.Text) == 0)
                {
                    MessageBox.Show("Se requiere  el Precio del Producto", "Tienda Albuquerque | Registro Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrecio.Focus();
                    txtNombre.BackColor = Color.LightYellow;
                    return;
                }
                if (string.IsNullOrEmpty(txtExistencias.Text) || Convert.ToDecimal(txtExistencias.Text) == 0)
                {
                    MessageBox.Show("Se requiere numero de existencias", "Tienda Albuquerque | Registro Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtExistencias.Focus();
                    txtNombre.BackColor = Color.LightYellow;
                    return;

                }
                if (!chkEstado.Checked)
                {
                    var dialogo = MessageBox.Show("Esta seguro que desea guardar el producto inactivo?", "Tienda Albuquerque | Registro Productos",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogo != DialogResult.Yes)
                    {
                        MessageBox.Show("Seleccione el cuadro Estado como activo", "Tienda Albuquerque | Registro Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    return;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "Tienda Albuquerque | Registro Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
