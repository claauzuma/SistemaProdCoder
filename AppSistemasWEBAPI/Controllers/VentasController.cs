using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionEntityFramework;
using SistemaGestionNegocios;

namespace AppSistemasWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        [HttpGet(Name = "GetVentas")]
        public IEnumerable<Venta> Get()
        {

            return VentaBusiness.Listar().ToArray();

        }

        [HttpDelete(Name = "EliminarVenta")]
        public void Delete([FromBody] int Id)
        {
            {
                VentaBusiness.eliminarVenta(Id);
            }

        }

        [HttpPut(Name = "ModificarVenta")]
        public void Put([FromBody] Venta venta)
        {
            {
                VentaBusiness.modificarVenta(venta);
            }

        }

        [HttpPost(Name = "AltaVenta")]
        public void Post([FromBody] Venta venta)
        {
            {
                VentaBusiness.CrearVenta(venta);
            }

        }


    }


}