using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace OfertasGo
{

    public partial class frmAgregarProducto : Form
    {
        public TProductos producto = null;
        public bool paso = false;
        public double[] ivaparacbx = { 0, 10.5,21,27};

        public frmAgregarProducto()
        {
            InitializeComponent();
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
                //producto.DescuentoCostoPorcentaje = double.Parse(txtPorcentajeDescuento.Text.Replace(".", ","));
                producto.RecargoPorcentaje = double.Parse(txtRecargo.Text.Replace(".", ","));
                producto.Final = double.Parse(txtFinal.Text.Replace(".", ","));
                producto.FechaModificacion = DateTime.Now.Date.ToString("dd/MM/yy"); // dtpFecha.Value.Date.ToString("dd/MM/yy");
                producto.Iva = double.Parse(cbxIva.Text.Replace(".", ","));

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
                        MessageBox.Show("No se Pudo agregar \n Verifique el campo RUBRO","ERROR DEL RUBRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
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


            if (producto == null)
            {
                txtCosto.Text = "0";
                txtPorcentajeDescuento.Text = "0";
                txtRecargo.Text = "0";
                txtFinal.Text = "0";
                txtDescripcion.Focus();

                cbxIva.Items.Add("0"); cbxIva.Items.Add("10.5"); cbxIva.Items.Add("21"); cbxIva.Items.Add("27");
                cbxIva.SelectedIndex=0 ;


                actComboBoxRubro();
                actComboBoxProveedores();
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
                cbxProveedor.SelectedValue = producto.Proveedores.idProveedores;
                cbxRubro.SelectedValue = producto.Rubro.idRubro;
                paso = true;
                    

            }

        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            if (paso) calcularResultadoFinal(txtCosto);

            //try

            //{
            //    double costo;
            //    double porcentajeDescuento;
            //    double costo_porcentajeDescuento;
            //    double recargo;
            //    double iva;
            //    double costo_iva;
            //    double final;
            //    if (producto == null)
            //    {
            //        if (txtCosto.Text != "0" && txtCosto.Text != "")
            //        {
            //            if (txtRecargo.Text != "0" && txtRecargo.Text != "")
            //            {
            //                if (txtPorcentajeDescuento.Text != "0" && txtPorcentajeDescuento.Text != "")
            //                {
            //                    costo = double.Parse(txtCosto.Text.Replace(".", ","));
            //                    porcentajeDescuento = double.Parse(txtPorcentajeDescuento.Text.Replace(".", ","));
            //                    iva = double.Parse(cbxIva.Text.Replace(".", ","));
            //                    recargo = double.Parse(txtRecargo.Text.Replace(".", ","));

            //                    costo_porcentajeDescuento = ((costo * porcentajeDescuento) / 100);
            //                    costo_iva = ((costo * iva) / 100) + costo;
            //                    final = ((costo_iva * recargo) / 100) + costo_iva - costo_porcentajeDescuento;
            //                    txtFinal.Text = final.ToString();
            //                    txtFinal.ForeColor = Color.Red;

            //                }
            //                costo = double.Parse(txtCosto.Text.Replace(".", ","));

            //                iva = double.Parse(cbxIva.Text.Replace(".",","));
            //                recargo = double.Parse(txtRecargo.Text.Replace(".", ","));


            //                costo_iva = ((costo * iva) / 100) + costo;
            //                final = ((costo_iva * recargo) / 100) + costo_iva;
            //                txtFinal.Text = final.ToString();
            //                txtFinal.ForeColor = Color.Red;
            //            }
            //            else
            //            {

            //                txtFinal.Text = txtCosto.Text;
            //                txtFinal.ForeColor = Color.Red;
            //            }

            //        }
            //    }
            //    else
            //    {
            //        if (txtCosto.Text != "0" && txtCosto.Text != "")
            //        {
            //            costo = double.Parse(txtCosto.Text.Replace(".", ","));
            //            if (txtRecargo.Text == "")
            //            {
            //                porcentajeDescuento = producto.DescuentoCostoProcentaje;
            //                recargo = producto.RecargoPorcentaje;
            //                iva = producto.Iva;
            //                cbxIva.Items.Add(iva);
            //            }
            //            else
            //            {
            //                porcentajeDescuento = double.Parse(txtPorcentajeDescuento.Text.Replace(".", ","));
            //                recargo = double.Parse(txtRecargo.Text.Replace(".", ","));
            //                iva = double.Parse(cbxIva.Text.Replace(".",","));
            //            }

            //            costo_porcentajeDescuento = ((costo * porcentajeDescuento) / 100);
            //            costo_iva = ((costo * iva) / 100) + costo;
            //            final = ((costo_iva * recargo) / 100) + costo_iva - costo_porcentajeDescuento;
            //            txtFinal.Text = final.ToString();
            //            txtFinal.ForeColor = Color.Red;
            //        }


            //        }

            //}
            //catch (System.FormatException){ MessageBox.Show("El tipo de dato ingresado no es un numero", "ERROR -ingrese nuevamente-", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            //catch (Exception ex)
            //{

            //    throw ex;
            //}
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
            string filtro = cbxRubro.Text.ToUpper();
          

        }

        private void cbxIva_SelectedValueChanged(object sender, EventArgs e)
        {
            if (paso)
            {
                try
                {
                    if (txtRecargo.Text != "" && cbxIva.Text != "")
                    {
                        double costo_porcentajeDescuento;
                        double costo_iva;
                        double final;

                        double costo = double.Parse(txtCosto.Text.Replace(".", ","));
                        double descuentoPorcentaje = double.Parse(txtPorcentajeDescuento.Text.Replace(".", ","));
                        double iva = double.Parse(cbxIva.Text.Replace(".", ","));
                        double recargo = double.Parse(txtRecargo.Text.Replace(".", ","));

                        costo_porcentajeDescuento = ((costo * descuentoPorcentaje) / 100);
                        costo_iva = ((costo * iva) / 100) + costo;
                        final = ((costo_iva * recargo) / 100) + costo_iva - costo_porcentajeDescuento;

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
                if (textBox.Text != "0" && textBox.Text != "")
                {
                    double costo_iva;
                    double final;
                    double costodescuento;
                    double costorecargo;

                    double descuento = double.Parse(txtPorcentajeDescuento.Text.Replace(".", ","));
                    double costo = double.Parse(txtCosto.Text.Replace(".", ","));
                    double iva = double.Parse(cbxIva.Text.Replace(".", ","));
                    double recargo = double.Parse(txtRecargo.Text.Replace(".", ","));

                    costodescuento = ((costo * descuento) / 100);
                    costo_iva = ((costo * iva) / 100);
                    costorecargo = ((costo * recargo) / 100);
                    final = costo - costodescuento + costo_iva + costorecargo;

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
}
