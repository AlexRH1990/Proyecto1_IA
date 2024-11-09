namespace Graphic_Layer
{
    partial class Admin_form
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
            ID = new TextBox();
            Nombre = new TextBox();
            PrimerApellido = new TextBox();
            SegundoApellido = new TextBox();
            FechaNacimientoPicker = new DateTimePicker();
            FechaIngresoPicker = new DateTimePicker();
            Enviar = new Button();
            Limpiar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // ID
            // 
            ID.Location = new Point(66, 62);
            ID.Name = "ID";
            ID.Size = new Size(126, 23);
            ID.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(66, 117);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(126, 23);
            Nombre.TabIndex = 1;
            // 
            // PrimerApellido
            // 
            PrimerApellido.Location = new Point(66, 166);
            PrimerApellido.Name = "PrimerApellido";
            PrimerApellido.Size = new Size(126, 23);
            PrimerApellido.TabIndex = 2;
            // 
            // SegundoApellido
            // 
            SegundoApellido.Location = new Point(66, 220);
            SegundoApellido.Name = "SegundoApellido";
            SegundoApellido.Size = new Size(126, 23);
            SegundoApellido.TabIndex = 3;
            // 
            // FechaNacimientoPicker
            // 
            FechaNacimientoPicker.Location = new Point(66, 275);
            FechaNacimientoPicker.Name = "FechaNacimientoPicker";
            FechaNacimientoPicker.Size = new Size(200, 23);
            FechaNacimientoPicker.TabIndex = 4;
            // 
            // FechaIngresoPicker
            // 
            FechaIngresoPicker.Location = new Point(66, 339);
            FechaIngresoPicker.Name = "FechaIngresoPicker";
            FechaIngresoPicker.Size = new Size(200, 23);
            FechaIngresoPicker.TabIndex = 5;
            // 
            // Enviar
            // 
            Enviar.Location = new Point(407, 43);
            Enviar.Name = "Enviar";
            Enviar.Size = new Size(140, 59);
            Enviar.TabIndex = 6;
            Enviar.Text = "Enviar";
            Enviar.UseVisualStyleBackColor = true;
            Enviar.Click += Enviar_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(407, 259);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(140, 59);
            Limpiar.TabIndex = 7;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
          
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 43);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 8;
            label1.Text = "ID del administrador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 99);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 9;
            label2.Text = "Nombre Administrador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 148);
            label3.Name = "label3";
            label3.Size = new Size(168, 15);
            label3.TabIndex = 10;
            label3.Text = "Primer Apellido Administrador";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 202);
            label4.Name = "label4";
            label4.Size = new Size(180, 15);
            label4.TabIndex = 11;
            label4.Text = "Segundo Apellido Administrador";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 257);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 12;
            label5.Text = "Fecha de nacimiento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 321);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 13;
            label6.Text = "Fecha de ingreso";
            // 
            // Admin_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Limpiar);
            Controls.Add(Enviar);
            Controls.Add(FechaIngresoPicker);
            Controls.Add(FechaNacimientoPicker);
            Controls.Add(SegundoApellido);
            Controls.Add(PrimerApellido);
            Controls.Add(Nombre);
            Controls.Add(ID);
            Name = "Admin_form";
            Text = "Registrar Administrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ID;
        private TextBox Nombre;
        private TextBox PrimerApellido;
        private TextBox SegundoApellido;
        private DateTimePicker FechaNacimientoPicker;
        private DateTimePicker FechaIngresoPicker;
        private Button Enviar;
        private Button Limpiar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}