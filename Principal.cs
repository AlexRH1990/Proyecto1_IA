using Business_Layer;
using Entity_layer;
using Graphic_Layer;

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
            // Instanciar el formulario ArtCat_Form
            ArtCat_Form formArtCat = new ArtCat_Form();

            // Mostrar el formulario de manera modal (el usuario debe cerrarlo para regresar al principal)
            formArtCat.ShowDialog();

            // Si prefieres que el formulario se abra sin bloquear la interacción con el formulario principal:
            // formArtCat.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        { // Crear instancia de la capa lógica para consultar los datos
            Cat_ArtLN categoriasLogica = new Cat_ArtLN();

            // Obtener el arreglo de categorías desde la capa lógica
            Cat_Art[] categorias = categoriasLogica.Consultar();

            // Limpiar el DataGridView antes de cargar nuevos datos (si es necesario)
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Si el DataGridView no tiene columnas, agregarlas dinámicamente
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("Id", "ID");
                dataGridView1.Columns.Add("Nombre", "Nombre Categoría");
                dataGridView1.Columns.Add("Descripcion", "Descripción Categoría");
            }

            // Cargar los datos en el DataGridView
            foreach (var categoria in categorias)
            {
                if (categoria != null)  // Solo agregar categorías no nulas
                {
                    dataGridView1.Rows.Add(categoria.Id, categoria.Nombre, categoria.Descripcion);
                }
            }
        }

        private void artículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Art_Form formArt = new Art_Form();
            formArt.Show();  // Abre el formulario sin bloquear el principal
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Crear instancia de la capa lógica para consultar los artículos
            ArticuloLN articulosLogica = new ArticuloLN();

            // Obtener el arreglo de artículos desde la capa lógica
            Articulo[] articulos = articulosLogica.Consultar();

            // Limpiar el DataGridView antes de cargar nuevos datos (si es necesario)
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();  // Limpiar también las columnas

            // Si el DataGridView no tiene columnas, agregarlas dinámicamente
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("Id", "ID");
                dataGridView1.Columns.Add("Descripcion", "Descripción");
                dataGridView1.Columns.Add("Categoria", "Categoría");
                dataGridView1.Columns.Add("Marca", "Marca");
                dataGridView1.Columns.Add("Activo", "Activo");
            }

            // Cargar los datos de los artículos en el DataGridView
            foreach (var articulo in articulos)
            {
                if (articulo != null)  // Solo agregar artículos no nulos
                {
                    // Agregar una nueva fila al DataGridView con los datos del artículo
                    dataGridView1.Rows.Add(
                        articulo.Id,
                        articulo.Descripcion,
                        articulo.Categoria.Nombre,  // Mostrar el nombre de la categoría asociada
                        articulo.Marca,
                        articulo.Activo ? "Sí" : "No"  // Convertir el booleano a "Sí"/"No"
                    );
                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // Crear instancia de la capa lógica para consultar los administradores
            AdministradorLN administradoresLogica = new AdministradorLN();

            // Obtener el arreglo de administradores desde la capa lógica
            Administrador[] administradores = administradoresLogica.Consultar();

            // Limpiar completamente el DataGridView: filas y columnas
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();  // Limpiar también las columnas

            // Agregar las columnas necesarias para los administradores
            dataGridView1.Columns.Add("Identificacion", "ID");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("PrimerApellido", "Primer Apellido");
            dataGridView1.Columns.Add("SegundoApellido", "Segundo Apellido");
            dataGridView1.Columns.Add("FechaNacimiento", "Fecha de Nacimiento");
            dataGridView1.Columns.Add("FechaIngreso", "Fecha de Ingreso");

            // Cargar los datos de los administradores en el DataGridView
            foreach (var administrador in administradores)
            {
                if (administrador != null)  // Solo agregar administradores no nulos
                {
                    // Agregar una nueva fila al DataGridView con los datos del administrador
                    dataGridView1.Rows.Add(
                        administrador.Identificacion,
                        administrador.Nombre,
                        administrador.PrimerApellido,
                        administrador.SegundoApellido,
                        administrador.FechaNacimiento.ToShortDateString(),  // Formato corto de la fecha
                        administrador.FechaIngreso.ToShortDateString()  // Formato corto de la fecha
                    );
                }
            }
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_form formArt = new Admin_form();
            formArt.Show();  // Abre el formulario sin bloquear el principal
        }

        private void administradorSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SucursalForm formArt = new SucursalForm();
            formArt.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            // Crear instancia de la capa lógica para consultar las sucursales
            SucursalLN sucursalesLogica = new SucursalLN();

            // Obtener el arreglo de sucursales desde la capa lógica
            Sucursal[] sucursales = sucursalesLogica.Consultar();

            // Limpiar completamente el DataGridView: filas y columnas
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();  // Limpiar también las columnas

            // Agregar las columnas necesarias para las sucursales
            dataGridView1.Columns.Add("Id", "ID de Sucursal");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Administrador", "Administrador");
            dataGridView1.Columns.Add("Direccion", "Dirección");
            dataGridView1.Columns.Add("Telefono", "Teléfono");
            dataGridView1.Columns.Add("Activo", "Activo");

            // Cargar los datos de las sucursales en el DataGridView
            foreach (var sucursal in sucursales)
            {
                if (sucursal != null)  // Solo agregar sucursales no nulas
                {
                    // Agregar una nueva fila al DataGridView con los datos de la sucursal
                    dataGridView1.Rows.Add(
                        sucursal.Id,
                        sucursal.Nombre,
                        sucursal.Administrador.Nombre,  // Mostrar el nombre del administrador
                        sucursal.Direccion,
                        sucursal.Telefono,
                        sucursal.Activo ? "Sí" : "No"  // Mostrar "Sí" o "No" para el estado de activo
                    );
                }
            }

        }
    }
}
