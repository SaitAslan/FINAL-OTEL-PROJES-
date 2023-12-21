using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Otelyeniden.Entityy;
using Otelyeniden.Formlar.Urun;

namespace Otelyeniden.Formlar.Rezervasyon
{
    public partial class FrmTumRezervasyonlar : Form
    {
        public FrmTumRezervasyonlar()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities2 db = new DbOtelYeniEntities2();
        private void FrmTumRezervasyonlar_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblRezervasyon
                                       select new
                                       {
                                           x.RezervasyonId,
                                           x.TblMisafir.AdSoyad,
                                           x.GirisTarih,
                                           x.CikisTarih,
                                           x.Kisi,
                                           x.TblOda.OdaNo,
                                           x.Telefon,
                                           x.TblDurum.DurumAd
                                       }).ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmRezervasyonKarti fr = new FrmRezervasyonKarti();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("RezervasyonId").ToString());
            fr.Show();
        }
    }
}
