namespace CapaPresentación
{
    partial class frm_Consulta_de_pacientes
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
            this.label12 = new System.Windows.Forms.Label();
            this.pacienteTableAdapter = new CapaPresentación.sistema_odontologiaDataSet7TableAdapters.pacienteTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buscarDNI = new FontAwesome.Sharp.IconButton();
            this.buscarApellido = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_odontologiaDataSet7 = new CapaPresentación.sistema_odontologiaDataSet7();
            this.actualizardatos = new FontAwesome.Sharp.IconButton();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_odontologiaDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(161, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Consulta de pacientes";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(544, 636);
            this.label12.TabIndex = 52;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Búsquda por DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Búsqueda por apellido:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 232);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 22);
            this.textBox1.TabIndex = 56;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 344);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 22);
            this.textBox2.TabIndex = 57;
            // 
            // buscarDNI
            // 
            this.buscarDNI.BackColor = System.Drawing.Color.RoyalBlue;
            this.buscarDNI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarDNI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarDNI.ForeColor = System.Drawing.Color.White;
            this.buscarDNI.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.buscarDNI.IconColor = System.Drawing.Color.Black;
            this.buscarDNI.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buscarDNI.IconSize = 26;
            this.buscarDNI.Location = new System.Drawing.Point(217, 226);
            this.buscarDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buscarDNI.Name = "buscarDNI";
            this.buscarDNI.Size = new System.Drawing.Size(150, 34);
            this.buscarDNI.TabIndex = 58;
            this.buscarDNI.Text = "Buscar";
            this.buscarDNI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscarDNI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buscarDNI.UseVisualStyleBackColor = false;
            this.buscarDNI.Click += new System.EventHandler(this.buscarDNI_Click);
            // 
            // buscarApellido
            // 
            this.buscarApellido.BackColor = System.Drawing.Color.RoyalBlue;
            this.buscarApellido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarApellido.ForeColor = System.Drawing.Color.White;
            this.buscarApellido.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.buscarApellido.IconColor = System.Drawing.Color.Black;
            this.buscarApellido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buscarApellido.IconSize = 26;
            this.buscarApellido.Location = new System.Drawing.Point(217, 338);
            this.buscarApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buscarApellido.Name = "buscarApellido";
            this.buscarApellido.Size = new System.Drawing.Size(150, 34);
            this.buscarApellido.TabIndex = 59;
            this.buscarApellido.Text = "Buscar";
            this.buscarApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscarApellido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buscarApellido.UseVisualStyleBackColor = false;
            this.buscarApellido.Click += new System.EventHandler(this.buscarApellido_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dNIDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pacienteBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.Location = new System.Drawing.Point(604, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(720, 150);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            this.dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            this.dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dNIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            this.dNIDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "paciente";
            this.pacienteBindingSource.DataSource = this.sistema_odontologiaDataSet7;
            // 
            // sistema_odontologiaDataSet7
            // 
            this.sistema_odontologiaDataSet7.DataSetName = "sistema_odontologiaDataSet7";
            this.sistema_odontologiaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actualizardatos
            // 
            this.actualizardatos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.actualizardatos.IconColor = System.Drawing.Color.Black;
            this.actualizardatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.actualizardatos.Location = new System.Drawing.Point(964, 432);
            this.actualizardatos.Name = "actualizardatos";
            this.actualizardatos.Size = new System.Drawing.Size(152, 43);
            this.actualizardatos.TabIndex = 61;
            this.actualizardatos.Text = "iconButton1";
            this.actualizardatos.UseVisualStyleBackColor = true;
            this.actualizardatos.Click += new System.EventHandler(this.actualizardatos_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(606, 411);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(184, 22);
            this.txtTelefono.TabIndex = 62;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(606, 471);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(184, 22);
            this.txtEmail.TabIndex = 63;
            // 
            // frm_Consulta_de_pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1397, 636);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.actualizardatos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buscarApellido);
            this.Controls.Add(this.buscarDNI);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Name = "frm_Consulta_de_pacientes";
            this.Text = "frm_Consulta_de_pacientes";
            this.Load += new System.EventHandler(this.frm_Consulta_de_pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_odontologiaDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private sistema_odontologiaDataSet7TableAdapters.pacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private FontAwesome.Sharp.IconButton buscarDNI;
        private FontAwesome.Sharp.IconButton buscarApellido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private sistema_odontologiaDataSet7 sistema_odontologiaDataSet7;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton actualizardatos;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
    }
}