﻿namespace OfertasGo
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
            lblHistorial = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHistorial
            // 
            lblHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHistorial.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblHistorial.Location = new System.Drawing.Point(730, 340);
            lblHistorial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new System.Drawing.Size(191, 24);
            lblHistorial.TabIndex = 3;
            lblHistorial.Text = "Historial de Precios";
            // 
            // dgvProductos
            // 
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
            this.dgvProductos.Size = new System.Drawing.Size(1003, 250);
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
            this.dgvHistorial.Location = new System.Drawing.Point(632, 366);
            this.dgvHistorial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnModificar.Location = new System.Drawing.Point(229, 335);
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
            this.btnActDes.Location = new System.Drawing.Point(12, 429);
            this.btnActDes.Name = "btnActDes";
            this.btnActDes.Size = new System.Drawing.Size(194, 77);
            this.btnActDes.TabIndex = 15;
            this.btnActDes.Text = "Activar/Desactivar";
            this.btnActDes.UseMnemonic = false;
            this.btnActDes.UseVisualStyleBackColor = false;
            this.btnActDes.Click += new System.EventHandler(this.btnActDes_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1027, 614);
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
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvProductos);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1043, 613);
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProductos_FormClosing);
            this.Load += new System.EventHandler(this.frmProductos_Load);
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
    }
}