namespace CapaPresentación
{
    partial class frmRegistro_paciente
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fechaNacimientoPaciente = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_DNI_paciente = new System.Windows.Forms.TextBox();
            this.txt_nombre_paciente = new System.Windows.Forms.TextBox();
            this.txt_apellido_paciente = new System.Windows.Forms.TextBox();
            this.txt_email_paciente = new System.Windows.Forms.TextBox();
            this.genero_paciente = new System.Windows.Forms.ComboBox();
            this.ciudad_paciente = new System.Windows.Forms.ComboBox();
            this.boton_registrar_paciente = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_telefono_paciente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sistema_odontologiaDataSet = new CapaPresentación.sistema_odontologiaDataSet();
            this.pacienteTableAdapter = new CapaPresentación.sistema_odontologiaDataSetTableAdapters.pacienteTableAdapter();
            this.datos_paciente = new System.Windows.Forms.DataGridView();
            this.dNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_odontologiaDataSet5 = new CapaPresentación.sistema_odontologiaDataSet5();
            this.sistema_odontologiaDataSet2 = new CapaPresentación.sistema_odontologiaDataSet2();
            this.pacienteTableAdapter1 = new CapaPresentación.sistema_odontologiaDataSet2TableAdapters.pacienteTableAdapter();
            this.pacienteTableAdapter2 = new CapaPresentación.sistema_odontologiaDataSet5TableAdapters.pacienteTableAdapter();
            this.txt_buscarPaciente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buscarpaciente = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_odontologiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_paciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_odontologiaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_odontologiaDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "*Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "*Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "*Fecha de nacimiento:";
            // 
            // fechaNacimientoPaciente
            // 
            this.fechaNacimientoPaciente.CustomFormat = "dd/MM/yyyy";
            this.fechaNacimientoPaciente.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaNacimientoPaciente.Location = new System.Drawing.Point(263, 203);
            this.fechaNacimientoPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.fechaNacimientoPaciente.Name = "fechaNacimientoPaciente";
            this.fechaNacimientoPaciente.Size = new System.Drawing.Size(165, 22);
            this.fechaNacimientoPaciente.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "*Genero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(259, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "*Ciudad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "*DNI:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(259, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Email:";
            // 
            // txt_DNI_paciente
            // 
            this.txt_DNI_paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DNI_paciente.Location = new System.Drawing.Point(81, 95);
            this.txt_DNI_paciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DNI_paciente.Name = "txt_DNI_paciente";
            this.txt_DNI_paciente.Size = new System.Drawing.Size(165, 27);
            this.txt_DNI_paciente.TabIndex = 19;
            // 
            // txt_nombre_paciente
            // 
            this.txt_nombre_paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_paciente.Location = new System.Drawing.Point(263, 95);
            this.txt_nombre_paciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombre_paciente.Name = "txt_nombre_paciente";
            this.txt_nombre_paciente.Size = new System.Drawing.Size(165, 27);
            this.txt_nombre_paciente.TabIndex = 20;
            // 
            // txt_apellido_paciente
            // 
            this.txt_apellido_paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido_paciente.Location = new System.Drawing.Point(81, 201);
            this.txt_apellido_paciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_apellido_paciente.Name = "txt_apellido_paciente";
            this.txt_apellido_paciente.Size = new System.Drawing.Size(165, 27);
            this.txt_apellido_paciente.TabIndex = 21;
            // 
            // txt_email_paciente
            // 
            this.txt_email_paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email_paciente.Location = new System.Drawing.Point(263, 432);
            this.txt_email_paciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_email_paciente.Name = "txt_email_paciente";
            this.txt_email_paciente.Size = new System.Drawing.Size(165, 27);
            this.txt_email_paciente.TabIndex = 22;
            // 
            // genero_paciente
            // 
            this.genero_paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genero_paciente.FormattingEnabled = true;
            this.genero_paciente.Location = new System.Drawing.Point(80, 307);
            this.genero_paciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genero_paciente.Name = "genero_paciente";
            this.genero_paciente.Size = new System.Drawing.Size(165, 28);
            this.genero_paciente.TabIndex = 23;
            // 
            // ciudad_paciente
            // 
            this.ciudad_paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudad_paciente.FormattingEnabled = true;
            this.ciudad_paciente.Location = new System.Drawing.Point(263, 307);
            this.ciudad_paciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ciudad_paciente.Name = "ciudad_paciente";
            this.ciudad_paciente.Size = new System.Drawing.Size(165, 28);
            this.ciudad_paciente.TabIndex = 24;
            // 
            // boton_registrar_paciente
            // 
            this.boton_registrar_paciente.BackColor = System.Drawing.Color.LimeGreen;
            this.boton_registrar_paciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_registrar_paciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_registrar_paciente.ForeColor = System.Drawing.Color.White;
            this.boton_registrar_paciente.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.boton_registrar_paciente.IconColor = System.Drawing.Color.Black;
            this.boton_registrar_paciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.boton_registrar_paciente.IconSize = 26;
            this.boton_registrar_paciente.Location = new System.Drawing.Point(175, 513);
            this.boton_registrar_paciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boton_registrar_paciente.Name = "boton_registrar_paciente";
            this.boton_registrar_paciente.Size = new System.Drawing.Size(169, 39);
            this.boton_registrar_paciente.TabIndex = 33;
            this.boton_registrar_paciente.Text = "Registrar";
            this.boton_registrar_paciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.boton_registrar_paciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.boton_registrar_paciente.UseVisualStyleBackColor = false;
            this.boton_registrar_paciente.Click += new System.EventHandler(this.boton_registrar_paciente_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 636);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_telefono_paciente
            // 
            this.txt_telefono_paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono_paciente.Location = new System.Drawing.Point(80, 432);
            this.txt_telefono_paciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_telefono_paciente.Name = "txt_telefono_paciente";
            this.txt_telefono_paciente.Size = new System.Drawing.Size(165, 27);
            this.txt_telefono_paciente.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 22);
            this.label8.TabIndex = 35;
            this.label8.Text = "Telèfono:";
            // 
            // sistema_odontologiaDataSet
            // 
            this.sistema_odontologiaDataSet.DataSetName = "sistema_odontologiaDataSet";
            this.sistema_odontologiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // datos_paciente
            // 
            this.datos_paciente.AllowUserToAddRows = false;
            this.datos_paciente.AllowUserToDeleteRows = false;
            this.datos_paciente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datos_paciente.AutoGenerateColumns = false;
            this.datos_paciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datos_paciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datos_paciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos_paciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dNIDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.datos_paciente.DataSource = this.pacienteBindingSource;
            this.datos_paciente.Location = new System.Drawing.Point(629, 55);
            this.datos_paciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datos_paciente.Name = "datos_paciente";
            this.datos_paciente.ReadOnly = true;
            this.datos_paciente.RowHeadersWidth = 51;
            this.datos_paciente.RowTemplate.Height = 24;
            this.datos_paciente.Size = new System.Drawing.Size(689, 150);
            this.datos_paciente.TabIndex = 36;
            this.datos_paciente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            this.dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            this.dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dNIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            this.dNIDataGridViewTextBoxColumn.ReadOnly = true;
            this.dNIDataGridViewTextBoxColumn.Width = 59;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 85;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoDataGridViewTextBoxColumn.Width = 86;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoDataGridViewTextBoxColumn.Width = 90;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 70;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "paciente";
            this.pacienteBindingSource.DataSource = this.sistema_odontologiaDataSet5;
            // 
            // sistema_odontologiaDataSet5
            // 
            this.sistema_odontologiaDataSet5.DataSetName = "sistema_odontologiaDataSet5";
            this.sistema_odontologiaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistema_odontologiaDataSet2
            // 
            this.sistema_odontologiaDataSet2.DataSetName = "sistema_odontologiaDataSet2";
            this.sistema_odontologiaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacienteTableAdapter1
            // 
            this.pacienteTableAdapter1.ClearBeforeFill = true;
            // 
            // pacienteTableAdapter2
            // 
            this.pacienteTableAdapter2.ClearBeforeFill = true;
            // 
            // txt_buscarPaciente
            // 
            this.txt_buscarPaciente.Location = new System.Drawing.Point(843, 222);
            this.txt_buscarPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_buscarPaciente.Name = "txt_buscarPaciente";
            this.txt_buscarPaciente.Size = new System.Drawing.Size(165, 22);
            this.txt_buscarPaciente.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(627, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 22);
            this.label10.TabIndex = 38;
            this.label10.Text = "Buscar paciente por DNI:";
            // 
            // buscarpaciente
            // 
            this.buscarpaciente.BackColor = System.Drawing.Color.RoyalBlue;
            this.buscarpaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarpaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarpaciente.ForeColor = System.Drawing.Color.White;
            this.buscarpaciente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.buscarpaciente.IconColor = System.Drawing.Color.Black;
            this.buscarpaciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buscarpaciente.IconSize = 26;
            this.buscarpaciente.Location = new System.Drawing.Point(1055, 216);
            this.buscarpaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buscarpaciente.Name = "buscarpaciente";
            this.buscarpaciente.Size = new System.Drawing.Size(167, 34);
            this.buscarpaciente.TabIndex = 39;
            this.buscarpaciente.Text = "Buscar";
            this.buscarpaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscarpaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buscarpaciente.UseVisualStyleBackColor = false;
            this.buscarpaciente.Click += new System.EventHandler(this.buscarpaciente_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 26;
            this.iconButton1.Location = new System.Drawing.Point(1055, 270);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(167, 34);
            this.iconButton1.TabIndex = 42;
            this.iconButton1.Text = "Buscar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(627, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(242, 22);
            this.label11.TabIndex = 41;
            this.label11.Text = "Buscar paciente por apellido:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(875, 282);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 22);
            this.textBox1.TabIndex = 40;
            // 
            // frmRegistro_paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1397, 636);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buscarpaciente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_buscarPaciente);
            this.Controls.Add(this.datos_paciente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_telefono_paciente);
            this.Controls.Add(this.boton_registrar_paciente);
            this.Controls.Add(this.ciudad_paciente);
            this.Controls.Add(this.genero_paciente);
            this.Controls.Add(this.txt_email_paciente);
            this.Controls.Add(this.txt_apellido_paciente);
            this.Controls.Add(this.txt_nombre_paciente);
            this.Controls.Add(this.txt_DNI_paciente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fechaNacimientoPaciente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRegistro_paciente";
            this.Text = "frmRegistro_paciente";
            this.Load += new System.EventHandler(this.frmRegistro_paciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistema_odontologiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_paciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_odontologiaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_odontologiaDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fechaNacimientoPaciente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_DNI_paciente;
        private System.Windows.Forms.TextBox txt_nombre_paciente;
        private System.Windows.Forms.TextBox txt_apellido_paciente;
        private System.Windows.Forms.TextBox txt_email_paciente;
        private System.Windows.Forms.ComboBox genero_paciente;
        private System.Windows.Forms.ComboBox ciudad_paciente;
        private FontAwesome.Sharp.IconButton boton_registrar_paciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_telefono_paciente;
        private System.Windows.Forms.Label label8;
        private sistema_odontologiaDataSet sistema_odontologiaDataSet;
        private sistema_odontologiaDataSetTableAdapters.pacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.DataGridView datos_paciente;
        private sistema_odontologiaDataSet2 sistema_odontologiaDataSet2;
        private sistema_odontologiaDataSet2TableAdapters.pacienteTableAdapter pacienteTableAdapter1;
        private sistema_odontologiaDataSet5 sistema_odontologiaDataSet5;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private sistema_odontologiaDataSet5TableAdapters.pacienteTableAdapter pacienteTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_buscarPaciente;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton buscarpaciente;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
    }
}