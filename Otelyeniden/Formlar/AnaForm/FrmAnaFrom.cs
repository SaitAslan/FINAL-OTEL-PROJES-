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

namespace Otelyeniden.Formlar.AnaForm
{
    public partial class FrmAnaFrom : Form
    {
        public FrmAnaFrom()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities2 db=new DbOtelYeniEntities2();
        private void FrmAnaFrom_Load(object sender, EventArgs e)
        {
            //Misafir Listesi
            gridControl3.DataSource = (from x in db.TblMisafir
                                       select new
                                       {
                                           x.AdSoyad
                                         
                                       }).ToList();

            //Bugün Gelecekler Listesi
            gridControl2.DataSource = (from x in db.TblRezervasyon
                                       select new
                                       {
                                           x.TblMisafir.AdSoyad,
                                           x.Durum

                                       }).Where(y=>y.Durum==1024).ToList();
            gridView2.Columns["Durum"].Visible = false;

            //ürün stok Listesi
            gridControl1.DataSource = (from x in db.TblUrun
                                       select new
                                       {
                                           x.UrunAd,
                                           x.Toplam

                                       }).ToList();
            //Ürün stok grafiği
            var urunler = db.TblUrun.ToList();
            foreach(var x in urunler)
            {
               chartControl1.Series["Urun-Stok"].Points.AddPoint(x.UrunAd,double.Parse(x.Toplam.ToString())); 
            }
            //Oda doluluk Grafiği
            var durumlar = db.OdaDurum();
            foreach(var x in durumlar)
            {
                chartControl2.Series["Durumlar"].Points.AddPoint(x.DurumAd, double.Parse(x.Sayı.ToString()));
            }
        }
    }
}
