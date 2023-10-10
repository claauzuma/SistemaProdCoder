namespace SistemaGestionEntityFramework
{
    partial class formModificarProducto
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
            botonGuardar = new Button();
            label1 = new Label();
            inputDescrip = new TextBox();
            inputCosto = new NumericUpDown();
            inputPrecioVenta = new NumericUpDown();
            inputStock = new NumericUpDown();
            inputIdUsuario = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            inputDescripciones = new Label();
            ((System.ComponentModel.ISupportInitialize)inputCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputIdUsuario).BeginInit();
            SuspendLayout();
            // 
            // botonGuardar
            // 
            botonGuardar.Location = new Point(189, 370);
            botonGuardar.Name = "botonGuardar";
            botonGuardar.Size = new Size(115, 28);
            botonGuardar.TabIndex = 0;
            botonGuardar.Text = "Guardar";
            botonGuardar.UseVisualStyleBackColor = true;
            botonGuardar.Click += botonGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 52);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 1;
            label1.Text = "Descripciones";
            label1.Click += label1_Click;
            // 
            // inputDescrip
            // 
            inputDescrip.Location = new Point(120, 70);
            inputDescrip.Name = "inputDescrip";
            inputDescrip.Size = new Size(266, 23);
            inputDescrip.TabIndex = 2;
            inputDescrip.TextChanged += inputNombreApellido_TextChanged;
            // 
            // inputCosto
            // 
            inputCosto.Location = new Point(120, 134);
            inputCosto.Name = "inputCosto";
            inputCosto.Size = new Size(120, 23);
            inputCosto.TabIndex = 8;
            // 
            // inputPrecioVenta
            // 
            inputPrecioVenta.Location = new Point(120, 193);
            inputPrecioVenta.Name = "inputPrecioVenta";
            inputPrecioVenta.Size = new Size(120, 23);
            inputPrecioVenta.TabIndex = 9;
            // 
            // inputStock
            // 
            inputStock.Location = new Point(120, 253);
            inputStock.Name = "inputStock";
            inputStock.Size = new Size(120, 23);
            inputStock.TabIndex = 10;
            // 
            // inputIdUsuario
            // 
            inputIdUsuario.Location = new Point(120, 317);
            inputIdUsuario.Name = "inputIdUsuario";
            inputIdUsuario.Size = new Size(120, 23);
            inputIdUsuario.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 116);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 12;
            label2.Text = "Costo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 175);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 13;
            label3.Text = "Precio Venta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 235);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 14;
            label4.Text = "Stock";
            // 
            // inputDescripciones
            // 
            inputDescripciones.AutoSize = true;
            inputDescripciones.Location = new Point(118, 299);
            inputDescripciones.Name = "inputDescripciones";
            inputDescripciones.Size = new Size(80, 15);
            inputDescripciones.TabIndex = 15;
            inputDescripciones.Text = "Descripciones";
            // 
            // formModificarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 450);
            Controls.Add(inputDescripciones);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(inputIdUsuario);
            Controls.Add(inputStock);
            Controls.Add(inputPrecioVenta);
            Controls.Add(inputCosto);
            Controls.Add(inputDescrip);
            Controls.Add(label1);
            Controls.Add(botonGuardar);
            Name = "formModificarProducto";
            Text = "Modificar Producto";
            Load += formModificarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)inputCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputIdUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonGuardar;
        private Label label1;
        private TextBox inputDescrip;
        private NumericUpDown inputCosto;
        private NumericUpDown inputPrecioVenta;
        private NumericUpDown inputStock;
        private NumericUpDown inputIdUsuario;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label inputDescripciones;
    }
}