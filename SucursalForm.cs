using Business_Layer;  // Importar la capa lógica
using Entity_layer;  // Importar la capa de entidades
using System;
using System.Windows.Forms;

namespace Graphic_Layer
{
    public partial class SucursalForm : Form
    {
        // Instancia de la capa lógica
        private SucursalLN sucursalLogica = new SucursalLN();
        private AdministradorLN administradorLogica = new AdministradorLN();  // Para llenar el ComboBox de Administradores

        #region Constructor
        public SucursalForm()
        {
            InitializeComponent();

            // Llenar el ComboBox con los administradores registrados
            LlenarComboBoxAdministradores();
        }
        #endregion

        #region Métodos

        // Método para llenar el ComboBox con los administradores registrados
        private void LlenarComboBoxAdministradores()
        {
            Administrador[] administradores = administradorLogica.Consultar();  // Obtener los administradores

            // Limpiar el ComboBox antes de agregar
            comboBox1.Items.Clear();

            // Agregar los administradores al ComboBox
            foreach (var administrador in administradores)
            {
                if (administrador != null)
                {
                    comboBox1.Items.Add(administrador);  // Agregar el objeto completo
                }
            }

            // Establecer qué propiedad mostrar en el ComboBox (en este caso, el Nombre)
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Identificacion";  // Opcional: si necesitas el ID como valor
        }

        #endregion

        #region Eventos

        // Método que se ejecuta al hacer clic en el botón "Enviar"
        private void Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                // Captura los valores de los TextBox y ComboBoxes
                int id = int.Parse(ID.Text);
                string nombre = Nombre.Text;
                Administrador administradorSeleccionado = (Administrador)comboBox1.SelectedItem;  // Obtener el administrador seleccionado
                string direccion = Direccion.Text;
                string telefono = Telefono.Text;
                bool activo = comboBox2.SelectedItem.ToString() == "Sí";  // Convertir "Sí" a true y "No" a false

                // Crear la nueva sucursal
                Sucursal nuevaSucursal = new Sucursal(id, nombre, administradorSeleccionado, direccion, telefono, activo);

                // Guardar la sucursal en la capa lógica
                bool guardado = sucursalLogica.GuardarSucursal(nuevaSucursal);

                if (guardado)
                {
                    MessageBox.Show("Sucursal guardada con éxito.");
                    LimpiarCampos();  // Limpiar los TextBox después de enviar los datos
                }
                else
                {
                    MessageBox.Show("Error: El ID ya existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la sucursal: {ex.Message}");
            }
        }

        // Método para limpiar los campos después de enviar los datos
        private void LimpiarCampos()
        {
            ID.Clear();
            Nombre.Clear();
            comboBox1.SelectedIndex = -1;  // Limpiar la selección del ComboBox de administradores
            Direccion.Clear();
            Telefono.Clear();
            comboBox2.SelectedIndex = -1;  // Limpiar la selección del ComboBox de Activo
        }

        #endregion
    }
}
