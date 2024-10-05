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



        private void categor�aDeArt�culoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciar el formulario ArtCat_Form
            ArtCat_Form formArtCat = new ArtCat_Form();

            // Mostrar el formulario de manera modal (el usuario debe cerrarlo para regresar al principal)
            formArtCat.ShowDialog();

            // Si prefieres que el formulario se abra sin bloquear la interacci�n con el formulario principal:
            // formArtCat.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        { // Crear instancia de la capa l�gica para consultar los datos
            Cat_ArtLN categoriasLogica = new Cat_ArtLN();

            // Obtener el arreglo de categor�as desde la capa l�gica
            Cat_Art[] categorias = categoriasLogica.Consultar();

            // Limpiar el DataGridView antes de cargar nuevos datos (si es necesario)
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Si el DataGridView no tiene columnas, agregarlas din�micamente
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("Id", "ID");
                dataGridView1.Columns.Add("Nombre", "Nombre Categor�a");
                dataGridView1.Columns.Add("Descripcion", "Descripci�n Categor�a");
            }

            // Cargar los datos en el DataGridView
            foreach (var categoria in categorias)
            {
                if (categoria != null)  // Solo agregar categor�as no nulas
                {
                    dataGridView1.Rows.Add(categoria.Id, categoria.Nombre, categoria.Descripcion);
                }
            }
        }

        private void art�culoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Art_Form formArt = new Art_Form();
            formArt.Show();  // Abre el formulario sin bloquear el principal
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Crear instancia de la capa l�gica para consultar los art�culos
            ArticuloLN articulosLogica = new ArticuloLN();

            // Obtener el arreglo de art�culos desde la capa l�gica
            Articulo[] articulos = articulosLogica.Consultar();

            // Limpiar el DataGridView antes de cargar nuevos datos (si es necesario)
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();  // Limpiar tambi�n las columnas

            // Si el DataGridView no tiene columnas, agregarlas din�micamente
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("Id", "ID");
                dataGridView1.Columns.Add("Descripcion", "Descripci�n");
                dataGridView1.Columns.Add("Categoria", "Categor�a");
                dataGridView1.Columns.Add("Marca", "Marca");
                dataGridView1.Columns.Add("Activo", "Activo");
            }

            // Cargar los datos de los art�culos en el DataGridView
            foreach (var articulo in articulos)
            {
                if (articulo != null)  // Solo agregar art�culos no nulos
                {
                    // Agregar una nueva fila al DataGridView con los datos del art�culo
                    dataGridView1.Rows.Add(
                        articulo.Id,
                        articulo.Descripcion,
                        articulo.Categoria.Nombre,  // Mostrar el nombre de la categor�a asociada
                        articulo.Marca,
                        articulo.Activo ? "S�" : "No"  // Convertir el booleano a "S�"/"No"
                    );
                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // Crear instancia de la capa l�gica para consultar los administradores
            AdministradorLN administradoresLogica = new AdministradorLN();

            // Obtener el arreglo de administradores desde la capa l�gica
            Administrador[] administradores = administradoresLogica.Consultar();

            // Limpiar completamente el DataGridView: filas y columnas
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();  // Limpiar tambi�n las columnas

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
            // Crear instancia de la capa l�gica para consultar las sucursales
            SucursalLN sucursalesLogica = new SucursalLN();

            // Obtener el arreglo de sucursales desde la capa l�gica
            Sucursal[] sucursales = sucursalesLogica.Consultar();

            // Limpiar completamente el DataGridView: filas y columnas
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();  // Limpiar tambi�n las columnas

            // Agregar las columnas necesarias para las sucursales
            dataGridView1.Columns.Add("Id", "ID de Sucursal");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Administrador", "Administrador");
            dataGridView1.Columns.Add("Direccion", "Direcci�n");
            dataGridView1.Columns.Add("Telefono", "Tel�fono");
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
                        sucursal.Activo ? "S�" : "No"  // Mostrar "S�" o "No" para el estado de activo
                    );
                }
            }

        }
    }
}
