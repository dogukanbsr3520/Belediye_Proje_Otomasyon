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
    public partial class BelediyeHizmetler : Form
    {
        public BelediyeHizmetler()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void BelediyeHizmetler_Load(object sender, EventArgs e)
        {
            dgv_BhizmetlerKayitlar.DataSource = vt.Select("select hizmet_id,hizmetNo,hizmetAd from tbl_hizmetler");

            dgv_BhizmetlerKayitlar.Columns[0].Visible = false;
        }

        private void btn_BhizmetEkle_Click(object sender, EventArgs e)
        {
           
            if (tx_BhizmetNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Hizmet No alanı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tx_BhizmetAd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Hizmet Ad alanı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete("insert into tbl_hizmetler(hizmetNo,hizmetAd)values('"+tx_BhizmetNo.Text+"', '"+tx_BhizmetAd.Text+"')");

            if (kayitSay > 0) 
            {
                BelediyeHizmetler_Load(null, null);
                MessageBox.Show("Belediye Hizmet Kaydı Başarıyla Eklendi...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_BhizmetGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_BhizmetlerKayitlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncelleme işlemini gerçekleştirebilmek için bir satır seçmelisiniz ! ", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgv_BhizmetlerKayitlar.SelectedRows.Count > 1)
            {
                MessageBox.Show("Güncelleme işleminde sadece 1 satır seçili olmalıdır ! ", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_hizmetler
                                            set hizmetNo='" + tx_BhizmetNo.Text + @"',
                                            hizmetAd='" + tx_BhizmetAd.Text + @"'
                                            where hizmet_id=" + dgv_BhizmetlerKayitlar.SelectedRows[0].Cells["hizmet_id"].Value);

            if (kayitSay > 0) 
            {
                BelediyeHizmetler_Load(null, null);
                MessageBox.Show("Belediye Hizmet Kaydı Başarıyla Güncellendi...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_BhizmetSil_Click(object sender, EventArgs e)
        {
            if (dgv_BhizmetlerKayitlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek Satırı Seçiniz!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_hizmetler where hizmet_id =" + dgv_BhizmetlerKayitlar.SelectedRows[0].Cells["hizmet_id"].Value);
            if (kayitSay > 0) 
            {
                BelediyeHizmetler_Load(null, null);
                MessageBox.Show("Seçili Belediye Hizmet Kaydı Başarıyla Güncellendi...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgv_BhizmetlerKayitlar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_BhizmetlerKayitlar.SelectedRows.Count == 0) 
            {
                return;
            }
            tx_BhizmetNo.Text = dgv_BhizmetlerKayitlar.SelectedRows[0].Cells["hizmetNo"].Value.ToString();
            tx_BhizmetAd.Text = dgv_BhizmetlerKayitlar.SelectedRows[0].Cells["hizmetAd"].Value.ToString();
        }

        private void BelediyeHizmetler_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa afrm = (AnaSayfa)this.MdiParent;
            afrm.tsbtn_BHizmetSayfa.Enabled = true;
        }

        private void sayfaKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
