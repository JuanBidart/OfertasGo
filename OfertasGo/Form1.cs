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
using Dominio;
using ConexionesExternas;
using System.Reflection.Emit;
using System.Globalization;

namespace OfertasGo
{
    public partial class Form1 : Form
    {

        string fechalarga;
        string Hora;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnProductos_Click(object sender, EventArgs e)
        {
                frmProductos productos = new frmProductos();
                productos.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tslAcercade_Click(object sender, EventArgs e)
        {
            frmAcercade acercade = new frmAcercade();
            acercade.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tsslFecha.Spring = true;
            tsslFecha.TextAlign = ContentAlignment.TopRight;
      

            tssHora.Spring = true;
            tssHora.TextAlign = ContentAlignment.TopRight;
          

            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

            fechalarga = DateTime.Now.ToLongDateString();
            tsslFecha.Text = ti.ToTitleCase(fechalarga);
            recorrer();
            tssHora.Text = Hora;
            timer2.Start();
            timer2.Tick += Timer2_Tick;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            Hora = DateTime.Now.ToShortTimeString();
            tssHora.Text = Hora;

        }

        public void recorrer()
        {
            
            apiDolar dolar = new apiDolar();
            string texto = dolar.Moneda + " Blue " + dolar.Venta + "   " + dolar.Compra;
            string Text1 = texto.Replace("casa", "").Remove(0, 9);
            string Txt2 = Text1.Replace('"', ' ');
            tsslBarra.Text = Txt2.ToUpper();

           

            
            timer1.Stop();
            timer1.Dispose();
            timer1.Start();
            timer1.Tick += Timer1_Tick;
           

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            fechalarga = DateTime.Now.ToLongDateString();
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            tsslFecha.Text = ti.ToTitleCase(fechalarga);


            if (DateTime.Now.Minute == 30 )
            {
                apiDolar dolar = new apiDolar();
                string texto = dolar.Moneda + " Blue " + dolar.Venta + "   " + dolar.Compra;
                string Text1 = texto.Replace("casa", "").Remove(0, 9);
                string Txt2 = Text1.Replace('"', ' ');
                tsslBarra.Text = Txt2.ToUpper();
            }
                               


        }

        
        
    }
}
