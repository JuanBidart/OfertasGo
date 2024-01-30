using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfertasGo
{
    public partial class frmAgregarRubro : Form
    {
        public frmAgregarRubro()
        {
            InitializeComponent();
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
    }
}
