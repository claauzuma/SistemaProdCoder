using SistemaGestionEntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace SistemaGestionNegocios;

public static class ProductoBusiness
{
    public static Producto buscarProdPorId(int IDproducto)
    {
       SistemaGestionContexto db = new SistemaGestionContexto();
       var productoBusc = db.Productos.Where(x => x.Id.Equals(IDproducto)).SingleOrDefault();
       return productoBusc;
    }

    public static void CrearProducto(string desc, decimal costo, decimal precioVta, decimal stock, decimal IDusu)
    {
        using (var context = new SistemaGestionContexto())
        {
            var producto = new Producto
            {
                Descripciones = desc,
                Costo = Convert.ToDouble(costo),
                PrecioVenta = Convert.ToDouble(precioVta),
                Stock = Convert.ToInt32(stock),
                IDusuario = Convert.ToInt16(IDusu)
            };

            context.Productos.Add(producto);
            context.SaveChanges();
        
        }
    }

    public static void eliminarProducto(Producto producto)
    {
        SistemaGestionContexto context = new SistemaGestionContexto();
        context.Productos.Remove(producto);
        context.SaveChanges();
    }

    public static void modificarProducto(int id, string desc, decimal costo, decimal precioVenta, decimal stock, decimal IDusuario)
    {
        SistemaGestionContexto context = new SistemaGestionContexto();
        var producto = context.Productos.Where(x => x.Id.Equals(id)).Single();
        producto.Descripciones = desc;
        producto.Costo = Convert.ToInt32(costo);
        producto.PrecioVenta = Convert.ToInt32(precioVenta);
        producto.Stock = Convert.ToInt32(stock);
        producto.IDusuario = Convert.ToInt32(IDusuario);
        context.SaveChanges();
    }

    public static List<Producto> Listar()
    {
       var db = new SistemaGestionContexto();
       var productos = db.Productos.OrderBy(p => p.Id).ToList();
       return productos;
    }
}
