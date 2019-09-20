using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace RAC.BL
{
    public class UsuariosBL
    {
        public BindingList <Usuario> ListadeUsuarios { get; set; } 

        public UsuariosBL()
        {
            ListadeUsuarios = new BindingList<Usuario>();
            CargarDatosdePrueba();
        }
        private void CargarDatosdePrueba()
        {
            var usuarioAdmin = new Usuario(1, "admin", "1234");
            usuarioAdmin.PuedeVerFactura = true;
            usuarioAdmin.PuedeVerListaAutos = true;
            usuarioAdmin.PuedeVerAuto = true;
            usuarioAdmin.PuedeVerAlquilar = true;
            usuarioAdmin.PuedeVerReportes = true;

            var UsuarioCaja = new Usuario(2, "cajero", "4321");
            UsuarioCaja.PuedeVerAuto = true;
            UsuarioCaja.PuedeVerListaAutos = true;
            UsuarioCaja.PuedeVerReportes = true;
            UsuarioCaja.PuedeVerAlquilar = true;

            ListadeUsuarios.Add(usuarioAdmin);
            ListadeUsuarios.Add(UsuarioCaja);
        }

        internal object Autenticar(string nombre, object p1, string contrasena, object p2)
        {
            throw new NotImplementedException();
        }

        public Usuario Autenticar(string nombre, string contrasena)
        {
            foreach (var usuario in ListadeUsuarios)
            {
                if (usuario.Nombre == nombre && usuario.Contrasena == contrasena)
                {
                    return usuario;
                }
            }

            return null;
        }
            
        }
    }

