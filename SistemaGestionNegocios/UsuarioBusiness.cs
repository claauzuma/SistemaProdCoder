using SistemaGestionEntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace SistemaGestionNegocios
{
    public static class UsuarioBusiness
    {
 

        public static Usuario buscarUsuarioPorId(int idCLiente)
        {
           var db = new SistemaGestionContexto();
           var usuarioBuscado =  db.Usuarios.Where(x => x.Id.Equals(idCLiente)).SingleOrDefault();
           return usuarioBuscado;
        }


        public static List<Usuario> buscarUsuariosPorNombre(string usuarioBuscado)
        {
            SistemaGestionContexto contexto = new SistemaGestionContexto();
            var usuarios = contexto.Usuarios.Where(x => x.NombreApellido.Contains(usuarioBuscado)
            ).ToList();
            return usuarios;

        }

        public static void CrearUsuario(string nombre, string domicilio, string telefono, string nUsuario, string contra, string email)
        {
            using (var context = new SistemaGestionContexto())
            {

                var usuario = new Usuario
                {
                    NombreApellido = nombre,
                    Domicilio = domicilio,
                    Telefono = telefono,
                    NombreUsuario = nUsuario,
                    Contrasenia = contra,
                    Email = email
                };

                context.Usuarios.Add(usuario);
                context.SaveChanges();

            }

        }

        public static void eliminarUsuario(Usuario usuario)
        {
            SistemaGestionContexto context = new SistemaGestionContexto();
            context.Usuarios.Remove(usuario);
            context.SaveChanges();
        }

        public static Usuario guardarUsuario(int Id)
        {
            SistemaGestionContexto context = new SistemaGestionContexto();
            var Usuario = context.Usuarios.Where(x => x.Id.Equals(Id)).Single();
            return Usuario;
        }

        public static List<Usuario> ListarUsuarios()
        {
            SistemaGestionContexto db = new SistemaGestionContexto();
            var usuarios = db.Usuarios.OrderBy(cliente => cliente.Id).ToList();
            return usuarios;
        }
    }
}
