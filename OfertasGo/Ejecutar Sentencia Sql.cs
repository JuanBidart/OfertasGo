using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Negocio;

namespace OfertasGo
{
    public partial class frmEjecutarSentenciaSql : Form
    {
        //private ProgressBar progressBar;
        public frmEjecutarSentenciaSql()
        {

            InitializeComponent();

        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea hacer una copia de la base de datos antes de modificar? \n ¡ES MUY RECOMENDABLE QUE LO HAGA!", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.btnBackupDB_Click(this, new EventArgs());
            }

            Cursor = Cursors.WaitCursor;
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Debe escribir o cargar la sentencia a ejecutar", "No puede estar vacio", default, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
                return;
            }
            progressBar1.Step = 25;
            progressBar1.PerformStep();
            lblEstado.Text = "Inicializando...";
            string consulta = textBox1.Text.Trim();
            Thread.Sleep(1000);
            progressBar1.PerformStep();

            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                lblEstado.Text = "Conectando...";
                Thread.Sleep(1000);
                accesoDatos.seterarConsulta(consulta);
                progressBar1.PerformStep();
                lblEstado.Text = "Conexion exitosa...";
                accesoDatos.ejecutarAccion();
                Thread.Sleep(1000);
                progressBar1.PerformStep();
                lblEstado.Text = "Exitoso...";
                MessageBox.Show("Ejecucion realizada con exito", "Exitoso", default, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                lblEstado.Text = "Error";
                MessageBox.Show(ex.Message, "ERROR", default, MessageBoxIcon.Error);

            }
            finally
            {
                accesoDatos.cerrarConexion();
                Cursor = Cursors.Default;

            }
        }

        private void btnBorraryPegar_Click(object sender, EventArgs e)
        {
            lblEstado.Text = string.Empty;
            textBox1.Text = string.Empty;
            progressBar1.Value = 0;
        }

        private void frmEjecutarSentenciaSql_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;

        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.sql)|*.sql";
            dlg.Title = "Buscar archivo";
            dlg.InitialDirectory = Path.GetDirectoryName(DesktopLocation.ToString());

            string archivo = string.Empty;
            if (DialogResult.OK == dlg.ShowDialog())
            {

                archivo = Path.GetFullPath(dlg.FileName);
                StreamReader streamReader = new StreamReader(archivo);
                textBox1.Text = streamReader.ReadLine();
                streamReader.Close();
            }
            else { }

        }


    }
}
