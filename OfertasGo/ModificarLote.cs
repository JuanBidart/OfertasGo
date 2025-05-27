using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;
using Negocio;
using FuncionesComunes;

namespace OfertasGo
{
    public partial class ModificarLote : Form
    {

        private List<TProductos> listadeProductosSeleccionados;
        public ModificarLote()
        {
            InitializeComponent();
        }
        public ModificarLote(List<TProductos> listadeSelecionados)
        {
            InitializeComponent();
            listadeProductosSeleccionados = listadeSelecionados;
        }
        private void ActualizarLista()
        {

            dgvSelecionados.DataSource = listadeProductosSeleccionados;

        }
        private void Lista_Load(object sender, EventArgs e)
        {
            var seleccion = listadeProductosSeleccionados;
            dgvSelecionados.DataSource = seleccion;
        }
                

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ConexionProductodb productodb = new ConexionProductodb();

            try
            {
                if (!(txtCostoModificar.Text == string.Empty))
                {
                    double numeroIngresado = double.Parse(txtCostoModificar.Text);
                    foreach (var item in listadeProductosSeleccionados)
                    {
                        if (robPorcentaje.Checked)
                        {
                            double finalactual = item.Final;
                            double costoactual = item.Costo;
                            double porcentajeActual = item.RecargoPorcentaje;

                            double costoConRecargo;

                            double finalNuevo;

                            costoConRecargo = ((costoactual * numeroIngresado) / 100) + costoactual;
                            finalNuevo = ((costoConRecargo * porcentajeActual) / 100) + costoConRecargo;

                            item.FechaModificacion = item.FechaModificacion = DateTime.Now.Date.ToString("dd/MM/yy");
                            item.Costo = costoConRecargo;
                            item.Final = finalNuevo;
                        }
                        if (robPeso.Checked)
                        {
                            double finalactual = item.Final;
                            double costoactual = item.Costo;
                            double porcentajeActual = item.RecargoPorcentaje;

                            double costoConRecargo;

                            double finalNuevo;

                            costoConRecargo = (costoactual + numeroIngresado);
                            finalNuevo = ((costoConRecargo * porcentajeActual) / 100) + costoConRecargo;

                            item.FechaModificacion = item.FechaModificacion = DateTime.Now.Date.ToString("dd/MM/yy");
                            item.Costo = costoConRecargo;
                            item.Final = finalNuevo;
                        }
                        if (!(robPeso.Checked) && !(robPorcentaje.Checked))
                        {
                            MessageBox.Show("Selecione unna opcion de cambio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            return;
                        }
                        productodb.modificarProducto(item);


                    }
                    ActualizarLista();

                    MessageBox.Show("Tarea realizada con exito", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (!(txtCambiarRecargo.Text == string.Empty))
                {
                    //Funcion de la clase estatica "Funciones comunes" modifica el producto pasando el recargo a aplicar

                    FuncionesComunes.Operaciones.ModificarDataProducto_Recargo(txtCambiarRecargo,listadeProductosSeleccionados);
                
                ActualizarLista();

                MessageBox.Show("Tarea realizada con exito", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                }
                else
                {
                    MessageBox.Show("Ingrese un dato en las cajas de texto", "Dato vacio",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }               
            }               
            catch (Exception)
            {

                throw;
            }
        }       
    }
}
