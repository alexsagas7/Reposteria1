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
    public partial class FormReporteDeFacturas : Form
    {
        public FormReporteDeFacturas()
        {
            InitializeComponent();
            var _facturasBL = new FacturaBL();
            var BindingSource = new BindingSource();
            BindingSource.DataSource = _facturasBL.ObtenerFacturas();

            var reporte = new Reporte_Facturas ();
            reporte.SetDataSource(BindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
