using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NachhilfeGeometrie
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnFiguren_Click(object sender, EventArgs e)
        {
            Form1 Figuren = new Form1(this);
            Figuren.ShowDialog();
        }

        private void btnKoerper_Click(object sender, EventArgs e)
        {
            FormKoerper Figuren = new FormKoerper(this);
        }
    }
}
