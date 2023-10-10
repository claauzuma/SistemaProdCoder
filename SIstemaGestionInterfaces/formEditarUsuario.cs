using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaGestionEntityFramework
{
    public partial class formEditarUsuario : Form
    {
        private Usuario usuario;

        public formEditarUsuario()
        {
            InitializeComponent();
        }


        public formEditarUsuario(int IDcliente)
        {
            InitializeComponent();

            this.usuario = new Usuario();

            var db = new SistemaGestionContexto();

            //Query
            this.usuario = db.Usuarios.Where(x => x.Id.Equals(IDcliente)).SingleOrDefault();

            inputNombreApellido.Text = usuario.NombreApellido;
            inputNombreUsuario.Text = usuario.NombreUsuario;
            InputDomi.Text = usuario.Domicilio;
            inputTel.Text = usuario.Telefono;
            inputEmail.Text = usuario.Email;
            inputContraseña.Text = usuario.Contrasenia;

        }

        private void label1_Click(object sender, EventArgs
            e)
        {

        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            using (var context = new SistemaGestionContexto())
            {
                var cliente = context.Usuarios.Where(x => x.Id.Equals(this.usuario.Id)).Single();
                cliente.NombreApellido = inputNombreApellido.Text;
                cliente.NombreUsuario = inputNombreUsuario.Text;
                cliente.Domicilio = InputDomi.Text;
                cliente.Telefono = inputTel.Text;
                cliente.Email = inputEmail.Text;
                cliente.Contrasenia = inputContraseña.Text;

                context.SaveChanges();
                this.Close();

            }
        }


        private void formEditarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void inputNombreApellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

