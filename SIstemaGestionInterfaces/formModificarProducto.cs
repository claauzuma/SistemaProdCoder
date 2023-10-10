using SistemaGestionNegocios;
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
            this.producto = ProductoBusiness.buscarProdPorId(IDproducto);
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
           ProductoBusiness.modificarProducto(this.producto.Id,inputDescrip.Text,inputCosto.Value,inputPrecioVenta.Value,
               inputStock.Value,inputIdUsuario.Value);
           this.Close();
            


        }

      

        private void formModificarProducto_Load(object sender, EventArgs e)
        {

        }

        private void inputNombreApellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

