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
    public partial class FormReporteDeClientes : Form
    {
        public FormReporteDeClientes()
        {
            InitializeComponent();
            var _clientesBL = new ClientesBL();
            var BindingSource = new BindingSource();
            BindingSource.DataSource = _clientesBL.ObtenerClientes();

            var reporte = new ReporteClientes();
            reporte.SetDataSource(BindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
