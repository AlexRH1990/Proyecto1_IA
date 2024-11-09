using Business_Layer;
using Entity_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Graphic_Layer
{
    public partial class ArticuloxSucursalForm : Form
    {
        private SucursalLN sucursalLogica = new SucursalLN();
        private ArticuloLN articuloLogica = new ArticuloLN();
        private ArticuloxSucursalLN articulosXSucursalLogica = new ArticuloxSucursalLN();

        public ArticuloxSucursalForm()
        {
            InitializeComponent();
            dataGridViewArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewArticulos.MultiSelect = true;

            LlenarComboBoxSucursales();
            LlenarDataGridViewArticulos();
        }

        private void LlenarComboBoxSucursales()
        {
            List<Sucursal> sucursales = sucursalLogica.Consultar();
            comboBoxSucursales.Items.Clear();
            foreach (var sucursal in sucursales.Where(s => s.Activo))
            {
                comboBoxSucursales.Items.Add(sucursal);
            }
            comboBoxSucursales.DisplayMember = "Nombre";
        }

        private void LlenarDataGridViewArticulos()
        {
            List<Articulo> articulos = articuloLogica.Consultar();
            dataGridViewArticulos.Rows.Clear();
            dataGridViewArticulos.Columns.Clear();

            dataGridViewArticulos.Columns.Add("Id", "ID");
            dataGridViewArticulos.Columns.Add("Descripcion", "Descripción");
            dataGridViewArticulos.Columns.Add("Categoria", "Categoría");
            dataGridViewArticulos.Columns.Add("Marca", "Marca");

            foreach (var articulo in articulos.Where(a => a.Activo))
            {
                dataGridViewArticulos.Rows.Add(articulo.Id, articulo.Descripcion, articulo.Categoria.Nombre, articulo.Marca);
            }
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                Sucursal sucursalSeleccionada = (Sucursal)comboBoxSucursales.SelectedItem;
                if (sucursalSeleccionada == null)
                {
                    MessageBox.Show("Debe seleccionar una sucursal activa.");
                    return;
                }

                int cantidad = int.Parse(txtCantidad.Text);
                if (cantidad <= 0)
                {
                    MessageBox.Show("La cantidad debe ser mayor que cero.");
                    return;
                }

                foreach (DataGridViewRow row in dataGridViewArticulos.SelectedRows)
                {
                    int idArticulo = int.Parse(row.Cells["Id"].Value.ToString());
                    Articulo articuloSeleccionado = articuloLogica.Consultar().First(a => a.Id == idArticulo);

                    ArticuloxSucursal nuevaAsociacion = new ArticuloxSucursal(sucursalSeleccionada, articuloSeleccionado, cantidad);
                    bool guardado = articulosXSucursalLogica.GuardarArticuloxSucursal(nuevaAsociacion);

                    if (!guardado)
                    {
                        MessageBox.Show($"El artículo {articuloSeleccionado.Descripcion} ya está asociado a la sucursal {sucursalSeleccionada.Nombre}.");
                    }
                    else
                    {
                        MessageBox.Show($"Asociación guardada: {articuloSeleccionado.Descripcion} en {sucursalSeleccionada.Nombre}.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la asociación: {ex.Message}");
            }
        }
    }
}
