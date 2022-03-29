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
    public partial class Belediyeiletisim : Form
    {
        public Belediyeiletisim()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void Belediyeiletisim_Load(object sender, EventArgs e)
        {
            dgv_BelediyeiletisimKayitlar.DataSource = vt.Select("select iletisim_id,email,telefon from tbl_belediyeiletisim");
            dgv_BelediyeiletisimKayitlar.Columns[0].Visible = false;
        }

        private void btn_BiletisimEkle_Click(object sender, EventArgs e)
        {
            if (tx_BiletisimEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("E-mail alanı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_BiletisimTelefon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Telefon alanı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete("insert into tbl_belediyeiletisim(email,telefon)values('" + tx_BiletisimEmail.Text + "', '" + tx_BiletisimTelefon.Text + "')");

            if (kayitSay > 0) 
            {
                Belediyeiletisim_Load(null, null);
                MessageBox.Show("Belediye İletişim Kaydı Başarıyla Eklendi...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_BiletisimGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_BelediyeiletisimKayitlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncelleme işlemini gerçekleştirebilmek için bir satır seçmelisiniz ! ", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgv_BelediyeiletisimKayitlar.SelectedRows.Count > 1)
            {
                MessageBox.Show("Güncelleme işleminde sadece 1 satır seçili olmalıdır ! ", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_belediyeiletisim
                                        set email='" + tx_BiletisimEmail.Text + @"',
                                        telefon='" + tx_BiletisimTelefon.Text + @"'
                                        where iletisim_id=" + dgv_BelediyeiletisimKayitlar.SelectedRows[0].Cells["iletisim_id"].Value);

            if (kayitSay > 0) 
            {
                Belediyeiletisim_Load(null, null);
                MessageBox.Show("Seçili Belediye İletişim Kaydı Başarıyla Güncellendi...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_BiletisimSil_Click(object sender, EventArgs e)
        {
            if (dgv_BelediyeiletisimKayitlar.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Silinecek Satırı Seçiniz!", "!!HATA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_belediyeiletisim where iletisim_id =" + dgv_BelediyeiletisimKayitlar.SelectedRows[0].Cells["iletisim_id"].Value);
            if (kayitSay > 0) 
            {
                Belediyeiletisim_Load(null, null);
                MessageBox.Show("Seçili Belediye İletişim Kaydı Başarıyla Silindi...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgv_BelediyeiletisimKayitlar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_BelediyeiletisimKayitlar.SelectedRows.Count == 0) 
            {
                return;
            }
            tx_BiletisimEmail.Text = dgv_BelediyeiletisimKayitlar.SelectedRows[0].Cells["email"].Value.ToString();
            tx_BiletisimTelefon.Text = dgv_BelediyeiletisimKayitlar.SelectedRows[0].Cells["telefon"].Value.ToString();
        }

        private void Belediyeiletisim_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa afrm = (AnaSayfa)this.MdiParent;
            afrm.tsbtn_BiletisimSayfa.Enabled = true;
        }

        private void sayfaKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
