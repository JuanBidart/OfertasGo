using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace OfertasGo
{
    public partial class frmAgregarProducto : Form
    {
        public frmAgregarProducto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TProductos producto = new TProductos();
            ConexionProductodb productodb = new ConexionProductodb();
            try
            {
                producto.Descripcion = txtDescripcion.Text;
                producto.Costo = double.Parse(txtCosto.Text);
                producto.RecargoPorcentaje = double.Parse(txtRecargo.Text);
                producto.Final = double.Parse(txtFinal.Text);
                producto.FechaModificacion = dtpFecha.Value.Date;

                productodb.agregarProducto(producto);
                MessageBox.Show("Agregado exitosamente");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAgregarRubro agregarRubro = new frmAgregarRubro();
            agregarRubro.ShowDialog();
        }

        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {
            ConexionRubro conexionRubro = new ConexionRubro();
            try
            {
                cboRubro.DataSource = conexionRubro.listarRubro();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            } 
        }
    }
}
