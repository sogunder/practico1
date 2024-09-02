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
            txtId = new TextBox();
            tablaProyectos = new DataGridView();
            btnEditarProyecto = new Button();
            btnEliminar = new Button();
            btnAgregarP = new Button();
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
            btnCargarInput = new Button();
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
            panel1.Controls.Add(btnCargarInput);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(tablaProyectos);
            panel1.Controls.Add(btnEditarProyecto);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnAgregarP);
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
            panel1.Location = new Point(11, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(928, 244);
            panel1.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(258, 32);
            txtId.Name = "txtId";
            txtId.Size = new Size(33, 23);
            txtId.TabIndex = 16;
            // 
            // tablaProyectos
            // 
            tablaProyectos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaProyectos.Location = new Point(326, 30);
            tablaProyectos.Name = "tablaProyectos";
            tablaProyectos.RowHeadersWidth = 51;
            tablaProyectos.RowTemplate.Height = 25;
            tablaProyectos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaProyectos.Size = new Size(578, 196);
            tablaProyectos.TabIndex = 15;
            // 
            // btnEditarProyecto
            // 
            btnEditarProyecto.Location = new Point(118, 202);
            btnEditarProyecto.Margin = new Padding(3, 2, 3, 2);
            btnEditarProyecto.Name = "btnEditarProyecto";
            btnEditarProyecto.Size = new Size(87, 28);
            btnEditarProyecto.TabIndex = 14;
            btnEditarProyecto.Text = "Editar";
            btnEditarProyecto.UseVisualStyleBackColor = true;
            btnEditarProyecto.Click += btnEditarProyecto_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(219, 202);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(91, 28);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregarP
            // 
            btnAgregarP.Location = new Point(25, 202);
            btnAgregarP.Margin = new Padding(3, 2, 3, 2);
            btnAgregarP.Name = "btnAgregarP";
            btnAgregarP.Size = new Size(79, 28);
            btnAgregarP.TabIndex = 12;
            btnAgregarP.Text = "Agregar";
            btnAgregarP.UseVisualStyleBackColor = true;
            btnAgregarP.Click += btnAgregarP_Click;
            // 
            // dateTimeCreacion
            // 
            dateTimeCreacion.Location = new Point(134, 168);
            dateTimeCreacion.Margin = new Padding(3, 2, 3, 2);
            dateTimeCreacion.Name = "dateTimeCreacion";
            dateTimeCreacion.Size = new Size(176, 23);
            dateTimeCreacion.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 168);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 9;
            label6.Text = "Fecha de creación:";
            // 
            // numericHorasTotales
            // 
            numericHorasTotales.Location = new Point(126, 134);
            numericHorasTotales.Margin = new Padding(3, 2, 3, 2);
            numericHorasTotales.Name = "numericHorasTotales";
            numericHorasTotales.Size = new Size(76, 23);
            numericHorasTotales.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 134);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 7;
            label5.Text = "Horas totales:";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(118, 99);
            comboBoxEstado.Margin = new Padding(3, 2, 3, 2);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(126, 23);
            comboBoxEstado.TabIndex = 6;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(118, 62);
            textBoxDescripcion.Margin = new Padding(3, 2, 3, 2);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(126, 23);
            textBoxDescripcion.TabIndex = 5;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(118, 30);
            textBoxNombre.Margin = new Padding(3, 2, 3, 2);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(128, 23);
            textBoxNombre.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 101);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Estado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 59);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Descripción:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 32);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 8);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
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
            panel2.Location = new Point(10, 269);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(930, 293);
            panel2.TabIndex = 1;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(165, 256);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 22);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnIngresarTarea
            // 
            btnIngresarTarea.Location = new Point(56, 256);
            btnIngresarTarea.Margin = new Padding(3, 2, 3, 2);
            btnIngresarTarea.Name = "btnIngresarTarea";
            btnIngresarTarea.Size = new Size(82, 22);
            btnIngresarTarea.TabIndex = 17;
            btnIngresarTarea.Text = "Ingresar ";
            btnIngresarTarea.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(327, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(578, 232);
            dataGridView1.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(93, 224);
            label11.Name = "label11";
            label11.Size = new Size(41, 15);
            label11.TabIndex = 14;
            label11.Text = "Horas:";
            // 
            // numericHoras
            // 
            numericHoras.Location = new Point(152, 222);
            numericHoras.Margin = new Padding(3, 2, 3, 2);
            numericHoras.Name = "numericHoras";
            numericHoras.Size = new Size(76, 23);
            numericHoras.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(82, 193);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 12;
            label10.Text = "Proyecto:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 190);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 23);
            textBox1.TabIndex = 11;
            // 
            // textBoxEmpleado
            // 
            textBoxEmpleado.Location = new Point(149, 162);
            textBoxEmpleado.Margin = new Padding(3, 2, 3, 2);
            textBoxEmpleado.Name = "textBoxEmpleado";
            textBoxEmpleado.Size = new Size(143, 23);
            textBoxEmpleado.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 164);
            label9.Name = "label9";
            label9.Size = new Size(116, 15);
            label9.TabIndex = 9;
            label9.Text = "Empleado Asignado:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(activo);
            groupBox1.Controls.Add(noActivo);
            groupBox1.Location = new Point(150, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(116, 81);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Area";
            // 
            // activo
            // 
            activo.AutoSize = true;
            activo.Location = new Point(14, 22);
            activo.Name = "activo";
            activo.Size = new Size(76, 19);
            activo.TabIndex = 3;
            activo.TabStop = true;
            activo.Text = "Hardware";
            activo.UseVisualStyleBackColor = true;
            // 
            // noActivo
            // 
            noActivo.AutoSize = true;
            noActivo.Location = new Point(14, 40);
            noActivo.Name = "noActivo";
            noActivo.Size = new Size(56, 19);
            noActivo.TabIndex = 3;
            noActivo.TabStop = true;
            noActivo.Text = "Redes";
            noActivo.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(119, 38);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(173, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // groupBoxActivo
            // 
            groupBoxActivo.Controls.Add(Progreso);
            groupBoxActivo.Controls.Add(Finalizado);
            groupBoxActivo.Controls.Add(Pendiente);
            groupBoxActivo.Location = new Point(20, 64);
            groupBoxActivo.Name = "groupBoxActivo";
            groupBoxActivo.Size = new Size(116, 86);
            groupBoxActivo.TabIndex = 6;
            groupBoxActivo.TabStop = false;
            groupBoxActivo.Text = "Estado";
            // 
            // Progreso
            // 
            Progreso.AutoSize = true;
            Progreso.Location = new Point(14, 58);
            Progreso.Name = "Progreso";
            Progreso.Size = new Size(88, 19);
            Progreso.TabIndex = 4;
            Progreso.TabStop = true;
            Progreso.Text = "En progreso";
            Progreso.UseVisualStyleBackColor = true;
            Progreso.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Finalizado
            // 
            Finalizado.AutoSize = true;
            Finalizado.Location = new Point(14, 22);
            Finalizado.Name = "Finalizado";
            Finalizado.Size = new Size(78, 19);
            Finalizado.TabIndex = 3;
            Finalizado.TabStop = true;
            Finalizado.Text = "Finalizado";
            Finalizado.UseVisualStyleBackColor = true;
            // 
            // Pendiente
            // 
            Pendiente.AutoSize = true;
            Pendiente.Location = new Point(14, 40);
            Pendiente.Name = "Pendiente";
            Pendiente.Size = new Size(78, 19);
            Pendiente.TabIndex = 3;
            Pendiente.TabStop = true;
            Pendiente.Text = "Pendiente";
            Pendiente.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 38);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 1;
            label8.Text = "Fecha de inicio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(309, 14);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 0;
            label7.Text = "Gestión de Tareas";
            // 
            // btnCargarInput
            // 
            btnCargarInput.Location = new Point(235, 134);
            btnCargarInput.Name = "btnCargarInput";
            btnCargarInput.Size = new Size(75, 23);
            btnCargarInput.TabIndex = 17;
            btnCargarInput.Text = "CargarDatos";
            btnCargarInput.UseVisualStyleBackColor = true;
            btnCargarInput.Click += btnCargarInput_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 572);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnEditarProyecto;
        private Button btnEliminar;
        private Button btnAgregarP;
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
        private TextBox txtId;
        private Button btnCargarInput;
    }
}
