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
            lvLista.Items.Clear();
           

            

            foreach (var item in listaProductos)
            {
                ListViewItem lvItem = new ListViewItem();

                lvItem = lvLista.Items.Add(item.idProductos.ToString());
                lvItem.SubItems.Add(item.Descripcion);
                if (item.Activo == 0)
                {
                    lvItem.SubItems.Add("NO");
                    lvItem.BackColor = Color.Red;
                }
                else
                {
                    lvItem.SubItems.Add("SI");
                }
                
            }
        }

        private void lvLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
