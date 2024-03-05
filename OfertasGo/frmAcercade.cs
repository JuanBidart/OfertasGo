using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
            
            
        }

        private void frmAcercade_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
