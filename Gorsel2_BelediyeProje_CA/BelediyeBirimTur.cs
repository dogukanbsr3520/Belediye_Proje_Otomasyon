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
    public partial class BelediyeBirimTur : Form
    {
        public BelediyeBirimTur()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void BelediyeBirimTur_Load(object sender, EventArgs e)
        {
            dgv_BbirimKayitlar.DataSource = vt.Select(@"select bt.birimTur_id,bt.birimNo,bt.birimAd,h.hizmetAd,bba.mahalle,bba.sokak,bba.il,bba.ilce
                                                    from tbl_birimTur bt
                                                    join tbl_hizmetler h on bt.hizmet_id = h.hizmet_id
                                                    join tbl_belediyeBirimAdres bba on bt.belediyeBirimAdres_id = bba.belediyeBirimAdres_id");

            dgv_BbirimKayitlar.Columns[0].Visible = false;
           

            cbx_BhizmetlerGoster.DisplayMember = "hizmetAd";
            cbx_BhizmetlerGoster.ValueMember = "hizmet_id";
            cbx_BhizmetlerGoster.DataSource = vt.Select("select hizmet_id,hizmetNo,hizmetAd from tbl_hizmetler");

            cbx_BbirimGoster.DisplayMember = "birimAd";
            cbx_BbirimGoster.ValueMember = "birimTur_id";
            cbx_BbirimGoster.DataSource = vt.Select("select birimTur_id,birimNo,birimAd,hizmet_id,belediyeBirimAdres_id from tbl_birimTur");


        }

        private void btn_BbirimEkle_Click(object sender, EventArgs e)
        {
            if (tx_BbirimNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Birim No Girdi Alanı Boş Bırakılmamalıdır!... ", "!Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (tx_BbirimAd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Birim Ad Girdi Alanı Boş Bırakılmamalıdır!... ", "!Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cbx_BhizmetlerGoster.SelectedIndex == -1)
            {
                MessageBox.Show("Hizmet Modeli Seçiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cbx_BbirimGoster.SelectedIndex == -1)
            {
                MessageBox.Show("Birim adresi Seçiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            int kayitSay = vt.UpdateDelete("insert into tbl_birimTur(birimNo,birimAd,hizmet_id,belediyeBirimAdres_id)values('" + tx_BbirimNo.Text + "', '" + tx_BbirimAd.Text + "', '" + cbx_BhizmetlerGoster.SelectedValue + "', '" + cbx_BbirimGoster.SelectedValue + "')");

            if (kayitSay > 0) 
            {
                BelediyeBirimTur_Load(null, null);
                MessageBox.Show("Belediye Birim Ekleme İşleminiz Başarıyla Gerçekleşti...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_BbirimGuncelle_Click(object sender, EventArgs e)
        {
            if (tx_BbirimNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Birim No Girdi Alanı Boş Bırakılmamalıdır!... ", "!Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (tx_BbirimAd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Birim Ad Girdi Alanı Boş Bırakılmamalıdır!... ", "!Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cbx_BhizmetlerGoster.SelectedIndex == -1)
            {
                MessageBox.Show("Hizmet Modeli Seçiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cbx_BbirimGoster.SelectedIndex == -1)
            {
                MessageBox.Show("Birim adresi Seçiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (dgv_BbirimKayitlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncelleme işlemini gerçekleştirebilmek için bir satır seçmelisiniz ! ", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgv_BbirimKayitlar.SelectedRows.Count > 1)
            {
                MessageBox.Show("Güncelleme işleminde sadece 1 satır seçili olmalıdır ! ", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_birimTur
                                            set birimNo='" + tx_BbirimNo.Text + @"',
                                            birimAd='" + tx_BbirimAd.Text + @"',
                                            hizmet_id='" + cbx_BhizmetlerGoster.SelectedValue + @"',
                                            belediyeBirimAdres_id='" + cbx_BbirimGoster.SelectedValue + @"'
                                            where birimTur_id=" + dgv_BbirimKayitlar.SelectedRows[0].Cells["birimTur_id"].Value);

            if (kayitSay > 0) 
            {
                BelediyeBirimTur_Load(null, null);
                MessageBox.Show("Belediye Birim Tür Kayıd Güncelleme Başarıyla Gerçekleşti...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_BbirimSil_Click(object sender, EventArgs e)
        {
            if (dgv_BbirimKayitlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek Satırı Seçiniz!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_birimTur where birimTur_id =" + dgv_BbirimKayitlar.SelectedRows[0].Cells["birimTur_id"].Value);

            if (kayitSay > 0) 
            {
                BelediyeBirimTur_Load(null, null);
                MessageBox.Show("Seçili Belediye Birim Kaydı Başarıyla Silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgv_BbirimKayitlar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_BbirimKayitlar.SelectedRows.Count == 0) 
            {
                return;
            }
            tx_BbirimNo.Text = dgv_BbirimKayitlar.SelectedRows[0].Cells["birimNo"].Value.ToString();
            tx_BbirimAd.Text = dgv_BbirimKayitlar.SelectedRows[0].Cells["birimAd"].Value.ToString();

        }

        private void BelediyeBirimTur_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa afrm = (AnaSayfa)this.MdiParent;
            afrm.tsbtn_BBirimTurSayfa.Enabled = true;

        }

        private void sayfaKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
