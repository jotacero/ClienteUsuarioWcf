using System.Collections.Generic;
using System.Runtime.Serialization;

namespace UsuarioWcf.Modelo.UsuarioDto
{
    [DataContract]
    public class UsuarioDto
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public int edad { get; set; }

        public Usuario ToUsuario()
        {
            var us = new Usuario()
            {
                id = id,
                nombre = nombre,
                edad = edad
            };
            return us;
        }

        public static List<UsuarioDto> FromListUsuario(List<Usuario> lista)
        {
            var l = new List<UsuarioDto>();
            foreach (var item in lista)
            {
                l.Add(UsuarioDto.FromUsuario(item));
            }
            return l;
        }

        public static UsuarioDto FromUsuario(Usuario us)
        {
            var usdto =new UsuarioDto();
            usdto.id = us.id;
            usdto.nombre = us.nombre;
            usdto.edad = us.edad;
            return usdto;
        }
    }

}