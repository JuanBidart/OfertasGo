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
        List<THistorialPrecio> ListaFiltradaObtenidda = new List<THistorialPrecio>();
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
        public void cargarListaFiltrada()
        {
            var productoSeleccionado = (TProductos)dgvProductos.CurrentRow.DataBoundItem;
            int idProductoSelec = productoSeleccionado.idProductos;
            List<THistorialPrecio> listaHistorioal = historialPrecios.listarhistorialDesendiente();
            List<THistorialPrecio> listaFiltrada = listaHistorioal.FindAll(n => idProductoSelec == n.idProducto);


            ListaFiltradaObtenidda = listaFiltrada;

        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (paso != false)
            {
                cargarListaFiltrada();
                dgvHistorial.DataSource = ListaFiltradaObtenidda;
                lblUltimaFechaAct.Text = obtenerUltimafechamod();
                lblDiasPasados.Text = diasPasados().ToString();

                try
                {

                    if (dgvHistorial.RowCount > 1)
                    {



                        List<double> listaCosto = new List<double>();
                        //listaCosto = null;
                        double valorActual = 0;
                        double ultimoValor = 0;
                        foreach (var item in ListaFiltradaObtenidda)
                        {
                            listaCosto.Add(item.Costo);
                        }
                        valorActual = listaCosto[0];
                        ultimoValor = listaCosto[1];

                        double porcentajeDeSuba = ((valorActual - ultimoValor) / ultimoValor) * 100;
                        if (porcentajeDeSuba >= 0)
                        {
                            lblPorcentaje.Text = porcentajeDeSuba.ToString("C2", CultureInfo.CreateSpecificCulture("ES-ar")).Remove(0, 1).Insert(0, "%");
                            lblPorcentaje.ForeColor = Color.WhiteSmoke;
                        }
                        else
                        {
                            lblPorcentaje.Text = porcentajeDeSuba.ToString("C2", CultureInfo.CreateSpecificCulture("ES-ar")).Remove(1, 1).Insert(0, "%");
                            lblPorcentaje.ForeColor = Color.Aquamarine;
                        }

                    }
                    else
                    {
                        lblPorcentaje.Text = "%0";
                        lblPorcentaje.ForeColor = Color.WhiteSmoke;
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
        public int diasPasados()
        {
            THistorialPrecio ultimofechaleida = ListaFiltradaObtenidda[0];
            DateTime ultimafecha = ultimofechaleida.FechaMod;
            DateTime fechaActual = DateTime.Now;
            TimeSpan dias = fechaActual - ultimafecha;
           return dias.Days;
        }
        public string obtenerUltimafechamod()
        {
            THistorialPrecio ultimaFecha = ListaFiltradaObtenidda[0];
            return ultimaFecha.FechaMod.ToString("dd/MM/yy");


        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            var productoSeleccionado = (TProductos)dgvProductos.CurrentRow.DataBoundItem;
            frmAgregarProducto frmAgregarProducto = new frmAgregarProducto(productoSeleccionado);
            frmAgregarProducto.ShowDialog();

            actualizaLista();

        }

        private void frmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            paso = false;
        }

        
    }
       
}
