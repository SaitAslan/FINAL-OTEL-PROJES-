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

namespace Otelyeniden.Formlar.Admin
{
    public partial class FrmSifreislemleri : Form
    {
        public FrmSifreislemleri()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities2 db = new DbOtelYeniEntities2();
        public int id;
        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtyeniSifre.Text == TxtyeniSifreTekrar.Text)
            {


                TblAdmin t = new TblAdmin();
                t.Kullanici = TxtKullanici.Text;
                t.Sifre = TxtyeniSifre.Text;
                db.TblAdmin.Add(t);
                db.SaveChanges();
                XtraMessageBox.Show("Yeni kullanıcı başarılı bir şekilde oluşturuldu", "Bilgi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Şifreler uyuşmuyor lütfen tekrar deneyiniz", "Hata", MessageBoxButtons.OK,
                MessageBoxIcon.Stop);
            }
        }




        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (TxtyeniSifre.Text == TxtyeniSifre.Text)
            {
                var deger = repo.Find(x => x.Id == id);
                deger.Kullanici = TxtKullanici.Text;
                deger.Sifre = TxtyeniSifre.Text;
                deger.Rol = TxtRol.Text;
                repo.TUpdate(deger);
                XtraMessageBox.Show("Admin Şifre bilgileri başarı ile güncellendi", "Bilgi", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                XtraMessageBox.Show("Lütfen Şifrelerin eşleştiğinden emin olunuz", "Uyarı", MessageBoxButtons.OK,
                   MessageBoxIcon.Stop);
            }
        }

        private void BtnListe_Click(object sender, EventArgs e)
        {
            FrmAdminListesi fr = new FrmAdminListesi();
            fr.Show();
            this.Hide();
        }

        Repository<TblAdmin> repo = new Repository<TblAdmin>();
        private void FrmSifreislemleri_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                var admin = repo.Find(x => x.Id == id);
                TxtKullanici.Text = admin.Kullanici;
                TxtMevcutSifre.Text = admin.Sifre;
                TxtRol.Text = admin.Rol;
            }
        }
    }
}
