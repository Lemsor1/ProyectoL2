using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAC
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public bool PuedeVerFactura { get; set; }
        public bool PuedeVerAuto { get; set; }
        public bool PuedeVerListaAutos { get; set; }
        public bool PuedeVerAlquilar { get; internal set; }
        public bool PuedeVerReportes { get; internal set; }

        public Usuario(int id, string nombre, string contrasena)
        {
            Id = id;
            Nombre = nombre;
            Contrasena = contrasena;
        } 
    }
}
