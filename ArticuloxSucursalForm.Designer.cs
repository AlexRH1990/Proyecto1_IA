namespace Graphic_Layer
{
    partial class ArticuloxSucursalForm
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
            txtCantidad = new TextBox();
            comboBoxSucursales = new ComboBox();
            dataGridViewArticulos = new DataGridView();
            Enviar = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArticulos).BeginInit();
            SuspendLayout();
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(53, 171);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(151, 23);
            txtCantidad.TabIndex = 0;
            // 
            // comboBoxSucursales
            // 
            comboBoxSucursales.FormattingEnabled = true;
            comboBoxSucursales.Location = new Point(53, 62);
            comboBoxSucursales.Name = "comboBoxSucursales";
            comboBoxSucursales.Size = new Size(151, 23);
            comboBoxSucursales.TabIndex = 1;
            // 
            // dataGridViewArticulos
            // 
            dataGridViewArticulos.AllowUserToOrderColumns = true;
            dataGridViewArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewArticulos.Location = new Point(363, 53);
            dataGridViewArticulos.Name = "dataGridViewArticulos";
            dataGridViewArticulos.RowTemplate.Height = 25;
            dataGridViewArticulos.Size = new Size(240, 150);
            dataGridViewArticulos.TabIndex = 2;
         
            // 
            // Enviar
            // 
            Enviar.Location = new Point(106, 319);
            Enviar.Name = "Enviar";
            Enviar.Size = new Size(143, 54);
            Enviar.TabIndex = 3;
            Enviar.Text = "Enviar";
            Enviar.UseVisualStyleBackColor = true;
            Enviar.Click += Registrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 27);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 5;
            label1.Text = "Sucursal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 131);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 6;
            label2.Text = "Cantidad";
            // 
            // ArticuloxSucursalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Enviar);
            Controls.Add(dataGridViewArticulos);
            Controls.Add(comboBoxSucursales);
            Controls.Add(txtCantidad);
            Name = "ArticuloxSucursalForm";
            Text = "ArticuloxSucursalForm";
            Click += Registrar_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridViewArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCantidad;
        private ComboBox comboBoxSucursales;
        private DataGridView dataGridViewArticulos;
        private Button Enviar;
        private Label label1;
        private Label label2;
    }
}