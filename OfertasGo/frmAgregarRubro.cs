using System;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace OfertasGo
{
    public partial class frmAgregarRubro : Form
    {
        public frmAgregarRubro()
        {
            InitializeComponent();
            this.TopLevel = true;
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

        }
    }
}
