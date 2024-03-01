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
    public partial class frmProductos : Form
    {
        public ConexionProductodb conexionProductodb = new ConexionProductodb();
        public ConexionHistorialPrecios historialPrecios = new ConexionHistorialPrecios();
        

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

        }
        public void actualizaHistorial() 
        {
            var listaHistorial = historialPrecios.listarhistorial();
            dgvHistorial.DataSource = listaHistorial;

            dgvHistorial.Columns[0].Visible = false;

        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            var productoSeleccionado = (TProductos)dgvProductos.CurrentRow.DataBoundItem;
            int idProductoSelec = productoSeleccionado.idProductos;
            List<THistorialPrecio> listaHistorioal = historialPrecios.listarhistorial();
            List<THistorialPrecio> listaFiltrada = listaHistorioal.FindAll(n => idProductoSelec == n.idProducto);
            dgvHistorial.DataSource = listaFiltrada;
        }
    }
}
