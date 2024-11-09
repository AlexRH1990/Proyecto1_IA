using Business_Layer;
using Entity_layer;
using System;
using System.Windows.Forms;

namespace Graphic_Layer
{
    public partial class Admin_form : Form
    {
        private AdministradorLN administradores = new AdministradorLN();

        public Admin_form()
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

            if (string.IsNullOrWhiteSpace(Nombre.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(PrimerApellido.Text))
            {
                MessageBox.Show("El campo Primer Apellido no puede estar vacío.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(SegundoApellido.Text))
            {
                MessageBox.Show("El campo Segundo Apellido no puede estar vacío.");
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
                int id = int.Parse(ID.Text);
                string nombre = Nombre.Text;
                string primerApellido = PrimerApellido.Text;
                string segundoApellido = SegundoApellido.Text;
                DateTime fechaNacimiento = FechaNacimientoPicker.Value;
                DateTime fechaIngreso = FechaIngresoPicker.Value;

                Administrador nuevoAdministrador = new Administrador(id, nombre, primerApellido, segundoApellido, fechaNacimiento, fechaIngreso);
                bool guardado = administradores.GuardarAdministrador(nuevoAdministrador);

                if (guardado)
                {
                    MessageBox.Show("Administrador guardado con éxito.");
                    LimpiarCampos();
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
