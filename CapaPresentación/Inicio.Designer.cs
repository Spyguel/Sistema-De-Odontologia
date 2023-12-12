namespace CapaPresentación
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre_usuario = new System.Windows.Forms.Label();
            this.turnos = new FontAwesome.Sharp.IconMenuItem();
            this.asignarTurnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesmenu = new FontAwesome.Sharp.IconMenuItem();
            this.agregar_paciente = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.historial = new FontAwesome.Sharp.IconMenuItem();
            this.consultarHistoriaClínicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticas = new FontAwesome.Sharp.IconMenuItem();
            this.promedioDeTurnosRegistradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recursos_humanos = new FontAwesome.Sharp.IconMenuItem();
            this.altaDePersonalMédicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alta_medicos = new System.Windows.Forms.ToolStripMenuItem();
            this.alta_personal_administrativo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(1358, 118);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de gestión de turnos e historia clínica";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contenedor
            // 
            this.contenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 194);
            this.contenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1358, 626);
            this.contenedor.TabIndex = 3;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedor_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1029, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bienvenido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.AutoSize = true;
            this.txt_nombre_usuario.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txt_nombre_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_usuario.ForeColor = System.Drawing.Color.White;
            this.txt_nombre_usuario.Location = new System.Drawing.Point(1141, 43);
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(87, 24);
            this.txt_nombre_usuario.TabIndex = 5;
            this.txt_nombre_usuario.Text = "lbusuario";
            this.txt_nombre_usuario.Click += new System.EventHandler(this.txt_nombre_usuario_Click);
            // 
            // turnos
            // 
            this.turnos.AutoSize = false;
            this.turnos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarTurnosToolStripMenuItem});
            this.turnos.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.turnos.IconColor = System.Drawing.Color.Black;
            this.turnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.turnos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.turnos.Name = "turnos";
            this.turnos.Size = new System.Drawing.Size(152, 72);
            this.turnos.Text = "Turnos";
            this.turnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.turnos.Click += new System.EventHandler(this.turnos_Click);
            // 
            // asignarTurnosToolStripMenuItem
            // 
            this.asignarTurnosToolStripMenuItem.Name = "asignarTurnosToolStripMenuItem";
            this.asignarTurnosToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.asignarTurnosToolStripMenuItem.Text = "Asignar Turnos";
            this.asignarTurnosToolStripMenuItem.Click += new System.EventHandler(this.asignarTurnosToolStripMenuItem_Click);
            // 
            // pacientesmenu
            // 
            this.pacientesmenu.AutoSize = false;
            this.pacientesmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregar_paciente,
            this.consultaPacientes});
            this.pacientesmenu.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            this.pacientesmenu.IconColor = System.Drawing.Color.Black;
            this.pacientesmenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pacientesmenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pacientesmenu.Name = "pacientesmenu";
            this.pacientesmenu.Size = new System.Drawing.Size(152, 72);
            this.pacientesmenu.Text = "  Pacientes";
            this.pacientesmenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // agregar_paciente
            // 
            this.agregar_paciente.Name = "agregar_paciente";
            this.agregar_paciente.Size = new System.Drawing.Size(290, 26);
            this.agregar_paciente.Text = "Agregar a un nuevo pacciente";
            this.agregar_paciente.Click += new System.EventHandler(this.agregarAUnNuevoPaccienteToolStripMenuItem_Click);
            // 
            // consultaPacientes
            // 
            this.consultaPacientes.Name = "consultaPacientes";
            this.consultaPacientes.Size = new System.Drawing.Size(290, 26);
            this.consultaPacientes.Text = "Consultar pacientes";
            this.consultaPacientes.Click += new System.EventHandler(this.consultaPacientes_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turnos,
            this.pacientesmenu,
            this.historial,
            this.estadisticas,
            this.recursos_humanos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 118);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1358, 76);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // historial
            // 
            this.historial.AutoSize = false;
            this.historial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarHistoriaClínicaToolStripMenuItem});
            this.historial.IconChar = FontAwesome.Sharp.IconChar.TeethOpen;
            this.historial.IconColor = System.Drawing.Color.Black;
            this.historial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.historial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.historial.Name = "historial";
            this.historial.Size = new System.Drawing.Size(152, 72);
            this.historial.Text = "Historia clínica";
            this.historial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // consultarHistoriaClínicaToolStripMenuItem
            // 
            this.consultarHistoriaClínicaToolStripMenuItem.Name = "consultarHistoriaClínicaToolStripMenuItem";
            this.consultarHistoriaClínicaToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.consultarHistoriaClínicaToolStripMenuItem.Text = "Consultar historia clínica";
            // 
            // estadisticas
            // 
            this.estadisticas.AutoSize = false;
            this.estadisticas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promedioDeTurnosRegistradosToolStripMenuItem});
            this.estadisticas.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.estadisticas.IconColor = System.Drawing.Color.Black;
            this.estadisticas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.estadisticas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.estadisticas.Name = "estadisticas";
            this.estadisticas.Size = new System.Drawing.Size(152, 72);
            this.estadisticas.Text = "Estadísticas";
            this.estadisticas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // promedioDeTurnosRegistradosToolStripMenuItem
            // 
            this.promedioDeTurnosRegistradosToolStripMenuItem.Name = "promedioDeTurnosRegistradosToolStripMenuItem";
            this.promedioDeTurnosRegistradosToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.promedioDeTurnosRegistradosToolStripMenuItem.Text = "Media de turnos registrados";
            this.promedioDeTurnosRegistradosToolStripMenuItem.Click += new System.EventHandler(this.promedioDeTurnosRegistradosToolStripMenuItem_Click);
            // 
            // recursos_humanos
            // 
            this.recursos_humanos.AutoSize = false;
            this.recursos_humanos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDePersonalMédicoToolStripMenuItem});
            this.recursos_humanos.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.recursos_humanos.IconColor = System.Drawing.Color.Black;
            this.recursos_humanos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.recursos_humanos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.recursos_humanos.Name = "recursos_humanos";
            this.recursos_humanos.Size = new System.Drawing.Size(162, 72);
            this.recursos_humanos.Text = "Recursos humanos";
            this.recursos_humanos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // altaDePersonalMédicoToolStripMenuItem
            // 
            this.altaDePersonalMédicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alta_medicos,
            this.alta_personal_administrativo});
            this.altaDePersonalMédicoToolStripMenuItem.Name = "altaDePersonalMédicoToolStripMenuItem";
            this.altaDePersonalMédicoToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.altaDePersonalMédicoToolStripMenuItem.Text = "Alta de personal";
            // 
            // alta_medicos
            // 
            this.alta_medicos.Name = "alta_medicos";
            this.alta_medicos.Size = new System.Drawing.Size(300, 26);
            this.alta_medicos.Text = "Alta de médicos";
            this.alta_medicos.Click += new System.EventHandler(this.altaDeMédicosToolStripMenuItem_Click);
            // 
            // alta_personal_administrativo
            // 
            this.alta_personal_administrativo.Name = "alta_personal_administrativo";
            this.alta_personal_administrativo.Size = new System.Drawing.Size(300, 26);
            this.alta_personal_administrativo.Text = "Alta de personal administrativo";
            this.alta_personal_administrativo.Click += new System.EventHandler(this.alta_personal_administrativo_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1358, 820);
            this.Controls.Add(this.txt_nombre_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_nombre_usuario;
        private FontAwesome.Sharp.IconMenuItem turnos;
        private FontAwesome.Sharp.IconMenuItem pacientesmenu;
        private System.Windows.Forms.ToolStripMenuItem agregar_paciente;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem historial;
        private FontAwesome.Sharp.IconMenuItem estadisticas;
        private System.Windows.Forms.ToolStripMenuItem asignarTurnosToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem recursos_humanos;
        private System.Windows.Forms.ToolStripMenuItem promedioDeTurnosRegistradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarHistoriaClínicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDePersonalMédicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alta_medicos;
        private System.Windows.Forms.ToolStripMenuItem alta_personal_administrativo;
        private System.Windows.Forms.ToolStripMenuItem consultaPacientes;
    }
}