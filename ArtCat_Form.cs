using Entity_layer;  // Importar la capa de entidades
using Business_Layer;  // Importar la capa lógica
using System;
using System.Windows.Forms;

namespace Graphic_Layer
{
    public partial class ArtCat_Form : Form
    {
        // Instancia de la capa lógica
        private Cat_ArtLN categorias = new Cat_ArtLN();

        #region Constructor
        public ArtCat_Form()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos

        // Método que se ejecuta al hacer clic en el botón "Enviar"
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Captura los valores de los TextBox
                int id = int.Parse(ID.Text);
                string nombre = Name.Text;
                string descripcion = Description.Text;

                // Crear la nueva categoría
                Cat_Art nuevaCategoria = new Cat_Art(id, nombre, descripcion);

                // Enviar los datos a la capa lógica para guardar la categoría
                bool guardado = categorias.GuardarCategoria(nuevaCategoria);  // Usar la instancia

                if (guardado)
                {
                    MessageBox.Show("Categoría guardada con éxito.");
                    LimpiarCampos();  // Limpiar los TextBox después de enviar los datos
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

        // Método que se ejecuta al hacer clic en el botón "Volver"
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();  // Cierra el formulario actual
        }

        // Método para limpiar los campos después de enviar los datos
        private void LimpiarCampos()
        {
            ID.Clear();
            Name.Clear();
            Description.Clear();
        }

        #endregion

        private void Name_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
