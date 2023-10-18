namespace CapaPresentación
{
    partial class Registro_Personal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombrePersonal = new System.Windows.Forms.TextBox();
            this.txtApellidoPersonal = new System.Windows.Forms.TextBox();
            this.fechaNacimientoPersonal = new System.Windows.Forms.DateTimePicker();
            this.txtDireccionPersonal = new System.Windows.Forms.TextBox();
            this.txtDNIpersonal = new System.Windows.Forms.TextBox();
            this.selGenero = new System.Windows.Forms.ComboBox();
            this.generopersonalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaodontologiaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_odontologiaDataSet = new CapaPresentación.sistema_odontologiaDataSet();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTelefonoPersonal = new System.Windows.Forms.TextBox();
            this.txtEmailPersonal = new System.Windows.Forms.TextBox();
            this.txtContrasenaPersonal = new System.Windows.Forms.TextBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generopersonalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selEspecialidad = new System.Windows.Forms.ComboBox();
            this.especialidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.boton_registrar = new FontAwesome.Sharp.IconButton();
            this.txtconfirmarConPersonal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.registroPersonalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genero_personalTableAdapter = new CapaPresentación.sistema_odontologiaDataSetTableAdapters.genero_personalTableAdapter();
            this.categoriaTableAdapter = new CapaPresentación.sistema_odontologiaDataSetTableAdapters.categoriaTableAdapter();
            this.especialidadTableAdapter = new CapaPresentación.sistema_odontologiaDataSetTableAdapters.especialidadTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.horario_inicio = new System.Windows.Forms.ComboBox();
            this.horario_fin = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.generopersonalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaodontologiaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_odontologiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generopersonalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroPersonalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(461, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(461, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(46, 372);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(461, 297);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Teléfono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(461, 375);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Correo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(46, 227);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Género:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(461, 461);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "Contraseña:";
            // 
            // txtNombrePersonal
            // 
            this.txtNombrePersonal.Location = new System.Drawing.Point(132, 152);
            this.txtNombrePersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombrePersonal.Name = "txtNombrePersonal";
            this.txtNombrePersonal.Size = new System.Drawing.Size(211, 28);
            this.txtNombrePersonal.TabIndex = 10;
            // 
            // txtApellidoPersonal
            // 
            this.txtApellidoPersonal.Location = new System.Drawing.Point(548, 152);
            this.txtApellidoPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoPersonal.Name = "txtApellidoPersonal";
            this.txtApellidoPersonal.Size = new System.Drawing.Size(195, 28);
            this.txtApellidoPersonal.TabIndex = 11;
            // 
            // fechaNacimientoPersonal
            // 
            this.fechaNacimientoPersonal.CustomFormat = "dd/MM/yyyy";
            this.fechaNacimientoPersonal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaNacimientoPersonal.Location = new System.Drawing.Point(664, 222);
            this.fechaNacimientoPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.fechaNacimientoPersonal.Name = "fechaNacimientoPersonal";
            this.fechaNacimientoPersonal.Size = new System.Drawing.Size(195, 28);
            this.fechaNacimientoPersonal.TabIndex = 12;
            // 
            // txtDireccionPersonal
            // 
            this.txtDireccionPersonal.Location = new System.Drawing.Point(144, 369);
            this.txtDireccionPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionPersonal.Name = "txtDireccionPersonal";
            this.txtDireccionPersonal.Size = new System.Drawing.Size(241, 28);
            this.txtDireccionPersonal.TabIndex = 14;
            // 
            // txtDNIpersonal
            // 
            this.txtDNIpersonal.Location = new System.Drawing.Point(99, 294);
            this.txtDNIpersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNIpersonal.Name = "txtDNIpersonal";
            this.txtDNIpersonal.Size = new System.Drawing.Size(215, 28);
            this.txtDNIpersonal.TabIndex = 17;
            // 
            // selGenero
            // 
            this.selGenero.DataSource = this.generopersonalBindingSource1;
            this.selGenero.DisplayMember = "Nombre";
            this.selGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selGenero.FormattingEnabled = true;
            this.selGenero.Location = new System.Drawing.Point(129, 222);
            this.selGenero.Margin = new System.Windows.Forms.Padding(4);
            this.selGenero.Name = "selGenero";
            this.selGenero.Size = new System.Drawing.Size(211, 33);
            this.selGenero.TabIndex = 20;
            this.selGenero.ValueMember = "GeneroID";
            this.selGenero.SelectedIndexChanged += new System.EventHandler(this.selGenero_SelectedIndexChanged);
            // 
            // generopersonalBindingSource1
            // 
            this.generopersonalBindingSource1.DataMember = "genero_personal";
            this.generopersonalBindingSource1.DataSource = this.sistemaodontologiaDataSetBindingSource;
            // 
            // sistemaodontologiaDataSetBindingSource
            // 
            this.sistemaodontologiaDataSetBindingSource.DataSource = this.sistema_odontologiaDataSet;
            this.sistemaodontologiaDataSetBindingSource.Position = 0;
            // 
            // sistema_odontologiaDataSet
            // 
            this.sistema_odontologiaDataSet.DataSetName = "sistema_odontologiaDataSet";
            this.sistema_odontologiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(978, 117);
            this.menuStrip2.TabIndex = 21;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label10.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(352, 78);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(224, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Formulario de registro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(46, 297);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 22);
            this.label11.TabIndex = 24;
            this.label11.Text = "DNI:";
            // 
            // txtTelefonoPersonal
            // 
            this.txtTelefonoPersonal.Location = new System.Drawing.Point(555, 297);
            this.txtTelefonoPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoPersonal.Name = "txtTelefonoPersonal";
            this.txtTelefonoPersonal.Size = new System.Drawing.Size(215, 28);
            this.txtTelefonoPersonal.TabIndex = 25;
            // 
            // txtEmailPersonal
            // 
            this.txtEmailPersonal.Location = new System.Drawing.Point(539, 375);
            this.txtEmailPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailPersonal.Name = "txtEmailPersonal";
            this.txtEmailPersonal.Size = new System.Drawing.Size(279, 28);
            this.txtEmailPersonal.TabIndex = 26;
            // 
            // txtContrasenaPersonal
            // 
            this.txtContrasenaPersonal.Location = new System.Drawing.Point(577, 458);
            this.txtContrasenaPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasenaPersonal.Name = "txtContrasenaPersonal";
            this.txtContrasenaPersonal.Size = new System.Drawing.Size(215, 28);
            this.txtContrasenaPersonal.TabIndex = 27;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "categoria";
            this.categoriaBindingSource.DataSource = this.sistemaodontologiaDataSetBindingSource;
            // 
            // generopersonalBindingSource
            // 
            this.generopersonalBindingSource.DataMember = "genero_personal";
            this.generopersonalBindingSource.DataSource = this.sistemaodontologiaDataSetBindingSource;
            // 
            // selEspecialidad
            // 
            this.selEspecialidad.AutoCompleteCustomSource.AddRange(new string[] {
            "Uno",
            "Dos"});
            this.selEspecialidad.DataSource = this.especialidadBindingSource;
            this.selEspecialidad.DisplayMember = "Nombre";
            this.selEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selEspecialidad.FormattingEnabled = true;
            this.selEspecialidad.Location = new System.Drawing.Point(171, 438);
            this.selEspecialidad.Margin = new System.Windows.Forms.Padding(4);
            this.selEspecialidad.Name = "selEspecialidad";
            this.selEspecialidad.Size = new System.Drawing.Size(174, 33);
            this.selEspecialidad.TabIndex = 31;
            this.selEspecialidad.ValueMember = "ID";
            // 
            // especialidadBindingSource
            // 
            this.especialidadBindingSource.DataMember = "especialidad";
            this.especialidadBindingSource.DataSource = this.sistemaodontologiaDataSetBindingSource;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(46, 443);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 22);
            this.label13.TabIndex = 30;
            this.label13.Text = "Especialidad:";
            // 
            // boton_registrar
            // 
            this.boton_registrar.BackColor = System.Drawing.Color.LimeGreen;
            this.boton_registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_registrar.ForeColor = System.Drawing.Color.White;
            this.boton_registrar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.boton_registrar.IconColor = System.Drawing.Color.Black;
            this.boton_registrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.boton_registrar.IconSize = 26;
            this.boton_registrar.Location = new System.Drawing.Point(382, 729);
            this.boton_registrar.Name = "boton_registrar";
            this.boton_registrar.Size = new System.Drawing.Size(167, 34);
            this.boton_registrar.TabIndex = 32;
            this.boton_registrar.Text = "Registrar";
            this.boton_registrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.boton_registrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.boton_registrar.UseVisualStyleBackColor = false;
            this.boton_registrar.Click += new System.EventHandler(this.boton_registrar_Click);
            // 
            // txtconfirmarConPersonal
            // 
            this.txtconfirmarConPersonal.Location = new System.Drawing.Point(656, 531);
            this.txtconfirmarConPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtconfirmarConPersonal.Name = "txtconfirmarConPersonal";
            this.txtconfirmarConPersonal.Size = new System.Drawing.Size(215, 28);
            this.txtconfirmarConPersonal.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(461, 534);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(187, 22);
            this.label14.TabIndex = 33;
            this.label14.Text = "Confirmar contraseña:";
            // 
            // registroPersonalBindingSource
            // 
            this.registroPersonalBindingSource.DataSource = typeof(CapaPresentación.Registro_Personal);
            // 
            // genero_personalTableAdapter
            // 
            this.genero_personalTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // especialidadTableAdapter
            // 
            this.especialidadTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 537);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 35;
            this.label2.Text = "Horario de Inicio:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(46, 600);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 22);
            this.label15.TabIndex = 36;
            this.label15.Text = "Horario de fin:";
            // 
            // horario_inicio
            // 
            this.horario_inicio.AutoCompleteCustomSource.AddRange(new string[] {
            "Uno",
            "Dos"});
            this.horario_inicio.DataSource = this.especialidadBindingSource;
            this.horario_inicio.DisplayMember = "Nombre";
            this.horario_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horario_inicio.FormattingEnabled = true;
            this.horario_inicio.Location = new System.Drawing.Point(194, 532);
            this.horario_inicio.Margin = new System.Windows.Forms.Padding(4);
            this.horario_inicio.Name = "horario_inicio";
            this.horario_inicio.Size = new System.Drawing.Size(174, 33);
            this.horario_inicio.TabIndex = 37;
            this.horario_inicio.ValueMember = "ID";
            // 
            // horario_fin
            // 
            this.horario_fin.AutoCompleteCustomSource.AddRange(new string[] {
            "Uno",
            "Dos"});
            this.horario_fin.DataSource = this.especialidadBindingSource;
            this.horario_fin.DisplayMember = "Nombre";
            this.horario_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horario_fin.FormattingEnabled = true;
            this.horario_fin.Location = new System.Drawing.Point(194, 595);
            this.horario_fin.Margin = new System.Windows.Forms.Padding(4);
            this.horario_fin.Name = "horario_fin";
            this.horario_fin.Size = new System.Drawing.Size(174, 33);
            this.horario_fin.TabIndex = 38;
            this.horario_fin.ValueMember = "ID";
            // 
            // Registro_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(978, 794);
            this.Controls.Add(this.horario_fin);
            this.Controls.Add(this.horario_inicio);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtconfirmarConPersonal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.boton_registrar);
            this.Controls.Add(this.selEspecialidad);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtContrasenaPersonal);
            this.Controls.Add(this.txtEmailPersonal);
            this.Controls.Add(this.txtTelefonoPersonal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.selGenero);
            this.Controls.Add(this.txtDNIpersonal);
            this.Controls.Add(this.txtDireccionPersonal);
            this.Controls.Add(this.fechaNacimientoPersonal);
            this.Controls.Add(this.txtApellidoPersonal);
            this.Controls.Add(this.txtNombrePersonal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registro_Personal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro_Personal";
            this.Load += new System.EventHandler(this.Registro_Personal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generopersonalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaodontologiaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_odontologiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generopersonalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroPersonalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombrePersonal;
        private System.Windows.Forms.TextBox txtApellidoPersonal;
        private System.Windows.Forms.DateTimePicker fechaNacimientoPersonal;
        private System.Windows.Forms.TextBox txtDireccionPersonal;
        private System.Windows.Forms.TextBox txtDNIpersonal;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTelefonoPersonal;
        private System.Windows.Forms.TextBox txtEmailPersonal;
        private System.Windows.Forms.TextBox txtContrasenaPersonal;
        private System.Windows.Forms.ComboBox selEspecialidad;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconButton boton_registrar;
        private System.Windows.Forms.TextBox txtconfirmarConPersonal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.BindingSource registroPersonalBindingSource;
        private System.Windows.Forms.BindingSource sistemaodontologiaDataSetBindingSource;
        private sistema_odontologiaDataSet sistema_odontologiaDataSet;
        private System.Windows.Forms.BindingSource generopersonalBindingSource;
        private sistema_odontologiaDataSetTableAdapters.genero_personalTableAdapter genero_personalTableAdapter;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private sistema_odontologiaDataSetTableAdapters.categoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.BindingSource generopersonalBindingSource1;
        public System.Windows.Forms.ComboBox selGenero;
        private System.Windows.Forms.BindingSource especialidadBindingSource;
        private sistema_odontologiaDataSetTableAdapters.especialidadTableAdapter especialidadTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox horario_inicio;
        private System.Windows.Forms.ComboBox horario_fin;
    }
}