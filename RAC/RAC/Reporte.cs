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
            autoListaBindingSource.DataSource = listaAutos.AutoLista;
        }
    }
}
