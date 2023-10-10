using SistemaGestionEntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SistemaGestionNegocios
{
    public static class ProductoVendidoBusiness
    {
        public static void CrearProductoVendido(decimal stock, decimal productoPV, decimal ventaPv)
        {
            using (var context = new SistemaGestionContexto())
            {
                var productoVendido = new ProductoVendido
                {
                    Stock = Convert.ToInt32(stock),
                    IdProducto = Convert.ToInt32(productoPV),
                    IdVenta = Convert.ToInt32(ventaPv),
                };

                context.ProductosVendidos.Add(productoVendido);
                context.SaveChanges();
               
            }
        }

        public static List<ProductoVendido> Listar()
        {
            var db = new SistemaGestionContexto();
            var pvendidos = db.ProductosVendidos.OrderBy(p => p.Id).ToList();
            return pvendidos;
        }
    }
}
