namespace Graphic_Layer
{
    partial class Art_Form
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
            Limpiar = new Button();
            ID = new TextBox();
            Descripcion = new TextBox();
            comboBox1 = new ComboBox();
            Marca = new TextBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Label500 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // Enviar
            // 
            Enviar.Location = new Point(439, 67);
            Enviar.Name = "Enviar";
            Enviar.Size = new Size(117, 50);
            Enviar.TabIndex = 0;
            Enviar.Text = "Enviar";
            Enviar.UseVisualStyleBackColor = true;
            Enviar.Click += Enviar_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(439, 232);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(117, 50);
            Limpiar.TabIndex = 1;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
           
            // 
            // ID
            // 
            ID.Location = new Point(56, 67);
            ID.Name = "ID";
            ID.Size = new Size(100, 23);
            ID.TabIndex = 2;
            // 
            // Descripcion
            // 
            Descripcion.Location = new Point(56, 136);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(100, 23);
            Descripcion.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(56, 212);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // Marca
            // 
            Marca.Location = new Point(56, 282);
            Marca.Name = "Marca";
            Marca.Size = new Size(100, 23);
            Marca.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Sí", "No" });
            comboBox2.Location = new Point(56, 347);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 49);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 7;
            label1.Text = "Id del Artículo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 118);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 8;
            label2.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 194);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 9;
            label3.Text = "Categoría del Artículo";
            // 
            // Label500
            // 
            Label500.AutoSize = true;
            Label500.Location = new Point(56, 264);
            Label500.Name = "Label500";
            Label500.Size = new Size(40, 15);
            Label500.TabIndex = 10;
            Label500.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 329);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 11;
            label4.Text = "Activo";
            // 
            // Art_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(Label500);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(Marca);
            Controls.Add(comboBox1);
            Controls.Add(Descripcion);
            Controls.Add(ID);
            Controls.Add(Limpiar);
            Controls.Add(Enviar);
            Name = "Art_Form";
            Text = "Registro de Artículos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Enviar;
        private Button Limpiar;
        private TextBox ID;
        private TextBox Descripcion;
        private ComboBox comboBox1;
        private TextBox Marca;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label Label500;
        private Label label4;
    }
}