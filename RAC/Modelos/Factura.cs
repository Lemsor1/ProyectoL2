using RAC.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAC
{
   public  class Factura
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public int ClienteId { get; set; }
        public ClientesBL Cliente { get; set; }

        public double SubTotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }

        public bool Activo { get; set; }

        public BindingList<FacturaDetalle> FacturaDetalles { get; set; }

        public void CalculartotalFactura()
        {
            var auto = new ListaAutos();
            double  subtotal = 0;

            foreach (var Producto in FacturaDetalles)
            {

                var precio = auto.ObtenerPrecio(Producto.ProdctoId);
                subtotal += Producto.CalcularTotalDetalle(precio);
            }
            SubTotal = subtotal;
            Impuesto = SubTotal - 0.15;
            Total = SubTotal + Impuesto;

        }

        public Factura()
        {
           
            Fecha = DateTime.Now;
            Activo = true;
            FacturaDetalles = new BindingList<FacturaDetalle>();
        }

         


        public class FacturaDetalle
        {
            public int Id { get; set; }
            public int ProdctoId { get; set; }
            public ListaAutos Marca { get; set; }

            public int Cantidad { get; set; }
            public double Precio { get; set; }
            public double Total { get; set; }

            public FacturaDetalle()
            {

                Cantidad = 1;
                ProdctoId = 1;

            }


            public double CalcularTotalDetalle(double precio) 
            {
                Precio = precio;

                Total = Cantidad * Precio;

                return Total;
            }



        }
    }
}
