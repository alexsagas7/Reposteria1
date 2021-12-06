using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Pasteleria
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            var Formlogin = new FormLogin();
            Formlogin.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormProductos = new FormProductos();
            FormProductos.MdiParent = this;
            FormProductos.Show();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormClientes = new FormClientes();
            FormClientes.MdiParent = this;
            FormClientes.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormProveedores = new FormProveedores();
            FormProveedores.MdiParent = this;
            FormProveedores.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            login();

        }

        private void reporteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormReportedeProductos = new FormReportedeProductos();
           FormReportedeProductos.MdiParent = this;
            FormReportedeProductos.Show();

        }

        private void reporteDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormReporteDeClientes = new FormReporteDeClientes();
            FormReporteDeClientes.MdiParent = this;
            FormReporteDeClientes.Show();
        }

       
              private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new FormFactura();
            formFactura.MdiParent = this;
            formFactura.Show();
        }

        private void reporteDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormReporteDeFacturas = new FormReporteDeFacturas();
            FormReporteDeFacturas.MdiParent = this;
            FormReporteDeFacturas.Show();

        }
    }
}
