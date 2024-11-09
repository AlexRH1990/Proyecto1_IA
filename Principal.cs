using Business_Layer;
using Entity_layer;
using Graphic_Layer;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto1_IA
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void categoríaDeArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArtCat_Form formArtCat = new ArtCat_Form();
            formArtCat.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cat_ArtLN categoriasLogica = new Cat_ArtLN();
            List<Cat_Art> categorias = categoriasLogica.Consultar();

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("Id", "ID");
                dataGridView1.Columns.Add("Nombre", "Nombre Categoría");
                dataGridView1.Columns.Add("Descripcion", "Descripción Categoría");
            }

            foreach (var categoria in categorias)
            {
                dataGridView1.Rows.Add(categoria.Id, categoria.Nombre, categoria.Descripcion);
            }
        }

        private void artículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Art_Form formArt = new Art_Form();
            formArt.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ArticuloLN articulosLogica = new ArticuloLN();
            List<Articulo> articulos = articulosLogica.Consultar();

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("Id", "ID");
                dataGridView1.Columns.Add("Descripcion", "Descripción");
                dataGridView1.Columns.Add("Categoria", "Categoría");
                dataGridView1.Columns.Add("Marca", "Marca");
                dataGridView1.Columns.Add("Activo", "Activo");
            }

            foreach (var articulo in articulos)
            {
                dataGridView1.Rows.Add(
                    articulo.Id,
                    articulo.Descripcion,
                    articulo.Categoria.Nombre,
                    articulo.Marca,
                    articulo.Activo ? "Sí" : "No"
                );
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AdministradorLN administradoresLogica = new AdministradorLN();
            List<Administrador> administradores = administradoresLogica.Consultar();

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Identificacion", "ID");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("PrimerApellido", "Primer Apellido");
            dataGridView1.Columns.Add("SegundoApellido", "Segundo Apellido");
            dataGridView1.Columns.Add("FechaNacimiento", "Fecha de Nacimiento");
            dataGridView1.Columns.Add("FechaIngreso", "Fecha de Ingreso");

            foreach (var administrador in administradores)
            {
                dataGridView1.Rows.Add(
                    administrador.Identificacion,
                    administrador.Nombre,
                    administrador.PrimerApellido,
                    administrador.SegundoApellido,
                    administrador.FechaNacimiento.ToShortDateString(),
                    administrador.FechaIngreso.ToShortDateString()
                );
            }
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_form formArt = new Admin_form();
            formArt.Show();
        }

        private void administradorSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SucursalForm formArt = new SucursalForm();
            formArt.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SucursalLN sucursalesLogica = new SucursalLN();
            List<Sucursal> sucursales = sucursalesLogica.Consultar();

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Id", "ID de Sucursal");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Administrador", "Administrador");
            dataGridView1.Columns.Add("Direccion", "Dirección");
            dataGridView1.Columns.Add("Telefono", "Teléfono");
            dataGridView1.Columns.Add("Activo", "Activo");

            foreach (var sucursal in sucursales)
            {
                dataGridView1.Rows.Add(
                    sucursal.Id,
                    sucursal.Nombre,
                    sucursal.Administrador.Nombre,
                    sucursal.Direccion,
                    sucursal.Telefono,
                    sucursal.Activo ? "Sí" : "No"
                );
            }
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArticuloxSucursalForm formArt = new ArticuloxSucursalForm();
            formArt.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            // Instancia de la capa lógica para consultar las relaciones de Artículo por Sucursal
            ArticuloxSucursalLN articulosXSucursalLogica = new ArticuloxSucursalLN();

            // Obtener los datos desde la capa lógica (sin modificar `ArticuloxSucursalAD`)
            List<ArticuloxSucursal> articulosXSucursal = articulosXSucursalLogica.Consultar();

            // Limpiar el DataGridView antes de cargar nuevos datos
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Agregar columnas para mostrar la información
            dataGridView1.Columns.Add("IdSucursal", "ID de Sucursal");
            dataGridView1.Columns.Add("NombreSucursal", "Nombre de Sucursal");
            dataGridView1.Columns.Add("IdArticulo", "ID de Artículo");
            dataGridView1.Columns.Add("DescripcionArticulo", "Descripción de Artículo");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");

            // Cargar los datos en el DataGridView
            foreach (var registro in articulosXSucursal)
            {
                dataGridView1.Rows.Add(
                    Convert.ToInt32(registro.Sucursal.Id),                // Convertir ID de sucursal a int
                    registro.Sucursal.Nombre,                             // Nombre de la sucursal
                    Convert.ToInt32(registro.Articulo.Id),               // Convertir ID de artículo a int
                    registro.Articulo.Descripcion,                        // Descripción del artículo
                    Convert.ToInt32(registro.Cantidad)                    // Convertir cantidad a int
                );
            }
        }


        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteForm formArt = new ClienteForm();
            formArt.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ClienteLN clienteLogica = new ClienteLN();
            List<Cliente> clientes = clienteLogica.Consultar();

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Identificacion", "ID");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("PrimerApellido", "Primer Apellido");
            dataGridView1.Columns.Add("SegundoApellido", "Segundo Apellido");
            dataGridView1.Columns.Add("FechaNacimiento", "Fecha de Nacimiento");
            dataGridView1.Columns.Add("Activo", "Activo");

            foreach (var cliente in clientes)
            {
                dataGridView1.Rows.Add(
                    cliente.Identificacion,
                    cliente.Nombre,
                    cliente.PrimerApellido,
                    cliente.SegundoApellido,
                    cliente.FechaNacimiento.ToShortDateString(),
                    cliente.Activo ? "Sí" : "No"
                );
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
