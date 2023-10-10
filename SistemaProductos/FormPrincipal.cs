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

        private void ActualizarDatosUsuarios()
        {

            var db = new SistemaGestionContexto();
            var usuarios = db.Usuarios.OrderBy(cliente => cliente.Id).ToList();
            dataUsuarios.DataSource = null;
            dataUsuarios.DataSource = usuarios;

        }

        private void ActualizarDatosProductos()
        {

            var db = new SistemaGestionContexto();
            var productos = db.Productos.OrderBy(p => p.Id).ToList();
            dataProductos.DataSource = null;
            dataProductos.DataSource = productos;

        }

        private void ActualizarDatosProductosVendidos()
        {

            var db = new SistemaGestionContexto();
            var pvendidos = db.ProductosVendidos.OrderBy(p => p.Id).ToList();
            dataProdVendidos.DataSource = null;
            dataProdVendidos.DataSource = pvendidos;

        }

        private void ActualizarDatosVentas()
        {

            var db = new SistemaGestionContexto();
            var ventas = db.Ventas.OrderBy(p => p.Id).ToList();
            dataVentas.DataSource = null;
            dataVentas.DataSource = ventas;

        }




        private void Productos_Click(object sender, EventArgs e)
        {



        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //Instanciamos un objeto del Contexto
            var db = new SistemaGestionContexto();

            //Query . //Ordenar los clientes por ID y luego listarlos, se los pasamos a clientes
            var usuarios = db.Usuarios.OrderBy(usuario => usuario.Id).ToList();

            //Generamos las columnas del datagriedview automaticamente
            dataUsuarios.AutoGenerateColumns = true;
            dataUsuarios.DataSource = usuarios;

            var productos = db.Productos.OrderBy(p => p.Id).ToList();
            dataProductos.AutoGenerateColumns = true;
            dataProductos.DataSource = productos;

            var ventas = db.Ventas.OrderBy(v => v.Id).ToList();
            dataVentas.AutoGenerateColumns = true;
            dataVentas.DataSource = ventas;

            var prodVendidos = db.ProductosVendidos.OrderBy(pv => pv.Id).ToList();
            dataProdVendidos.AutoGenerateColumns = true;
            dataProdVendidos.DataSource = prodVendidos;


        }

        private void botonCrearUsuario_Click(object sender, EventArgs e)
        {
            using (var context = new SistemaGestionContexto())
            {

                var cliente = new Usuario
                {
                    NombreApellido = inputNombreApellido.Text,
                    Domicilio = inputDomicilio.Text,
                    Telefono = inputTelefono.Text,
                    NombreUsuario = inputUsuario.Text,
                    Contrasenia = inputContraseña.Text,
                    Email = inputEmail.Text
                };

                context.Usuarios.Add(cliente);
                context.SaveChanges();
                this.ActualizarDatosUsuarios();

            }
        }

        private void botonCrearProducto_Click(object sender, EventArgs e)
        {
            using (var context = new SistemaGestionContexto())
            {
                var producto = new Producto
                {
                    Descripciones = inputDescripcion.Text,
                    Costo = Convert.ToDouble(inputCosto.Value),
                    PrecioVenta = Convert.ToDouble(inputPrecioVenta.Value),
                    Stock = Convert.ToInt32(inputStock.Value),
                    IDusuario = Convert.ToInt16(inputIDusuario.Value)
                };

                context.Productos.Add(producto);
                context.SaveChanges();
                this.ActualizarDatosProductos();
            }
        }

        private void Productoss_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void botonCrearProdVendido_Click(object sender, EventArgs e)
        {
            using (var context = new SistemaGestionContexto())
            {
                var productoVendido = new ProductoVendido
                {
                    Stock = Convert.ToInt32(inputStockPv.Value),
                    IdProducto = Convert.ToInt32(inputProductoPV.Value),
                    IdVenta = Convert.ToInt32(inputVentaPv.Value),
                };

                context.ProductosVendidos.Add(productoVendido);
                context.SaveChanges();
                this.ActualizarDatosProductosVendidos();
            }
        }

        private void botonCrearVenta_Click(object sender, EventArgs e)
        {
            using (var context = new SistemaGestionContexto())
            {
                var venta = new Venta
                {
                    Coementarios = inputComentariosV.Text,
                    IdUsuario = Convert.ToInt32(inputIdUsuarioV.Value),

                };

                context.Ventas.Add(venta);
                context.SaveChanges();
                this.ActualizarDatosVentas();



            }




        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void dataUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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


                SistemaGestionContexto context = new SistemaGestionContexto();

                var usuario = context.Usuarios.Where(x => x.Id.Equals(codigo)).SingleOrDefault();
                if (usuario != null)
                {
                    DialogResult r = MessageBox.Show("Estas seguro de eliminar a " + usuario.NombreApellido, "Eliminacion", MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)
                    {
                        context.Usuarios.Remove(usuario);
                        context.SaveChanges();

                        this.dataUsuarios.DataSource = null;
                        this.ActualizarDatosUsuarios();
                    }


                }
            }

        }

        private void dataProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                var producto = context.Productos.Where(x => x.Id.Equals(codigo)).SingleOrDefault();
                if (producto != null)
                {
                    DialogResult r = MessageBox.Show("Estas seguro de eliminar a " + producto.Descripciones, "Eliminacion", MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)
                    {
                        context.Productos.Remove(producto);
                        context.SaveChanges();
                        this.ActualizarDatosProductos();
                    }


                }
            }




        }
    }




}
