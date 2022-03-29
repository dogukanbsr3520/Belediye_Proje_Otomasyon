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
    public partial class BelediyePersonelTur : Form
    {
        public BelediyePersonelTur()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void BelediyePersonelTur_Load(object sender, EventArgs e)
        {
            dgv_personelTurKayit.DataSource = vt.Select("select personelTur_id,personelNo,turAd from tbl_personelTur");

            dgv_personelTurKayit.Columns[0].Visible = false;
        }

        private void btn_BpersonelTurEkle_Click(object sender, EventArgs e)
        {
            if (tx_personelTurNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Personel Tür No alanı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_personelTurAd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Personel Tür Ad alanı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"insert into tbl_personelTur(personelNo,turAd)
                                                values('"+tx_personelTurNo.Text+"','"+tx_personelTurAd.Text+"')");

            if (kayitSay > 0) 
            {
                BelediyePersonelTur_Load(null, null);
                MessageBox.Show("Belediye Personel Tür Kaydı Başarıyla Oluşturuldu...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_BpersonelTurGuncelle_Click(object sender, EventArgs e)
        {

            if (dgv_personelTurKayit.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncelleme işlemini gerçekleştirebilmek için bir satır seçmelisiniz ! ", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgv_personelTurKayit.SelectedRows.Count > 1)
            {
                MessageBox.Show("Güncelleme işleminde sadece 1 satır seçili olmalıdır ! ", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_personelTur
                                            set personelNo='" + tx_personelTurNo.Text + @"',
                                            turAd='" + tx_personelTurAd.Text + @"'
                                            where personelTur_id=" + dgv_personelTurKayit.SelectedRows[0].Cells["personelTur_id"].Value);

            if (kayitSay > 0) 
            {
                BelediyePersonelTur_Load(null, null);
                MessageBox.Show("Belediye Personel Tür Kaydı Başarıyla Güncellendi...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_BpersonelTurSil_Click(object sender, EventArgs e)
        {
            if (dgv_personelTurKayit.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek Satırı Seçiniz!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_personelTur where personelTur_id =" + dgv_personelTurKayit.SelectedRows[0].Cells["personelTur_id"].Value);

            if (kayitSay > 0) 
            {
                BelediyePersonelTur_Load(null, null);
                MessageBox.Show("Belediye Personel Tür Kaydı Başarıyla Silindi...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgv_personelTurKayit_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_personelTurKayit.SelectedRows.Count == 0) 
            {
                return;
            }
            tx_personelTurNo.Text = dgv_personelTurKayit.SelectedRows[0].Cells["personelNo"].Value.ToString();
            tx_personelTurAd.Text = dgv_personelTurKayit.SelectedRows[0].Cells["turAd"].Value.ToString();

        }

        private void BelediyePersonelTur_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa afrm = (AnaSayfa)this.MdiParent;
            afrm.tsbtn_personelTurSayfa.Enabled = true;
        }

        private void sayfaKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
