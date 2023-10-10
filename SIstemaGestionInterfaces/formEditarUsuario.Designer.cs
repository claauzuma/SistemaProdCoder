namespace SistemaGestionEntityFramework
{
    partial class formEditarUsuario
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
            inputNombreApellido = new TextBox();
            inputTel = new TextBox();
            label2 = new Label();
            label4 = new Label();
            inputContraseña = new TextBox();
            inputNombreUsuario = new TextBox();
            inputEmail = new TextBox();
            InputDomi = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // botonGuardar
            // 
            botonGuardar.Location = new Point(194, 365);
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
            label1.Location = new Point(120, 57);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre y Apellido";
            label1.Click += label1_Click;
            // 
            // inputNombreApellido
            // 
            inputNombreApellido.Location = new Point(120, 75);
            inputNombreApellido.Name = "inputNombreApellido";
            inputNombreApellido.Size = new Size(266, 23);
            inputNombreApellido.TabIndex = 2;
            inputNombreApellido.TextChanged += inputNombreApellido_TextChanged;
            // 
            // inputTel
            // 
            inputTel.Location = new Point(120, 238);
            inputTel.Name = "inputTel";
            inputTel.Size = new Size(266, 23);
            inputTel.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 220);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 4;
            label2.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 308);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // inputContraseña
            // 
            inputContraseña.Location = new Point(120, 326);
            inputContraseña.Name = "inputContraseña";
            inputContraseña.Size = new Size(266, 23);
            inputContraseña.TabIndex = 7;
            // 
            // inputNombreUsuario
            // 
            inputNombreUsuario.Location = new Point(120, 131);
            inputNombreUsuario.Name = "inputNombreUsuario";
            inputNombreUsuario.Size = new Size(266, 23);
            inputNombreUsuario.TabIndex = 8;
            // 
            // inputEmail
            // 
            inputEmail.Location = new Point(120, 282);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(266, 23);
            inputEmail.TabIndex = 9;
            // 
            // InputDomi
            // 
            InputDomi.Location = new Point(120, 185);
            InputDomi.Name = "InputDomi";
            InputDomi.Size = new Size(266, 23);
            InputDomi.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 264);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 11;
            label3.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 167);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 12;
            label5.Text = "Domicilio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(120, 113);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 13;
            label6.Text = "Nombre Usuario";
            // 
            // formEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(InputDomi);
            Controls.Add(inputEmail);
            Controls.Add(inputNombreUsuario);
            Controls.Add(inputContraseña);
            Controls.Add(label4);
            Controls.Add(inputTel);
            Controls.Add(label2);
            Controls.Add(inputNombreApellido);
            Controls.Add(label1);
            Controls.Add(botonGuardar);
            Name = "formEditarUsuario";
            Text = "Editar Usuario";
            Load += formEditarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonGuardar;
        private Label label1;
        private TextBox inputNombreApellido;
        private TextBox inputTel;
        private Label label2;
        private Label label4;
        private TextBox inputContraseña;
        private TextBox inputNombreUsuario;
        private TextBox inputEmail;
        private TextBox InputDomi;
        private Label label3;
        private Label label5;
        private Label label6;
    }
}