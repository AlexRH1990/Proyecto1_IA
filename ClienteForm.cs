using Business_Layer;
using Entity_layer;
using System;
using System.Windows.Forms;

namespace Graphic_Layer
{
    public partial class ClienteForm : Form
    {
        private ClienteLN clienteLogica = new ClienteLN();

        public ClienteForm()
        {
            InitializeComponent();
            comboBoxActivo.SelectedIndex = 0;
        }

        private bool ValidarCamposLlenos()
        {
            if (string.IsNullOrWhiteSpace(textBoxIdentificacion.Text))
            {
                MessageBox.Show("El campo ID no puede estar vacío.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxPrimerApellido.Text))
            {
                MessageBox.Show("El campo Primer Apellido no puede estar vacío.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxSegundoApellido.Text))
            {
                MessageBox.Show("El campo Segundo Apellido no puede estar vacío.");
                return false;
            }

            if (comboBoxActivo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estado (Activo o Inactivo).");
                return false;
            }

            return true;
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposLlenos())
            {
                return;
            }

            try
            {
                int id = int.Parse(textBoxIdentificacion.Text);
                string nombre = textBoxNombre.Text;
                string primerApellido = textBoxPrimerApellido.Text;
                string segundoApellido = textBoxSegundoApellido.Text;
                DateTime fechaNacimiento = dateTimePickerFechaNacimiento.Value;
                bool activo = comboBoxActivo.SelectedItem.ToString() == "Sí";

                Cliente nuevoCliente = new Cliente(id, nombre, primerApellido, segundoApellido, fechaNacimiento, activo);
                bool guardado = clienteLogica.GuardarCliente(nuevoCliente);

                if (guardado)
                {
                    MessageBox.Show("Cliente registrado con éxito.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error: La identificación ya existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el cliente: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            textBoxIdentificacion.Clear();
            textBoxNombre.Clear();
            textBoxPrimerApellido.Clear();
            textBoxSegundoApellido.Clear();
            comboBoxActivo.SelectedIndex = 0;
        }
    }
}
