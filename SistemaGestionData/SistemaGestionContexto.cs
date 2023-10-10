using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SistemaGestionEntityFramework
{
    public class SistemaGestionContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }  
        public DbSet<Venta> Ventas { get; set; }    
        public DbSet<ProductoVendido> ProductosVendidos { get; set; }   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
               @"Server=(localdb)\mssqllocaldb;DataBase=SistemaGestionEF;Trusted_Connection=true");
               //@"Server=DESKTOP-8LB3ANG;DataBase=SistemaGestionEF;Trusted_Connection=true");
        }



       

    }
}
