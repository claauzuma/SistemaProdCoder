using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionEntityFramework;
using SistemaGestionNegocios;

namespace AppSistemasWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        [HttpGet(Name = "GetProductosVendidos")]
        public IEnumerable<Producto> Get()
        {
            return ProductoBusiness.Listar().ToArray();

        }

        [HttpDelete(Name = "EliminarProducto")]
        public void Delete([FromBody] int Id)
        {
            {
                ProductoBusiness.eliminarProducto(Id);
            }

        }

        [HttpPut(Name = "ModificarProducto")]
        public void Put([FromBody] Producto producto)
        {
            {
                ProductoBusiness.modificarProducto(producto);
            }

        }

        [HttpPost(Name = "AltaProducto")]
        public void Post([FromBody] Producto producto)
        {
            {
                ProductoBusiness.CrearProducto(producto);
            }

        }


    }


}

