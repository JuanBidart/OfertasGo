using Dominio;
using Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;

namespace OfertasGo
{
    public partial class frmProductos : Form
    {
        public ConexionProductodb conexionProductodb = new ConexionProductodb();
        public ConexionHistorialPrecios historialPrecios = new ConexionHistorialPrecios();
        List<THistorialPrecio> ListaFiltradaObtenidda = new List<THistorialPrecio>();
        List<TProductos> listaProductosActivos = new List<TProductos>();
        bool paso = false;
        bool paso2 = true;

        public frmProductos()
        {
            InitializeComponent();


        }

        private void frmProductos_Load(object sender, EventArgs e)
        {

            actualizaLista(true,true,true);
            actualizaHistorial();
            actComboBoxProveedor();
            prop_dgvProductos();
            cbxProveedor.SelectedIndex = -1;
           
            dgvHistorial.RowHeadersVisible = false;



        }
        private void prop_dgvProductos() 
        
        {
            lblCanPro.Text = dgvProductos.RowCount.ToString();
            dgvProductos.Columns[4].DefaultCellStyle.Format = new CultureInfo("es-AR").NumberFormat.CurrencySymbol + "#,##0.00";
            dgvProductos.Columns["Final"].DefaultCellStyle.Format = new CultureInfo("es-AR").NumberFormat.CurrencySymbol + "#,##0.00";
            dgvProductos.RowHeadersVisible = false;
            
        }
        public void actComboBoxProveedor()
        {
            ConexionProveedores conexionProveedores = new ConexionProveedores();
            try
            {
                cbxProveedor.DataSource = conexionProveedores.listarProveedores();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
                frmAgregarProducto agregarProducto = new frmAgregarProducto();
                Thread.Sleep(100);
                agregarProducto.ShowDialog();
                
                if (txtbuscar.Text =="") 
                {
                    actualizaLista(true, true, true);
                    dgvProductos.CurrentRow.Selected = false;
                    actComboBoxProveedor();
                    cbxProveedor.SelectedIndex = -1;
                }
                else
                {

                    actualizaLista();
                    string texto = txtbuscar.Text;

                    txtbuscar.Text = "";

                    txtbuscar.Text = texto;
                    txtbuscar.Focus();
                }
                
                
            }
            catch (NullReferenceException)
            {


            }


        }
        public void actualizaLista(bool activo=true ,bool orden = true, bool ascOdsc = true)
        {
            var listadeProductos = conexionProductodb.listarProductosActivos(activo, orden,ascOdsc);

            dgvProductos.DataSource = listadeProductos;

            listaProductosActivos.Clear();
            listaProductosActivos = listadeProductos;

            prop_dgvProductos();
        }
        public void actualizaHistorial()
        {
            var listaHistorial = historialPrecios.listarhistorialDesendiente();

            dgvHistorial.DataSource = listaHistorial;

            dgvHistorial.Columns[0].Visible = false;

            paso = true;

        }
        public void cargarListaFiltrada()
        {
            var productoSeleccionado = (TProductos)dgvProductos.CurrentRow.DataBoundItem;
            lblPrecioFinal.Text = productoSeleccionado.Final.ToString("C2", CultureInfo.CreateSpecificCulture("ES-ar"));
            int idProductoSelec = productoSeleccionado.idProductos;
            List<THistorialPrecio> listaHistorioal = historialPrecios.listarhistorialDesendiente();
            List<THistorialPrecio> listaFiltrada = listaHistorioal.FindAll(n => idProductoSelec == n.idProducto);


            ListaFiltradaObtenidda = listaFiltrada;
            paso = true;
        }
        public string doubleAPorcentaje(double funcion)
        {
            if (funcion >= 0)
            {
                return funcion.ToString("C2", CultureInfo.CreateSpecificCulture("ES-ar")).Remove(0, 1).Insert(0, "%");
            }
            else
            {
                return funcion.ToString("C2", CultureInfo.CreateSpecificCulture("ES-ar")).Remove(1, 1).Insert(0, "%");

            }

        }//Funcion que convierte en string con formato %00,00 una funcion que devuelve double

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            //cada vez que seleciono un producto de la tabla producto
            //if (dgvProductos.CurrentRow.Index != 0) //para que al abrir el formulario no intente con los datos aun no cargados
            if (paso != false && dgvProductos.CurrentRow != null)

