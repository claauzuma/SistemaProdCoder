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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void AutoGenerarColumnas(DataGridView data)
        {
            data.AutoGenerateColumns = true;
        }

        private void ActualizarDatosUsuarios()
        {
            {
                try
                {
                    var usuarios = UsuarioBusiness.ListarUsuarios();
                    dataUsuarios.DataSource = null;
                    dataUsuarios.DataSource = usuarios;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void ActualizarDatosProductos()
        {
            {
                try
                {
                    var productos = ProductoBusiness.Listar();
                    dataProductos.DataSource = null;
                    dataProductos.DataSource = productos;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        private void ActualizarDatosProductosVendidos()
        {
            {
                try
                {
                    var productosVend = ProductoVendidoBusiness.Listar();
                    dataProdVendidos.DataSource = null;
                    dataProdVendidos.DataSource = productosVend;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        private void ActualizarDatosVentas()
        {
            {
                try
                {
                    var ventas = VentaBusiness.Listar();
                    dataVentas.DataSource = null;
                    dataVentas.DataSource = ventas;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                var usuarios = UsuarioBusiness.ListarUsuarios();
                this.AutoGenerarColumnas(dataUsuarios);
                dataUsuarios.DataSource = usuarios;

                var productos = ProductoBusiness.Listar();
                this.AutoGenerarColumnas(dataProductos);
                dataProductos.DataSource = productos;

                var ventas = VentaBusiness.Listar();
                this.AutoGenerarColumnas(dataVentas);
                dataVentas.DataSource = ventas;

                var prodVend = ProductoVendidoBusiness.Listar();
                this.AutoGenerarColumnas(dataProdVendidos);
                dataProdVendidos.DataSource = prodVend;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hola");
                Console.WriteLine(ex.Message);
            }

        }

        private void botonCrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBusiness.CrearUsuario(inputNombreApellido.Text, inputDomicilio.Text, inputTelefono.Text, inputUsuario.Text, inputContraseña.Text,
                inputEmail.Text);
                ActualizarDatosUsuarios();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void botonCrearProducto_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoBusiness.CrearProducto(inputDescripcion.Text, inputCosto.Value, inputPrecioVenta.Value, inputStock.Value, inputIDusuario.Value);
                this.ActualizarDatosProductos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void botonCrearProdVendido_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoVendidoBusiness.CrearProductoVendido(inputStockPv.Value, inputProductoPV.Value, inputVentaPv.Value);
                this.ActualizarDatosProductosVendidos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void botonCrearVenta_Click(object sender, EventArgs e)
        {
            try
            {
                VentaBusiness.CrearVenta(inputComentariosV.Text, inputIdUsuarioV.Value);
                this.ActualizarDatosVentas();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        private void dataVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

                if (this.dataVentas.Columns[e.ColumnIndex].Name == "EditarVenta")
                {

                    int codigo = (int)this.dataVentas.Rows[e.RowIndex].Cells["Id"].Value;
                    this.dataVentas.DataSource = null;
                    this.ActualizarDatosVentas();
                }
                if (this.dataVentas.Columns[e.ColumnIndex].Name == "EliminarVenta")
                {
                    int codigo = (int)this.dataVentas.Rows[e.RowIndex].Cells["Id"].Value;


                    SistemaGestionContexto context = new SistemaGestionContexto();

                    var venta = context.Ventas.Where(x => x.Id.Equals(codigo)).SingleOrDefault();
                    if (venta != null)
                    {
                        DialogResult r = MessageBox.Show("Estas seguro de eliminar la venta", "Eliminacion", MessageBoxButtons.YesNo);
                        if (r == DialogResult.Yes)
                        {
                            context.Ventas.Remove(venta);
                            context.SaveChanges();

                            this.dataVentas.DataSource = null;
                            this.ActualizarDatosVentas();
                        }


                    }
                }

            }

            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
                

            }
            

        private void dataUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

                if (this.dataUsuarios.Columns[e.ColumnIndex].Name == "EditarU")
                {

                    int codigo = (int)this.dataUsuarios.Rows[e.RowIndex].Cells["Id"].Value;
                    formEditarUsuario editar = new formEditarUsuario(codigo);
                    this.Hide();
                    editar.ShowDialog();
                    this.Show();

                    this.dataUsuarios.DataSource = null;
                    this.ActualizarDatosUsuarios();
                }
                if (this.dataUsuarios.Columns[e.ColumnIndex].Name == "EliminarU")
                {
                    int codigo = (int)this.dataUsuarios.Rows[e.RowIndex].Cells["Id"].Value;
                    var usuario = UsuarioBusiness.buscarUsuarioPorId(codigo);
                    if (usuario != null)
                    {
                        DialogResult r = MessageBox.Show("Estas seguro de eliminar a " + usuario.NombreApellido, "Eliminacion", MessageBoxButtons.YesNo);
                        if (r == DialogResult.Yes)
                        {
                            UsuarioBusiness.eliminarUsuario(usuario);
                            this.dataUsuarios.DataSource = null;
                            this.ActualizarDatosUsuarios();
                        }
                    }
                }

            }
            catch(Exception ex) { 
                Console.WriteLine(ex.Message);  
            
            }

            

        }

        private void dataProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

                if (this.dataProductos.Columns[e.ColumnIndex].Name == "EditarP")
                {

                    int codigo = (int)this.dataProductos.Rows[e.RowIndex].Cells["Id"].Value;
                    formModificarProducto editar = new formModificarProducto(codigo);
                    this.Hide();
                    editar.ShowDialog();
                    this.Show();
                    this.ActualizarDatosProductos();
                }
                if (this.dataProductos.Columns[e.ColumnIndex].Name == "EliminarP")
                {
                    int codigo = (int)this.dataProductos.Rows[e.RowIndex].Cells["Id"].Value;


                    SistemaGestionContexto context = new SistemaGestionContexto();

                    var producto = ProductoBusiness.buscarProdPorId(codigo);
                    if (producto != null)
                    {
                        DialogResult r = MessageBox.Show("Estas seguro de eliminar a " + producto.Descripciones, "Eliminacion", MessageBoxButtons.YesNo);
                        if (r == DialogResult.Yes)
                        {
                            ProductoBusiness.eliminarProducto(producto);
                            this.ActualizarDatosProductos();
                        }


                    }
                }


            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            

        }


        private void botonBuscarUsuarios_Click(object sender, EventArgs e)
        {
            try {
                dataUsuarios.DataSource = null;
                var usuarios = UsuarioBusiness.buscarUsuariosPorNombre(inputBuscarUsuario.Text);
                dataUsuarios.DataSource = usuarios;
            }
            catch(Exception ex) { 
                Console.WriteLine(ex.Message);  
            
            }
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {

        }
    }




}
