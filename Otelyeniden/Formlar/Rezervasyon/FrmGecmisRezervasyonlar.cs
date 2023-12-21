
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

namespace Otelyeniden.Formlar.Rezervasyon
{
    public partial class FrmGecmisRezervasyonlar : Form
    {
        public FrmGecmisRezervasyonlar()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities2  db=new DbOtelYeniEntities2();
        private void FrmGecmisRezervasyonlar_Load(object sender, EventArgs e)
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
                                       }).Where(y => y.DurumAd == "Çıkış Yapıldı").ToList();
        }
    }
}
