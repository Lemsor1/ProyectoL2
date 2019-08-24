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
    public partial class FrmMenu : Form
    {

        ListaAutos _listaAutos;
        public FrmMenu()
        {
            InitializeComponent();

            _listaAutos = new ListaAutos();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu.ActiveForm.Close();
     
        }

        private void alquilarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Frmalquilar = new Form2();
            Frmalquilar.MdiParent = this;

            Frmalquilar.CargarDatos(_listaAutos);

            Frmalquilar.Show();
        }

        private void porAñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FrmReporte = new FrmReporte();
            FrmReporte.MdiParent = this;

            FrmReporte.CargarDatos(_listaAutos);
            FrmReporte.Show();
        }
    }
}
