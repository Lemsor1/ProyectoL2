using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RAC.BL;

namespace RAC
{
    public partial class FrmFacturas : Form
    {
        FacturaBL _facturaBL;

        public FrmFacturas()
        {
            InitializeComponent();
        }


        public void CargarDatos(ListaAutos lista, FacturaBL facturasBL,Factura listadetalles,ClientesBL clientes)
        {

            _facturaBL = facturasBL;

            autoListaBindingSource.DataSource = lista.AutoLista;

            listadeFacturasBindingSource.DataSource = facturasBL.ListadeFacturas;
          
            clientesBLBindingSource.DataSource = clientes.Listaclientes;

        }

        private void factura_FacturaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var factura =(Factura)listadeFacturasBindingSource.Current;
            factura.CalculartotalFactura();
            listadeFacturasBindingSource.ResetBindings(false);
        }

        private void factura_FacturaDetalleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmFacturas_Load(object sender, EventArgs e)
        {
            
        }
    }
}
