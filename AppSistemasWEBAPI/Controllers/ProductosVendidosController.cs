using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionEntityFramework;
using SistemaGestionNegocios;

namespace AppSistemasWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosVendidosController : ControllerBase
    {
        [HttpGet(Name = "GetProductos")]
        public IEnumerable<ProductoVendido> Get()
        {

            return ProductoVendidoBusiness.Listar().ToArray();

        }

        [HttpDelete(Name = "EliminarProducto")]
        public void Delete([FromBody] int Id)
        {
            {
                ProductoVendidoBusiness.eliminarProducto(Id);
            }

        }

        [HttpPut(Name = "ModificarProducto")]
        public void Put([FromBody] ProductoVendido producto)
        {
            {
                ProductoVendidoBusiness.modificarProducto(producto);
            }

        }

        [HttpPost(Name = "AltaProducto")]
        public void Post([FromBody] ProductoVendido producto)
        {
            {
                ProductoVendidoBusiness.CrearProducto(producto);
            }

        }


    }


}
