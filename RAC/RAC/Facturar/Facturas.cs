using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAC.Facturar
{
   public class Facturas
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public int ClienteID { get; set; }
        public Clientes Clientes { get; set; }

        public double Subtotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }

        public Bindinglist<FacturaDetalle> FacturaDetalle { get; set; }



        public Facturas()
        {
            Fecha = DateTime.Now;
            FacturaDetalle = new Bindinglist<FacturaDetalle>();

        }

        public class FacturaDetalle
        {
            public int Id { get; set; }
            public int ProductoID { get; set; }
            public Clientes Clientes { get; set; }
            public int Cantidad { get; set; }
            public double Precio { get; set; }
            public double Total { get; set; }

            public FacturaDetalle()
            {
                Cantidad = 1;
            }


        }



    }
}
