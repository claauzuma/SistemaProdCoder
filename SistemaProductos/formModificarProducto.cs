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
    public partial class formModificarProducto : Form
    {
        private Producto producto;

        public formModificarProducto()
        {
            InitializeComponent();
        }


        public formModificarProducto(int IDproducto)
        {
            InitializeComponent();

            this.producto = new Producto();

            var db = new SistemaGestionContexto();

            //Query
            this.producto = db.Productos.Where(x => x.Id.Equals(IDproducto)).SingleOrDefault();

            inputDescrip.Text = producto.Descripciones;
            inputCosto.Value = Convert.ToDecimal(producto.Costo);
            inputPrecioVenta.Value = Convert.ToDecimal(producto.PrecioVenta);
            inputStock.Value =  Convert.ToDecimal(producto.Stock);
            inputIdUsuario.Value =  Convert.ToDecimal(producto.IDusuario);

        }

        private void label1_Click(object sender, EventArgs
            e)
        {

        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            using (var context = new SistemaGestionContexto())
            {
                var producto = context.Productos.Where(x => x.Id.Equals(this.producto.Id)).Single();
                producto.Descripciones = inputDescrip.Text;
                producto.Costo = Convert.ToInt32(inputCosto.Value);
                producto.PrecioVenta = Convert.ToInt32(inputPrecioVenta.Value);
                producto.Stock = Convert.ToInt32(inputStock.Value);
                producto.IDusuario = Convert.ToInt32(inputIdUsuario.Value);
                context.SaveChanges();
                this.Close();

            }
        }


        private void formModificarProducto_Load(object sender, EventArgs e)
        {

        }

        private void inputNombreApellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

