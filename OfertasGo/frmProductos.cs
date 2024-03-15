using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace OfertasGo
{
    public partial class frmProductos : Form
    {
        public ConexionProductodb conexionProductodb = new ConexionProductodb();
        public ConexionHistorialPrecios historialPrecios = new ConexionHistorialPrecios();
        List<THistorialPrecio> ListaFiltradaObtenidda =new List<THistorialPrecio>();
        bool paso = false;
        public frmProductos()
        {
            InitializeComponent();
            

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
           
            actualizaLista();
            actualizaHistorial();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarProducto agregarProducto = new frmAgregarProducto();
            agregarProducto.ShowDialog();
            actualizaLista();
            actualizaHistorial();
        }
        public void actualizaLista()
        {
            var listadeProductos = conexionProductodb.listarProductos();
            dgvProductos.DataSource = listadeProductos;
            paso = true;
        }
        public void actualizaHistorial()
        {
            var listaHistorial = historialPrecios.listarhistorialDesendiente();
            
            dgvHistorial.DataSource = listaHistorial;

            dgvHistorial.Columns[0].Visible = false;
            
             

        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (paso != false)
            {
                 var productoSeleccionado = (TProductos)dgvProductos.CurrentRow.DataBoundItem;
                int idProductoSelec = productoSeleccionado.idProductos;
                List<THistorialPrecio> listaHistorioal = historialPrecios.listarhistorialDesendiente();
                List<THistorialPrecio> listaFiltrada = listaHistorioal.FindAll(n => idProductoSelec == n.idProducto);

                dgvHistorial.DataSource = listaFiltrada;
                ListaFiltradaObtenidda = listaFiltrada;
            }
            
            
            


        }

        private void dgvHistorial_DataSourceChanged(object sender, EventArgs e)
        {
           /* try
            {
                if (dgvHistorial.RowCount > 2)
                {
                    List<double> listaCosto = new List<double>();
                    foreach (var item in ListaFiltradaObtenidda)
                    {
                        listaCosto.Add(item.Costo);
                    }
                    double valorActual = listaCosto[0];
                    double ultimoValor = listaCosto[1];
                    double porcentajeDeSuba = ((valorActual - ultimoValor) / ultimoValor) * 100;
                    lblPorcentaje.Text = porcentajeDeSuba.ToString("C2",CultureInfo.CreateSpecificCulture("ES-ar")).Remove(0,1).Insert(0, "%");
                }
                else
                {
                    lblPorcentaje.Text = "%0";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }*/
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var productoSeleccionado = (TProductos)dgvProductos.CurrentRow.DataBoundItem;
            frmAgregarProducto frmAgregarProducto = new frmAgregarProducto(productoSeleccionado);
            frmAgregarProducto.ShowDialog();
            
            actualizaLista();
            actualizaHistorial();
        }

        private void dgvHistorial_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (dgvHistorial.RowCount > 2)
                {
                    List<double> listaCosto = new List<double>();
                    foreach (var item in ListaFiltradaObtenidda)
                    {
                        listaCosto.Add(item.Costo);
                    }
                    double valorActual = listaCosto[0];
                    Debug.WriteLine(valorActual);
                    double ultimoValor = listaCosto[1];
                    Debug.WriteLine(ultimoValor);
                    double porcentajeDeSuba = ((valorActual - ultimoValor) / ultimoValor) * 100;
                    lblPorcentaje.Text = porcentajeDeSuba.ToString("C2", CultureInfo.CreateSpecificCulture("ES-ar")).Remove(0, 1).Insert(0, "%");
                }
                else
                {
                    lblPorcentaje.Text = "%0";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
