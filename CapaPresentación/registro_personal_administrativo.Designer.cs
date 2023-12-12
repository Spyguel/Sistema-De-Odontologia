namespace CapaPresentación
{
    partial class registro_personal_administrativo
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
            this.label10 = new System.Windows.Forms.Label();
            this.txtContrasenaPersonal = new System.Windows.Forms.TextBox();
            this.txtEmailPersonal = new System.Windows.Forms.TextBox();
            this.txtTelefonoPersonal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.selGenero = new System.Windows.Forms.ComboBox();
            this.txtDNIpersonal = new System.Windows.Forms.TextBox();
            this.txtDireccionPersonal = new System.Windows.Forms.TextBox();
            this.fechaNacimientoPersonal = new System.Windows.Forms.DateTimePicker();
            this.txtApellidoPersonal = new System.Windows.Forms.TextBox();
            this.txtNombrePersonal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boton_registrar = new FontAwesome.Sharp.IconButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(153, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(224, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "Formulario de registro";
            // 
            // txtContrasenaPersonal
            // 
            this.txtContrasenaPersonal.Location = new System.Drawing.Point(386, 519);
            this.txtContrasenaPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasenaPersonal.Name = "txtContrasenaPersonal";
            this.txtContrasenaPersonal.Size = new System.Drawing.Size(142, 22);
            this.txtContrasenaPersonal.TabIndex = 49;
            this.txtContrasenaPersonal.UseSystemPasswordChar = true;
            // 
            // txtEmailPersonal
            // 
            this.txtEmailPersonal.Location = new System.Drawing.Point(86, 519);
            this.txtEmailPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailPersonal.Name = "txtEmailPersonal";
            this.txtEmailPersonal.Size = new System.Drawing.Size(167, 22);
            this.txtEmailPersonal.TabIndex = 48;
            // 
            // txtTelefonoPersonal
            // 
            this.txtTelefonoPersonal.Location = new System.Drawing.Point(357, 213);
            this.txtTelefonoPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoPersonal.Name = "txtTelefonoPersonal";
            this.txtTelefonoPersonal.Size = new System.Drawing.Size(156, 22);
            this.txtTelefonoPersonal.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(16, 405);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 22);
            this.label11.TabIndex = 46;
            this.label11.Text = "DNI:";
            // 
            // selGenero
            // 
            this.selGenero.DisplayMember = "Nombre";
            this.selGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selGenero.FormattingEnabled = true;
            this.selGenero.Location = new System.Drawing.Point(99, 206);
            this.selGenero.Margin = new System.Windows.Forms.Padding(4);
            this.selGenero.Name = "selGenero";
            this.selGenero.Size = new System.Drawing.Size(156, 33);
            this.selGenero.TabIndex = 45;
            this.selGenero.ValueMember = "GeneroID";
            // 
            // txtDNIpersonal
            // 
            this.txtDNIpersonal.Location = new System.Drawing.Point(69, 405);
            this.txtDNIpersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNIpersonal.Name = "txtDNIpersonal";
            this.txtDNIpersonal.Size = new System.Drawing.Size(156, 22);
            this.txtDNIpersonal.TabIndex = 44;
            // 
            // txtDireccionPersonal
            // 
            this.txtDireccionPersonal.Location = new System.Drawing.Point(357, 407);
            this.txtDireccionPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionPersonal.Name = "txtDireccionPersonal";
            this.txtDireccionPersonal.Size = new System.Drawing.Size(171, 22);
            this.txtDireccionPersonal.TabIndex = 43;
            this.txtDireccionPersonal.TextChanged += new System.EventHandler(this.txtDireccionPersonal_TextChanged);
            // 
            // fechaNacimientoPersonal
            // 
            this.fechaNacimientoPersonal.CustomFormat = "dd/MM/yyyy";
            this.fechaNacimientoPersonal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaNacimientoPersonal.Location = new System.Drawing.Point(202, 316);
            this.fechaNacimientoPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.fechaNacimientoPersonal.Name = "fechaNacimientoPersonal";
            this.fechaNacimientoPersonal.Size = new System.Drawing.Size(195, 22);
            this.fechaNacimientoPersonal.TabIndex = 42;
            // 
            // txtApellidoPersonal
            // 
            this.txtApellidoPersonal.Location = new System.Drawing.Point(357, 114);
            this.txtApellidoPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoPersonal.Name = "txtApellidoPersonal";
            this.txtApellidoPersonal.Size = new System.Drawing.Size(156, 22);
            this.txtApellidoPersonal.TabIndex = 41;
            // 
            // txtNombrePersonal
            // 
            this.txtNombrePersonal.Location = new System.Drawing.Point(99, 114);
            this.txtNombrePersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombrePersonal.Name = "txtNombrePersonal";
            this.txtNombrePersonal.Size = new System.Drawing.Size(156, 22);
            this.txtNombrePersonal.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(263, 517);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 22);
            this.label9.TabIndex = 39;
            this.label9.Text = "Contraseña:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(16, 211);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 22);
            this.label8.TabIndex = 38;
            this.label8.Text = "Género:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(13, 517);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 22);
            this.label7.TabIndex = 37;
            this.label7.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(263, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 22);
            this.label6.TabIndex = 36;
            this.label6.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(263, 407);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 35;
            this.label5.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 316);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 22);
            this.label4.TabIndex = 34;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(263, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 33;
            this.label3.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre:";
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
            this.boton_registrar.Location = new System.Drawing.Point(158, 581);
            this.boton_registrar.Name = "boton_registrar";
            this.boton_registrar.Size = new System.Drawing.Size(167, 34);
            this.boton_registrar.TabIndex = 50;
            this.boton_registrar.Text = "Registrar";
            this.boton_registrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.boton_registrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.boton_registrar.UseVisualStyleBackColor = false;
            this.boton_registrar.Click += new System.EventHandler(this.boton_registrar_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(544, 653);
            this.label12.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 23);
            this.label2.TabIndex = 54;
            this.label2.Text = "Datos personales y de perfil";
            // 
            // registro_personal_administrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1362, 653);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boton_registrar);
            this.Controls.Add(this.txtContrasenaPersonal);
            this.Controls.Add(this.txtEmailPersonal);
            this.Controls.Add(this.txtTelefonoPersonal);
            this.Controls.Add(this.label11);
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
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Name = "registro_personal_administrativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registro_personal_administrativo";
            this.Load += new System.EventHandler(this.registro_personal_administrativo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtContrasenaPersonal;
        private System.Windows.Forms.TextBox txtEmailPersonal;
        private System.Windows.Forms.TextBox txtTelefonoPersonal;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox selGenero;
        private System.Windows.Forms.TextBox txtDNIpersonal;
        private System.Windows.Forms.TextBox txtDireccionPersonal;
        private System.Windows.Forms.DateTimePicker fechaNacimientoPersonal;
        private System.Windows.Forms.TextBox txtApellidoPersonal;
        private System.Windows.Forms.TextBox txtNombrePersonal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton boton_registrar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
    }
}