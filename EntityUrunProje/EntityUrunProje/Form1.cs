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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void btnlistele_Click(object sender, EventArgs e)
        {
            var kategoriler = db.Tbl_Kategori.ToList();
            dataGridView1.DataSource = kategoriler;
            //var bütün değişkenleri üstüne alabiliyor genel değişkendir.
            //Bu şekilde listeleme işlemi yapıyoruz fakat Datagride Navigation Properties de ekleniyor. Daha sonra sileceğiz.



        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            //Tablodan nesne üretmiş oluyoruz.
            //İlgili sütuna nesne üretmeden ulaşamıyoruz. Bu sebeple Tablodan nesne üretip ulaşıyoruz.
            Tbl_Kategori kategori_nesne = new Tbl_Kategori();
            kategori_nesne.Ad = txtkatad.Text;
            db.Tbl_Kategori.Add(kategori_nesne);
            db.SaveChanges();
            MessageBox.Show("Kategori eklendi");
            

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtkatid.Text);
            var ktgr = db.Tbl_Kategori.Find(x);
            db.Tbl_Kategori.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Kategori silinmiştir");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtkatid.Text);
            var ktgr = db.Tbl_Kategori.Find(x);
            ktgr.Ad = txtkatad.Text;
            db.SaveChanges();
            MessageBox.Show("Değişiklikler kaydedilmiştir");
        }
    }
}
