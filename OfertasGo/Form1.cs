using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using ConexionesExternas;
using Dominio;
using Negocio;

namespace OfertasGo
{
    public partial class Form1 : Form
    {
        private string fechalarga;
        private string hora;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VerificarActualizacion();
            btnCargardb.Enabled = false;

            tsslFecha.Spring = tssHora.Spring = true;
            tsslFecha.TextAlign = tssHora.TextAlign = ContentAlignment.TopRight;

            tslVersion.Text = "Vers. " + ProductVersion;
            tslVersion.Alignment = ToolStripItemAlignment.Right;

            ActualizarFecha();
            ActualizarHora();
            ActualizarDolar();

            timer1.Tick += Timer1_Tick;
            timer1.Start();

            timer2.Tick += Timer2_Tick;
            timer2.Start();
        }

        private void VerificarActualizacion()
        {
            // Código comentado de actualización.
        }

        private void ActualizarHora()
        {
            hora = DateTime.Now.ToShortTimeString();
            tssHora.Text = hora;
        }

        private void ActualizarFecha()
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            fechalarga = DateTime.Now.ToLongDateString();
            tsslFecha.Text = ti.ToTitleCase(fechalarga);
        }

        private void ActualizarDolar()
        {
            try
            {
                apiDolar dolar = new apiDolar();
                string texto = dolar.Moneda + " Blue " + dolar.Venta;
                string textoFinal = texto.Replace("casa", "").Remove(0, 9).Replace('"', ' ');
                tsslBarra.Text = textoFinal.ToUpper();
            }
            catch
            {
                tsslBarra.Text = "Error al obtener cotización";
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            ActualizarHora();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ActualizarFecha();

            if (DateTime.Now.Minute == 30)
            {
                ActualizarDolar();
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

        public void btnBackupDB_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog browserDialog = new FolderBrowserDialog())
                {
                    browserDialog.ShowNewFolderButton = true;

                    if (browserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string destino = browserDialog.SelectedPath;
                        File.WriteAllText("./rutabackup.txt", destino);

                        string fecha = DateTime.Now.ToString("dd-MM-yy (HH mm)");
                        string origenDB = ConfigurationManager.AppSettings["RutaDBdirectorio"];
                        string[] archivos = Directory.GetFiles(origenDB);

                        if (archivos.Length > 0)
                        {
                            string origen = archivos[0];
                            string destinoFinal = Path.Combine(destino, "BackUpDbOfertas " + fecha + ".db");
                            File.Copy(origen, destinoFinal);
                            MessageBox.Show("Backup creado con éxito en " + destino, "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró base de datos para respaldar.");
                        }
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Ya existe la base de datos. Intente en un minuto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            ConexionProveedores conexion = new ConexionProveedores();
            List<TProveedores> lista = conexion.listarProveedores(false);

            if (lista.Count > 0)
            {
                frmAgregarProveedor frm = new frmAgregarProveedor(lista[0]);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay proveedores cargados.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirm = MessageBox.Show(
                    "¿Está seguro?\n¡Al cargar otra base de datos se borrarán los datos actuales!\n¿Desea continuar?",
                    "CUIDADO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (confirm == DialogResult.OK)
                {
                    using (OpenFileDialog ofd = new OpenFileDialog())
                    {
                        ofd.Title = "Seleccione la Base de Datos";
                        ofd.Filter = "DATABASE|*.db";

                        string rutaDB = ConfigurationManager.AppSettings["RutaDB"];
                        string directorio = ConfigurationManager.AppSettings["RutaDBDirectorio"];

                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            if (Directory.Exists(directorio))
                            {
                                foreach (string archivo in Directory.EnumerateFiles(directorio))
                                {
                                    File.Delete(archivo);
                                }
                            }
                            else
                            {
                                Directory.CreateDirectory(directorio);
                            }

                            File.Copy(ofd.FileName, rutaDB, true);
                            MessageBox.Show("Carga exitosa");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
            this.Opacity = 0.2;
            frmEjecutarSentenciaSql frm = new frmEjecutarSentenciaSql();
            frm.ShowDialog();
            this.Opacity = 1.0;
        }

        private void btnListaProductos_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            ListaProductos listaProductos = new ListaProductos();
            listaProductos.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }

        private void rubrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TRubro rubro = new TRubro();
            frmAgregarRubro agregarRubro = new frmAgregarRubro(rubro);
            agregarRubro.ShowDialog();
        }
    }
}
