namespace Graphic_Layer
{
    partial class SucursalForm
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
            Enviar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            ID = new TextBox();
            Nombre = new TextBox();
            Direccion = new TextBox();
            Telefono = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Enviar
            // 
            Enviar.Location = new Point(413, 50);
            Enviar.Name = "Enviar";
            Enviar.Size = new Size(163, 47);
            Enviar.TabIndex = 0;
            Enviar.Text = "Enviar";
            Enviar.UseVisualStyleBackColor = true;
            Enviar.Click += Enviar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 56);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 1;
            label1.Text = "Id de la sucursal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 121);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre de la sucursal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 187);
            label3.Name = "label3";
            label3.Size = new Size(157, 15);
            label3.TabIndex = 3;
            label3.Text = "Administrador de la sucursal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 246);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 4;
            label4.Text = "Dirección de la sucursal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 306);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 5;
            label5.Text = "Telefono de la sucursal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 369);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 6;
            label6.Text = "Activo";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(56, 205);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 23);
            comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Sí", "No" });
            comboBox2.Location = new Point(56, 387);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 8;
            // 
            // ID
            // 
            ID.Location = new Point(56, 74);
            ID.Name = "ID";
            ID.Size = new Size(125, 23);
            ID.TabIndex = 9;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(56, 139);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(125, 23);
            Nombre.TabIndex = 10;
            // 
            // Direccion
            // 
            Direccion.Location = new Point(56, 264);
            Direccion.Name = "Direccion";
            Direccion.Size = new Size(125, 23);
            Direccion.TabIndex = 11;
            // 
            // Telefono
            // 
            Telefono.Location = new Point(56, 333);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(125, 23);
            Telefono.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(413, 246);
            button1.Name = "button1";
            button1.Size = new Size(163, 47);
            button1.TabIndex = 13;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
        
            // 
            // SucursalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Telefono);
            Controls.Add(Direccion);
            Controls.Add(Nombre);
            Controls.Add(ID);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Enviar);
            Name = "SucursalForm";
            Text = "Registro de Sucursal ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Enviar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox ID;
        private TextBox Nombre;
        private TextBox Direccion;
        private TextBox Telefono;
        private Button button1;
    }
}