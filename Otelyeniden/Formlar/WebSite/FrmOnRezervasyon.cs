using Otelyeniden.Entityy;
using Otelyeniden.Formlar.Rezervasyon;
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
    public partial class FrmOnRezervasyon : Form
    {
        public FrmOnRezervasyon()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities2 db =new DbOtelYeniEntities2();

        private void FrmOnRezervasyon_Load(object sender, EventArgs e)
        {

            gridControl1.DataSource=(from x in db.TblOnRezervasyon
                                     select new
                                     {
                                         x.Id,
                                         x.AdSoyad,
                                         x.Mail,
                                         x.Telefon,
                                         x.Tarih
                                     }).ToList();
           //    
                                            
                                       
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmOnRezervasyonKarti fr = new FrmOnRezervasyonKarti();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            fr.Show();
        }
    }
}
