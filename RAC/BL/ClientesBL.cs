using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAC.BL
{
    public class ClientesBL
    {

        public BindingList<Clientes> Listaclientes { get; set; }


        public ClientesBL()
        {
            Listaclientes = new BindingList<Clientes>();
            //CrearClientes();

            var cliente1 = new Clientes();
            cliente1.Id = 1;
            cliente1.Nombre = "Juan Lopez";
            cliente1.Telefono = "98651243";
            cliente1.Ciudad = "San Pedro Sula";

            var cliente2 = new Clientes();
            cliente2.Id = 2;
            cliente2.Nombre = "Carlos Mendoza";
            cliente2.Telefono = "99562314";
            cliente2.Ciudad = "Tegucigalpa";

            var cliente3 = new Clientes();
            cliente3.Id = 3;
            cliente3.Nombre = "Maria Ramirez";
            cliente3.Telefono = "33569300";
            cliente3.Ciudad = "La Ceiba";

            var cliente4 = new Clientes();
            cliente4.Id = 4;
            cliente4.Nombre = "Carlos Slim";
            cliente4.Telefono = "97752376";
            cliente4.Ciudad = "La Lima";

            var cliente5 = new Clientes();
            cliente5.Id = 5;
            cliente5.Nombre = "David Gonzales";
            cliente5.Telefono = "95230258";
            cliente5.Ciudad = "Siguatepeque";


            Listaclientes.Add(cliente1);
            Listaclientes.Add(cliente2);
            Listaclientes.Add(cliente3);
            Listaclientes.Add(cliente4);
            Listaclientes.Add(cliente5);




        }

        //private void CrearClientes()
        //{
        //}

    }
}
