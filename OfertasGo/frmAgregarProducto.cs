using System;
using System.Drawing;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace OfertasGo
{

    public partial class frmAgregarProducto : Form
    {
        public TProductos producto = null;
        public bool paso = false;
        public double[] ivaparacbx = { 0, 10.5, 21, 27 };

        public frmAgregarProducto()
        {
            InitializeComponent();
            this.TopLevel = true;
            //this.TopMost = true;
            lblinfofecha.Visible = false;
            cbxRubro.DropDownStyle = ComboBoxStyle.DropDown;
            cbxRubro.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxRubro.AutoCompleteCustomSource = devolverdatos();
            cbxRubro.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }
        public frmAgregarProducto(TProductos producto)
        {

            InitializeComponent();
            this.producto = producto;
            this.Text = "Modificar Producto";
            dtpFecha.Enabled = false;
            lblinfofecha.Visible = true;
            this.TopLevel = true;
            this.TopMost = true;
            ;


        }

        private AutoCompleteStringCollection devolverdatos()
        {
            AutoCompleteStringCollection autoCompleteStrings = new AutoCompleteStringCollection();
            ConexionRubro conexionRubro = new ConexionRubro();

            foreach (var item in conexionRubro.listarRubro())
            {
                autoCompleteStrings.Add(item.Rubro);
            }
            return autoCompleteStrings;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            ConexionProductodb productodb = new ConexionProductodb();


            try
            {
                if (producto == null)
                {
                    producto = new TProductos();
                }
                producto.Descripcion = txtDescripcion.Text;
                producto.Costo = double.Parse(txtCosto.Text.Replace(".", ","));
                producto.DescuentoCostoPorcentaje = double.Parse(txtPorcentajeDescuento.Text.Replace(".", ","));
                producto.RecargoPorcentaje = double.Parse(txtRecargo.Text.Replace(".", ","));
                producto.Final = double.Parse(txtFinal.Text.Replace(".", ","));
                producto.FechaModificacion = DateTime.Now.Date.ToString("dd/MM/yy"); // dtpFecha.Value.Date.ToString("dd/MM/yy");
                producto.Iva = double.Parse(cbxIva.Text.Replace(".", ","));
                producto.AjustePesos = double.Parse(txtAjuste.Text.Replace(".", ","));

                if (chbactivo.Checked)
                {
                    producto.Activo = 1;
                }
                else producto.Activo = 0;

                producto.Rubro = (TRubro)cbxRubro.SelectedItem;
                producto.Proveedores = (TProveedores)cbxProveedor.SelectedItem;


                if (producto.idProductos != 0)
                {
                    productodb.modificarProducto(producto);
                    MessageBox.Show("Modificado", "OK");
                    Dispose();
                    Close();

                }
                else
                {
                    productodb.agregarProducto(producto);
                    if (producto.Rubro != null)
                    {
                        MessageBox.Show("Agregado exitosamente");

                    }
                    else
                    {
                        MessageBox.Show("No se Pudo agregar \n Verifique el campo RUBRO", "ERROR DEL RUBRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Dispose();
                    Close();

                }


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
            cbxRubro.Focus();
        }
        public void actComboBoxRubro()
        {
            ConexionRubro conexionRubro = new ConexionRubro();
            try
            {
                cbxRubro.DataSource = conexionRubro.listarRubro();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
        public void actComboBoxProveedores()
        {
            ConexionProveedores conexionProveedores = new ConexionProveedores();
            try
            {
                cbxProveedor.DataSource = conexionProveedores.listarProveedores(true);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

        }
        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {
            this.Activate();


            if (producto == null)
            {
                txtAjuste.Text = "0";
                txtCosto.Text = "0";
                txtPorcentajeDescuento.Text = "0";
                txtRecargo.Text = "0";
                txtFinal.Text = "0";
                txtDescripcion.Focus();

                cbxIva.Items.Add("0"); cbxIva.Items.Add("10.5"); cbxIva.Items.Add("21"); cbxIva.Items.Add("27");
                cbxIva.SelectedIndex = 0;


                actComboBoxRubro();
                actComboBoxProveedores();
                paso = true;
            }

            else
            {
                actComboBoxRubro();
                actComboBoxProveedores();
                cbxProveedor.ValueMember = "idProveedores";
                cbxProveedor.DisplayMember = "RazonSocial";
                cbxRubro.ValueMember = "idRubro";
                cbxRubro.DisplayMember = "Rubro";

                switch (cbxIva.Text = producto.Iva.ToString())
                {
                    case "0":
                        cbxIva.Items.Add("10.5"); cbxIva.Items.Add("21"); cbxIva.Items.Add("27");
                        break;
                    case "10.5":
                        cbxIva.Items.Add("0"); cbxIva.Items.Add("21"); cbxIva.Items.Add("27");
                        break;
                    case "21":
                        cbxIva.Items.Add("10.5"); cbxIva.Items.Add("0"); cbxIva.Items.Add("27");
                        break;
                    case "27":
                        cbxIva.Items.Add("10.5"); cbxIva.Items.Add("21"); cbxIva.Items.Add("0");
                        break;
                    default:
                        break;
                }

                txtDescripcion.Text = producto.Descripcion.ToString();
                txtCosto.Text = producto.Costo.ToString();//if (txtCosto.Text == string.Empty) { txtCosto.Text = "0"; };
                txtPorcentajeDescuento.Text = producto.DescuentoCostoPorcentaje.ToString(); if (txtPorcentajeDescuento.Text == string.Empty) { txtPorcentajeDescuento.Text = "0"; };
                txtRecargo.Text = producto.RecargoPorcentaje.ToString(); if (txtRecargo.Text == string.Empty) { txtRecargo.Text = "0"; };
                txtFinal.Text = producto.Final.ToString(); if (txtFinal.Text == string.Empty) { txtFinal.Text = "0"; };
                dtpFecha.Text = producto.FechaModificacion;
                txtAjuste.Text = producto.AjustePesos.ToString();
                cbxProveedor.SelectedValue = producto.Proveedores.idProveedores;
                cbxRubro.SelectedValue = producto.Rubro.idRubro;
                paso = true;


            }

        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            if (paso) calcularResultadoFinal(txtCosto);

            
        }

        private void txtRecargo_TextChanged(object sender, EventArgs e)
        {
            if (paso) calcularResultadoFinal(txtRecargo);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAgregarProveedor frmproveedor = new frmAgregarProveedor();
            frmproveedor.ShowDialog();
            actComboBoxProveedores();
            cbxProveedor.Focus();
        }


        private void cbxRubro_TextChanged(object sender, EventArgs e)
        {
            //string filtro = cbxRubro.Text.ToUpper();


        }

        private void cbxIva_SelectedValueChanged(object sender, EventArgs e)
        {
            if (paso)
            {
                try
                {
                    if (txtRecargo.Text != "" && cbxIva.Text != "")
                    {
                        double costo_iva;
                        double final;
                        double costodescuento;
                        double costorecargo;


                        double descuento = double.Parse(txtPorcentajeDescuento.Text.Replace(".", ","));
                        double costo = double.Parse(txtCosto.Text.Replace(".", ","));
                        double iva = double.Parse(cbxIva.Text.Replace(".", ","));
                        double recargo = double.Parse(txtRecargo.Text.Replace(".", ","));
                        double ajuste = double.Parse(txtAjuste.Text.Replace(".", ","));

                        costodescuento = ((costo * descuento) / 100);

                        costo_iva = ((costo * iva) / 100);

                        double costoMasIva = costo + costo_iva;

                        costorecargo = ((costoMasIva * recargo) / 100) + costoMasIva;//recargo sobre el iva aplicado

                        final = (costorecargo - costodescuento) + ajuste;

                        cbxIva.Text = iva.ToString();
                        txtFinal.Text = final.ToString();
                        txtFinal.ForeColor = Color.Red;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Los datos ingresados son incorrectos", "Error");
                }


                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        private void txtPorcentajeDescuento_TextChanged(object sender, EventArgs e)
        {
            if (paso) calcularResultadoFinal(txtPorcentajeDescuento);


        }
        private void calcularResultadoFinal(TextBox textBox)
        {

            try
            {
                if (textBox.Text != "" /*&& textBox.Text != ""*/)
                {
                    double costo_iva;
                    double final;
                    double costodescuento;
                    double costorecargo;


                    double descuento = double.Parse(txtPorcentajeDescuento.Text.Replace(".", ","));
                    double costo = double.Parse(txtCosto.Text.Replace(".", ","));
                    double iva = double.Parse(cbxIva.Text.Replace(".", ","));
                    double recargo = double.Parse(txtRecargo.Text.Replace(".", ","));
                    double ajuste = double.Parse(txtAjuste.Text.Replace(".", ","));

                    costodescuento = ((costo * descuento) / 100);

                    costo_iva = ((costo * iva) / 100);

                    double costoMasIva = costo + costo_iva;

                    costorecargo = ((costoMasIva * recargo) / 100)+costoMasIva;//recargo sobre el iva aplicado

                    final = (costorecargo - costodescuento) + ajuste;

                    cbxIva.Text = iva.ToString();
                    txtFinal.Text = final.ToString();
                    txtFinal.ForeColor = Color.Red;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Los datos ingresados son incorrectos", "Error");
            }


            catch (Exception ex)
            {

                throw ex;
            }



        }

        private void txtAjuste_TextChanged(object sender, EventArgs e)
        {
            string tecleado = txtAjuste.Text;
            foreach (char item in tecleado)
            {
                if (char.IsNumber(item))
                {
                    if (paso) calcularResultadoFinal(txtAjuste);
                }
                else
                {
                    int cont = tecleado.Length;
                    tecleado.Remove(cont - 1);
                    txtAjuste.Text = tecleado;
                }
            }


        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Imágenes (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp|" +
                                                 "Todos los archivos (*.*)|*.*"; 
            openFile.Title = "Cargar Imagen";
            

            if (openFile.ShowDialog() == DialogResult.OK)
            {
               string Ruta = openFile.FileName;
                pbxImagen.Load(Ruta);
            }
            else {
               // pbxImagen.Load() ;

            }
            
        }
    }
}
