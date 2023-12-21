using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otelyeniden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void BtnDurumTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmDurum fr = new Formlar.Tanımlamalar.FrmDurum();
            fr.Show();
        }

        private void BtnBirimTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmBirim fr = new Formlar.Tanımlamalar.FrmBirim();
            fr.Show();
        }

        private void BtnDepartmanTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmDepartman fr = new Formlar.Tanımlamalar.FrmDepartman();
            fr.Show();
        }

        private void BtnGorevTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmGorev fr = new Formlar.Tanımlamalar.FrmGorev();
            fr.Show();
        }

        private void BtnKasaTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmKasa fr = new Formlar.Tanımlamalar.FrmKasa();
            fr.Show();
        }

        private void BtnKurTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmKur fr = new Formlar.Tanımlamalar.FrmKur();
            fr.Show();
        }

        private void BtnOdaTanımları_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmOda fr = new Formlar.Tanımlamalar.FrmOda();
            fr.Show();
        }

        private void BtnTelefonTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmTelefon fr = new Formlar.Tanımlamalar.FrmTelefon();
            fr.Show();
        }

        private void BtnUlkeTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmUlke fr = new Formlar.Tanımlamalar.FrmUlke();
            fr.Show();
        }

        private void BtnUrunGrup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmUrunGrup fr = new Formlar.Tanımlamalar.FrmUrunGrup();
            fr.Show();
        }

        private void BtnPersonelKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Personel.FrmPersonelKarti fr = new Formlar.Personel.FrmPersonelKarti();
            fr.Show();
        }

        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Personel.FrmPersonelListesi fr = new Formlar.Personel.FrmPersonelListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnMisafirKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Misafir.FrmMisafirKarti fr =new Formlar.Misafir.FrmMisafirKarti();
            fr.Show();
        }

        private void BtnMisafirListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Misafir.FrmMisafirListesi fr = new Formlar.Misafir.FrmMisafirListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Urun.FrmUrunListesi fr = new Formlar.Urun.FrmUrunListesi();
            fr.MdiParent = this;
            fr.Show();
        }

       

        private void BtnUrunKart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Urun.FrmUrunKarti fr = new Formlar.Urun.FrmUrunKarti();
            
            fr.Show();
        }

        private void BtnUrunGiris_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Urun.FrmUrunGirisHareketleri fr = new Formlar.Urun.FrmUrunGirisHareketleri();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnUrunCıkıs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Urun.FrmUrunCıkısHareketleri fr = new Formlar.Urun.FrmUrunCıkısHareketleri();
            fr.MdiParent = this;
            fr.Show();
        }

       

        private void BtnYeniUrunHareketi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Urun.FrmUrunHareketTanimi fr = new Formlar.Urun.FrmUrunHareketTanimi();
            
            fr.Show();
        }

        private void BtnrezervasyonKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Rezervasyon.FrmRezervasyonKarti fr = new Formlar.Rezervasyon.FrmRezervasyonKarti();

            fr.Show();
        }

        private void BtnTumRezervasyonlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Rezervasyon.FrmTumRezervasyonlar fr = new Formlar.Rezervasyon.FrmTumRezervasyonlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnAktifRezervasyonlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Rezervasyon.FrmAktifRezervasyon fr = new Formlar.Rezervasyon.FrmAktifRezervasyon();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnIptalRezervasyon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Rezervasyon.FrmIptalRezervasyon fr = new Formlar.Rezervasyon.FrmIptalRezervasyon();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnGecmisRezervasyon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Rezervasyon.FrmGecmisRezervasyonlar fr = new Formlar.Rezervasyon.FrmGecmisRezervasyonlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnGelecekRezervasyonlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Rezervasyon.FrmGelecelRezervasyon fr = new Formlar.Rezervasyon.FrmGelecelRezervasyon();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void BtnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void BtnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void BtnKurlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Araclar.FrmKurlar fr = new Formlar.Araclar.FrmKurlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Araclar.FrmYoutube fr = new Formlar.Araclar.FrmYoutube();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btngoogle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Araclar.FrmGoogle fr = new Formlar.Araclar.FrmGoogle();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYeniKayitlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.WebSite.FrmYeniKayit fr = new Formlar.WebSite.FrmYeniKayit();
            fr.MdiParent = this;
            fr.Show();
        }

      

        private void BtnOnRezervasyon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.WebSite.FrmOnRezervasyon fr = new Formlar.WebSite.FrmOnRezervasyon();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnAnaForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.AnaForm.FrmAnaFrom fr = new Formlar.AnaForm.FrmAnaFrom();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnGrafik1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Grafikler.FrmGrafik2 fr = new Formlar.Grafikler.FrmGrafik2();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnGrafik2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Grafikler.FrmGrafik1 fr = new Formlar.Grafikler.FrmGrafik1();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnSifre_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Admin.FrmSifreislemleri fr = new Formlar.Admin.FrmSifreislemleri();
            fr.Show();
        }
        public string kullanicirolu;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Thread.Sleep(5000);
            //ribbonPage6.Visible=false;
             this.Text = kullanicirolu;
            if (kullanicirolu != "B")
            {
                ribbonPage6.Visible = false;
            }

            Formlar.AnaForm.FrmAnaFrom fr = new Formlar.AnaForm.FrmAnaFrom();
            fr.MdiParent = this;
            fr.Show();  
        }

        private void BtnYetkiler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Formlar.Admin.FrmSifreislemleri fr = new Formlar.Admin.FrmSifreislemleri();
            fr.Show();
        }

        private void BtnResepsiyonHareket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Kasa.FrmResepsiyonHareket fr = new Formlar.Kasa.FrmResepsiyonHareket();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmKasa fr = new Formlar.Tanımlamalar.FrmKasa();
            
            fr.Show();
        }

        private void BtnKasaCikisKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Kasa.FrmKasaCikisKarti fr = new Formlar.Kasa.FrmKasaCikisKarti();

            fr.Show();
        }

        private void BtnKasaCikisHareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Kasa.FrmKasaCikisHareketListesi fr = new Formlar.Kasa.FrmKasaCikisHareketListesi();
            fr.MdiParent = this;
            fr.Show();
        }
    }
    }

