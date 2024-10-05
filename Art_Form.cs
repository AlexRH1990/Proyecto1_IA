using Business_Layer;  // Importar la capa lógica
using Entity_layer;  // Importar la capa de entidades
using System;
using System.Windows.Forms;


namespace Graphic_Layer
{
    public partial class Art_Form : Form
    {
        // Instancia de la capa lógica para categorías
        private Cat_ArtLN categoriasLogica = new Cat_ArtLN();
        private ArticuloLN articuloLogica = new ArticuloLN();  // Instancia de la capa lógica para artículos

        #region Constructor
        public Art_Form()
        {
            InitializeComponent();

            // Llenar el ComboBox con las categorías registradas
            LlenarComboBoxCategorias();
        }
        #endregion

        #region Métodos

        // Método para llenar el ComboBox con las categorías registradas
        private void LlenarComboBoxCategorias()
        {
            Cat_Art[] categorias = categoriasLogica.Consultar();  // Obtener las categorías

            // Limpiar el ComboBox antes de agregar
            comboBox1.Items.Clear();

            // Agregar las categorías al ComboBox
            foreach (var categoria in categorias)
            {
                if (categoria != null)
                {
                    comboBox1.Items.Add(categoria);  // Agregar el objeto completo
                }
            }

            // Establecer qué propiedad mostrar en el ComboBox (en este caso, el Nombre)
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id";  // Opcional: si necesitas el ID como valor
        }

        #endregion

        #region Eventos

        // Método que se ejecuta al hacer clic en el botón "Enviar"
        private void Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                // Captura los valores de los TextBox
                int id = int.Parse(ID.Text);
                string descripcion = Descripcion.Text;
                Cat_Art categoriaSeleccionada = (Cat_Art)comboBox1.SelectedItem;  // Obtener la categoría seleccionada
                string marca = Marca.Text;
                bool activo = comboBox2.SelectedItem.ToString() == "Sí";  // Convertir "Sí" a true y "No" a false

                // Crear el nuevo artículo
                Articulo nuevoArticulo = new Articulo(id, descripcion, categoriaSeleccionada, marca, activo);

                // Guardar el artículo en la capa lógica
                bool guardado = articuloLogica.GuardarArticulo(nuevoArticulo);  // Usar la instancia

                if (guardado)
                {
                    MessageBox.Show("Artículo guardado con éxito.");
                    LimpiarCampos();  // Limpiar los TextBox después de enviar los datos
                }
                else
                {
                    MessageBox.Show("Error: El ID ya existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el artículo: {ex.Message}");
            }
        }

        // Método que se ejecuta al hacer clic en el botón "Limpiar"
        private void Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Método para limpiar los campos después de enviar los datos
        private void LimpiarCampos()
        {
            ID.Clear();
            Descripcion.Clear();
            comboBox1.SelectedIndex = -1;  // Limpiar la selección del ComboBox de categorías
            Marca.Clear();
            comboBox2.SelectedIndex = -1;  // Limpiar la selección del ComboBox de Activo
        }

        #endregion
    }
}
