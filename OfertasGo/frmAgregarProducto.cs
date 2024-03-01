using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            //TRubro rubro = new TRubro();
            ConexionProductodb productodb = new ConexionProductodb();
            
            
            try
            {
                producto.Descripcion = txtDescripcion.Text;
                producto.Costo = double.Parse(txtCosto.Text);
                producto.RecargoPorcentaje = double.Parse(txtRecargo.Text);
                producto.Final = double.Parse(txtFinal.Text);
                producto.FechaModificacion = dtpFecha.Value.Date.ToString("dd/MM/yy");

                if (chbactivo.Checked)
                {
                    producto.Activo = 1;
                }
                else producto.Activo = 0;
                
                producto.Rubro = (TRubro)cboRubro.SelectedItem;
                producto.Proveedores = (TProveedores)cbxProveedor.SelectedItem;
                

                
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
            actComboBoxRubro();
        }
        public void actComboBoxRubro() 
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
        public void actComboBoxProveedores () 
        {
            ConexionProveedores conexionProveedores = new ConexionProveedores();
            try
            {
                cbxProveedor.DataSource = conexionProveedores.listarProveedores();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

        }
        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {
            txtCosto.Text = "0";
            txtRecargo.Text = "0";
            txtFinal.Text = "0";
            txtDescripcion.Focus();

            //    ToString("C2", CultureInfo.CreateSpecificCulture("ES-ar"));
            actComboBoxRubro();
            actComboBoxProveedores();
        }

        

       

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCosto.Text != "0" && txtCosto.Text != "")
                {
                    double costo = double.Parse(txtCosto.Text);
                    double recargo = double.Parse(txtRecargo.Text);
                    double final = ((costo * recargo) / 100) + costo;
                    txtFinal.Text = final.ToString();
                    txtFinal.ForeColor = Color.Red;

                }
            }
            catch (Exception)
            {

                throw;
            }
          
           
        }

        private void txtRecargo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtRecargo.Text != "0" && txtRecargo.Text != "")
                {

                    double costo = double.Parse(txtCosto.Text);
                    double recargo = double.Parse(txtRecargo.Text);
                    double final = ((costo * recargo) / 100) + costo;
                    txtFinal.Text = final.ToString();
                    txtFinal.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {

               throw ex;
            }
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
