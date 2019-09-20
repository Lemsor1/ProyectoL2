using RAC.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAC
{
    public partial class FrmReporteVentas : Form
    {
        public FrmReporteVentas()
        {
            InitializeComponent();
        }

        public void CargarDatos(FacturaBL facturaBL,ClientesBL clientesBl)
        {

            var bindingSource = new BindingSource();
            bindingSource.DataSource =
                from f in facturaBL.ListadeFacturas
                select new
                {
                   Id = f.Id,
                   Fecha=f.Fecha,
                   Cliente=clientesBl.Listaclientes.FirstOrDefault(r=>r.Id==f.ClienteId).Nombre,
                   SubTotal=f.SubTotal,
                   Impuesto=f.Impuesto,
                   Total=f.Total
                };

            var reporte = new ReporteFacturas();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
           

        }
    }
}
