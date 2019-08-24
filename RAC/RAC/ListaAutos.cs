using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAC
{
   public class ListaAutos
    {
       public List<Auto> AutoLista { get; set; }


       public ListaAutos()
       {
           AutoLista = new List<Auto>();
           CrearLista();
       }



        private void CrearLista()
        {
            var auto1 = new Auto();
            auto1.Id = 1;
            auto1.Marca = "Toyota";
            auto1.Modelo = "Corolla";
            auto1.Año = "2000";
            auto1.Estado = "Disponible";


            var auto2 = new Auto();
            auto2.Id = 2;
            auto2.Marca = "Ford";
            auto2.Modelo = "Escape";
            auto2.Año = "2010";
            auto2.Estado= "Disponible";


            var auto3 = new Auto();
            auto3.Id = 3;
            auto3.Marca = "Honda";
            auto3.Modelo = "Civic";
            auto3.Año = "2015";
            auto3.Estado= "Disponible";


            AutoLista.Add(auto1);
            AutoLista.Add(auto2);
            AutoLista.Add(auto3);
           }
   
        

       }
}
