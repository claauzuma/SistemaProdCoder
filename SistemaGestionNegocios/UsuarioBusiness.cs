using SistemaGestionEntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            var usuarios = contexto.Usuarios.Where(x => x.NombreUsuario.Contains(usuarioBuscado)
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

        public static void CrearUsuario(Usuario usuario)
        {
            try {
                SistemaGestionContexto context = new SistemaGestionContexto();
                if (usuario != null)
                {
                    context.Usuarios.Add(usuario);
                }
                else {
                    throw new Exception("El usuario no puede ser nulo");
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public static void eliminarUsuario(Usuario usuario)
        {
            try {
                SistemaGestionContexto context = new SistemaGestionContexto();
                context.Usuarios.Remove(usuario);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void eliminarUsuario(int id)
        {
            try {
                SistemaGestionContexto context = new SistemaGestionContexto();
                var usuario = context.Usuarios.Where(x => x.Id.Equals(id)).Single();
                context.Usuarios.Remove(usuario);
                context.SaveChanges();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            
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

        public static void modificarUsuario(Usuario usuario)
        {
            try {
                SistemaGestionContexto db = new SistemaGestionContexto();
                var usuarioAModificar = buscarUsuarioPorId(usuario.Id);
                    usuarioAModificar.NombreUsuario = usuario.NombreUsuario;
                    usuarioAModificar.Domicilio = usuario.Domicilio;
                    usuarioAModificar.Contrasenia = usuario.Contrasenia;
                    usuarioAModificar.Email = usuario.Email;
                    usuarioAModificar.NombreApellido = usuario.NombreApellido;
                    db.SaveChanges();
                }
             catch 

        (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            

        }

        public static List<Usuario> buscarUsuariosPorNombreYApellido(string nombreYApellido)
        {
            SistemaGestionContexto contexto = new SistemaGestionContexto();
            var usuarios = contexto.Usuarios.Where(x => x.NombreApellido.Contains(nombreYApellido)
            ).ToList();
            return usuarios;
        }

        public static List<Usuario> buscarUsuariosPorNombreyUsuario(string nombre, string usuario)
        {

            SistemaGestionContexto contexto = new SistemaGestionContexto();
            var usuarios = contexto.Usuarios.Where(x => x.NombreApellido.Contains(nombre) && x.NombreUsuario.Contains(usuario)).ToList();
            return usuarios;
        }
    }
}
