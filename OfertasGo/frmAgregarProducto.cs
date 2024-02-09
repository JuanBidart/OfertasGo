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
            ConexionProductodb productodb = new ConexionProductodb();
            try
            {
                producto.Descripcion = txtDescripcion.Text;
                producto.Costo = double.Parse(txtCosto.Text.Remove(0, 1));
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
            actComboBoxRubro();
        }
        public void actComboBoxRubro() 
        {
            ConexionRubro conexionRubro = new ConexionRubro();
            try
            {
                List<TRubro> rubros = new List<TRubro>();
                rubros = conexionRubro.listarRubro();
                List<string> values = new List<string>();

                foreach (var rubro in rubros)
                {
                    values.Add(rubro.Rubro);

                }

                cboRubro.DataSource = values;

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
        }

        

        private void txtCosto_Leave(object sender, EventArgs e)
        {
            string input = txtCosto.Text;
            if (decimal.TryParse(input, out decimal value))
            {


                string formattedValue = value.ToString("C2", CultureInfo.CreateSpecificCulture("ES-ar"));

                // Asignar el valor formateado al TextBox
                txtCosto.Text = formattedValue;
            }
            else 
            {
                MessageBox.Show("Solo Numeros", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtCosto.Text = "";
                txtCosto.Focus();
             }
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            if (txtCosto.Text != "0" && !txtCosto.Text.Contains("$"))
            {
                double costo = double.Parse(txtCosto.Text);
                double recargo = double.Parse(txtRecargo.Text);
                double final = ((costo * recargo) / 100) + costo;
                txtFinal.Text = final.ToString();
                txtFinal.ForeColor = Color.Red;

            }
           
        }

        private void txtRecargo_TextChanged(object sender, EventArgs e)
        {
            if (txtRecargo.Text != "0")
            {

                double costo = double.Parse(txtCosto.Text.Remove(0,1));
                double recargo = double.Parse(txtRecargo.Text);
                double final = ((costo * recargo) / 100) + costo;
                txtFinal.Text = final.ToString();
                txtFinal.ForeColor = Color.Red;
            }
           
        }

        private void frmAgregarProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
           // frmProductos productos = new frmProductos();
           // productos.actualizaLLista();
        }
    }
}
