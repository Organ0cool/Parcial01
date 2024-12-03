namespace Capa_Presentacion
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTarifa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFinalizar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMantenimiento,
            this.mnuAcercaDe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1559, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuMantenimiento
            // 
            this.mnuMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuarios,
            this.mnuTarifa,
            this.toolStripSeparator1,
            this.mnuCerrarSesion,
            this.mnuFinalizar});
            this.mnuMantenimiento.Image = global::Capa_Presentacion.Properties.Resources.iconArchivo;
            this.mnuMantenimiento.Name = "mnuMantenimiento";
            this.mnuMantenimiento.Size = new System.Drawing.Size(157, 25);
            this.mnuMantenimiento.Text = "Mantenimiento";
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.Image = global::Capa_Presentacion.Properties.Resources.iconClienteRegistro;
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.mnuUsuarios.Size = new System.Drawing.Size(238, 26);
            this.mnuUsuarios.Text = "Usuarios";
            // 
            // mnuTarifa
            // 
            this.mnuTarifa.Image = global::Capa_Presentacion.Properties.Resources.iconVentas;
            this.mnuTarifa.Name = "mnuTarifa";
            this.mnuTarifa.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.mnuTarifa.Size = new System.Drawing.Size(238, 26);
            this.mnuTarifa.Text = "Tarifas";
            this.mnuTarifa.Click += new System.EventHandler(this.mnuTarifa_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(235, 6);
            // 
            // mnuCerrarSesion
            // 
            this.mnuCerrarSesion.Image = global::Capa_Presentacion.Properties.Resources.btnCerrarSesion;
            this.mnuCerrarSesion.Name = "mnuCerrarSesion";
            this.mnuCerrarSesion.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuCerrarSesion.Size = new System.Drawing.Size(238, 26);
            this.mnuCerrarSesion.Text = "Cerrar Sesión";
            this.mnuCerrarSesion.Click += new System.EventHandler(this.mnuCerrarSesion_Click);
            // 
            // mnuFinalizar
            // 
            this.mnuFinalizar.Image = global::Capa_Presentacion.Properties.Resources.btnSalir;
            this.mnuFinalizar.Name = "mnuFinalizar";
            this.mnuFinalizar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuFinalizar.Size = new System.Drawing.Size(238, 26);
            this.mnuFinalizar.Text = "Finalizar";
            this.mnuFinalizar.Click += new System.EventHandler(this.mnuFinalizar_Click);
            // 
            // mnuAcercaDe
            // 
            this.mnuAcercaDe.Image = global::Capa_Presentacion.Properties.Resources.iconAyudaAcercade;
            this.mnuAcercaDe.Name = "mnuAcercaDe";
            this.mnuAcercaDe.Size = new System.Drawing.Size(114, 25);
            this.mnuAcercaDe.Text = "Acerca De";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 903);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMenu";
            this.Text = "EXAMEN PARCIAL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuTarifa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem mnuFinalizar;
        private System.Windows.Forms.ToolStripMenuItem mnuAcercaDe;
    }
}