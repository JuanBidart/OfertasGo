using Dominio;
using Negocio;
using System;
using System.Windows.Forms;

namespace OfertasGo
{
    public partial class frmAgregarProveedor : Form
    {
        TProveedores Proveedor = null;
        public frmAgregarProveedor()
        {
            InitializeComponent();
        }
        public frmAgregarProveedor(TProveedores ProovedoorRecibido) 
        {
            InitializeComponent();
            Proveedor = ProovedoorRecibido;
        
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

            //Validacion cargar nuevo si no esta en la lista:
            var selecionadoid = (TProveedores)dgvListaProveedores.CurrentRow.DataBoundItem;
            if (txtRazonSocial.Text == selecionadoid.RazonSocial)
            {
                MessageBox.Show("¡Ya existe el Proveedor! \n Si lo que quiere es modificar presione el boton MODIFICAR","Lea atentamente",MessageBoxButtons.OK,MessageBoxIcon.Question);
                return;
            }
            
            //Validacion si el telewfono es un numero:
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
        private void cargardgvLista() 
        {
            ConexionProveedores conexionProveedores = new ConexionProveedores();
            dgvListaProveedores.DataSource = conexionProveedores.listarProveedores();
        
        }

        private void frmAgregarProveedor_Load(object sender, EventArgs e)
        {
            if (Proveedor != null) 
            {
                this.Width = 850;
                this.Height = 500;
                dgvListaProveedores.Visible = true;
                lblListaProvedores.Visible = true;
                btnDesactivar.Visible = true;
                cargardgvLista();
                dgvListaProveedores.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
                dgvListaProveedores.Columns["Eliminado"].Visible = false;


            }
            else
            {
                btnDesactivar.Visible = false;
                btnModificar.Visible = false;
                lblListaProvedores.Visible = false;
                dgvListaProveedores.Visible = false;
                this.Width = 440;
                this.Height = 460;

            }
        }

        private void dgvListaProveedores_SelectionChanged(object sender, EventArgs e)
        {
            var selecionadoid = (TProveedores)dgvListaProveedores.CurrentRow.DataBoundItem;
            txtRazonSocial.Text = selecionadoid.RazonSocial.ToString();
            txtDireccion.Text = selecionadoid.Direccion.ToString();
            txtCiudad.Text = selecionadoid.Ciudad.ToString();
            txtTelefono.Text = selecionadoid.Telefono.ToString();
            txtTelefono2.Text = selecionadoid.Telefono2.ToString();
            if (selecionadoid.Activo ==1)
            {
                cbxActivo.Checked = true;
            }
            else
            {
                cbxActivo.Checked = false;
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            TProveedores Proveedor = (TProveedores)dgvListaProveedores.CurrentRow.DataBoundItem;
            ConexionProveedores conexionProveedores = new ConexionProveedores();
            conexionProveedores.desactivar(Proveedor);
            cargardgvLista();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ConexionProveedores proveedores = new ConexionProveedores();
            TProveedores proveedores1 = new TProveedores();
            var provedorselecionado = (TProveedores)dgvListaProveedores.CurrentRow.DataBoundItem;
            proveedores1.idProveedores = provedorselecionado.idProveedores;
            proveedores1.RazonSocial = txtRazonSocial.Text;
            proveedores1.Direccion = txtDireccion.Text;
            proveedores1.Ciudad = txtCiudad.Text;
            proveedores1.Telefono = txtTelefono.Text;
            proveedores1.Telefono2 = txtTelefono2.Text;
            if (cbxActivo.Checked == true)
            {
                proveedores1.Activo = 1;
            }
            else
            {
                proveedores1.Activo = 0;
            }

            proveedores.modificarproveedor(proveedores1);

            cargardgvLista();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtRazonSocial.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            txtTelefono.Text = "";
            txtTelefono2.Text = "";
        }
    }
}
