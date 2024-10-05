namespace Graphic_Layer
{
    partial class ArtCat_Form
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
            button1 = new Button();
            Enviar = new Button();
            ID = new TextBox();
            Name = new TextBox();
            Description = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            
            // 
            // button1
            // 
            button1.Location = new Point(500, 251);
            button1.Name = "button1";
            button1.Size = new Size(121, 52);
            button1.TabIndex = 0;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            // 
            // Enviar
            // 
            Enviar.Location = new Point(500, 62);
            Enviar.Name = "Enviar";
            Enviar.Size = new Size(121, 52);
            Enviar.TabIndex = 1;
            Enviar.Text = "Enviar";
            Enviar.UseVisualStyleBackColor = true;
            Enviar.Click += button2_Click;
            // 
            // ID
            // 
            ID.Location = new Point(54, 91);
            ID.Name = "ID";
            ID.Size = new Size(175, 23);
            ID.TabIndex = 2;
            // 
            // Name
            // 
            Name.Location = new Point(54, 181);
            Name.Name = "Name";
            Name.Size = new Size(175, 23);
            Name.TabIndex = 3;
            Name.TextChanged += Name_TextChanged;
            // 
            // Description
            // 
            Description.Location = new Point(54, 280);
            Description.Name = "Description";
            Description.Size = new Size(219, 23);
            Description.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 59);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 5;
            label1.Text = "ID Categoría";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 144);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 6;
            label2.Text = "Nombre Categoría";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 241);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 7;
            label3.Text = "Descripción Categoría";
            // 
            // ArtCat_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Description);
            Controls.Add(Name);
            Controls.Add(ID);
            Controls.Add(Enviar);
            Controls.Add(button1);
            
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button button1;
        private Button Enviar;
        private TextBox ID;
        private TextBox Name;
        private TextBox Description;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}