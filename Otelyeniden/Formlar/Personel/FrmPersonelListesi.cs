
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

namespace Otelyeniden.Formlar.Personel
{
    public partial class FrmPersonelListesi : Form
    {
        public FrmPersonelListesi()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities2 db = new DbOtelYeniEntities2();
        private void FrmPersonelListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblPersonel
                            select new
                            {
                                x.PersonelId,
                                x.AdSoyad,
                                x.Tc,
                                x.Telefon,
                                x.Mail,
                                x.TblDepartman.DepartmanAd,
                                x.TblGorev.GorevAd,
                                x.TblDurum.DurumAd

                            }).ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmPersonelKarti fr = new FrmPersonelKarti();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("PersonelId").ToString());
            fr.Show();
        }
    }
}
