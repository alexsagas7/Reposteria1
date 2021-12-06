using BL.Reposteria;
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
    public partial class FormReportedeProductos : Form
    {
        public FormReportedeProductos()
        {
            InitializeComponent();
            var _productoBL = new ProductosBL();
            var BindingSource = new BindingSource();
            BindingSource.DataSource = _productoBL.ObtenerProductos();

            var reporte = new ReporteProducto();
            reporte.SetDataSource(BindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }

        private void FormReportedeProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
