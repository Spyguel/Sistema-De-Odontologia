namespace CapaPresentación
{
    partial class frmTurnos
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
            this.turnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_odontologiaDataSet1 = new CapaPresentación.sistema_odontologiaDataSet1();
            this.turnosTableAdapter = new CapaPresentación.sistema_odontologiaDataSet1TableAdapters.turnosTableAdapter();
            this.sel_odontologo = new System.Windows.Forms.ComboBox();
            this.lista_horarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fecha_turno = new System.Windows.Forms.DateTimePicker();
            this.sistema_odontologiaDataSet3 = new CapaPresentación.sistema_odontologiaDataSet3();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteTableAdapter = new CapaPresentación.sistema_odontologiaDataSet3TableAdapters.pacienteTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_observaciones = new System.Windows.Forms.TextBox();
            this.btn_registrar_turno = new FontAwesome.Sharp.IconButton();
            this.sistema_odontologiaDataSet4 = new CapaPresentación.sistema_odontologiaDataSet4();
            this.pacienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteTableAdapter1 = new CapaPresentación.sistema_odontologiaDataSet4TableAdapters.pacienteTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.turnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_odontologiaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_odontologiaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_odontologiaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // turnosBindingSource
            // 
            this.turnosBindingSource.DataMember = "turnos";
            this.turnosBindingSource.DataSource = this.sistema_odontologiaDataSet1;
            // 
            // sistema_odontologiaDataSet1
            // 
            this.sistema_odontologiaDataSet1.DataSetName = "sistema_odontologiaDataSet1";
            this.sistema_odontologiaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // turnosTableAdapter
            // 
            this.turnosTableAdapter.ClearBeforeFill = true;
            // 
            // sel_odontologo
            // 
            this.sel_odontologo.BackColor = System.Drawing.Color.White;
            this.sel_odontologo.FormattingEnabled = true;
            this.sel_odontologo.Location = new System.Drawing.Point(267, 97);
            this.sel_odontologo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sel_odontologo.Name = "sel_odontologo";
            this.sel_odontologo.Size = new System.Drawing.Size(151, 24);
            this.sel_odontologo.TabIndex = 0;
            this.sel_odontologo.SelectedIndexChanged += new System.EventHandler(this.sel_odontologo_SelectedIndexChanged);
            // 
            // lista_horarios
            // 
            this.lista_horarios.BackColor = System.Drawing.Color.White;
            this.lista_horarios.FormattingEnabled = true;
            this.lista_horarios.Location = new System.Drawing.Point(323, 259);
            this.lista_horarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lista_horarios.Name = "lista_horarios";
            this.lista_horarios.Size = new System.Drawing.Size(151, 24);
            this.lista_horarios.TabIndex = 1;
            this.lista_horarios.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(-1, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elija un médico para asignar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(-1, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione un horario para el turno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(-1, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seleccione una fecha para el turno:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // fecha_turno
            // 
            this.fecha_turno.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.fecha_turno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_turno.Location = new System.Drawing.Point(323, 179);
            this.fecha_turno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fecha_turno.Name = "fecha_turno";
            this.fecha_turno.Size = new System.Drawing.Size(151, 22);
            this.fecha_turno.TabIndex = 5;
            this.fecha_turno.ValueChanged += new System.EventHandler(this.fecha_turno_ValueChanged);
            // 
            // sistema_odontologiaDataSet3
            // 
            this.sistema_odontologiaDataSet3.DataSetName = "sistema_odontologiaDataSet3";
            this.sistema_odontologiaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "paciente";
            this.pacienteBindingSource.DataSource = this.sistema_odontologiaDataSet3;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(-1, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Notas del turno:";
            // 
            // txt_observaciones
            // 
            this.txt_observaciones.BackColor = System.Drawing.Color.White;
            this.txt_observaciones.Location = new System.Drawing.Point(154, 312);
            this.txt_observaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_observaciones.Multiline = true;
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.Size = new System.Drawing.Size(332, 106);
            this.txt_observaciones.TabIndex = 9;
            // 
            // btn_registrar_turno
            // 
            this.btn_registrar_turno.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_registrar_turno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar_turno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_turno.ForeColor = System.Drawing.Color.White;
            this.btn_registrar_turno.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btn_registrar_turno.IconColor = System.Drawing.Color.Black;
            this.btn_registrar_turno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_registrar_turno.IconSize = 26;
            this.btn_registrar_turno.Location = new System.Drawing.Point(193, 453);
            this.btn_registrar_turno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_registrar_turno.Name = "btn_registrar_turno";
            this.btn_registrar_turno.Size = new System.Drawing.Size(150, 35);
            this.btn_registrar_turno.TabIndex = 34;
            this.btn_registrar_turno.Text = "Registrar";
            this.btn_registrar_turno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_registrar_turno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_registrar_turno.UseVisualStyleBackColor = false;
            this.btn_registrar_turno.Click += new System.EventHandler(this.btn_registrar_turno_Click);
            // 
            // sistema_odontologiaDataSet4
            // 
            this.sistema_odontologiaDataSet4.DataSetName = "sistema_odontologiaDataSet4";
            this.sistema_odontologiaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacienteBindingSource1
            // 
            this.pacienteBindingSource1.DataMember = "paciente";
            this.pacienteBindingSource1.DataSource = this.sistema_odontologiaDataSet4;
            // 
            // pacienteTableAdapter1
            // 
            this.pacienteTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(277, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 22);
            this.textBox1.TabIndex = 35;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(-2, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Elija un paciente para asignar:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(567, 548);
            this.label7.TabIndex = 36;
            // 
            // frmTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1135, 548);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_registrar_turno);
            this.Controls.Add(this.txt_observaciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fecha_turno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista_horarios);
            this.Controls.Add(this.sel_odontologo);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTurnos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmTurnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_odontologiaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_odontologiaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_odontologiaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private sistema_odontologiaDataSet1 sistema_odontologiaDataSet1;
        private System.Windows.Forms.BindingSource turnosBindingSource;
        private sistema_odontologiaDataSet1TableAdapters.turnosTableAdapter turnosTableAdapter;
        private System.Windows.Forms.ComboBox sel_odontologo;
        private System.Windows.Forms.ComboBox lista_horarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fecha_turno;
        private sistema_odontologiaDataSet3 sistema_odontologiaDataSet3;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private sistema_odontologiaDataSet3TableAdapters.pacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_observaciones;
        private FontAwesome.Sharp.IconButton btn_registrar_turno;
        private sistema_odontologiaDataSet4 sistema_odontologiaDataSet4;
        private System.Windows.Forms.BindingSource pacienteBindingSource1;
        private sistema_odontologiaDataSet4TableAdapters.pacienteTableAdapter pacienteTableAdapter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}