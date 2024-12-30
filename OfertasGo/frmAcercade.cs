using System;
using System.Drawing;
using System.Windows.Forms;

namespace OfertasGo
{
    public partial class frmAcercade : Form
    {
        public frmAcercade()
        {
            InitializeComponent();
        }

        private void frmAcercade_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap("./acercade.png");

            this.Height = bmp.Height;
            this.Width = bmp.Width;
            this.BackgroundImage = bmp;


            lblVersion.Text = ProductVersion.ToString();


        }

        private void frmAcercade_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
