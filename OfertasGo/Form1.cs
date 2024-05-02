using ConexionesExternas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

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


            if (DateTime.Now.Minute == 30)
            {
                apiDolar dolar = new apiDolar();
                string texto = dolar.Moneda + " Blue " + dolar.Venta + "   " + dolar.Compra;
                string Text1 = texto.Replace("casa", "").Remove(0, 9);
                string Txt2 = Text1.Replace('"', ' ');
                tsslBarra.Text = Txt2.ToUpper();
            }



        }

        private void btnBackupDB_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog browserDialog = new FolderBrowserDialog();
                browserDialog.ShowNewFolderButton = true;
                //browserDialog.ShowDialog();

                if (browserDialog.ShowDialog() == DialogResult.OK)
                {

                    string direccion = browserDialog.SelectedPath;
                    StreamWriter sw = new StreamWriter("./rutabackup.txt");
                    sw.Write(direccion);
                    sw.Close();

                    StreamReader sr = new StreamReader("./rutabackup.txt");
                    string direccionleida = sr.ReadToEnd();
                    sr.Close();

                    string fecha = DateTime.Now.ToString("dd-MM-yy (HH mm)");
                    string direccionDatabase = "./Database";

                    string copiaarchivo = "./Backup\\database" + fecha + ".db";


                    string[] database = Directory.GetFiles(direccionDatabase);


                    File.Copy(database[0], direccionleida + "\\database" + fecha + ".db");


                    MessageBox.Show("Backup creado con Exito en " + direccionleida, "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                // else if (browserDialog.ShowDialog() == DialogResult.Cancel)
                {

                }


            }
            catch (IOException) 
            {
                MessageBox.Show("Ya exite la base de datos intente en un minuto","Error",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("¿Esta seguro? \n !Al cargar otra base de datos borra todos los datos actuales! \n ¿Dese Continuar?", "CUIDADO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Title = "Seleccione la Base de Datos";
                    ofd.Filter = "DATABASE|*.db";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        if (Directory.Exists("./Database"))
                        {
                            List<string> archivos = new List<string>();
                            foreach (var item in Directory.EnumerateFiles("./Database"))
                            {
                                archivos.Add(item.Trim());
                                
                            }
                            foreach (var archivo in archivos)
                            {
                                File.Delete(archivo);
                            }
                            
                        }
                        else
                        {
                            Directory.CreateDirectory("./Database");
                        }

                        string databaseNueva = Path.GetFullPath(ofd.FileName);

                        File.Copy(databaseNueva, ".\\Database\\dbofertas.db");

                        MessageBox.Show("Carga exitosa");
                    }ofd.Dispose();
                }
            }

            catch (ArgumentException) 
            { 
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error"+ex.Message.ToString());
            }
           
        }

       }
}
