using DevExpress.Data.Mask.Internal;
using DevExpress.XtraEditors;

using Otelyeniden.Entityy;
using Otelyeniden.Repositories;
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
    public partial class FrmRezervasyonKarti : Form
    {
        public FrmRezervasyonKarti()
        {
            InitializeComponent();
        }

        DbOtelYeniEntities2 db = new DbOtelYeniEntities2();
        Repository<TblRezervasyon> repo = new Repository<TblRezervasyon>();
        TblRezervasyon t = new TblRezervasyon();
        public int id;
        private void FrmRezervasyonKarti_Load(object sender, EventArgs e)
        {
            //Misafirp Listesi

            lookUpEditMisafir.Properties.DataSource = (from x in db.TblMisafir
                                                       select new
                                                       {
                                                           x.MisafirId,
                                                           x.AdSoyad
                                                       }).ToList();

            //Misafirp Listesi2
            lookUpEditKisi2.Properties.DataSource = (from x in db.TblMisafir
                                                     select new
                                                     {
                                                         x.MisafirId,
                                                         x.AdSoyad
                                                     }).ToList();
            //Misafirp Listesi3
            lookUpEditKisi3.Properties.DataSource = (from x in db.TblMisafir
                                                     select new
                                                     {
                                                         x.MisafirId,
                                                         x.AdSoyad
                                                     }).ToList();
            //Misafirp Listesi4
            lookUpEditKisi4.Properties.DataSource = (from x in db.TblMisafir
                                                     select new
                                                     {
                                                         x.MisafirId,
                                                         x.AdSoyad
                                                     }).ToList();

            //oda listesi
            lookUpEditOdaa.Properties.DataSource = (from x in db.TblOda
                                                    select new
                                                    {
                                                        x.OdaId,
                                                        x.OdaNo,
                                                        x.TblDurum.DurumAd
                                                    }).Where(y => y.DurumAd == "Aktif").ToList();
            //DUERUM LİSTESİ
            lookUpEditDurum.Properties.DataSource = (from x in db.TblDurum
                                                     select new
                                                     {

                                                         x.DurumId,
                                                         x.DurumAd
                                                     }).ToList();


            //ÜRün güncelleme alanı
            if (id != 0)
            {
                var rezervasyon = repo.Find(x => x.RezervasyonId == id);
                lookUpEditMisafir.EditValue = rezervasyon.Misafir;
                dateEditGiris.Text = rezervasyon.GirisTarih.ToString();
                dateEditCıkıs.Text = rezervasyon.CikisTarih.ToString();
                numericUpDown1.Value = decimal.Parse(rezervasyon.Kisi.ToString());
                lookUpEditOdaa.EditValue = rezervasyon.Oda;
                TxtTelefon.Text = rezervasyon.Telefon;
                TxtAciklama.Text = rezervasyon.Aciklama;
                TxtToplam.Text = rezervasyon.Toplam.ToString();
                lookUpEditDurum.EditValue = rezervasyon.Durum;
                lookUpEditKisi2.EditValue = rezervasyon.Kisi1;
                lookUpEditKisi3.EditValue = rezervasyon.Kisi2;
                lookUpEditKisi4.EditValue = rezervasyon.Kisi3;
                TxtOdaNo.Text = rezervasyon.TblOda.OdaNo;

            }


        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TblRezervasyon t = new TblRezervasyon();

            t.Misafir = int.Parse(lookUpEditMisafir.EditValue.ToString());

            if (numericUpDown1.Value >= 2)
            {
                t.Kisi1 = int.Parse(lookUpEditKisi2.EditValue.ToString());
            }

            if (numericUpDown1.Value >= 3)
            {
                t.Kisi2 = int.Parse(lookUpEditKisi3.EditValue.ToString());
            }

            if (numericUpDown1.Value == 4)
            {
                t.Kisi3 = int.Parse(lookUpEditKisi4.EditValue.ToString());
            }

            t.GirisTarih = DateTime.Parse(dateEditGiris.Text);
            t.CikisTarih = DateTime.Parse(dateEditCıkıs.Text);
            t.Kisi = numericUpDown1.Value.ToString();
            t.Oda = int.Parse(lookUpEditOdaa.EditValue.ToString());
            t.Telefon = TxtTelefon.Text;
            t.Aciklama = TxtAciklama.Text;
            t.Durum = int.Parse(lookUpEditDurum.EditValue.ToString());
            t.Toplam = decimal.Parse(TxtToplam.Text);
            repo.TAdd(t);
            XtraMessageBox.Show("Rezervasyon Başarılı Bir Şekilde Oluşturuldu");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lookUpEditMisafir_EditValueChanged(object sender, EventArgs e)
        {
            int secilen;
            secilen = int.Parse(lookUpEditMisafir.EditValue.ToString());
            var telefon = db.TblMisafir.Where(x => x.MisafirId == secilen).Select(y => y.Telefon).FirstOrDefault();
            TxtTelefon.Text = telefon.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {

            var rezervasyon = repo.Find(x => x.RezervasyonId == id);


            Repository<TblOda> repo2 = new Repository<TblOda>();
            if (lookUpEditDurum.Text == "Çıkış Yapıldı")
            {


                var odadurum = repo2.Find(x => x.OdaId == rezervasyon.Oda);
                odadurum.Durum = 3;
                repo2.TUpdate(odadurum);
                rezervasyon.KasayaAktar = true;
                repo.TUpdate(rezervasyon);

                //Kasaya AKtarma İşlemi
                TblKasaHareketi tkasa = new TblKasaHareketi();
                Repository<TblKasaHareketi> repokasa = new Repository<TblKasaHareketi>();
                tkasa.Misafir = lookUpEditMisafir.Text;
                tkasa.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
                tkasa.Tutar = decimal.Parse(TxtToplam.Text);
                repokasa.TAdd(tkasa);
            }
            rezervasyon.Misafir = int.Parse(lookUpEditMisafir.EditValue.ToString());
            rezervasyon.GirisTarih = DateTime.Parse(dateEditGiris.Text);
            rezervasyon.CikisTarih = DateTime.Parse(dateEditCıkıs.Text);
            rezervasyon.Kisi = numericUpDown1.Value.ToString();
            rezervasyon.Oda = int.Parse(lookUpEditOdaa.EditValue.ToString());
            rezervasyon.Telefon = TxtTelefon.Text;
            rezervasyon.Durum = int.Parse(lookUpEditDurum.EditValue.ToString());
            rezervasyon.Toplam = decimal.Parse(TxtToplam.Text);

            if (numericUpDown1.Value >= 2)
            {
                rezervasyon.Kisi1 = int.Parse(lookUpEditKisi2.EditValue.ToString());
            }

            if (numericUpDown1.Value >= 3)
            {
                rezervasyon.Kisi2 = int.Parse(lookUpEditKisi3.EditValue.ToString());
            }

            if (numericUpDown1.Value == 4)
            {
                rezervasyon.Kisi3 = int.Parse(lookUpEditKisi4.EditValue.ToString());
            }

            rezervasyon.Aciklama = TxtAciklama.Text;

            repo.TUpdate(rezervasyon);
            XtraMessageBox.Show("Rezervasyon başarılı bir şekilde güncellendi");

            //Odanın Durumunu Değiştirelim

        }


    }
}
