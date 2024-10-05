using Entity_layer;  // Importar la capa de entidades
using Business_Layer;  // Importar la capa lógica
using System;
using System.Windows.Forms;
using Data_layer;

namespace Graphic_Layer
{
    public partial class Admin_form : Form
    {
        private AdministradorLN administradores = new AdministradorLN();
        public Admin_form()
        {
            InitializeComponent();
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                // Captura los valores de los TextBox y DateTimePickers
                int id = int.Parse(ID.Text);
                string nombre = Nombre.Text;
                string primerApellido = PrimerApellido.Text;
                string segundoApellido = SegundoApellido.Text;
                DateTime fechaNacimiento = FechaNacimientoPicker.Value;
                DateTime fechaIngreso = FechaIngresoPicker.Value;

                // Crear el nuevo administrador
                Administrador nuevoAdministrador = new Administrador(id, nombre, primerApellido, segundoApellido, fechaNacimiento, fechaIngreso);

                // Guardar el administrador en la capa lógica
                bool guardado = administradores.GuardarAdministrador(nuevoAdministrador);

                if (guardado)
                {
                    MessageBox.Show("Administrador guardado con éxito.");
                    LimpiarCampos();  // Limpiar los TextBox después de enviar los datos
                }
                else
                {
                    MessageBox.Show("Error: La identificación ya existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el administrador: {ex.Message}");
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            ID.Clear();
            Nombre.Clear();
            PrimerApellido.Clear();
            SegundoApellido.Clear();
            FechaNacimientoPicker.Value = DateTime.Now;
            FechaIngresoPicker.Value = DateTime.Now;
        }

       
    }
}
