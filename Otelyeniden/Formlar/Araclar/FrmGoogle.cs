using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otelyeniden.Formlar.Araclar
{
    public partial class FrmGoogle : Form
    {
        public FrmGoogle()
        {
            InitializeComponent();
        }

        private void FrmGoogle_Load(object sender, EventArgs e)
        {
            webBrowser2.Navigate("http://www.google.com");
        }
    }
}
