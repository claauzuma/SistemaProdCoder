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
        public static void CrearProducto(ProductoVendido producto)
        {
            try
            {
                if (producto != null)
                {
                    var context = new SistemaGestionContexto();
                    context.ProductosVendidos.Add(producto);
                    context.SaveChanges();

                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message); 
            }
           
        }

        public static void CrearProductoVendido(decimal stock, decimal productoPV, decimal ventaPv)
        {
            try
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
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
          
        }

        public static void eliminarProducto(int id)
        {
            try {
                var context = new SistemaGestionContexto();
                var productoAEliminar = buscarProductoPorId(id);
                if (productoAEliminar != null)
                {
                    context.ProductosVendidos.Remove(productoAEliminar);
                    context.SaveChanges();
                }
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);  
            }

        }

        private static ProductoVendido buscarProductoPorId(int id)
        {
                SistemaGestionContexto db = new SistemaGestionContexto();
                var productoBusc = db.ProductosVendidos.Where(x => x.Id.Equals(id)).SingleOrDefault();
                return productoBusc;
    
        }

        public static List<ProductoVendido> Listar()
        {
            var db = new SistemaGestionContexto();
            var pvendidos = db.ProductosVendidos.OrderBy(p => p.Id).ToList();
            return pvendidos;
        }

        public static void modificarProducto(ProductoVendido producto)
        {
            try {
                if (producto != null)
                {
                    SistemaGestionContexto context = new SistemaGestionContexto();
                    var productoAModificar = buscarProductoPorId(producto.Id);
                    if (productoAModificar != null) {
                        productoAModificar = producto;
                        context.SaveChanges();
                    }
                    
                }
            } catch (Exception ex) {

                Console.WriteLine(ex.Message);
              }
           
        }
    }
}
