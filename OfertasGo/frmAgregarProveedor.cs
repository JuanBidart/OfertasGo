using Dominio;
using Negocio;
using System;
using System.Windows.Forms;

namespace OfertasGo
{
    public partial class frmAgregarProveedor : Form
    {
        public frmAgregarProveedor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool validacionNumero(TextBox textbox)
        {
            string Texto = textbox.Text;
            foreach (char T in Texto)
            {
                if (!char.IsNumber(T))
                {
                    return false;


                };

            }
            return true;

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ConexionProveedores proveedores = new ConexionProveedores();
            TProveedores proveedor = new TProveedores();
            AccesoDatos datos = new AccesoDatos();

            //Validacion
            if (!(validacionNumero(txtTelefono) && validacionNumero(txtTelefono2)))
            {
                MessageBox.Show("Ingrese solo numeros en los campos Numeros de Teléfono", "Error", MessageBoxButtons.OK);
                txtTelefono.Focus();
            }
            else
            {
                try
                {




                    proveedor.RazonSocial = txtRazonSocial.Text;
                    proveedor.Direccion = txtDireccion.Text;
                    proveedor.Ciudad = txtCiudad.Text;
                    proveedor.Telefono = txtTelefono.Text;
                    proveedor.Telefono2 = txtTelefono2.Text;
                    if (cbxActivo.Checked)
                    {
                        proveedor.Activo = 1;

                    }
                    else proveedor.Activo = 0;


                    proveedores.agregarProveedor(proveedor);
                    MessageBox.Show("Agregado exitosamente");
                    this.Close();

                }

                catch (Exception ex)
                {

                    MessageBox.Show("Error al Agregar" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { datos.cerrarConexion(); }

            }


        }


    }
}
