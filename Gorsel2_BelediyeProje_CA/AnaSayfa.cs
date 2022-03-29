using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorsel2_BelediyeProje_CA
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tsbtn_personelSayfa_Click(object sender, EventArgs e)
        {
            if (tsbtn_personelSayfa.Enabled == false)
                return;
            BelediyePersonelKayit bpfrm = new BelediyePersonelKayit();
            bpfrm.MdiParent = this;
            tsbtn_personelSayfa.Enabled = false;
            bpfrm.Show();
        }

        private void tsbtn_personelTurSayfa_Click(object sender, EventArgs e)
        {
            if (tsbtn_personelTurSayfa.Enabled == false)
                return;
            BelediyePersonelTur bptfrm = new BelediyePersonelTur();
            bptfrm.MdiParent = this;
            tsbtn_personelTurSayfa.Enabled = false;
            bptfrm.Show();
        }

        private void tsbtn_BBirimTurSayfa_Click(object sender, EventArgs e)
        {
            if (tsbtn_BBirimTurSayfa.Enabled == false)
                return;
            BelediyeBirimTur btfrm = new BelediyeBirimTur();
            btfrm.MdiParent = this;
            tsbtn_BBirimTurSayfa.Enabled = false;
            btfrm.Show();
        }

        private void tsbtn_BHizmetSayfa_Click(object sender, EventArgs e)
        {
            if (tsbtn_BHizmetSayfa.Enabled == false)
                return;
            BelediyeHizmetler bhfrm = new BelediyeHizmetler();
            bhfrm.MdiParent = this;
            tsbtn_BHizmetSayfa.Enabled = false;
            bhfrm.Show();
        }

        private void tsbtn_personelAdresSayfa_Click(object sender, EventArgs e)
        {
            if (tsbtn_personelAdresSayfa.Enabled == false)
                return;
            BelediyePersonelAdres bpafrm = new BelediyePersonelAdres();
            bpafrm.MdiParent = this;
            tsbtn_personelAdresSayfa.Enabled = false;
            bpafrm.Show();
        }

        private void tsbtn_BBirimAdresSayfa_Click(object sender, EventArgs e)
        {
            if (tsbtn_BBirimAdresSayfa.Enabled == false)
                return;
            BelediyeBirimAdres bbafrm = new BelediyeBirimAdres();
            bbafrm.MdiParent = this;
            tsbtn_BBirimAdresSayfa.Enabled = false;
            bbafrm.Show();
        }

        private void tsbtn_BiletisimSayfa_Click(object sender, EventArgs e)
        {
            if (tsbtn_BiletisimSayfa.Enabled == false)
                return;
            Belediyeiletisim bifrm = new Belediyeiletisim();
            bifrm.MdiParent = this;
            tsbtn_BiletisimSayfa.Enabled = false;
            bifrm.Show();
        }

        private void notifyIconBelediye_DoubleClick(object sender, EventArgs e)
        {
            if (this.Visible == false)
                this.Show();
            else
                this.Hide();
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtn_SistemKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerSure_saatTarih_Tick(object sender, EventArgs e)
        {
            lbl_saatB.Text = DateTime.Now.ToLongTimeString();
            timerSure_saatTarih.Start();

            toolStripMenu.Text = DateTime.Now.ToLongTimeString();
            timerSure_saatTarih.Start();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            timerSure_saatTarih.Start();
            lbl_saatB.Text = DateTime.Now.ToLongTimeString();
            lbl_tarihB.Text = DateTime.Now.ToShortDateString();

            toolStripMenu.Text = DateTime.Now.ToLongTimeString();

        }

     
    }
}
