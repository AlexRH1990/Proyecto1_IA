using Business_Layer;
using Entity_layer;
using System;
using System.Windows.Forms;

namespace Graphic_Layer
{
    public partial class ArtCat_Form : Form
    {
        private Cat_ArtLN categorias = new Cat_ArtLN();

        public ArtCat_Form()
        {
            InitializeComponent();
        }

        private bool ValidarCamposLlenos()
        {
            if (string.IsNullOrWhiteSpace(ID.Text))
            {
                MessageBox.Show("El campo ID no puede estar vacío.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textboxName.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Description.Text))
            {
                MessageBox.Show("El campo Descripción no puede estar vacío.");
                return false;
            }

            return true;
        }

        private void ButtonEnviar_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposLlenos())
            {
                return;
            }

            try
            {
                int id = int.Parse(ID.Text);
                string nombre = textboxName.Text;
                string descripcion = Description.Text;

                Cat_Art nuevaCategoria = new Cat_Art(id, nombre, descripcion);
                bool guardado = categorias.GuardarCategoria(nuevaCategoria);

                if (guardado)
                {
                    MessageBox.Show("Categoría guardada con éxito.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error: El ID ya existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la categoría: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            ID.Clear();
            textboxName.Clear();
            Description.Clear();
        }
    }
}
