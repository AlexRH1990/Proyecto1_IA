namespace Graphic_Layer
{
    partial class ClienteForm
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
            label1 = new Label();
            textBoxIdentificacion = new TextBox();
            textBoxSegundoApellido = new TextBox();
            textBoxPrimerApellido = new TextBox();
            textBoxNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePickerFechaNacimiento = new DateTimePicker();
            label5 = new Label();
            comboBoxActivo = new ComboBox();
            Activo = new Label();
            Enviar = new Button();
            Limpiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 30);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "ID cliente";
            // 
            // textBoxIdentificacion
            // 
            textBoxIdentificacion.Location = new Point(56, 48);
            textBoxIdentificacion.Name = "textBoxIdentificacion";
            textBoxIdentificacion.Size = new Size(129, 23);
            textBoxIdentificacion.TabIndex = 1;
            // 
            // textBoxSegundoApellido
            // 
            textBoxSegundoApellido.Location = new Point(56, 241);
            textBoxSegundoApellido.Name = "textBoxSegundoApellido";
            textBoxSegundoApellido.Size = new Size(129, 23);
            textBoxSegundoApellido.TabIndex = 4;
            // 
            // textBoxPrimerApellido
            // 
            textBoxPrimerApellido.Location = new Point(56, 170);
            textBoxPrimerApellido.Name = "textBoxPrimerApellido";
            textBoxPrimerApellido.Size = new Size(129, 23);
            textBoxPrimerApellido.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(56, 109);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(129, 23);
            textBoxNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 91);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 5;
            label2.Text = "Nombre Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 152);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 6;
            label3.Text = "Primer Apellido Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 223);
            label4.Name = "label4";
            label4.Size = new Size(141, 15);
            label4.TabIndex = 7;
            label4.Text = "Segundo Apellido Cliente";
            // 
            // dateTimePickerFechaNacimiento
            // 
            dateTimePickerFechaNacimiento.Location = new Point(56, 305);
            dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            dateTimePickerFechaNacimiento.Size = new Size(200, 23);
            dateTimePickerFechaNacimiento.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 287);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 9;
            label5.Text = "Fecha de Nacimiento";
            // 
            // comboBoxActivo
            // 
            comboBoxActivo.FormattingEnabled = true;
            comboBoxActivo.Items.AddRange(new object[] { "Sí", "No" });
            comboBoxActivo.Location = new Point(54, 361);
            comboBoxActivo.Name = "comboBoxActivo";
            comboBoxActivo.Size = new Size(121, 23);
            comboBoxActivo.TabIndex = 6;
            // 
            // Activo
            // 
            Activo.AutoSize = true;
            Activo.Location = new Point(54, 343);
            Activo.Name = "Activo";
            Activo.Size = new Size(119, 15);
            Activo.TabIndex = 11;
            Activo.Text = "Fecha de Nacimiento";
            // 
            // Enviar
            // 
            Enviar.Location = new Point(421, 48);
            Enviar.Name = "Enviar";
            Enviar.Size = new Size(150, 58);
            Enviar.TabIndex = 7;
            Enviar.Text = "Enviar";
            Enviar.UseVisualStyleBackColor = true;
            Enviar.Click += Enviar_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(421, 265);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(150, 58);
            Limpiar.TabIndex = 8;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
       
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Limpiar);
            Controls.Add(Enviar);
            Controls.Add(Activo);
            Controls.Add(comboBoxActivo);
            Controls.Add(label5);
            Controls.Add(dateTimePickerFechaNacimiento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxPrimerApellido);
            Controls.Add(textBoxSegundoApellido);
            Controls.Add(textBoxIdentificacion);
            Controls.Add(label1);
            Name = "ClienteForm";
            Text = "Registrar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxIdentificacion;
        private TextBox textBoxSegundoApellido;
        private TextBox textBoxPrimerApellido;
        private TextBox textBoxNombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePickerFechaNacimiento;
        private Label label5;
        private ComboBox comboBoxActivo;
        private Label Activo;
        private Button Enviar;
        private Button Limpiar;
    }
}