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
            this.txtNombrePersonal = new System.Windows.Forms.TextBox();
            this.txtApellidoPersonal = new System.Windows.Forms.TextBox();
            this.fechaNacimientoPersonal = new System.Windows.Forms.DateTimePicker();
            this.txtDireccionPersonal = new System.Windows.Forms.TextBox();
            this.txtDNIpersonal = new System.Windows.Forms.TextBox();
            this.selGenero = new System.Windows.Forms.ComboBox();
            this.generopersonalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaodontologiaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_odontologiaDataSet = new CapaPresentación.sistema_odontologiaDataSet();
            this.txtTelefonoPersonal = new System.Windows.Forms.TextBox();
            this.txtEmailPersonal = new System.Windows.Forms.TextBox();
            this.txtContrasenaPersonal = new System.Windows.Forms.TextBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generopersonalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selEspecialidad = new System.Windows.Forms.ComboBox();
            this.especialidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boton_registrar = new FontAwesome.Sharp.IconButton();
            this.registroPersonalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genero_personalTableAdapter = new CapaPresentación.sistema_odontologiaDataSetTableAdapters.genero_personalTableAdapter();
            this.categoriaTableAdapter = new CapaPresentación.sistema_odontologiaDataSetTableAdapters.categoriaTableAdapter();
            this.especialidadTableAdapter = new CapaPresentación.sistema_odontologiaDataSetTableAdapters.especialidadTableAdapter();
            this.horario_inicio = new System.Windows.Forms.ComboBox();
            this.horario_fin = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.generopersonalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaodontologiaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_odontologiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generopersonalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroPersonalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombrePersonal
            // 
            this.txtNombrePersonal.Location = new System.Drawing.Point(105, 124);
            this.txtNombrePersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombrePersonal.Name = "txtNombrePersonal";
            this.txtNombrePersonal.Size = new System.Drawing.Size(211, 28);
            this.txtNombrePersonal.TabIndex = 10;
            this.txtNombrePersonal.TextChanged += new System.EventHandler(this.txtNombrePersonal_TextChanged);
            // 
            // txtApellidoPersonal
            // 
            this.txtApellidoPersonal.Location = new System.Drawing.Point(105, 203);
            this.txtApellidoPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoPersonal.Name = "txtApellidoPersonal";
            this.txtApellidoPersonal.Size = new System.Drawing.Size(195, 28);
            this.txtApellidoPersonal.TabIndex = 11;
            // 
            // fechaNacimientoPersonal
            // 
            this.fechaNacimientoPersonal.CustomFormat = "dd/MM/yyyy";
            this.fechaNacimientoPersonal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaNacimientoPersonal.Location = new System.Drawing.Point(219, 276);
            this.fechaNacimientoPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.fechaNacimientoPersonal.Name = "fechaNacimientoPersonal";
            this.fechaNacimientoPersonal.Size = new System.Drawing.Size(145, 28);
            this.fechaNacimientoPersonal.TabIndex = 12;
            // 
            // txtDireccionPersonal
            // 
            this.txtDireccionPersonal.Location = new System.Drawing.Point(106, 568);
            this.txtDireccionPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionPersonal.Name = "txtDireccionPersonal";
            this.txtDireccionPersonal.Size = new System.Drawing.Size(241, 28);
            this.txtDireccionPersonal.TabIndex = 14;
            // 
            // txtDNIpersonal
            // 
            this.txtDNIpersonal.Location = new System.Drawing.Point(105, 422);
            this.txtDNIpersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNIpersonal.Name = "txtDNIpersonal";
            this.txtDNIpersonal.Size = new System.Drawing.Size(215, 28);
            this.txtDNIpersonal.TabIndex = 17;
            this.txtDNIpersonal.TextChanged += new System.EventHandler(this.txtDNIpersonal_TextChanged);
            // 
            // selGenero
            // 
            this.selGenero.DataSource = this.generopersonalBindingSource1;
            this.selGenero.DisplayMember = "Nombre";
            this.selGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selGenero.FormattingEnabled = true;
            this.selGenero.Location = new System.Drawing.Point(105, 349);
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
            // txtTelefonoPersonal
            // 
            this.txtTelefonoPersonal.Location = new System.Drawing.Point(106, 495);
            this.txtTelefonoPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoPersonal.Name = "txtTelefonoPersonal";
            this.txtTelefonoPersonal.Size = new System.Drawing.Size(215, 28);
            this.txtTelefonoPersonal.TabIndex = 25;
            this.txtTelefonoPersonal.TextChanged += new System.EventHandler(this.txtTelefonoPersonal_TextChanged);
            // 
            // txtEmailPersonal
            // 
            this.txtEmailPersonal.Location = new System.Drawing.Point(1083, 294);
            this.txtEmailPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailPersonal.Name = "txtEmailPersonal";
            this.txtEmailPersonal.Size = new System.Drawing.Size(214, 28);
            this.txtEmailPersonal.TabIndex = 26;
            // 
            // txtContrasenaPersonal
            // 
            this.txtContrasenaPersonal.Location = new System.Drawing.Point(742, 428);
            this.txtContrasenaPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasenaPersonal.Name = "txtContrasenaPersonal";
            this.txtContrasenaPersonal.Size = new System.Drawing.Size(174, 28);
            this.txtContrasenaPersonal.TabIndex = 27;
            this.txtContrasenaPersonal.UseSystemPasswordChar = true;
            this.txtContrasenaPersonal.TextChanged += new System.EventHandler(this.txtContrasenaPersonal_TextChanged);
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
            this.selEspecialidad.Location = new System.Drawing.Point(742, 292);
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
            this.boton_registrar.Location = new System.Drawing.Point(1178, 565);
            this.boton_registrar.Name = "boton_registrar";
            this.boton_registrar.Size = new System.Drawing.Size(167, 34);
            this.boton_registrar.TabIndex = 32;
            this.boton_registrar.Text = "Registrar";
            this.boton_registrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.boton_registrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.boton_registrar.UseVisualStyleBackColor = false;
            this.boton_registrar.Click += new System.EventHandler(this.boton_registrar_Click);
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
            // horario_inicio
            // 
            this.horario_inicio.AutoCompleteCustomSource.AddRange(new string[] {
            "Uno",
            "Dos"});
            this.horario_inicio.DataSource = this.especialidadBindingSource;
            this.horario_inicio.DisplayMember = "Nombre";
            this.horario_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horario_inicio.FormattingEnabled = true;
            this.horario_inicio.Location = new System.Drawing.Point(742, 140);
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
            this.horario_fin.Location = new System.Drawing.Point(1119, 140);
            this.horario_fin.Margin = new System.Windows.Forms.Padding(4);
            this.horario_fin.Name = "horario_fin";
            this.horario_fin.Size = new System.Drawing.Size(174, 33);
            this.horario_fin.TabIndex = 38;
            this.horario_fin.ValueMember = "ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(19, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(180, 25);
            this.label16.TabIndex = 41;
            this.label16.Text = "Datos personales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(19, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(19, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 43;
            this.label3.Text = "Apellido:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label8.Location = new System.Drawing.Point(20, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 22);
            this.label8.TabIndex = 44;
            this.label8.Text = "Genero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.Location = new System.Drawing.Point(20, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 22);
            this.label4.TabIndex = 45;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label11.Location = new System.Drawing.Point(46, 422);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 22);
            this.label11.TabIndex = 46;
            this.label11.Text = "DNI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label6.Location = new System.Drawing.Point(13, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 22);
            this.label6.TabIndex = 47;
            this.label6.Text = "Teléfono:";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.Location = new System.Drawing.Point(13, 568);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 48;
            this.label5.Text = "Dirección:";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(544, 636);
            this.label12.TabIndex = 49;
            this.label12.Click += new System.EventHandler(this.label12_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(570, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 25);
            this.label10.TabIndex = 50;
            this.label10.Text = "Datos del perfil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(590, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 51;
            this.label2.Text = "Horario de Inicio:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label15.Location = new System.Drawing.Point(989, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 22);
            this.label15.TabIndex = 52;
            this.label15.Text = "Horario de fin:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.Location = new System.Drawing.Point(609, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 22);
            this.label7.TabIndex = 53;
            this.label7.Text = "Especialidad:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label13.Location = new System.Drawing.Point(1011, 297);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 22);
            this.label13.TabIndex = 54;
            this.label13.Text = "E-mail:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label9.Location = new System.Drawing.Point(627, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 22);
            this.label9.TabIndex = 55;
            this.label9.Text = "Contraseña:";
            // 
            // Registro_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1397, 636);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.horario_fin);
            this.Controls.Add(this.horario_inicio);
            this.Controls.Add(this.boton_registrar);
            this.Controls.Add(this.selEspecialidad);
            this.Controls.Add(this.txtContrasenaPersonal);
            this.Controls.Add(this.txtEmailPersonal);
            this.Controls.Add(this.txtTelefonoPersonal);
            this.Controls.Add(this.selGenero);
            this.Controls.Add(this.txtDNIpersonal);
            this.Controls.Add(this.txtDireccionPersonal);
            this.Controls.Add(this.fechaNacimientoPersonal);
            this.Controls.Add(this.txtApellidoPersonal);
            this.Controls.Add(this.txtNombrePersonal);
            this.Controls.Add(this.label12);
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
        private System.Windows.Forms.TextBox txtNombrePersonal;
        private System.Windows.Forms.TextBox txtApellidoPersonal;
        private System.Windows.Forms.DateTimePicker fechaNacimientoPersonal;
        private System.Windows.Forms.TextBox txtDireccionPersonal;
        private System.Windows.Forms.TextBox txtDNIpersonal;
        private System.Windows.Forms.TextBox txtTelefonoPersonal;
        private System.Windows.Forms.TextBox txtEmailPersonal;
        private System.Windows.Forms.TextBox txtContrasenaPersonal;
        private System.Windows.Forms.ComboBox selEspecialidad;
        private FontAwesome.Sharp.IconButton boton_registrar;
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
        private System.Windows.Forms.ComboBox horario_inicio;
        private System.Windows.Forms.ComboBox horario_fin;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
    }
}