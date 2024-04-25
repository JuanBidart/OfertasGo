using System.Security;

namespace OfertasGo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tslConfiguracion = new System.Windows.Forms.ToolStripLabel();
            this.tslAcercade = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sspBarradeEstado = new System.Windows.Forms.StatusStrip();
            this.tsslBarra = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnBackupDB = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.sspBarradeEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.Transparent;
            this.btnProductos.Location = new System.Drawing.Point(12, 48);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(386, 125);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProveedores.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.Transparent;
            this.btnProveedores.Location = new System.Drawing.Point(12, 370);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(173, 72);
            this.btnProveedores.TabIndex = 1;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tslConfiguracion,
            this.tslAcercade});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(833, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(61, 22);
            this.toolStripLabel1.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tslConfiguracion
            // 
            this.tslConfiguracion.Name = "tslConfiguracion";
            this.tslConfiguracion.Size = new System.Drawing.Size(83, 22);
            this.tslConfiguracion.Text = "Configuración";
            // 
            // tslAcercade
            // 
            this.tslAcercade.Name = "tslAcercade";
            this.tslAcercade.Size = new System.Drawing.Size(43, 22);
            this.tslAcercade.Text = "Acerca";
            this.tslAcercade.Click += new System.EventHandler(this.tslAcercade_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            // 
            // sspBarradeEstado
            // 
            this.sspBarradeEstado.BackColor = System.Drawing.Color.DodgerBlue;
            this.sspBarradeEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslBarra,
            this.tsslFecha,
            this.tssHora});
            this.sspBarradeEstado.Location = new System.Drawing.Point(0, 456);
            this.sspBarradeEstado.Name = "sspBarradeEstado";
            this.sspBarradeEstado.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.sspBarradeEstado.Size = new System.Drawing.Size(833, 22);
            this.sspBarradeEstado.TabIndex = 4;
            this.sspBarradeEstado.Text = "statusStrip1";
            // 
            // tsslBarra
            // 
            this.tsslBarra.ForeColor = System.Drawing.SystemColors.Control;
            this.tsslBarra.Name = "tsslBarra";
            this.tsslBarra.Size = new System.Drawing.Size(118, 17);
            this.tsslBarra.Text = "toolStripStatusLabel2";
            // 
            // tsslFecha
            // 
            this.tsslFecha.AutoSize = false;
            this.tsslFecha.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.tsslFecha.ForeColor = System.Drawing.SystemColors.Control;
            this.tsslFecha.Name = "tsslFecha";
            this.tsslFecha.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsslFecha.Size = new System.Drawing.Size(118, 17);
            this.tsslFecha.Text = "toolStripStatusLabel1";
            // 
            // tssHora
            // 
            this.tssHora.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssHora.ForeColor = System.Drawing.SystemColors.Control;
            this.tssHora.Name = "tssHora";
            this.tssHora.Size = new System.Drawing.Size(33, 17);
            this.tssHora.Text = "Hora";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            // 
            // btnBackupDB
            // 
            this.btnBackupDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBackupDB.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBackupDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupDB.ForeColor = System.Drawing.Color.Transparent;
            this.btnBackupDB.Location = new System.Drawing.Point(631, 370);
            this.btnBackupDB.Name = "btnBackupDB";
            this.btnBackupDB.Size = new System.Drawing.Size(173, 72);
            this.btnBackupDB.TabIndex = 5;
            this.btnBackupDB.Text = "Backup DB";
            this.btnBackupDB.UseVisualStyleBackColor = false;
            this.btnBackupDB.Click += new System.EventHandler(this.btnBackupDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(833, 478);
            this.Controls.Add(this.btnBackupDB);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.sspBarradeEstado);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(562, 343);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.sspBarradeEstado.ResumeLayout(false);
            this.sspBarradeEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslConfiguracion;
        private System.Windows.Forms.ToolStripLabel tslAcercade;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip sspBarradeEstado;
        private System.Windows.Forms.ToolStripStatusLabel tsslBarra;
        private System.Windows.Forms.ToolStripStatusLabel tsslFecha;
        private System.Windows.Forms.ToolStripStatusLabel tssHora;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnBackupDB;
    }
}

