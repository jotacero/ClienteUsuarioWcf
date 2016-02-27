using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using UsuarioWcf.Modelo.UsuarioDto;

namespace UsuarioWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioUsuario" in both code and config file together.
    [ServiceContract]
    public interface IServicioUsuario
    {
        [OperationContract]
        UsuarioDto GetUsuario(int id);

        [OperationContract]
        List<UsuarioDto> GetAllUsuarios();

        [OperationContract]
        void AddUsuario(UsuarioDto usuarioDto);

    }
}
