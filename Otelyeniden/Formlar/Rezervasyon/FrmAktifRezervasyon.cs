
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
    public partial class FrmAktifRezervasyon : Form
    {
        public FrmAktifRezervasyon()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities2 db = new DbOtelYeniEntities2();
        private void FrmAktifRezervasyon_Load(object sender, EventArgs e)
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
                                       }).Where(y=>y.DurumAd=="Aktif").ToList();
        }
    }
}
