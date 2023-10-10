using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntityFramework
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreApellido { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string NombreUsuario { get; set; }   
        public string Contrasenia { get; set; } 
        public string Email { get; set; }   


    }
}
