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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void btnlistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Tbl_Urunler
                                        select new
                                        {
                                            x.UrunId,
                                            x.UrunAd,
                                            x.Marka,
                                            x.Stok,
                                            x.Fiyat,
                                            x.Tbl_Kategori.Ad,
                                            x.Durum
                                        }).ToList();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Tbl_Urunler urunler = new Tbl_Urunler();
            urunler.UrunAd = txturunad.Text;
            urunler.Stok = short.Parse(txtstok.Text);
            urunler.Marka = txtmarka.Text;
            urunler.Kategori = int.Parse(comboBox1.SelectedValue.ToString());
            urunler.Fiyat = decimal.Parse(txtfiyat.Text);
            urunler.Durum = true;
            db.Tbl_Urunler.Add(urunler);
            db.SaveChanges();
            MessageBox.Show("Ürün eklenmiştir");

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            var urun = db.Tbl_Urunler.Find(id);
            db.Tbl_Urunler.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün silinmiştir");

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            var urunguncelle = db.Tbl_Urunler.Find(id);
            urunguncelle.UrunAd = txturunad.Text;
            urunguncelle.Stok = short.Parse(txtstok.Text);
            urunguncelle.Marka = txtmarka.Text;
            urunguncelle.Kategori = int.Parse(comboBox1.SelectedValue.ToString());
            urunguncelle.Durum = bool.Parse(txtdurum.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün güncellenmiştir");

        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.Tbl_Kategori
                               select new
                               {
                                   x.Id, x.Ad
                               }
                               ).ToList();
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Ad";
            comboBox1.DataSource = kategoriler;
        }

       

    }
}
