namespace SistemaGestionEntityFramework
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataProductosVendidos = new TabControl();
            Usuarios = new TabPage();
            botonBuscarUsuarios = new Button();
            label8 = new Label();
            inputBuscarUsuario = new TextBox();
            botonCrearUsuario = new Button();
            label6 = new Label();
            Email = new Label();
            label4 = new Label();
            Domicilio = new Label();
            label2 = new Label();
            label1 = new Label();
            inputContraseña = new TextBox();
            inputEmail = new TextBox();
            inputTelefono = new TextBox();
            inputDomicilio = new TextBox();
            inputUsuario = new TextBox();
            inputNombreApellido = new TextBox();
            dataUsuarios = new DataGridView();
            EditarU = new DataGridViewButtonColumn();
            EliminarU = new DataGridViewButtonColumn();
            Productoss = new TabPage();
            botonCrearProducto = new Button();
            inputCosto = new NumericUpDown();
            label10 = new Label();
            Stock = new Label();
            inputIDusuario = new NumericUpDown();
            inputPrecioVenta = new NumericUpDown();
            inputStock = new NumericUpDown();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            inputDescripcion = new TextBox();
            dataProductos = new DataGridView();
            EditarP = new DataGridViewButtonColumn();
            EliminarP = new DataGridViewButtonColumn();
            tabPage1 = new TabPage();
            inputVentaPv = new NumericUpDown();
            inputProductoPV = new NumericUpDown();
            inputStockPv = new NumericUpDown();
            botonCrearProdVendido = new Button();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            dataProdVendidos = new DataGridView();
            EditarPV = new DataGridViewButtonColumn();
            EliminarPV = new DataGridViewButtonColumn();
            tabPage2 = new TabPage();
            botonCrearVenta = new Button();
            inputComentariosV = new TextBox();
            inputIdUsuarioV = new NumericUpDown();
            label14 = new Label();
            label13 = new Label();
            dataVentas = new DataGridView();
            EditarVenta = new DataGridViewButtonColumn();
            EliminarVenta = new DataGridViewButtonColumn();
            dataProductosVendidos.SuspendLayout();
            Usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataUsuarios).BeginInit();
            Productoss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputIDusuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataProductos).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputVentaPv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputProductoPV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputStockPv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataProdVendidos).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputIdUsuarioV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataVentas).BeginInit();
            SuspendLayout();
            // 
            // dataProductosVendidos
            // 
            dataProductosVendidos.Controls.Add(Usuarios);
            dataProductosVendidos.Controls.Add(Productoss);
            dataProductosVendidos.Controls.Add(tabPage1);
            dataProductosVendidos.Controls.Add(tabPage2);
            dataProductosVendidos.Location = new Point(0, 12);
            dataProductosVendidos.Name = "dataProductosVendidos";
            dataProductosVendidos.SelectedIndex = 0;
            dataProductosVendidos.Size = new Size(1040, 568);
            dataProductosVendidos.TabIndex = 0;
            // 
            // Usuarios
            // 
            Usuarios.Controls.Add(botonBuscarUsuarios);
            Usuarios.Controls.Add(label8);
            Usuarios.Controls.Add(inputBuscarUsuario);
            Usuarios.Controls.Add(botonCrearUsuario);
            Usuarios.Controls.Add(label6);
            Usuarios.Controls.Add(Email);
            Usuarios.Controls.Add(label4);
            Usuarios.Controls.Add(Domicilio);
            Usuarios.Controls.Add(label2);
            Usuarios.Controls.Add(label1);
            Usuarios.Controls.Add(inputContraseña);
            Usuarios.Controls.Add(inputEmail);
            Usuarios.Controls.Add(inputTelefono);
            Usuarios.Controls.Add(inputDomicilio);
            Usuarios.Controls.Add(inputUsuario);
            Usuarios.Controls.Add(inputNombreApellido);
            Usuarios.Controls.Add(dataUsuarios);
            Usuarios.Location = new Point(4, 24);
            Usuarios.Name = "Usuarios";
            Usuarios.Padding = new Padding(3);
            Usuarios.Size = new Size(1032, 540);
            Usuarios.TabIndex = 0;
            Usuarios.Text = "Usuarios";
            Usuarios.UseVisualStyleBackColor = true;
            Usuarios.Click += Usuarios_Click;
            // 
            // botonBuscarUsuarios
            // 
            botonBuscarUsuarios.Location = new Point(888, 45);
            botonBuscarUsuarios.Name = "botonBuscarUsuarios";
            botonBuscarUsuarios.Size = new Size(83, 23);
            botonBuscarUsuarios.TabIndex = 17;
            botonBuscarUsuarios.Text = "Buscar";
            botonBuscarUsuarios.UseVisualStyleBackColor = true;
            botonBuscarUsuarios.Click += botonBuscarUsuarios_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(606, 49);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 16;
            label8.Text = "Buscar Usuario";
            // 
            // inputBuscarUsuario
            // 
            inputBuscarUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputBuscarUsuario.Location = new Point(697, 43);
            inputBuscarUsuario.Name = "inputBuscarUsuario";
            inputBuscarUsuario.Size = new Size(185, 25);
            inputBuscarUsuario.TabIndex = 15;
            // 
            // botonCrearUsuario
            // 
            botonCrearUsuario.Location = new Point(66, 452);
            botonCrearUsuario.Name = "botonCrearUsuario";
            botonCrearUsuario.Size = new Size(117, 23);
            botonCrearUsuario.TabIndex = 13;
            botonCrearUsuario.Text = "Crear Usuario";
            botonCrearUsuario.UseVisualStyleBackColor = true;
            botonCrearUsuario.Click += botonCrearUsuario_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 393);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 12;
            label6.Text = "Contraseña";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(39, 326);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 11;
            Email.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 261);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 10;
            label4.Text = "Telefono";
            // 
            // Domicilio
            // 
            Domicilio.AutoSize = true;
            Domicilio.Location = new Point(39, 190);
            Domicilio.Name = "Domicilio";
            Domicilio.Size = new Size(58, 15);
            Domicilio.TabIndex = 9;
            Domicilio.Text = "Domicilio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 127);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 8;
            label2.Text = "Nombre Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 58);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 7;
            label1.Text = "Nombre y Apellido";
            // 
            // inputContraseña
            // 
            inputContraseña.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputContraseña.Location = new Point(39, 411);
            inputContraseña.Name = "inputContraseña";
            inputContraseña.Size = new Size(185, 25);
            inputContraseña.TabIndex = 6;
            // 
            // inputEmail
            // 
            inputEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputEmail.Location = new Point(39, 344);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(185, 25);
            inputEmail.TabIndex = 5;
            // 
            // inputTelefono
            // 
            inputTelefono.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputTelefono.Location = new Point(39, 279);
            inputTelefono.Name = "inputTelefono";
            inputTelefono.Size = new Size(185, 25);
            inputTelefono.TabIndex = 4;
            // 
            // inputDomicilio
            // 
            inputDomicilio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputDomicilio.Location = new Point(39, 208);
            inputDomicilio.Name = "inputDomicilio";
            inputDomicilio.Size = new Size(185, 25);
            inputDomicilio.TabIndex = 3;
            // 
            // inputUsuario
            // 
            inputUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputUsuario.Location = new Point(39, 145);
            inputUsuario.Name = "inputUsuario";
            inputUsuario.Size = new Size(185, 25);
            inputUsuario.TabIndex = 2;
            // 
            // inputNombreApellido
            // 
            inputNombreApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputNombreApellido.Location = new Point(39, 76);
            inputNombreApellido.Name = "inputNombreApellido";
            inputNombreApellido.Size = new Size(185, 25);
            inputNombreApellido.TabIndex = 1;
            // 
            // dataUsuarios
            // 
            dataUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataUsuarios.Columns.AddRange(new DataGridViewColumn[] { EditarU, EliminarU });
            dataUsuarios.Location = new Point(230, 76);
            dataUsuarios.Name = "dataUsuarios";
            dataUsuarios.RowTemplate.Height = 25;
            dataUsuarios.Size = new Size(796, 458);
            dataUsuarios.TabIndex = 14;
            dataUsuarios.CellContentClick += dataUsuarios_CellContentClick;
            // 
            // EditarU
            // 
            EditarU.DataPropertyName = "EditarU";
            EditarU.HeaderText = "Editar";
            EditarU.Name = "EditarU";
            // 
            // EliminarU
            // 
            EliminarU.DataPropertyName = "EliminarU";
            EliminarU.HeaderText = "Eliminar";
            EliminarU.Name = "EliminarU";
            // 
            // Productoss
            // 
            Productoss.Controls.Add(botonCrearProducto);
            Productoss.Controls.Add(inputCosto);
            Productoss.Controls.Add(label10);
            Productoss.Controls.Add(Stock);
            Productoss.Controls.Add(inputIDusuario);
            Productoss.Controls.Add(inputPrecioVenta);
            Productoss.Controls.Add(inputStock);
            Productoss.Controls.Add(label3);
            Productoss.Controls.Add(label5);
            Productoss.Controls.Add(label7);
            Productoss.Controls.Add(inputDescripcion);
            Productoss.Controls.Add(dataProductos);
            Productoss.Location = new Point(4, 24);
            Productoss.Name = "Productoss";
            Productoss.Padding = new Padding(3);
            Productoss.Size = new Size(1032, 540);
            Productoss.TabIndex = 1;
            Productoss.Text = "Productos";
            Productoss.UseVisualStyleBackColor = true;
            // 
            // botonCrearProducto
            // 
            botonCrearProducto.Location = new Point(27, 370);
            botonCrearProducto.Name = "botonCrearProducto";
            botonCrearProducto.Size = new Size(174, 23);
            botonCrearProducto.TabIndex = 23;
            botonCrearProducto.Text = "Crear Producto";
            botonCrearProducto.UseVisualStyleBackColor = true;
            botonCrearProducto.Click += botonCrearProducto_Click;
            // 
            // inputCosto
            // 
            inputCosto.Location = new Point(27, 161);
            inputCosto.Name = "inputCosto";
            inputCosto.Size = new Size(120, 23);
            inputCosto.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 310);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 21;
            label10.Text = "Id Usuario";
            // 
            // Stock
            // 
            Stock.AutoSize = true;
            Stock.Location = new Point(27, 253);
            Stock.Name = "Stock";
            Stock.Size = new Size(36, 15);
            Stock.TabIndex = 19;
            Stock.Text = "Stock";
            // 
            // inputIDusuario
            // 
            inputIDusuario.Location = new Point(27, 328);
            inputIDusuario.Name = "inputIDusuario";
            inputIDusuario.Size = new Size(120, 23);
            inputIDusuario.TabIndex = 18;
            // 
            // inputPrecioVenta
            // 
            inputPrecioVenta.Location = new Point(27, 218);
            inputPrecioVenta.Name = "inputPrecioVenta";
            inputPrecioVenta.Size = new Size(120, 23);
            inputPrecioVenta.TabIndex = 17;
            // 
            // inputStock
            // 
            inputStock.Location = new Point(27, 271);
            inputStock.Name = "inputStock";
            inputStock.Size = new Size(120, 23);
            inputStock.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 200);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 15;
            label3.Text = "Precio Venta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 143);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 14;
            label5.Text = "Costo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 88);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 13;
            label7.Text = "Descripcion";
            // 
            // inputDescripcion
            // 
            inputDescripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputDescripcion.Location = new Point(27, 106);
            inputDescripcion.Name = "inputDescripcion";
            inputDescripcion.Size = new Size(174, 25);
            inputDescripcion.TabIndex = 10;
            // 
            // dataProductos
            // 
            dataProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataProductos.Columns.AddRange(new DataGridViewColumn[] { EditarP, EliminarP });
            dataProductos.Location = new Point(218, 59);
            dataProductos.Name = "dataProductos";
            dataProductos.RowTemplate.Height = 25;
            dataProductos.Size = new Size(807, 456);
            dataProductos.TabIndex = 0;
            dataProductos.CellContentClick += dataProductos_CellContentClick;
            // 
            // EditarP
            // 
            EditarP.HeaderText = "Editar";
            EditarP.Name = "EditarP";
            EditarP.Resizable = DataGridViewTriState.True;
            EditarP.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // EliminarP
            // 
            EliminarP.HeaderText = "Eliminar";
            EliminarP.Name = "EliminarP";
            EliminarP.Resizable = DataGridViewTriState.True;
            EliminarP.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(inputVentaPv);
            tabPage1.Controls.Add(inputProductoPV);
            tabPage1.Controls.Add(inputStockPv);
            tabPage1.Controls.Add(botonCrearProdVendido);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(dataProdVendidos);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1032, 540);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "ProductosVendidos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // inputVentaPv
            // 
            inputVentaPv.Location = new Point(30, 244);
            inputVentaPv.Name = "inputVentaPv";
            inputVentaPv.Size = new Size(120, 23);
            inputVentaPv.TabIndex = 14;
            // 
            // inputProductoPV
            // 
            inputProductoPV.Location = new Point(30, 175);
            inputProductoPV.Name = "inputProductoPV";
            inputProductoPV.Size = new Size(120, 23);
            inputProductoPV.TabIndex = 13;
            // 
            // inputStockPv
            // 
            inputStockPv.Location = new Point(30, 98);
            inputStockPv.Name = "inputStockPv";
            inputStockPv.Size = new Size(120, 23);
            inputStockPv.TabIndex = 12;
            // 
            // botonCrearProdVendido
            // 
            botonCrearProdVendido.Location = new Point(21, 301);
            botonCrearProdVendido.Name = "botonCrearProdVendido";
            botonCrearProdVendido.Size = new Size(141, 39);
            botonCrearProdVendido.TabIndex = 10;
            botonCrearProdVendido.Text = "Crear Producto Vendido";
            botonCrearProdVendido.UseVisualStyleBackColor = true;
            botonCrearProdVendido.Click += botonCrearProdVendido_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(30, 226);
            label12.Name = "label12";
            label12.Size = new Size(49, 15);
            label12.TabIndex = 5;
            label12.Text = "Id Venta";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(30, 157);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 4;
            label11.Text = "Id Producto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 80);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 3;
            label9.Text = "Stock";
            // 
            // dataProdVendidos
            // 
            dataProdVendidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataProdVendidos.Columns.AddRange(new DataGridViewColumn[] { EditarPV, EliminarPV });
            dataProdVendidos.Location = new Point(184, 52);
            dataProdVendidos.Name = "dataProdVendidos";
            dataProdVendidos.RowTemplate.Height = 25;
            dataProdVendidos.Size = new Size(841, 463);
            dataProdVendidos.TabIndex = 1;
            // 
            // EditarPV
            // 
            EditarPV.HeaderText = "Editar";
            EditarPV.Name = "EditarPV";
            EditarPV.Resizable = DataGridViewTriState.True;
            EditarPV.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // EliminarPV
            // 
            EliminarPV.HeaderText = "Eliminar";
            EliminarPV.Name = "EliminarPV";
            EliminarPV.Resizable = DataGridViewTriState.True;
            EliminarPV.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(botonCrearVenta);
            tabPage2.Controls.Add(inputComentariosV);
            tabPage2.Controls.Add(inputIdUsuarioV);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(dataVentas);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1032, 540);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "Ventas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // botonCrearVenta
            // 
            botonCrearVenta.Location = new Point(36, 231);
            botonCrearVenta.Name = "botonCrearVenta";
            botonCrearVenta.Size = new Size(100, 34);
            botonCrearVenta.TabIndex = 8;
            botonCrearVenta.Text = "Crear Venta";
            botonCrearVenta.UseVisualStyleBackColor = true;
            botonCrearVenta.Click += botonCrearVenta_Click;
            // 
            // inputComentariosV
            // 
            inputComentariosV.Location = new Point(36, 95);
            inputComentariosV.Name = "inputComentariosV";
            inputComentariosV.Size = new Size(100, 23);
            inputComentariosV.TabIndex = 7;
            // 
            // inputIdUsuarioV
            // 
            inputIdUsuarioV.Location = new Point(36, 174);
            inputIdUsuarioV.Name = "inputIdUsuarioV";
            inputIdUsuarioV.Size = new Size(120, 23);
            inputIdUsuarioV.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(36, 156);
            label14.Name = "label14";
            label14.Size = new Size(60, 15);
            label14.TabIndex = 4;
            label14.Text = "Id Usuario";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(36, 77);
            label13.Name = "label13";
            label13.Size = new Size(75, 15);
            label13.TabIndex = 3;
            label13.Text = "Comentarios";
            // 
            // dataVentas
            // 
            dataVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataVentas.Columns.AddRange(new DataGridViewColumn[] { EditarVenta, EliminarVenta });
            dataVentas.Location = new Point(178, 61);
            dataVentas.Name = "dataVentas";
            dataVentas.RowTemplate.Height = 25;
            dataVentas.Size = new Size(847, 454);
            dataVentas.TabIndex = 1;
            dataVentas.CellContentClick += dataVentas_CellContentClick;
            // 
            // EditarVenta
            // 
            EditarVenta.HeaderText = "Editar";
            EditarVenta.Name = "EditarVenta";
            // 
            // EliminarVenta
            // 
            EliminarVenta.HeaderText = "Eliminar";
            EliminarVenta.Name = "EliminarVenta";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 582);
            Controls.Add(dataProductosVendidos);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            dataProductosVendidos.ResumeLayout(false);
            Usuarios.ResumeLayout(false);
            Usuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataUsuarios).EndInit();
            Productoss.ResumeLayout(false);
            Productoss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inputCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputIDusuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataProductos).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inputVentaPv).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputProductoPV).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputStockPv).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataProdVendidos).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inputIdUsuarioV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl dataProductosVendidos;
        private TabPage Usuarios;
        private DataGridView dataUsuarios;
        private TabPage Productoss;
        private DataGridView dataProductos;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox inputTelefono;
        private TextBox inputDomicilio;
        private TextBox inputUsuario;
        private TextBox inputNombreApellido;
        private Label label6;
        private Label Email;
        private Label label4;
        private Label Domicilio;
        private Label label2;
        private Label label1;
        private TextBox inputContraseña;
        private TextBox inputEmail;
        private Button botonCrearUsuario;
        private Label label3;
        private Label label5;
        private Label label7;
        private TextBox inputDescripcion;
        private NumericUpDown inputIDusuario;
        private NumericUpDown inputPrecioVenta;
        private NumericUpDown inputStock;
        private Label label10;
        private Label Stock;
        private NumericUpDown inputCosto;
        private DataGridView dataProdVendidos;
        private DataGridView dataVentas;
        private Button botonCrearProducto;
        private Label label12;
        private Label label11;
        private Label label9;
        private Button botonCrearProdVendido;
        private NumericUpDown inputVentaPv;
        private NumericUpDown inputProductoPV;
        private NumericUpDown inputStockPv;
        private Button botonCrearVenta;
        private TextBox inputComentariosV;
        private NumericUpDown inputIdUsuarioV;
        private Label label14;
        private Label label13;
        private DataGridViewButtonColumn EditarP;
        private DataGridViewButtonColumn EliminarP;
        private DataGridViewButtonColumn EditarPV;
        private DataGridViewButtonColumn EliminarPV;
        private DataGridViewButtonColumn EditarVenta;
        private DataGridViewButtonColumn EliminarVenta;
        private DataGridViewButtonColumn EditarU;
        private DataGridViewButtonColumn EliminarU;
        private Label label8;
        private TextBox inputBuscarUsuario;
        private Button botonBuscarUsuarios;
    }
}