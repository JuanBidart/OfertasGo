using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace OfertasGo
{
    public partial class frmAgregarRubro : Form
    {
        TRubro trubro = null;
        List<TRubro> listarubro = new List<TRubro>();   
        public frmAgregarRubro()
        {
            InitializeComponent();
            this.TopLevel = true;
        }
        public frmAgregarRubro(TRubro rubro)
        { 
         trubro = rubro;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TRubro trubro = new TRubro();
            ConexionRubro conexion = new ConexionRubro();
            try
            {
                trubro.Rubro = txtRubro.Text;

                conexion.agregarRubro(trubro);
                MessageBox.Show("Agregado exitosamente");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txtRubro_TextChanged(object sender, EventArgs e)
        {
            string texto = txtRubro.Text;
            cbxRubro.Text = texto;
            //List<TRubro> rubrosfiltrados = new List<TRubro>();
            //foreach (TRubro rubro in listarubro)
            //{
            //    if (rubro.Rubro.ToLower().Contains(texto.ToLower()))
            //    {
            //        rubrosfiltrados.Add(rubro);
            //    }
            //}


            cbxRubro.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxRubro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxRubro.DataSource = listarubro;


        }

        private void frmAgregarRubro_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.TopLevel = true;
            this.TopMost = true;

            

            
            ConexionRubro conexionrubro = new ConexionRubro();
            listarubro = conexionrubro.listarRubro();

            dgvRubros.DataSource = listarubro;
            dgvRubros_Propiedades();
            if (trubro != null)
            {
                this.Text = "Modificar";

                
            }

        }
        private void dgvRubros_Propiedades()
        {
            dgvRubros.Columns[0].Visible = false;
            dgvRubros.Columns[2].Visible = false;
            dgvRubros.Columns[3].Visible = false;
        }

        private void frmAgregarRubro_MouseLeave(object sender, EventArgs e)
        {
            TopMost = false;
        }

        private void cbxRubro_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
