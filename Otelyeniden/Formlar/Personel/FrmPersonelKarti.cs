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

namespace Otelyeniden.Formlar.Personel
{
    public partial class FrmPersonelKarti : Form
    {
        public FrmPersonelKarti()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities2 db=new DbOtelYeniEntities2();

       public int id;
        Repository<TblPersonel> repo = new Repository<TblPersonel>();
        private void FrmPersonelKarti_Load(object sender, EventArgs e)
        {
            //this.Text = id.ToString();

            if (id != 0)
            {
                var personel = repo.Find(x => x.PersonelId == id);
                TxtAdSoyad.Text = personel.AdSoyad;
                TxtTc.Text= personel.Tc;
                TxtAdres.Text = personel.Adres;
                TxtTelefon.Text = personel.Telefon;
                TxtMail.Text = personel.Mail;
                dateEditGiris.Text = personel.IseGirisTarihi.ToString();
                dateEditCikis.Text = personel.IstenCıkısTarihi.ToString();
                TxtAciklama.Text = personel.Acıklama;
                TxtSifre.Text = personel.Sifre;
                PictureEditKimlikOn.Image = Image.FromFile(personel.KimlikOn);
                PictureEditKimlikArka.Image = Image.FromFile(personel.KimlikArka);
                labelControl15.Text = personel.KimlikOn;
                labelControl16.Text = personel.KimlikArka;
                lookUpEditDepartman.EditValue = personel.Departman;
                lookUpEditGorev.EditValue = personel.Gorev;

            }
            lookUpEditDepartman.Properties.DataSource = (from x in db.TblDepartman
                                                         select new
                                                         {
                                                             x.DepartmanId,
                                                             x.DepartmanAd
                                                         }).ToList();
            lookUpEditGorev.Properties.DataSource = (from x in db.TblGorev
                                                         select new
                                                         {
                                                             x.GorevId,
                                                             x.GorevAd
                                                         }).ToList();

        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            
            TblPersonel t= new TblPersonel();
            t.AdSoyad = TxtAdSoyad.Text;
            t.Tc= TxtTc.Text;
            t.Adres = TxtAdres.Text;
            t.Telefon= TxtTelefon.Text;
            t.IseGirisTarihi=DateTime.Parse(dateEditGiris.Text);
            t.Departman=int.Parse(lookUpEditDepartman.EditValue.ToString());
            t.Gorev=int.Parse(lookUpEditGorev.EditValue.ToString());
            t.Acıklama=TxtAciklama.Text;
            t.Mail=TxtMail.Text;
            t.KimlikOn = PictureEditKimlikOn.GetLoadedImageLocation();
            t.KimlikArka = PictureEditKimlikArka.GetLoadedImageLocation();
            t.Sifre=TxtSifre.Text;
            t.Durum = 1;
            repo.TAdd(t);
            XtraMessageBox.Show("Personel başarılı bir şekilde sisteme kayıt edildi");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            var deger = repo.Find(x=> x.PersonelId == id);
            deger.AdSoyad = TxtAdSoyad.Text;
            deger.Tc = TxtTc.Text;
            deger.Adres = TxtAdres.Text;
            deger.Telefon = TxtTelefon.Text;
            deger.IseGirisTarihi = DateTime.Parse(dateEditGiris.Text);
            deger.Departman = int.Parse(lookUpEditDepartman.EditValue.ToString());
            deger.Gorev = int.Parse(lookUpEditGorev.EditValue.ToString());
            deger.Acıklama = TxtAciklama.Text;
            deger.Mail = TxtMail.Text;
            deger.Sifre = TxtSifre.Text;
            deger.KimlikOn = labelControl15.Text;
            deger.KimlikArka = labelControl16.Text;
            repo.TUpdate(deger);
            XtraMessageBox.Show("Personel kartı bilgileri başarı ile güncellendi", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            
        }

        private void labelControl13_Click(object sender, EventArgs e)
        {

        }

        private void PictureEditKimlikOn_EditValueChanged(object sender, EventArgs e)
        {
            labelControl15.Text= PictureEditKimlikOn.GetLoadedImageLocation().ToString();   
        }

        private void PictureEditKimlikArka_EditValueChanged(object sender, EventArgs e)
        {
            labelControl16.Text = PictureEditKimlikArka.GetLoadedImageLocation().ToString();
        }
    }
}
