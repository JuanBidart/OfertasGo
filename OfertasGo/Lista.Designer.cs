namespace OfertasGo
{
    partial class Lista
    {
      

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label6;
            this.dgvSelecionados = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.robPorcentaje = new System.Windows.Forms.RadioButton();
            this.robPeso = new System.Windows.Forms.RadioButton();
            this.txtCostoModificar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelecionados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSelecionados
            // 
            this.dgvSelecionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSelecionados.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelecionados.Location = new System.Drawing.Point(12, 56);
            this.dgvSelecionados.Name = "dgvSelecionados";
            this.dgvSelecionados.ReadOnly = true;
            this.dgvSelecionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelecionados.Size = new System.Drawing.Size(929, 219);
            this.dgvSelecionados.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            label6.Location = new System.Drawing.Point(246, 19);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(460, 31);
            label6.TabIndex = 21;
            label6.Text = "Lista De Productos Seleccionados";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificar.Location = new System.Drawing.Point(682, 293);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(259, 135);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar Lote";
            this.btnModificar.UseMnemonic = false;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(57, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Cambiar Costo";
            // 
            // robPorcentaje
            // 
            this.robPorcentaje.AutoSize = true;
            this.robPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robPorcentaje.Location = new System.Drawing.Point(6, 16);
            this.robPorcentaje.Name = "robPorcentaje";
            this.robPorcentaje.Size = new System.Drawing.Size(43, 28);
            this.robPorcentaje.TabIndex = 24;
            this.robPorcentaje.TabStop = true;
            this.robPorcentaje.Text = "%";
            this.robPorcentaje.UseVisualStyleBackColor = true;
            // 
            // robPeso
            // 
            this.robPeso.AutoSize = true;
            this.robPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robPeso.Location = new System.Drawing.Point(94, 16);
            this.robPeso.Name = "robPeso";
            this.robPeso.Size = new System.Drawing.Size(38, 28);
            this.robPeso.TabIndex = 25;
            this.robPeso.TabStop = true;
            this.robPeso.Text = "$";
            this.robPeso.UseVisualStyleBackColor = true;
            // 
            // txtCostoModificar
            // 
            this.txtCostoModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoModificar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtCostoModificar.Location = new System.Drawing.Point(42, 388);
            this.txtCostoModificar.Name = "txtCostoModificar";
            this.txtCostoModificar.Size = new System.Drawing.Size(139, 31);
            this.txtCostoModificar.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.robPeso);
            this.groupBox1.Controls.Add(this.robPorcentaje);
            this.groupBox1.Location = new System.Drawing.Point(42, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 50);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de dato";
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCostoModificar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(label6);
            this.Controls.Add(this.dgvSelecionados);
            this.Name = "Lista";
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelecionados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelecionados;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton robPorcentaje;
        private System.Windows.Forms.RadioButton robPeso;
        private System.Windows.Forms.TextBox txtCostoModificar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}