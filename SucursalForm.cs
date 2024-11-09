using Business_Layer;
using Entity_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Graphic_Layer
{
    public partial class SucursalForm : Form
    {
        private SucursalLN sucursalLogica = new SucursalLN();
        private AdministradorLN administradorLogica = new AdministradorLN();

        public SucursalForm()
        {
            InitializeComponent();
            LlenarComboBoxAdministradores();
        }

        private void LlenarComboBoxAdministradores()
        {
            List<Administrador> administradores = administradorLogica.Consultar();
            comboBox1.Items.Clear();
            foreach (var administrador in administradores)
            {
                comboBox1.Items.Add(administrador);
            }
            comboBox1.DisplayMember = "Nombre";
        }

        private bool ValidarCamposLlenos()
        {
            if (string.IsNullOrWhiteSpace(ID.Text) ||
                string.IsNullOrWhiteSpace(Nombre.Text) ||
                comboBox1.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(Direccion.Text) ||
                string.IsNullOrWhiteSpace(Telefono.Text) ||
                comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return false;
            }
            return true;
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposLlenos()) return;

            try
            {
                int id = int.Parse(ID.Text);
                string nombre = Nombre.Text;
                Administrador administradorSeleccionado = (Administrador)comboBox1.SelectedItem;
                string direccion = Direccion.Text;
                string telefono = Telefono.Text;
                bool activo = comboBox2.SelectedItem.ToString() == "Sí";

                Sucursal nuevaSucursal = new Sucursal(id, nombre, administradorSeleccionado, direccion, telefono, activo);
                bool guardado = sucursalLogica.GuardarSucursal(nuevaSucursal);

                MessageBox.Show(guardado ? "Sucursal guardada con éxito." : "Error: El ID ya existe.");
                if (guardado) LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la sucursal: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            ID.Clear();
            Nombre.Clear();
            comboBox1.SelectedIndex = -1;
            Direccion.Clear();
            Telefono.Clear();
            comboBox2.SelectedIndex = -1;
        }
    }
}
