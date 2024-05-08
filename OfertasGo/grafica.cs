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
using System.Windows.Forms.DataVisualization.Charting;

namespace OfertasGo
{
    public partial class grafica : Form
    {
        private List<THistorialPrecio> thistorialPrecioList;
        public grafica()
        {
            InitializeComponent();
        }
        public grafica(List<THistorialPrecio> listaHistorial) 
        {
            thistorialPrecioList = listaHistorial;
        }
        ConexionHistorialPrecios historialPrecios = new ConexionHistorialPrecios(); 
        private void grafica_Load(object sender, EventArgs e)
        {

            
            
           
           
            



        }
    }
}
