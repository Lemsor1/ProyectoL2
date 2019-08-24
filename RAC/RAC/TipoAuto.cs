using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAC
{
    public class TipoAuto:Auto
    {

        public bool Camioneta { get; set; }
        public bool Turismo { get; set; }


        public TipoAuto()
        {

            var Auto1 = new TipoAuto();
            Auto1.Camioneta = false;
            Auto1.Id = 1;
            Auto1.Marca = "Toyota";
            Auto1.Modelo = "Corolla";

            var Auto2 = new TipoAuto();
            Auto2.Camioneta = true;
            Auto2.Id = 2;
            Auto2.Marca = "Ford";
            Auto2.Modelo = "Explorer";

            var Auto3 = new TipoAuto();
            Auto3.Camioneta = true;
            Auto3.Id = 3;
            Auto3.Marca = "Honda";
            Auto3.Modelo = "Civic";




        }

    }
}
