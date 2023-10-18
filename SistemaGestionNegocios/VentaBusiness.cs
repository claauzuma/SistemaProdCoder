using SistemaGestionEntityFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaGestionNegocios
{
    public class VentaBusiness
    {
        public static void CrearVenta(string coment, decimal IDusuarioV)
        {

            using (var context = new SistemaGestionContexto())
            {
                var venta = new Venta
                {
                    Coementarios = coment,
                    IdUsuario = Convert.ToInt32(IDusuarioV),

                };
                context.Ventas.Add(venta);
                context.SaveChanges();
            }
        }

        public static void CrearVenta(Venta venta)
        {
            try {
                    var context = new SistemaGestionContexto();
                    context.Ventas.Add(venta);
                    context.SaveChanges();
               
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public static void eliminarVenta(int id)
        {
            try {
                var context = new SistemaGestionContexto();
                var venta = buscarVentaPorId(id);
                context.Ventas.Remove(venta);
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static Venta buscarVentaPorId(int id)
        {
            var db = new SistemaGestionContexto();
            var ventaBuscada = db.Ventas.Where(x => x.Id.Equals(id)).SingleOrDefault();
            return ventaBuscada;

        }

        public static List<Venta> Listar()
        {
            var db = new SistemaGestionContexto();
            var ventas = db.Ventas.OrderBy(p => p.Id).ToList();
            return ventas;
        }

        public static void modificarVenta(Venta venta)
        {
            try {
                SistemaGestionContexto context = new SistemaGestionContexto();
                var ventaAEliminar = buscarVentaPorId(venta.Id);
                ventaAEliminar = venta;
                context.SaveChanges();
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           


        }
    }
}
