namespace OfertasGo
{
    partial class frmListaProductos
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.lvLista = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colActivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnActivarLote = new System.Windows.Forms.Button();
            this.btnDesactivarLote = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvLista
            // 
            this.lvLista.CheckBoxes = true;
            this.lvLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colProducto,
            this.colActivo});
            this.lvLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLista.HideSelection = false;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            this.lvLista.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.lvLista.LabelEdit = true;
            this.lvLista.Location = new System.Drawing.Point(23, 140);
            this.lvLista.Margin = new System.Windows.Forms.Padding(2);
            this.lvLista.Name = "lvLista";
            this.lvLista.Size = new System.Drawing.Size(529, 359);
            this.lvLista.TabIndex = 0;
            this.lvLista.UseCompatibleStateImageBehavior = false;
            this.lvLista.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "Id";
            // 
            // colProducto
            // 
            this.colProducto.Text = "Producto";
            this.colProducto.Width = 350;
            // 
            // colActivo
            // 
            this.colActivo.Text = "Activo";
            // 
            // btnActivarLote
            // 
            this.btnActivarLote.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnActivarLote.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnActivarLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivarLote.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActivarLote.Location = new System.Drawing.Point(567, 140);
            this.btnActivarLote.Name = "btnActivarLote";
            this.btnActivarLote.Size = new System.Drawing.Size(184, 77);
            this.btnActivarLote.TabIndex = 7;
            this.btnActivarLote.Text = "Activar Lote";
            this.btnActivarLote.UseMnemonic = false;
            this.btnActivarLote.UseVisualStyleBackColor = false;
            this.btnActivarLote.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // btnDesactivarLote
            // 
            this.btnDesactivarLote.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDesactivarLote.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDesactivarLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivarLote.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDesactivarLote.Location = new System.Drawing.Point(567, 223);
            this.btnDesactivarLote.Name = "btnDesactivarLote";
            this.btnDesactivarLote.Size = new System.Drawing.Size(184, 77);
            this.btnDesactivarLote.TabIndex = 8;
            this.btnDesactivarLote.Text = "Desactivar Lote";
            this.btnDesactivarLote.UseMnemonic = false;
            this.btnDesactivarLote.UseVisualStyleBackColor = false;
            this.btnDesactivarLote.Click += new System.EventHandler(this.btnDesactivarLote_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBuscar.Location = new System.Drawing.Point(83, 102);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(354, 31);
            this.txtBuscar.TabIndex = 9;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(22, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buscar";
            // 
            // frmListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(763, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnDesactivarLote);
            this.Controls.Add(this.btnActivarLote);
            this.Controls.Add(this.lvLista);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmListaProductos";
            this.Text = "ListaProductos";
            this.Load += new System.EventHandler(this.frmListaProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvLista;
        private System.Windows.Forms.ColumnHeader colProducto;
        private System.Windows.Forms.ColumnHeader colActivo;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.Button btnActivarLote;
        private System.Windows.Forms.Button btnDesactivarLote;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
    }
}