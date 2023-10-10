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

     

        public static List<Venta> Listar()
        {
            var db = new SistemaGestionContexto();
            var ventas = db.Ventas.OrderBy(p => p.Id).ToList();
            return ventas;
        }
    }
}
