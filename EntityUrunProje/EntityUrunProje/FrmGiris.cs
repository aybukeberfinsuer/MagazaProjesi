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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnkategori_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show(); 
            
        }

        private void btnurun_Click(object sender, EventArgs e)
        {
            FrmUrun frmurun = new FrmUrun();
            frmurun.Show();
        }

        private void btnistatislik_Click(object sender, EventArgs e)
        {
            Frmistatiktik frmistatiktik = new Frmistatiktik();
            frmistatiktik.Show();
        }
    }
}