            {
                cargarListaFiltrada(); //carga la lista a la propiedad de la clase
                dgvHistorial.DataSource = ListaFiltradaObtenidda;
                lblUltimaFechaAct.Text = obtenerUltimafechamod();
                lblDiasPasados.Text = diasPasados().ToString();
                lbIinflacionMen.Text = doubleAPorcentaje(inflacion(30));
                lblVarMen.Text = doubleAPorcentaje(variacionMensualAcumulada());
                
               


                try
                {

                    if (dgvHistorial.RowCount > 1)
                    {



                        List<double> listaCosto = new List<double>();

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
                finally { }
            }
        }
        private List<THistorialPrecio> listaFiltradaporFecha(int DiasPasados) //Funcion que devuelve una nueva lista solo de los objetos con fecha dentro de los dias pasados por parametros
        {

            List<THistorialPrecio> historialFiltroFecha = new List<THistorialPrecio>();
            DateTime ahora = DateTime.Now;
            DateTime tiempo = ahora.Subtract(TimeSpan.FromDays(DiasPasados));
            foreach (var item in ListaFiltradaObtenidda)
            {
                if (item.FechaMod > tiempo)
                {
                    historialFiltroFecha.Add(item);
                }
            }
            return historialFiltroFecha;
        }

        public double inflacion(int diasContados)
        {
            try
            {
                List<THistorialPrecio> historialFiltroFecha = listaFiltradaporFecha(diasContados);
                double resultado = 0.0;

                List<double> datosVariaciones = new List<double>();
                foreach (var item in historialFiltroFecha)
                {
                    datosVariaciones.Add(item.Costo);
                }

                THistorialPrecio valoractual = historialFiltroFecha[0];

                double actualCosto = valoractual.Costo;
                double minCosto = datosVariaciones.Min();
                if (actualCosto == minCosto)
                {
                    datosVariaciones.Remove(minCosto);
                    minCosto = datosVariaciones.Min();

                    resultado = ((actualCosto - minCosto) / minCosto) * 100;
                    return resultado;
                }
                else
                {
                    resultado = ((actualCosto - minCosto) / minCosto) * 100; ;
                    return resultado;
                }
            }
            catch (Exception)
            {

                return 00.00;
            }




        }
        public double variacionMensualAcumulada()
        {
            List<THistorialPrecio> historialFiltroFecha = listaFiltradaporFecha(30);
            int cantidadDeRegistros = historialFiltroFecha.Count;

            List<double> datosVariaciones = new List<double>();
            foreach (var item in historialFiltroFecha)
            {
                datosVariaciones.Add(item.Costo);
            }
            double resultadoCosto = 0;
            for (int i = cantidadDeRegistros - 1; i > 0; i--)
            {


                {
                    resultadoCosto += ((datosVariaciones[i - 1] - datosVariaciones[i]) / datosVariaciones[i]) * 100;
                }



            }
            return resultadoCosto;




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
            try
            {
                var productoSeleccionado = (TProductos)dgvProductos.CurrentRow.DataBoundItem;
                frmAgregarProducto frmAgregarProducto = new frmAgregarProducto(productoSeleccionado);
                frmAgregarProducto.ShowDialog();

                if (txtbuscar.Text == "")
                {
                    dgvProductos.DataSource = null;
                    actualizaLista(true, true, true);
                    dgvProductos.CurrentRow.Selected = false;
                }
                else
                {
                    actualizaLista();
                    string texto = txtbuscar.Text;

                    txtbuscar.Text="";
                   
                    txtbuscar.Text=texto;
                    txtbuscar.Focus();
                }

            }
            catch (NullReferenceException)
            {

                MessageBox.Show("Debe haber un elemento seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void frmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            paso = false;
        }

        private void btnActDes_Click(object sender, EventArgs e)
        {
            frmListaProductos frmListaProductos = new frmListaProductos();
            frmListaProductos.ShowDialog();
            actualizaLista(true, true, true);
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            var productoSeleccionado = (TProductos)dgvProductos.CurrentRow.DataBoundItem;
            conexionProductodb.desOactProducto(productoSeleccionado, false);
            actualizaLista(true, true, true);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int index = cbxProveedor.SelectedIndex;
            var provedor = (TProveedores)cbxProveedor.SelectedItem;

            List<TProductos> listaProductosbuscados;
            
            string filtro = txtbuscar.Text;
            if (filtro.Length > 1)
            {
                dgvProductos.DataSource = null;
                if (index >= 0 && provedor != null)
                {
                    listaProductosbuscados = listaProductosActivos.FindAll(x => (filtro.ToUpper() == x.Descripcion.ToUpper() || x.Descripcion.ToUpper().Contains(filtro.ToUpper())) &&  x.Proveedores.idProveedores == provedor.idProveedores);
                    
                    dgvProductos.DataSource = listaProductosbuscados;
                }
                else
                {
                    listaProductosbuscados = listaProductosActivos.FindAll(x => filtro.ToUpper() == x.Descripcion.ToUpper() || x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                    dgvProductos.DataSource = listaProductosbuscados;
                }

                

            }
            else
            {
                dgvProductos.DataSource = null;
                actualizaLista(true, true, true);

            }
            prop_dgvProductos();
        }

        private void cbxProveedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int index = cbxProveedor.SelectedIndex;
            var provedor = (TProveedores)cbxProveedor.SelectedItem;

            List<TProductos> listaProductosbuscados;
            string filtro = txtbuscar.Text;

            dgvProductos.DataSource = null;
            if (index >= 0)
            {
                listaProductosbuscados = listaProductosActivos.FindAll(x => (filtro.ToUpper() == x.Descripcion.ToUpper() || x.Descripcion.ToUpper().Contains(filtro.ToUpper())) && x.Proveedores.idProveedores == provedor.idProveedores);
                dgvProductos.DataSource = listaProductosbuscados;
            }
            else
            {
                listaProductosbuscados = listaProductosActivos.FindAll(x => filtro.ToUpper() == x.Descripcion.ToUpper() || x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                dgvProductos.DataSource = listaProductosbuscados;
            }
            prop_dgvProductos();
        }

        private void frmProductos_Resize(object sender, EventArgs e)
        {
            //1044; 653
            int altura = this.Height;
            int anchura = this.Width;

            if (anchura < 1000) 
            {
            dgvHistorial.Visible = false;
            }else dgvHistorial.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grafica grafica = new grafica(ListaFiltradaObtenidda);
            grafica.Show();
            grafica.TopMost = true;
        }

        private void dgvProductos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridView dataGridView = dgvProductos; // Referencia al DataGridView;
            List <TProductos> productosVisualizados = new List<TProductos>();

            if (dataGridView.DataSource != null)
            {
                // Convertir la fuente de datos a una lista de objetos Producto
                List<TProductos> productosOriginales = (List<TProductos>)dataGridView.DataSource;

                // Recorrer la lista de objetos Producto y agregarlos a la nueva lista
                foreach (TProductos producto in productosOriginales)
                {
                    if (dataGridView.Rows[producto.IndiceFila].Visible) // Filtrar por filas visibles
                    {
                        productosVisualizados.Add(producto);
                    }
                }
            }

            // La lista 'productosVisualizados' contiene los datos que se muestran en el DataGridView


            List<TProductos> listactual = new List<TProductos>();
            listactual = productosVisualizados;
            IEnumerable<TProductos> listaordenada =null;
            switch (e.ColumnIndex)
            {
                case 0: //ordenar por id
                    if (paso2)
                    {
                        listaordenada = listactual.OrderBy(x => x.idProductos);
                        paso2 = false;
                    }
                    else
                    {
                        listaordenada = listactual.OrderByDescending(x => x.idProductos);
                        paso2 = true;
                    }
                    break;
                case 1: //ordenar por descripcion

                    if (paso2)
                    {
                        listaordenada = listactual.OrderBy(x => x.Descripcion);
                        paso2 = false;
                    }
                    else
                    {
                        listaordenada = listactual.OrderByDescending(x => x.Descripcion);
                        paso2 = true;
                    }
                    break;
                case 2:
                    listaordenada=listactual.OrderBy(x => x.Rubro.ToString());
                    break;
                case 3:
                    listaordenada=listactual.OrderBy(x => x.Proveedores.ToString());
                    break;
                case 10: //Ordenar por fecha
                    if (paso2)
                    { 
                        listaordenada = listactual.OrderBy(x =>
                        {
                            DateTime fechaModificacion;
                            if (DateTime.TryParseExact(x.FechaModificacion, "dd/MM/yy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaModificacion))
                            {
                                return fechaModificacion;
                            }
                            else
                            {
                                // Manejar el caso de error si la cadena de fecha no tiene el formato esperado
                                return DateTime.MinValue;
                            }
                        });
                        paso2 = false;
                    }
                    else
                    {
                        listaordenada = listactual.OrderByDescending(x =>
                        {
                            DateTime fechaModificacion;
                            if (DateTime.TryParseExact(x.FechaModificacion, "dd/MM/yy", CultureInfo.InvariantCulture,DateTimeStyles.None, out fechaModificacion))
                            {
                                return fechaModificacion;
                            }
                            else
                            {
                                // Manejar el caso de error si la cadena de fecha no tiene el formato esperado
                                return DateTime.MinValue;
                            }
                        });

                        paso2 = true;
                    }
                    break;

                default: return;
            }
            List<TProductos> listafinal = new List<TProductos>();
            foreach (TProductos producto in listaordenada)
            {
                listafinal.Add(producto);
            }
            dgvProductos.DataSource = listafinal;
         
            
              
        }//Click en los encabezado de columna para ordenar

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }

}
