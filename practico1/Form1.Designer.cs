namespace practico1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            tablaProyectos = new DataGridView();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnEditarProyecto = new Button();
            dateTimeCreacion = new DateTimePicker();
            label6 = new Label();
            numericHorasTotales = new NumericUpDown();
            label5 = new Label();
            comboBoxEstado = new ComboBox();
            textBoxDescripcion = new TextBox();
            textBoxNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnEditar = new Button();
            btnIngresarTarea = new Button();
            dataGridView1 = new DataGridView();
            label11 = new Label();
            numericHoras = new NumericUpDown();
            label10 = new Label();
            textBox1 = new TextBox();
            textBoxEmpleado = new TextBox();
            label9 = new Label();
            groupBox1 = new GroupBox();
            activo = new RadioButton();
            noActivo = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            groupBoxActivo = new GroupBox();
            Progreso = new RadioButton();
            Finalizado = new RadioButton();
            Pendiente = new RadioButton();
            label8 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaProyectos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericHorasTotales).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericHoras).BeginInit();
            groupBox1.SuspendLayout();
            groupBoxActivo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tablaProyectos);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnEditarProyecto);
            panel1.Controls.Add(dateTimeCreacion);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(numericHorasTotales);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBoxEstado);
            panel1.Controls.Add(textBoxDescripcion);
            panel1.Controls.Add(textBoxNombre);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1061, 325);
            panel1.TabIndex = 0;
            // 
            // tablaProyectos
            // 
            tablaProyectos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaProyectos.Location = new Point(373, 40);
            tablaProyectos.Margin = new Padding(3, 4, 3, 4);
            tablaProyectos.Name = "tablaProyectos";
            tablaProyectos.RowHeadersWidth = 51;
            tablaProyectos.RowTemplate.Height = 25;
            tablaProyectos.Size = new Size(660, 261);
            tablaProyectos.TabIndex = 15;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(265, 277);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(154, 277);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditarProyecto
            // 
            btnEditarProyecto.Location = new Point(34, 277);
            btnEditarProyecto.Name = "btnEditarProyecto";
            btnEditarProyecto.Size = new Size(94, 29);
            btnEditarProyecto.TabIndex = 12;
            btnEditarProyecto.Text = "Editar";
            btnEditarProyecto.UseVisualStyleBackColor = true;
            btnEditarProyecto.Click += btnAgregar_Click;
            // 
            // dateTimeCreacion
            // 
            dateTimeCreacion.Location = new Point(153, 224);
            dateTimeCreacion.Name = "dateTimeCreacion";
            dateTimeCreacion.Size = new Size(201, 27);
            dateTimeCreacion.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 224);
            label6.Name = "label6";
            label6.Size = new Size(131, 20);
            label6.TabIndex = 9;
            label6.Text = "Fecha de creación:";
            // 
            // numericHorasTotales
            // 
            numericHorasTotales.Location = new Point(144, 179);
            numericHorasTotales.Name = "numericHorasTotales";
            numericHorasTotales.Size = new Size(87, 27);
            numericHorasTotales.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 179);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 7;
            label5.Text = "Horas totales:";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(135, 132);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(143, 28);
            comboBoxEstado.TabIndex = 6;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(135, 83);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(143, 27);
            textBoxDescripcion.TabIndex = 5;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(135, 40);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(146, 27);
            textBoxNombre.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 135);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Estado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 79);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Descripción:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 43);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 11);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 0;
            label1.Text = "Gestión de proyectos";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnIngresarTarea);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(numericHoras);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(textBoxEmpleado);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(groupBoxActivo);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(11, 359);
            panel2.Name = "panel2";
            panel2.Size = new Size(1063, 391);
            panel2.TabIndex = 1;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(189, 341);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnIngresarTarea
            // 
            btnIngresarTarea.Location = new Point(64, 341);
            btnIngresarTarea.Name = "btnIngresarTarea";
            btnIngresarTarea.Size = new Size(94, 29);
            btnIngresarTarea.TabIndex = 17;
            btnIngresarTarea.Text = "Ingresar ";
            btnIngresarTarea.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(374, 61);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(661, 309);
            dataGridView1.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(106, 299);
            label11.Name = "label11";
            label11.Size = new Size(51, 20);
            label11.TabIndex = 14;
            label11.Text = "Horas:";
            // 
            // numericHoras
            // 
            numericHoras.Location = new Point(174, 296);
            numericHoras.Name = "numericHoras";
            numericHoras.Size = new Size(87, 27);
            numericHoras.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(94, 257);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 12;
            label10.Text = "Proyecto:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 253);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 27);
            textBox1.TabIndex = 11;
            // 
            // textBoxEmpleado
            // 
            textBoxEmpleado.Location = new Point(170, 216);
            textBoxEmpleado.Name = "textBoxEmpleado";
            textBoxEmpleado.Size = new Size(163, 27);
            textBoxEmpleado.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 219);
            label9.Name = "label9";
            label9.Size = new Size(147, 20);
            label9.TabIndex = 9;
            label9.Text = "Empleado Asignado:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(activo);
            groupBox1.Controls.Add(noActivo);
            groupBox1.Location = new Point(171, 92);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(133, 108);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Area";
            // 
            // activo
            // 
            activo.AutoSize = true;
            activo.Location = new Point(16, 29);
            activo.Margin = new Padding(3, 4, 3, 4);
            activo.Name = "activo";
            activo.Size = new Size(95, 24);
            activo.TabIndex = 3;
            activo.TabStop = true;
            activo.Text = "Hardware";
            activo.UseVisualStyleBackColor = true;
            // 
            // noActivo
            // 
            noActivo.AutoSize = true;
            noActivo.Location = new Point(16, 53);
            noActivo.Margin = new Padding(3, 4, 3, 4);
            noActivo.Name = "noActivo";
            noActivo.Size = new Size(70, 24);
            noActivo.TabIndex = 3;
            noActivo.TabStop = true;
            noActivo.Text = "Redes";
            noActivo.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(136, 51);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(197, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // groupBoxActivo
            // 
            groupBoxActivo.Controls.Add(Progreso);
            groupBoxActivo.Controls.Add(Finalizado);
            groupBoxActivo.Controls.Add(Pendiente);
            groupBoxActivo.Location = new Point(23, 85);
            groupBoxActivo.Margin = new Padding(3, 4, 3, 4);
            groupBoxActivo.Name = "groupBoxActivo";
            groupBoxActivo.Padding = new Padding(3, 4, 3, 4);
            groupBoxActivo.Size = new Size(133, 115);
            groupBoxActivo.TabIndex = 6;
            groupBoxActivo.TabStop = false;
            groupBoxActivo.Text = "Estado";
            // 
            // Progreso
            // 
            Progreso.AutoSize = true;
            Progreso.Location = new Point(16, 77);
            Progreso.Margin = new Padding(3, 4, 3, 4);
            Progreso.Name = "Progreso";
            Progreso.Size = new Size(110, 24);
            Progreso.TabIndex = 4;
            Progreso.TabStop = true;
            Progreso.Text = "En progreso";
            Progreso.UseVisualStyleBackColor = true;
            Progreso.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Finalizado
            // 
            Finalizado.AutoSize = true;
            Finalizado.Location = new Point(16, 29);
            Finalizado.Margin = new Padding(3, 4, 3, 4);
            Finalizado.Name = "Finalizado";
            Finalizado.Size = new Size(98, 24);
            Finalizado.TabIndex = 3;
            Finalizado.TabStop = true;
            Finalizado.Text = "Finalizado";
            Finalizado.UseVisualStyleBackColor = true;
            // 
            // Pendiente
            // 
            Pendiente.AutoSize = true;
            Pendiente.Location = new Point(16, 53);
            Pendiente.Margin = new Padding(3, 4, 3, 4);
            Pendiente.Name = "Pendiente";
            Pendiente.Size = new Size(95, 24);
            Pendiente.TabIndex = 3;
            Pendiente.TabStop = true;
            Pendiente.Text = "Pendiente";
            Pendiente.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 51);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 1;
            label8.Text = "Fecha de inicio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(353, 18);
            label7.Name = "label7";
            label7.Size = new Size(125, 20);
            label7.TabIndex = 0;
            label7.Text = "Gestión de Tareas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 763);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaProyectos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericHorasTotales).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericHoras).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxActivo.ResumeLayout(false);
            groupBoxActivo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxEstado;
        private TextBox textBoxDescripcion;
        private TextBox textBoxNombre;
        private DateTimePicker dateTimeCreacion;
        private Label label6;
        private NumericUpDown numericHorasTotales;
        private Label label5;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnEditarProyecto;
        private Panel panel2;
        private Label label7;
        private GroupBox groupBoxActivo;
        private RadioButton Progreso;
        private RadioButton Finalizado;
        private RadioButton Pendiente;
        private Label label8;
        private Label label10;
        private TextBox textBox1;
        private TextBox textBoxEmpleado;
        private Label label9;
        private GroupBox groupBox1;
        private RadioButton activo;
        private RadioButton noActivo;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericHoras;
        private Button btnIngresarTarea;
        private DataGridView dataGridView1;
        private Label label11;
        private DataGridView tablaProyectos;
        private Button btnEditar;
    }
}
