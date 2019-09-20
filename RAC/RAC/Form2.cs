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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            //var listaAutos = new ListaAutos();
            //dataGridView1.DataSource  = listaAutos.AutoLista; 
        }

        public void CargarDatos(ListaAutos listaAutos)
        {
            dataGridView1.DataSource = listaAutos.AutoLista;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Se alquilara el auto, Desea continuar?","Confirmacion",MessageBoxButtons .YesNo )==DialogResult .Yes )    
            {

            }

        }

       
    }
}
