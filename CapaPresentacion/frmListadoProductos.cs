using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmListadoProductos : Form
    {
        public frmListadoProductos()
        {
            InitializeComponent();
        }

        private void frmListadoProductos_Load(object sender, EventArgs e)
        {
            // *** CORRECCIÓN DE ORDEN ***

            // 1. Cargar el contenido de AMBOS combos primero
            CargarCategorias();
            CargarColumnasBusqueda();

            // 2. Asignar el SelectedIndex del combo de búsqueda (cboBusqueda) PRIMERO
            //    Esto es crucial para que no sea null.
            cboBusqueda.SelectedIndex = 0;

            // 3. Asignar el SelectedIndex del combo de categoría (cboCategoria) DESPUÉS
            //    Esta línea disparará el evento cboCategoria_SelectedIndexChanged
            cboCategoria.SelectedIndex = 0;

            // 4. Cargar los productos en la grilla
            CargarProductos();
        }

        // Carga el ComboBox de Categorías
        private void CargarCategorias()
        {
            cboCategoria.Items.Clear();
            cboCategoria.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Todas" });

            List<Categoria> listaCategoria = new CN_Categoria().Listar();
            foreach (Categoria item in listaCategoria)
            {
                cboCategoria.Items.Add(new OpcionCombo() { Valor = item.IdCategoria, Texto = item.Descripcion });
            }
            cboCategoria.DisplayMember = "Texto";
            cboCategoria.ValueMember = "Valor";

            // cboCategoria.SelectedIndex = 0; // <-- SE QUITA ESTA LÍNEA DE AQUÍ
        }

        // Carga el ComboBox de columnas para filtrar
        private void CargarColumnasBusqueda()
        {
            cboBusqueda.Items.Clear();
            cboBusqueda.Items.Add(new OpcionCombo() { Valor = "Nombre", Texto = "Nombre" });
            cboBusqueda.Items.Add(new OpcionCombo() { Valor = "Codigo", Texto = "Código" });
            cboBusqueda.Items.Add(new OpcionCombo() { Valor = "Descripcion", Texto = "Descripción" });

            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";

            // cboBusqueda.SelectedIndex = 0; // <-- SE QUITA ESTA LÍNEA DE AQUÍ
        }

        // Carga todos los productos en la grilla
        private void CargarProductos()
        {
            dgvdata.Rows.Clear();

            // Usamos CN_Producto.Listar(), que ya existe
            List<Producto> listaProducto = new CN_Producto().Listar();
            foreach (Producto item in listaProducto)
            {
                // Solo mostramos productos Activos
                if (item.Estado == true)
                {
                    dgvdata.Rows.Add(new object[] {
                        item.IdProducto,
                        item.Codigo,
                        item.Nombre,
                        item.Descripcion,
                        item.oCategoria.IdCategoria, // Guardamos el ID real en la columna oculta
                        item.oCategoria.Descripcion, // Mostramos el texto
                        item.Stock,
                        item.PrecioVenta
                    });
                }
            }
        }

        // Lógica del botón Buscar (combina ambos filtros)
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtenemos el IdCategoria seleccionado (0 si es "Todas")
            int idCategoriaSeleccionada = Convert.ToInt32(((OpcionCombo)cboCategoria.SelectedItem).Valor);

            // Obtenemos la columna de texto seleccionada (ej. "Nombre")
            string columnaFiltro = ((OpcionCombo)cboBusqueda.SelectedItem).Valor.ToString();

            // Obtenemos el texto a buscar
            string textoBusqueda = txtBusqueda.Text.Trim().ToUpper();

            // Recorremos cada fila de la grilla
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                // Obtenemos el IdCategoria de la fila (de la columna oculta)
                int idCategoriaFila = Convert.ToInt32(row.Cells["IdCategoria"].Value);

                // --- Lógica de Filtro ---

                // 1. Condición de Categoría
                // La fila es visible si se seleccionó "Todas" (ID 0) O si el ID de la fila coincide con el ID seleccionado
                bool categoriaVisible = (idCategoriaSeleccionada == 0) || (idCategoriaFila == idCategoriaSeleccionada);

                // 2. Condición de Texto
                // La fila es visible si no se escribió nada O si el texto de la celda contiene el texto buscado
                bool textoVisible = string.IsNullOrEmpty(textoBusqueda) ||
                                    row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(textoBusqueda);

                // La fila solo se muestra si CUMPLE AMBAS CONDICIONES
                row.Visible = categoriaVisible && textoVisible;
            }
        }

        // Limpia todos los filtros y muestra todo
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboCategoria.SelectedIndex = 0;
            cboBusqueda.SelectedIndex = 0;
            txtBusqueda.Text = "";

            // Mostramos todas las filas
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        // Si el usuario cambia la categoría, aplicamos el filtro de inmediato
        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Para no ejecutar el filtro cuando el formulario recién carga
            if (cboCategoria.SelectedIndex > -1)
            {
                btnBuscar_Click(sender, e);
            }
        }
    }
}