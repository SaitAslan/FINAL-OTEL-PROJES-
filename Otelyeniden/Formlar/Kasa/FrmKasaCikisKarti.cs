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

namespace Otelyeniden.Formlar.Kasa
{
    public partial class FrmKasaCikisKarti : Form
    {
        public FrmKasaCikisKarti()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities2 db = new DbOtelYeniEntities2();
        Repository<TblKasaCikisHareketi> repo = new Repository<TblKasaCikisHareketi>();
        TblKasaCikisHareketi t = new TblKasaCikisHareketi();

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            t.Aciklama = TxtAciklama.Text;
            t.Tarih=DateTime.Parse(dateEdit1.Text);
            t.Tutar = decimal.Parse(Txttoplam.Text);
            repo.TAdd(t);
            XtraMessageBox.Show("Çıkış hareketi sisteme kayıt edildi");
        }

        private void FrmKasaCikisKarti_Load(object sender, EventArgs e)
        {

        }
    }
}
