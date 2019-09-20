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
    public partial class FrmMenu : Form
    {

       ListaAutos _listaAutos;
       FacturaBL _facturabl;
       ClientesBL _clientes;
       Factura _facturadetalles;
       UsuariosBL _usuariosBL;



        public FrmMenu()
        {
            InitializeComponent();

            _listaAutos = new ListaAutos();
            _facturabl = new FacturaBL();
            _clientes = new ClientesBL();
            _facturadetalles = new Factura();
            _usuariosBL = new BL.UsuariosBL();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu.ActiveForm.Close();
     
        }

        private void alquilarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Frmalquilar = new FrmFacturas();
            Frmalquilar.MdiParent = this;

            Frmalquilar.CargarDatos(_listaAutos,_facturabl,_facturadetalles,_clientes);

            Frmalquilar.Show();
        }

        private void porAñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FrmReporte = new FrmReporte();
            FrmReporte.MdiParent = this;

            FrmReporte.CargarDatos(_listaAutos);
            FrmReporte.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            var login = new login();
            login.CargarDatos(_usuariosBL);
            login.ShowDialog();

            autosToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerAuto;
            facturasToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerFactura;
            alquilarToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerAlquilar;
            porAñoToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerListaAutos;
            reportesToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerReportes;

        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmreporteVentas = new FrmReporteVentas();

            frmreporteVentas.CargarDatos(_facturabl,_clientes);

            frmreporteVentas.MdiParent = this;
            frmreporteVentas.Show();

        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void autosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var FrmAutos = new Form2();

            FrmAutos.CargarDatos( _listaAutos);

            FrmAutos.MdiParent = this;
            FrmAutos.Show();

        }
    }
}
