using Infolutions.services; // Asegúrate de tener esta referencia para usar ProyectoServicio
using Infolutions.modelos;  // Referencia al modelo Proyecto
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using practico1.modelo;
using practico1.servicios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace practico1
{
    public partial class Form1 : Form
    {
        private ProyectoServicio proyectoServicio;
        private BindingSource bindingSourceProyectos;
        private TareaServicio tareaServicio;
        private BindingSource bindingSourceTareas;
        // Declaración del BindingSource


        public Form1()
        {
            InitializeComponent();
            proyectoServicio = new ProyectoServicio(); // Inicializar la instancia de ProyectoServicio
            bindingSourceProyectos = new BindingSource(); // Inicializar el BindingSource
            tareaServicio = new TareaServicio(); // Inicializa el servicio de tarea
            bindingSourceTareas = new BindingSource(); // Inicializa el BindingSource para tareas
            tablaProyectos.DataSource = bindingSourceProyectos;
            tablaTareas.DataSource = bindingSourceTareas;

            CargarProyectos();
            CargarTareas();// Llamar a la función para cargar proyectos al iniciar el formulario

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
                    WorkerHours = numericHorasEstimadas.Value.ToString(),
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

        //BOTON EDITAR-----------------------------------------------------------------------------------------------------------------------------

        private async void btnEditarProyecto_Click(object sender, EventArgs e)
        {
            // Validar los campos de entrada
            if (string.IsNullOrEmpty(textBoxNombre.Text) || string.IsNullOrEmpty(textBoxDescripcion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.");
                return;
            }

            try
            {
                // Crear un objeto Proyecto con los datos de los controles
                Proyecto proyectoEditado = new Proyecto
                {
                    Id = int.Parse(txtId.Text), // Asumiendo que tienes un campo txtId
                    Name = textBoxNombre.Text,
                    Description = textBoxDescripcion.Text,
                    Status = comboBoxEstado.SelectedItem?.ToString() ?? "Pendiente",
                    WorkerHours = numericHorasEstimadas.Value.ToString(),
                    TotalHours = numericHorasTotales.Value.ToString(),
                    CreatedAt = dateTimeCreacion.Value
                };

                // Llamar al método Update para actualizar el proyecto a través de la API
                string resultado = await proyectoServicio.Update(proyectoEditado.Id, proyectoEditado);

                if (!string.IsNullOrEmpty(resultado))
                {
                    MessageBox.Show("Proyecto actualizado exitosamente.");

                    // Volver a cargar los proyectos para reflejar la actualización en el DataGridView
                    CargarProyectos();
                }
                else
                {
                    MessageBox.Show("Hubo un error al intentar actualizar el proyecto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el proyecto: {ex.Message}");
            }
        }

        private void btnCargarInput_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (tablaProyectos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un proyecto para editar.");
                return;
            }

            // Obtener el proyecto seleccionado del DataGridView
            Proyecto proyectoSeleccionado = (Proyecto)tablaProyectos.SelectedRows[0].DataBoundItem;

            // Rellenar los controles con los datos del proyecto seleccionado para permitir la edición
            txtId.Text = proyectoSeleccionado.Id.ToString(); // Asumiendo que tienes un campo txtId
            textBoxNombre.Text = proyectoSeleccionado.Name;
            textBoxDescripcion.Text = proyectoSeleccionado.Description;
            comboBoxEstado.SelectedItem = proyectoSeleccionado.Status;
            numericHorasEstimadas.Value = decimal.Parse(proyectoSeleccionado.WorkerHours);
            numericHorasTotales.Value = decimal.Parse(proyectoSeleccionado.TotalHours);
            dateTimeCreacion.Value = proyectoSeleccionado.CreatedAt;
        }


        // ----------------------------------- Gestion de Tareas -----------------------------------

        // Método para agregar una tarea a un proyecto

        private string ObtenerEstadoTarea()
        {
            if (Finalizado.Checked)
            {
                return "Finalizado";
            }
            else if (Pendiente.Checked)
            {
                return "Pendiente";
            }
            else if (Progreso.Checked)
            {
                return "En Progreso";
            }
            else
            {
                return "Pendiente";
            }
        }

        private string ObtenerAreaTarea()
        {
            if (Hardware.Checked)
            {
                return "Hardware";
            }
            else if (Redes.Checked)
            {
                return "Redes";
            }
            else
            {
                return "No especificado"; // Valor predeterminado si ningún RadioButton está seleccionado
            }
        }

        private async void CargarTareas()
        {
            try
            {
                // Verificar que tengas una instancia de TareaServicio
                List<Tarea> listaDeTareas = await tareaServicio.Index();

                // Validar si listaDeTareas es null
                if (listaDeTareas == null)
                {
                    MessageBox.Show("No se pudieron cargar las tareas. La lista es nula.");
                    return;
                }

                // Verificar si la lista está vacía
                if (listaDeTareas.Count == 0)
                {
                    MessageBox.Show("La lista de tareas está vacía.");
                }

                // Mostrar la cantidad de tareas cargadas
                MessageBox.Show($"Se cargaron {listaDeTareas.Count} tareas.");

                // Asignar la lista de tareas al BindingSource
                bindingSourceTareas.DataSource = listaDeTareas;

                // Refrescar el DataGridView para mostrar los nuevos datos
                tablaTareas.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las tareas: {ex.Message}");
            }
        }

        private async void btnIngresarTareas_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBoxEmpleado.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.");
                return;
            }

            try
            {
                // Crear un nuevo objeto Tarea con los datos ingresados
                Tarea nuevaTarea = new Tarea
                {
                    Responsable = textBoxEmpleado.Text,
                    FechaCreacion = dateTimePicker1.Value,
                    Descripcion = textBox1.Text,
                    Estado = ObtenerEstadoTarea(),
                    Area = ObtenerAreaTarea()
                };

                string resultado = await tareaServicio.Create(nuevaTarea);

                if (!string.IsNullOrEmpty(resultado))
                {
                    MessageBox.Show("Tarea agregada exitosamente.");
                    CargarTareas(); // Recargar las tareas para reflejar la nueva tarea
                }
                else
                {
                    MessageBox.Show("Hubo un error al intentar agregar la tarea.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la tarea: {ex.Message}");
            }
        }

       
    }


}




