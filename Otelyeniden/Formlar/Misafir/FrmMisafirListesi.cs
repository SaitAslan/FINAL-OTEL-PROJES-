
using Otelyeniden.Entityy;
using Otelyeniden.Formlar.Personel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otelyeniden.Formlar.Misafir
{
    public partial class FrmMisafirListesi : Form
    {
        public FrmMisafirListesi()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities2 db = new DbOtelYeniEntities2();
        private void FrmMisafirListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource=(from x in db.TblMisafir
                                     select new
                                     {
                                         x.MisafirId,
                                         x.AdSoyad,
                                         x.Tc,
                                         x.Telefon,
                                         x.Mail,
                                         x.iller.sehir,
                                         x.ilceler.ilce
                                     }).ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmMisafirKarti fr = new FrmMisafirKarti();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("MisafirId").ToString());
            fr.Show();
            
        }
    }
}
