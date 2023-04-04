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
    public partial class FormKoerper : Form
    {
        public FormKoerper()
        {
            InitializeComponent();
        }

        public FormKoerper(Welcome? caller) : this() { }
    }
}
