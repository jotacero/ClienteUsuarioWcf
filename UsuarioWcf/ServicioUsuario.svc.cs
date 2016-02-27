using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using UsuarioWcf.Modelo;
using UsuarioWcf.Modelo.UsuarioDto;

namespace UsuarioWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioUsuario" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicioUsuario.svc or ServicioUsuario.svc.cs at the Solution Explorer and start debugging.
    public class ServicioUsuario : IServicioUsuario
    {
        public UsuarioDto GetUsuario(int id)
        {
            using (var db = new UsuarioEntities())
            {
                var usuario = db.Usuario.Find(id);
                var usuarioDto = UsuarioDto.FromUsuario(usuario);
                return usuarioDto;
            }
        }

        public List<UsuarioDto> GetAllUsuarios()
        {
            using (var db = new UsuarioEntities())
            {
                var usuarioDto = UsuarioDto.FromListUsuario(db.Usuario.ToList());
                return usuarioDto;
            }
        }

        public void AddUsuario(UsuarioDto usuarioDto)
        {
            var usuario = usuarioDto.ToUsuario();
            using (var db = new UsuarioEntities())
            {
                db.Usuario.Add(usuario);
                db.SaveChanges();
            }
        }
    }
}
