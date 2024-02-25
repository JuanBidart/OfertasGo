using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace OfertasGo
{
    public partial class frmProductos : Form
    {
        public ConexionProductodb conexionProductodb = new ConexionProductodb();
        

        public frmProductos()
        {
            InitializeComponent();
            
            
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            actualizaLLista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarProducto agregarProducto = new frmAgregarProducto();
            agregarProducto.ShowDialog();
            actualizaLLista();
        }
        public void actualizaLLista() 
        {
            var listadeProductos = conexionProductodb.listarProductos();
            dgvProductos.DataSource = listadeProductos;
        }
    }
}
