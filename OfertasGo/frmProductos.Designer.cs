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
            this.button1 = new System.Windows.Forms.Button();
            lblHistorial = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHistorial
            // 
            lblHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHistorial.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblHistorial.Location = new System.Drawing.Point(729, 340);
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
            label6.Location = new System.Drawing.Point(435, 44);
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
            this.dgvProductos.Size = new System.Drawing.Size(999, 250);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar.Location = new System.Drawing.Point(12, 335);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(194, 77);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseMnemonic = false;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(628, 366);
            this.dgvHistorial.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.RowHeadersWidth = 51;
            this.dgvHistorial.RowTemplate.Height = 24;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.ShowCellToolTips = false;
            this.dgvHistorial.Size = new System.Drawing.Size(384, 171);
            this.dgvHistorial.TabIndex = 2;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPorcentaje.Location = new System.Drawing.Point(523, 394);
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
            this.label1.Location = new System.Drawing.Point(515, 366);
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
            this.btnModificar.Location = new System.Drawing.Point(12, 416);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(194, 77);
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
            this.label2.Location = new System.Drawing.Point(481, 429);
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
            this.lblUltimaFechaAct.Location = new System.Drawing.Point(519, 445);
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
            this.lbld555.Location = new System.Drawing.Point(515, 477);
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
            this.lblDiasPasados.Location = new System.Drawing.Point(544, 493);
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
            this.label3.Location = new System.Drawing.Point(640, 573);
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
            this.lblVarMen.Location = new System.Drawing.Point(654, 547);
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
            this.lbIinflacionMen.Location = new System.Drawing.Point(758, 547);
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
            this.label5.Location = new System.Drawing.Point(758, 574);
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
            this.btnActDes.Location = new System.Drawing.Point(12, 586);
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
            this.btnDesactivar.Location = new System.Drawing.Point(12, 503);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(194, 77);
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
            this.txtbuscar.Size = new System.Drawing.Size(327, 20);
            this.txtbuscar.TabIndex = 17;
            this.txtbuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(548, 49);
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
            this.label7.Location = new System.Drawing.Point(243, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Precio Final";
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioFinal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrecioFinal.Location = new System.Drawing.Point(242, 366);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(32, 24);
            this.lblPrecioFinal.TabIndex = 22;
            this.lblPrecioFinal.Text = "00";
            // 
            // lblCanPro
            // 
            this.lblCanPro.AutoSize = true;
            this.lblCanPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanPro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCanPro.Location = new System.Drawing.Point(907, 50);
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
            this.label9.Location = new System.Drawing.Point(908, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Ctd. Productos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(299, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 44);
            this.button1.TabIndex = 25;
            this.button1.Text = "Grafica";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1023, 642);
            this.Controls.Add(this.button1);
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
            this.Resize += new System.EventHandler(this.frmProductos_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
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
        private System.Windows.Forms.Button button1;
    }
}