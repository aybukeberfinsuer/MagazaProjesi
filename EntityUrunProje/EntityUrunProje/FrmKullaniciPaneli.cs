using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace EntityUrunProje
{
    public partial class FrmKullaniciPaneli : Form
    {
        public FrmKullaniciPaneli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbEntityUrunEntities db = new DbEntityUrunEntities();
            var sorgu = from x in db.Tbl_Kullanici where x.AdminKullanici == textBox1.Text && x.AdminSifre == textBox2.Text select x;
            if (sorgu.Any())
            {
                FrmGiris frmgiris = new FrmGiris();
                frmgiris.Show();
                this.Hide();
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Lütfen bilgilerinizi kontrol edip tekrar giriniz", " Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        
        }

        
    }
}
