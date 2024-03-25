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
            this.lvLista = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvLista
            // 
            this.lvLista.HideSelection = false;
            this.lvLista.Location = new System.Drawing.Point(150, 214);
            this.lvLista.Name = "lvLista";
            this.lvLista.Size = new System.Drawing.Size(661, 307);
            this.lvLista.TabIndex = 0;
            this.lvLista.UseCompatibleStateImageBehavior = false;
            // 
            // frmListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1094, 568);
            this.Controls.Add(this.lvLista);
            this.Name = "frmListaProductos";
            this.Text = "ListaProductos";
            this.Load += new System.EventHandler(this.frmListaProductos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvLista;
    }
}