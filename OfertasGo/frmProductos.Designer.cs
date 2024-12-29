namespace OfertasGo
{
    partial class frmProductos
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
            System.Windows.Forms.Label lblHistorial;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label6;
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUltimaFechaAct = new System.Windows.Forms.Label();
            this.lbld555 = new System.Windows.Forms.Label();
            this.lblDiasPasados = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVarMen = new System.Windows.Forms.Label();
            this.lbIinflacionMen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnActDes = new System.Windows.Forms.Button();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.lblCanPro = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCambiarPorLotes = new System.Windows.Forms.Button();
            this.btnVermas = new System.Windows.Forms.Button();
            this.btnVermenos = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pruebaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prueba2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBorrarDatosHistorial = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            lblHistorial = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHistorial
            // 
            lblHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHistorial.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblHistorial.Location = new System.Drawing.Point(748, 340);
            lblHistorial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new System.Drawing.Size(191, 24);
            lblHistorial.TabIndex = 3;
            lblHistorial.Text = "Historial de Precios";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            label4.Location = new System.Drawing.Point(8, 44);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(80, 24);
            label4.TabIndex = 19;
            label4.Text = "Buscar:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            label6.Location = new System.Drawing.Point(367, 44);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(107, 24);
            label6.TabIndex = 20;
            label6.Text = "Proveedor";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductos.Location = new System.Drawing.Point(12, 79);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(1055, 250);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentDoubleClick);
            this.dgvProductos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductos_ColumnHeaderMouseClick);
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar.Location = new System.Drawing.Point(10, 335);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 77);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseMnemonic = false;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvHistorial.Location = new System.Drawing.Point(628, 366);
            this.dgvHistorial.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.RowHeadersWidth = 51;
            this.dgvHistorial.RowTemplate.Height = 24;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.ShowCellToolTips = false;
            this.dgvHistorial.Size = new System.Drawing.Size(439, 171);
            this.dgvHistorial.TabIndex = 2;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPorcentaje.Location = new System.Drawing.Point(657, 556);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(32, 24);
            this.lblPorcentaje.TabIndex = 4;
            this.lblPorcentaje.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(625, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ultimo Cambio";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificar.Location = new System.Drawing.Point(132, 335);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(121, 77);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseMnemonic = false;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(625, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha Actualización";
            // 
            // lblUltimaFechaAct
            // 
            this.lblUltimaFechaAct.AutoSize = true;
            this.lblUltimaFechaAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimaFechaAct.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUltimaFechaAct.Location = new System.Drawing.Point(624, 596);
            this.lblUltimaFechaAct.Name = "lblUltimaFechaAct";
            this.lblUltimaFechaAct.Size = new System.Drawing.Size(24, 24);
            this.lblUltimaFechaAct.TabIndex = 8;
            this.lblUltimaFechaAct.Text = "--";
            // 
            // lbld555
            // 
            this.lbld555.AutoSize = true;
            this.lbld555.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbld555.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbld555.Location = new System.Drawing.Point(770, 539);
            this.lbld555.Name = "lbld555";
            this.lbld555.Size = new System.Drawing.Size(105, 16);
            this.lbld555.TabIndex = 9;
            this.lbld555.Text = "Dias Pasados";
            // 
            // lblDiasPasados
            // 
            this.lblDiasPasados.AutoSize = true;
            this.lblDiasPasados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasPasados.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDiasPasados.Location = new System.Drawing.Point(799, 559);
            this.lblDiasPasados.Name = "lblDiasPasados";
            this.lblDiasPasados.Size = new System.Drawing.Size(32, 24);
            this.lblDiasPasados.TabIndex = 10;
            this.lblDiasPasados.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(899, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Variacion\rMensual Acu.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVarMen
            // 
            this.lblVarMen.AutoSize = true;
            this.lblVarMen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarMen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblVarMen.Location = new System.Drawing.Point(898, 574);
            this.lblVarMen.Name = "lblVarMen";
            this.lblVarMen.Size = new System.Drawing.Size(32, 24);
            this.lblVarMen.TabIndex = 12;
            this.lblVarMen.Text = "00";
            // 
            // lbIinflacionMen
            // 
            this.lbIinflacionMen.AutoSize = true;
            this.lbIinflacionMen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIinflacionMen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbIinflacionMen.Location = new System.Drawing.Point(1004, 574);
            this.lbIinflacionMen.Name = "lbIinflacionMen";
            this.lbIinflacionMen.Size = new System.Drawing.Size(32, 24);
            this.lbIinflacionMen.TabIndex = 13;
            this.lbIinflacionMen.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(1005, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "Inflacion\r\nMensual";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnActDes
            // 
            this.btnActDes.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnActDes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnActDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActDes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActDes.Location = new System.Drawing.Point(371, 529);
            this.btnActDes.Name = "btnActDes";
            this.btnActDes.Size = new System.Drawing.Size(194, 44);
            this.btnActDes.TabIndex = 15;
            this.btnActDes.Text = "Activar/Desactivar por Lotes";
            this.btnActDes.UseMnemonic = false;
            this.btnActDes.UseVisualStyleBackColor = false;
            this.btnActDes.Click += new System.EventHandler(this.btnActDes_Click);
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDesactivar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDesactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDesactivar.Location = new System.Drawing.Point(254, 335);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(121, 77);
            this.btnDesactivar.TabIndex = 16;
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.UseMnemonic = false;
            this.btnDesactivar.UseVisualStyleBackColor = false;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(96, 48);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(266, 20);
            this.txtbuscar.TabIndex = 17;
            this.txtbuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(479, 48);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(121, 21);
            this.cbxProveedor.TabIndex = 18;
            this.cbxProveedor.SelectionChangeCommitted += new System.EventHandler(this.cbxProveedor_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(12, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Precio Final";
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioFinal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrecioFinal.Location = new System.Drawing.Point(21, 437);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(38, 25);
            this.lblPrecioFinal.TabIndex = 22;
            this.lblPrecioFinal.Text = "00";
            // 
            // lblCanPro
            // 
            this.lblCanPro.AutoSize = true;
            this.lblCanPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanPro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCanPro.Location = new System.Drawing.Point(475, 351);
            this.lblCanPro.Name = "lblCanPro";
            this.lblCanPro.Size = new System.Drawing.Size(32, 24);
            this.lblCanPro.TabIndex = 24;
            this.lblCanPro.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Location = new System.Drawing.Point(457, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Ctd. Productos";
            // 
            // btnCambiarPorLotes
            // 
            this.btnCambiarPorLotes.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCambiarPorLotes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCambiarPorLotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarPorLotes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCambiarPorLotes.Location = new System.Drawing.Point(371, 479);
            this.btnCambiarPorLotes.Name = "btnCambiarPorLotes";
            this.btnCambiarPorLotes.Size = new System.Drawing.Size(194, 44);
            this.btnCambiarPorLotes.TabIndex = 25;
            this.btnCambiarPorLotes.Text = "Cambiar precio de lote";
            this.btnCambiarPorLotes.UseMnemonic = false;
            this.btnCambiarPorLotes.UseVisualStyleBackColor = false;
            this.btnCambiarPorLotes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVermas
            // 
            this.btnVermas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVermas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnVermas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVermas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVermas.Location = new System.Drawing.Point(371, 585);
            this.btnVermas.Name = "btnVermas";
            this.btnVermas.Size = new System.Drawing.Size(86, 44);
            this.btnVermas.TabIndex = 27;
            this.btnVermas.Text = "Ver mas datos >>";
            this.btnVermas.UseMnemonic = false;
            this.btnVermas.UseVisualStyleBackColor = false;
            this.btnVermas.Click += new System.EventHandler(this.btnVermas_Click);
            // 
            // btnVermenos
            // 
            this.btnVermenos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVermenos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnVermenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVermenos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVermenos.Location = new System.Drawing.Point(479, 585);
            this.btnVermenos.Name = "btnVermenos";
            this.btnVermenos.Size = new System.Drawing.Size(86, 44);
            this.btnVermenos.TabIndex = 28;
            this.btnVermenos.Text = "Ver Menos datos <<";
            this.btnVermenos.UseMnemonic = false;
            this.btnVermenos.UseVisualStyleBackColor = false;
            this.btnVermenos.Click += new System.EventHandler(this.btnVermenos_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pruebaToolStripMenuItem,
            this.prueba2ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 48);
            this.contextMenuStrip1.Text = "HOla";
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // pruebaToolStripMenuItem
            // 
            this.pruebaToolStripMenuItem.Name = "pruebaToolStripMenuItem";
            this.pruebaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.pruebaToolStripMenuItem.Text = "Prueba";
            this.pruebaToolStripMenuItem.Click += new System.EventHandler(this.pruebaToolStripMenuItem_Click);
            // 
            // prueba2ToolStripMenuItem
            // 
            this.prueba2ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.prueba2ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.prueba2ToolStripMenuItem.Name = "prueba2ToolStripMenuItem";
            this.prueba2ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.prueba2ToolStripMenuItem.Text = "Prueba2";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnImprimir.Location = new System.Drawing.Point(371, 429);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(194, 44);
            this.btnImprimir.TabIndex = 26;
            this.btnImprimir.Text = "Imprimir Lista Actual";
            this.btnImprimir.UseMnemonic = false;
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnBorrarDatosHistorial
            // 
            this.btnBorrarDatosHistorial.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBorrarDatosHistorial.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBorrarDatosHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarDatosHistorial.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBorrarDatosHistorial.Location = new System.Drawing.Point(833, 601);
            this.btnBorrarDatosHistorial.Name = "btnBorrarDatosHistorial";
            this.btnBorrarDatosHistorial.Size = new System.Drawing.Size(234, 33);
            this.btnBorrarDatosHistorial.TabIndex = 29;
            this.btnBorrarDatosHistorial.Text = "Borrar dato selecionado de historial";
            this.btnBorrarDatosHistorial.UseMnemonic = false;
            this.btnBorrarDatosHistorial.UseVisualStyleBackColor = false;
            this.btnBorrarDatosHistorial.Click += new System.EventHandler(this.btnBorrarDatosHistorial_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitulo.Location = new System.Drawing.Point(127, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(386, 25);
            this.lblTitulo.TabIndex = 32;
            this.lblTitulo.Text = "Configuracion y datos de productos";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1070, 641);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnBorrarDatosHistorial);
            this.Controls.Add(this.btnVermenos);
            this.Controls.Add(this.btnVermas);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCambiarPorLotes);
            this.Controls.Add(this.lblCanPro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.label7);
            this.Controls.Add(label6);
            this.Controls.Add(label4);
            this.Controls.Add(this.cbxProveedor);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btnDesactivar);
            this.Controls.Add(this.btnActDes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbIinflacionMen);
            this.Controls.Add(this.lblVarMen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDiasPasados);
            this.Controls.Add(this.lbld555);
            this.Controls.Add(this.lblUltimaFechaAct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(lblHistorial);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.dgvHistorial);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProductos_FormClosing);
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.MouseLeave += new System.EventHandler(this.frmProductos_MouseLeave);
            this.Resize += new System.EventHandler(this.frmProductos_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUltimaFechaAct;
        private System.Windows.Forms.Label lbld555;
        private System.Windows.Forms.Label lblDiasPasados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVarMen;
        private System.Windows.Forms.Label lbIinflacionMen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnActDes;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPrecioFinal;
        private System.Windows.Forms.Label lblCanPro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCambiarPorLotes;
        private System.Windows.Forms.Button btnVermas;
        private System.Windows.Forms.Button btnVermenos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pruebaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prueba2ToolStripMenuItem;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBorrarDatosHistorial;
        private System.Windows.Forms.Label lblTitulo;
    }
}