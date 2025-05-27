using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ConexionesExternas;
using Dominio;
using Negocio;

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

        private void actualizacion()
        {
            try
            {
                //if (ConfigurationManager.AppSettings["Actualizacion"] == "true")
                //{
                //    MessageBox.Show("su sistema se va a actualizar", "ACTUALIZACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                //    string sentencia = "ALTER TABLE Productos RENAME COLUMN Recargo$ TO AjustePesos;";
                //    AccesoDatos accesoDatos = new AccesoDatos();
                //    accesoDatos.seterarConsulta(sentencia);
                //    accesoDatos.ejecutarAccion();
                //    accesoDatos.cerrarConexion();
                //    ConfigurationManager.AppSettings["Actualizacion"] = "false";
                //    MessageBox.Show("su sistema esta actualizado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                //}

            }
            catch (Exception )
            {

                throw;
            }
           

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            frmProductos productos = new frmProductos();
            productos.ShowDialog();
            this.WindowState = FormWindowState.Normal;
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
             actualizacion();       // Verifica e instala una actualizacion
            btnCargardb.Enabled = false;

            tsslFecha.Spring = true;
            tsslFecha.TextAlign = ContentAlignment.TopRight;


            tssHora.Spring = true;
            tssHora.TextAlign = ContentAlignment.TopRight;

            tslVersion.Text = "Vers." + ProductVersion.ToString();
            tslVersion.Alignment = ToolStripItemAlignment.Right;


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
            string texto = dolar.Moneda + " Blue " + dolar.Venta + "   ";//+ dolar.Compra;
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
                string texto = dolar.Moneda + " Blue " + dolar.Venta; //+ "   " + dolar.Compra;
                string Text1 = texto.Replace("casa", "").Remove(0, 9);
                string Txt2 = Text1.Replace('"', ' ');
                tsslBarra.Text = Txt2.ToUpper();
            }



        }

        public void btnBackupDB_Click(object sender, EventArgs e)
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
                MessageBox.Show("Ya exite la base de datos intente en un minuto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            ConexionProveedores conexionProveedores = new ConexionProveedores();
            List<TProveedores> listapr = new List<TProveedores>();
            listapr = conexionProveedores.listarProveedores(false);
            TProveedores proveedores = listapr[0];
            frmAgregarProveedor frmAgregarProveedor = new frmAgregarProveedor(proveedores);
            frmAgregarProveedor.ShowDialog();

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
                    }
                    ofd.Dispose();
                }
            }

            catch (ArgumentException)
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex.Message.ToString());
            }

        }

        private void cargarDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void backupDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBackupDB_Click(sender, e);
        }



        private void sentenciaDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 20;

            frmEjecutarSentenciaSql frmEjecutarSentenciaSql = new frmEjecutarSentenciaSql();
            frmEjecutarSentenciaSql.ShowDialog();
            this.Opacity = 100;
        }

        private void btnListaProductos_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            ListaProductos listaProductos = new ListaProductos();
            listaProductos.ShowDialog();
        }

        private void rubrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TRubro rubro = new TRubro();
            
            frmAgregarRubro agregarRubro = new frmAgregarRubro(rubro);


        }
    }
}
