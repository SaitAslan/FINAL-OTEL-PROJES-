using Otelyeniden.Entityy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otelyeniden.Formlar.WebSite
{
    public partial class FrmYeniKayit : Form
    {
        public FrmYeniKayit()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities2 db = new DbOtelYeniEntities2();
        private void FrmYeniKayit_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblYeniKayit
                                       select new
                                       {
                                           x.AdSoyad,
                                           x.Mail,
       
                                           x.Telefon,
                                           
                                       }).ToList();
        }
    }
}
