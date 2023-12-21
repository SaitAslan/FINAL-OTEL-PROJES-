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

namespace Otelyeniden.Formlar.Misafir
{
    public partial class FrmMisafirKarti : Form
    {
        public FrmMisafirKarti()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities2 db = new DbOtelYeniEntities2();
        Repository<TblMisafir> repo = new Repository<TblMisafir>();
        TblMisafir t = new TblMisafir();
        public int id;
        string resim1, resim2;
        private void FrmMisafirKarti_Load(object sender, EventArgs e)
        {
            try
            {
                if (id != 0)
                {
                    var misafir = repo.Find(x => x.MisafirId == id);
                    TxtAdSoyad.Text = misafir.AdSoyad;
                    TxtTc.Text = misafir.Tc;
                    TxtAdres.Text = misafir.Adres;
                    TxtTelefon.Text = misafir.Telefon;
                    TxtMail.Text = misafir.Mail;
                    TxtAciklama.Text = misafir.Aciklama;
                    lookUpEditSehir.EditValue = misafir.sehir;
                    lookUpEditUlke.EditValue = misafir.Ülke;
                    lookUpEditIlce.EditValue = misafir.ilce;
                    PictureEditKimlikOn.Image = Image.FromFile(misafir.KimlikFoto1);
                    PictureEditKimlikArka.Image = Image.FromFile(misafir.KimlikFoto2);
                    resim1 = misafir.KimlikFoto1;
                    resim2 = misafir.KimlikFoto2;
                }

            }
            catch (Exception)
            {

                XtraMessageBox.Show("Bir Hata Oluştu Lütfen sütünları kontrol edin","Hata",MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            //Güncellenecek kart bilgileri

            //Ülke Listesi

            lookUpEditUlke.Properties.DataSource = (from x in db.TblUlke
                                                    select new
                                                    {
                                                        x.UlkeId,
                                                        x.UlkeAd
                                                    }).ToList();
            //Şehir Listesi
            lookUpEditSehir.Properties.DataSource = (from x in db.iller
                                                     select new
                                                     {
                                                         Id = x.id,
                                                         Şehir = x.sehir
                                                     }).ToList();


        }

        private void lookUpEditSehir_EditValueChanged(object sender, EventArgs e)
        {
            int secilen;
            secilen = int.Parse(lookUpEditSehir.EditValue.ToString());
            lookUpEditIlce.Properties.DataSource = (from x in db.ilceler
                                                    select new
                                                    {
                                                        Id = x.id,
                                                        İlçe = x.ilce,
                                                        Şehir = x.sehir

                                                    }).Where(y => y.Şehir == secilen).ToList();
        }


        private void PictureEditKimlikOn_EditValueChanged(object sender, EventArgs e)
        {
            resim1=PictureEditKimlikOn.GetLoadedImageLocation().ToString();
        }

        private void PictureEditKimlikArka_EditValueChanged(object sender, EventArgs e)
        {
            resim2=PictureEditKimlikArka.GetLoadedImageLocation().ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            var deger = repo.Find(x => x.MisafirId == id);
            deger.AdSoyad = TxtAdSoyad.Text;
            deger.Tc = TxtTc.Text;
            deger.Mail = TxtMail.Text;
            deger.Telefon = TxtTelefon.Text;
            deger.Adres = TxtAdres.Text;
            deger.Aciklama = TxtAciklama.Text;
            deger.KimlikFoto1 = resim1;
            deger.KimlikFoto2 = resim2;
            deger.Ülke = int.Parse(lookUpEditUlke.EditValue.ToString());
            deger.sehir = int.Parse(lookUpEditSehir.EditValue.ToString());
            deger.ilce = int.Parse(lookUpEditIlce.EditValue.ToString());
            deger.Durum = 1;
            repo.TUpdate(deger);
            XtraMessageBox.Show("Misafir kartı bilgileri başarı ile güncellendi", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (PictureEditKimlikArka.Image !=null && PictureEditKimlikOn.Image !=null) 
            {
                t.AdSoyad = TxtAdSoyad.Text;
                t.Tc = TxtTc.Text;
                t.Telefon = TxtTelefon.Text;
                t.Mail = TxtMail.Text;
                t.Adres = TxtAdres.Text;
                t.Aciklama = TxtAciklama.Text;
                t.Durum = 1;
                t.sehir = int.Parse(lookUpEditSehir.EditValue.ToString());
                t.ilce = int.Parse(lookUpEditIlce.EditValue.ToString());
                t.Ülke = int.Parse(lookUpEditUlke.EditValue.ToString());
                t.KimlikFoto1 = resim1;
                t.KimlikFoto2 = resim2;
                repo.TAdd(t);
                XtraMessageBox.Show("Misafir sisteme başarılı bir şekilde kaydedildi", "Bilgi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lütfen Bilgileri Eksiksiz Doldurunuz.", "Bilgi", MessageBoxButtons.OK,
                   MessageBoxIcon.Stop);
            }
            
            
        }
    }
}
