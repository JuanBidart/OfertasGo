using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfertasGo
{
    public partial class frmListaProductos : Form
    {
        TProductos productos = new TProductos();
        ConexionProductodb conexionProductodb = new ConexionProductodb();
        public frmListaProductos()
        {
            InitializeComponent();
        }

        private void frmListaProductos_Load(object sender, EventArgs e)
        {
           List<TProductos> listaProductos = conexionProductodb.listarProductos();
            lvLista.
        }
    }
}
