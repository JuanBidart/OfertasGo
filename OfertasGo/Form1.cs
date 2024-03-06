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

namespace OfertasGo
{
    public partial class Form1 : Form
    {
        int ancho = -400;
        int alto;
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



            recorrer();

        }
        public void recorrer()
        {
            
            apiDolar dolar = new apiDolar();
            string texto = dolar.Moneda + " Blue " + dolar.Venta + "   " + dolar.Compra;
            string Text1 = texto.Replace("casa", "").Remove(0, 9);
            string Txt2 = Text1.Replace('"', ' ');
            lblDolar.Text = Txt2.ToUpper();

            alto = this.Height;

            lblDolar.Location = new Point(ancho, alto - 70);
            timer1.Stop();
            timer1.Dispose();
            timer1.Interval = 100;
            timer1.Start();
            timer1.Tick += Timer1_Tick;
           

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            
            if (DateTime.Now.Minute == 01 && DateTime.Now.Second < 1)
            {
                apiDolar dolar = new apiDolar();
                string texto = dolar.Moneda + " Blue " + dolar.Venta + "   " + dolar.Compra;
                string Text1 = texto.Replace("casa", "").Remove(0, 9);
                string Txt2 = Text1.Replace('"', ' ');
                lblDolar.Text = Txt2.ToUpper();
            }

            ancho += 1;
            lblDolar.Location = new Point(ancho, alto - 70);
            if (ancho == 850)
            {
                ancho = -400;
            }
            


        }

        private void Form1_Activated(object sender, EventArgs e)
        { 

            

        }
    }
}
