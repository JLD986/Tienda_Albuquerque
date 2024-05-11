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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MnMttnProductos_Click(object sender, EventArgs e)
        {
             MantenimientoProduto objMttProducto = new MantenimientoProduto ();
            objMttProducto.ShowDialog();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MnRegistroVenta_Click(object sender, EventArgs e)
        {

        }
    }
}
