using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionEntityFramework;
using SistemaGestionNegocios;
using System.ComponentModel.Design;
using System.Data.Entity.Core.Common.CommandTrees;

namespace AppSistemasWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        [HttpGet(Name = "GetUsuarios")]
        public IEnumerable<Usuario> Get()
        {

            return UsuarioBusiness.ListarUsuarios().ToArray();

        }

        [HttpDelete(Name = "EliminarCliente")]
        public void Delete([FromBody] int Id)
        {
            {
                UsuarioBusiness.eliminarUsuario(Id);
            }

        }

        [HttpPut(Name = "ModificarCliente")]
        public void Put([FromBody] Usuario usuario)
        {
            {
                UsuarioBusiness.modificarUsuario(usuario);
            }

        }

        [HttpPost(Name = "AltaCliente")]
        public void Post([FromBody] Usuario usuario)
        {
            {
                UsuarioBusiness.CrearUsuario(usuario);
            }

        }


    }
}
