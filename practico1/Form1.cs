using Infolutions.services; // Asegúrate de tener esta referencia para usar ProyectoServicio
using Infolutions.modelos;  // Referencia al modelo Proyecto
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace practico1
{
    public partial class Form1 : Form
    {
        private ProyectoServicio proyectoServicio;
        private BindingSource bindingSourceProyectos; // Declaración del BindingSource

        public Form1()
        {
            InitializeComponent();
            proyectoServicio = new ProyectoServicio(); // Inicializar la instancia de ProyectoServicio
            bindingSourceProyectos = new BindingSource(); // Inicializar el BindingSource
            tablaProyectos.DataSource = bindingSourceProyectos; // Enlazar el DataGridView con el BindingSource
            CargarProyectos(); // Llamar a la función para cargar proyectos al iniciar el formulario
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Lógica para manejar el evento del cambio de estado del RadioButton
        }

        private async void btnAgregarP_Click(object sender, EventArgs e)
        {
            // Validar los campos de entrada
            if (string.IsNullOrEmpty(textBoxNombre.Text) || string.IsNullOrEmpty(textBoxDescripcion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.");
                return;
            }

            try
            {
                // Crear un nuevo objeto Proyecto con los datos ingresados
                Proyecto nuevoProyecto = new Proyecto
                {
                    Name = textBoxNombre.Text,
                    Description = textBoxDescripcion.Text,
                    Status = comboBoxEstado.SelectedItem?.ToString() ?? "Pendiente", // Asumimos que la opción por defecto es "Pendiente"
                    WorkerHours = numericHoras.Value.ToString(),
                    TotalHours = numericHorasTotales.Value.ToString(),
                    CreatedAt = dateTimeCreacion.Value
                };

                // Llamar al método Create para agregar el proyecto a través de la API
                string resultado = await proyectoServicio.Create(nuevoProyecto);

                if (!string.IsNullOrEmpty(resultado))
                {
                    MessageBox.Show("Proyecto agregado exitosamente.");

                    // Volver a cargar los proyectos para reflejar el nuevo en el DataGridView
                    CargarProyectos();
                }
                else
                {
                    MessageBox.Show("Hubo un error al intentar agregar el proyecto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el proyecto: {ex.Message}");
            }
        }

        // Función para cargar proyectos en el BindingSource y actualizar el DataGridView
        private async void CargarProyectos()
        {
            try
            {
                // Llamar al método Index de ProyectoServicio para obtener la lista de proyectos
                List<Proyecto> listaDeProyectos = await proyectoServicio.Index();

                // Validar si listaDeProyectos es null
                if (listaDeProyectos == null)
                {
                    MessageBox.Show("No se pudieron cargar los proyectos. La lista es nula.");
                    return; // Salir de la función si la lista es nula
                }

                // Asignar la lista de proyectos al BindingSource
                bindingSourceProyectos.DataSource = listaDeProyectos;

                // Refrescar el DataGridView para mostrar los nuevos datos
                tablaProyectos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los proyectos: {ex.Message}");
            }
        }

        //BOTON ELIMINAR----------------------------------------------------------------------------------------

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            // Asegurarse de que hay una fila seleccionada
            if (tablaProyectos.SelectedRows.Count > 0)
            {
                // Obtener el proyecto seleccionado
                var selectedRow = tablaProyectos.SelectedRows[0];
                var proyecto = (Proyecto)selectedRow.DataBoundItem;

                // Confirmar la eliminación
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este proyecto?",
                                                     "Confirmar Eliminación",
                                                     MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        // Llamar al método Delete del servicio
                        string resultado = await proyectoServicio.Delete(proyecto.Id);
                        MessageBox.Show(resultado, "Resultado de Eliminación", MessageBoxButtons.OK);

                        // Volver a cargar los proyectos para reflejar la eliminación en el DataGridView
                        CargarProyectos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar el proyecto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un proyecto para eliminar.", "Ningún Proyecto Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
