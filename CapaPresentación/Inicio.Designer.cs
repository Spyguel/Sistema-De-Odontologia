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
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.turnos = new FontAwesome.Sharp.IconMenuItem();
            this.pacientes = new FontAwesome.Sharp.IconMenuItem();
            this.historial = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turnos,
            this.pacientes,
            this.historial});
            this.menuStrip1.Location = new System.Drawing.Point(0, 71);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 76);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // turnos
            // 
            this.turnos.AutoSize = false;
            this.turnos.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.turnos.IconColor = System.Drawing.Color.Black;
            this.turnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.turnos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.turnos.Name = "turnos";
            this.turnos.Size = new System.Drawing.Size(80, 72);
            this.turnos.Text = "Turnos";
            this.turnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // pacientes
            // 
            this.pacientes.AutoSize = false;
            this.pacientes.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            this.pacientes.IconColor = System.Drawing.Color.Black;
            this.pacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pacientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pacientes.Name = "pacientes";
            this.pacientes.Size = new System.Drawing.Size(120, 72);
            this.pacientes.Text = "  Pacientes";
            this.pacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // historial
            // 
            this.historial.AutoSize = false;
            this.historial.IconChar = FontAwesome.Sharp.IconChar.TeethOpen;
            this.historial.IconColor = System.Drawing.Color.Black;
            this.historial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.historial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.historial.Name = "historial";
            this.historial.Size = new System.Drawing.Size(80, 72);
            this.historial.Text = "Historial";
            this.historial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(800, 71);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema Odontología";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private FontAwesome.Sharp.IconMenuItem historial;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem turnos;
        private FontAwesome.Sharp.IconMenuItem pacientes;
    }
}