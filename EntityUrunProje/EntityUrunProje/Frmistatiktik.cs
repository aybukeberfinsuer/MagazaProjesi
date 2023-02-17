using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityUrunProje
{
    public partial class Frmistatiktik : Form
    {
        public Frmistatiktik()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();


        private void Frmistatiktik_Load(object sender, EventArgs e)
        {
            lblkategori.Text = db.Tbl_Kategori.Count().ToString();
            lbluruntoplam.Text = db.Tbl_Urunler.Count().ToString();

            lblaktif.Text = db.Tbl_Musteriler.Count(x => x.Durum == true).ToString();
            lblpasif.Text = db.Tbl_Musteriler.Count(x => x.Durum == false).ToString();

            lbltoplam.Text = db.Tbl_Urunler.Sum(x => x.Stok).ToString();
            lblkasa.Text = db.Tbl_Satis.Sum(z => z.Fiyat).ToString()+" TL";

            lblmax.Text = db.Tbl_Urunler.Max(x => x.Fiyat).ToString() + " TL";
            lblmax2.Text=(from x in db.Tbl_Urunler orderby x.Fiyat descending select x.UrunAd).FirstOrDefault();
            lblmintutar.Text = db.Tbl_Urunler.Min(x => x.Fiyat).ToString() + " TL";
            lblmin.Text = (from x in db.Tbl_Urunler orderby x.Fiyat ascending select x.UrunAd).FirstOrDefault();

            lblbeyazesya.Text = db.Tbl_Urunler.Count(x => x.Kategori == 1).ToString() ;
            lblbuzdolabi.Text = db.Tbl_Urunler.Count(x => x.UrunAd == "Buzdolabı").ToString();
            lblsehir.Text = (from x in db.Tbl_Musteriler select x.Sehir).Distinct().Count().ToString();

            lblmaxurunlumarka.Text = db.MarkaGetir().FirstOrDefault();
        }
    }
}
