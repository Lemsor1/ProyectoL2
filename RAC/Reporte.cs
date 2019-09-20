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
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();

            //var listaAutos = new ListaAutos();
            //autoListaBindingSource.DataSource = listaAutos.AutoLista; 
        }

        public void CargarDatos(ListaAutos listaAutos)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource =
                from p in listaAutos.AutoLista
                select new {
                    Foto=p.Foto,
                    Id = p.Id,
                    Marca = p.Marca,
                    Modelo = p.Modelo,
                    Ano = p.Año,
                    Precio = p.Precio
                };

                                  var reporte = new ReporteProductos();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();





        }
    }
}
