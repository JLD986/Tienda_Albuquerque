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
    public partial class MantenimientoProduto : Form
    {
        public MantenimientoProduto()
        {
            InitializeComponent();
        }

        private void BttnnuevoProducto_Click(object sender, EventArgs e)
        {
            RegistroProducto objRegistroproducto = new RegistroProducto();
            objRegistroproducto.ShowDialog();
        }

        private void bttnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
