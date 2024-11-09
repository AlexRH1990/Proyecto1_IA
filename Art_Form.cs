using Business_Layer;
using Entity_layer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Graphic_Layer
{
    public partial class Art_Form : Form
    {
        private Cat_ArtLN categoriasLogica = new Cat_ArtLN();
        private ArticuloLN articuloLogica = new ArticuloLN();

        public Art_Form()
        {
            InitializeComponent();
            LlenarComboBoxCategorias();
        }

        private void LlenarComboBoxCategorias()
        {
            List<Cat_Art> categorias = categoriasLogica.Consultar();
            comboBox1.Items.Clear();
            foreach (var categoria in categorias)
            {
                comboBox1.Items.Add(categoria);
            }
            comboBox1.DisplayMember = "Nombre";
        }

        private bool ValidarCamposLlenos()
        {
            return !string.IsNullOrWhiteSpace(ID.Text) &&
                   !string.IsNullOrWhiteSpace(Descripcion.Text) &&
                   comboBox1.SelectedIndex != -1 &&
                   !string.IsNullOrWhiteSpace(Marca.Text) &&
                   comboBox2.SelectedIndex != -1;
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposLlenos())
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            try
            {
                int id = int.Parse(ID.Text);
                string descripcion = Descripcion.Text;
                Cat_Art categoriaSeleccionada = (Cat_Art)comboBox1.SelectedItem;
                string marca = Marca.Text;
                bool activo = comboBox2.SelectedItem.ToString() == "Sí";

                Articulo nuevoArticulo = new Articulo(id, descripcion, categoriaSeleccionada, marca, activo);
                bool guardado = articuloLogica.GuardarArticulo(nuevoArticulo);

                MessageBox.Show(guardado ? "Artículo guardado con éxito." : "Error: El ID ya existe.");
                if (guardado) LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el artículo: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            ID.Clear();
            Descripcion.Clear();
            comboBox1.SelectedIndex = -1;
            Marca.Clear();
            comboBox2.SelectedIndex = -1;
        }
    }
}
