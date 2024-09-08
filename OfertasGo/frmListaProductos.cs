using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OfertasGo
{
    public partial class frmListaProductos : Form
    {
        TProductos productos = new TProductos();
        ConexionProductodb conexionProductodb = new ConexionProductodb();
        List<TProductos> listaTotalProductos = new List<TProductos>();
        public frmListaProductos()
        {
            InitializeComponent();
            listaTotalProductos = conexionProductodb.listarProductosTodos(true,true);
        }

        private void frmListaProductos_Load(object sender, EventArgs e)
        {

            refrescarLista(listaTotalProductos);

        }
        private void refrescarLista(List<TProductos> listaProductos)
        {


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


        private void btnActivar_Click(object sender, EventArgs e)
        {


            foreach (ListViewItem item in lvLista.CheckedItems)
            {
                TProductos productoSelecionado = new TProductos();
                productoSelecionado.idProductos = int.Parse(item.Text);
                conexionProductodb.desOactProducto(productoSelecionado, true);
            }
            listaTotalProductos = conexionProductodb.listarProductosTodos(true, true);
            refrescarLista(listaTotalProductos);
            txtBuscar.Text = string.Empty;
        }

        private void btnDesactivarLote_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvLista.CheckedItems)
            {
                TProductos productoSelecionado = new TProductos();
                productoSelecionado.idProductos = int.Parse(item.Text);
                conexionProductodb.desOactProducto(productoSelecionado, false);
            }
            listaTotalProductos = conexionProductodb.listarProductosTodos(true, true);
            refrescarLista(listaTotalProductos);
            txtBuscar.Text = string.Empty;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                lvLista.Items.Clear();
                List<TProductos> listaProductos2 = new List<TProductos>();
                listaProductos2 = conexionProductodb.listarProductosTodos(true, true);
                listaProductos2 = listaProductos2.FindAll(x => x.Descripcion.ToUpper() == txtBuscar.Text.ToUpper() || x.Descripcion.ToUpper().Contains(txtBuscar.Text.ToUpper()));

                refrescarLista(listaProductos2);

            }
            else
            {
                refrescarLista(listaTotalProductos);
            }
        }

       
    }
}
