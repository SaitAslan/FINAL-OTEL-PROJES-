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

namespace Otelyeniden.Formlar.WebSite
{
    public partial class FrmOnRezervasyonKarti : Form
    {
        public FrmOnRezervasyonKarti()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities2 db = new DbOtelYeniEntities2();
        Repository<TblOnRezervasyon> repo = new Repository<TblOnRezervasyon>();
        public int id;
        private void FrmOnRezervasyonKarti_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                var rezervasyon = repo.Find(x => x.Id == id);
                dateEditGiris.Text = rezervasyon.GirisTarih.ToString();
                dateEditCıkıs.Text = rezervasyon.CikisTarih.ToString();
                dateEditTarih.Text = rezervasyon.Tarih.ToString();
                numericUpDown1.Value = decimal.Parse(rezervasyon.Kisi.ToString());
                TxtTelefon.Text = rezervasyon.Telefon;
                TxtAdSoyad.Text = rezervasyon.AdSoyad;
                TxtMail.Text = rezervasyon.Mail;
                TxtAciklama.Text = rezervasyon.Aciklama;

            }
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
