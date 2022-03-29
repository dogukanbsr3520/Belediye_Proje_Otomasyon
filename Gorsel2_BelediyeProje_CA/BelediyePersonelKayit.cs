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
    public partial class BelediyePersonelKayit : Form
    {
        public BelediyePersonelKayit()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void btn_personelFotoEkle_Click(object sender, EventArgs e)
        {
            pbx_personelFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            ofd_personelFotoYukle.ShowDialog();
            pbx_personelFoto.ImageLocation = ofd_personelFotoYukle.FileName;
        }

        private void BelediyePersonelKayit_Load(object sender, EventArgs e)
        {
            dgv_BpersonelKayit.DataSource = vt.Select(@"select p.personel_id,p.ad,p.soyad,p.kimlikNo,p.email,p.telefon,p.sifre,pa.mahalle,pa.sokak,pa.il,pa.ilce,bt.birimNo,bt.birimAd,pt.personelNo,pt.turAd,bi.email,bi.telefon 
                                                        from tbl_personel p
                                                        join tbl_personelAdres pa on p.personelAdres_id=pa.personelAdres_id
                                                        join tbl_birimTur bt on p.birimTur_id=bt.birimTur_id
                                                        join tbl_personelTur pt on p.personelTur_id=pt.personelTur_id
                                                        join tbl_belediyeiletisim bi on p.iletisim_id=bi.iletisim_id
                                                        where personel_id=p.personel_id");

            dgv_BpersonelKayit.Columns[0].Visible = false;

            cbx_PersonelAdresSec.DisplayMember = "mahalle";
            cbx_PersonelAdresSec.ValueMember = "personelAdres_id";
            cbx_PersonelAdresSec.DataSource = vt.Select("select personelAdres_id,mahalle,sokak,il,ilce from tbl_personelAdres");

            cbx_PersonelBirimTurSec.DisplayMember = "birimAd";
            cbx_PersonelBirimTurSec.ValueMember = "birimTur_id";
            cbx_PersonelBirimTurSec.DataSource = vt.Select("select birimTur_id,birimNo,birimAd,hizmet_id,belediyeBirimAdres_id from tbl_birimTur");

            cbx_PersonelTurSec.DisplayMember = "turAd";
            cbx_PersonelTurSec.ValueMember = "personelTur_id";
            cbx_PersonelTurSec.DataSource = vt.Select("select personelTur_id,personelNo,turAd from tbl_personelTur");

            cbx_PersoneliletisimSec.DisplayMember = "email";
            cbx_PersoneliletisimSec.ValueMember = "iletisim_id";
            cbx_PersoneliletisimSec.DataSource = vt.Select("select iletisim_id,email,telefon from tbl_belediyeiletisim");
        }

        private void btn_BpersonelEkle_Click(object sender, EventArgs e)
        {
            if (tx_PersonelAd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Personel Ad alanı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_PersonelSoyad.Text.Trim().Length == 0)
            {
                MessageBox.Show("Personel Soyad alanı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_PTCKimlik.Text.Trim().Length == 0)
            {
                MessageBox.Show("Personel T.C. Kimlik No alanı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_PersonelEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Personel E-mail alanı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_PersonelTel.Text.Trim().Length == 0)
            {
                MessageBox.Show("Personel Telefon alanı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_PersonelSifre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Personel Şifre alanı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbx_PersonelAdresSec.SelectedIndex == -1)
            {
                MessageBox.Show("Personel Adres Bilgilerini Seçiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbx_PersonelBirimTurSec.SelectedIndex == -1)
            {
                MessageBox.Show("Personel Birim Tür Bilgilerini Seçiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbx_PersonelTurSec.SelectedIndex == -1)
            {
                MessageBox.Show("Personel Tür Bilgilerini Seçiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbx_PersoneliletisimSec.SelectedIndex == -1)
            {
                MessageBox.Show("Personel-Belediye İletişim Bilgilerini Seçiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"insert into tbl_personel(ad,soyad,kimlikNo,email,telefon,sifre,personelAdres_id,birimTur_id,personelTur_id,iletisim_id)
                                            values('" + tx_PersonelAd.Text + "','" + tx_PersonelSoyad.Text + "','" + tx_PTCKimlik.Text + "','" + tx_PersonelEmail.Text + "','" + tx_PersonelTel.Text + "','" + tx_PersonelSifre.Text + "','" + cbx_PersonelAdresSec.SelectedValue + "','" + cbx_PersonelBirimTurSec.SelectedValue + "','" + cbx_PersonelTurSec.SelectedValue + "','" + cbx_PersoneliletisimSec.SelectedValue + "')");

            if (kayitSay > 0) 
            {
                BelediyePersonelKayit_Load(null, null);
                MessageBox.Show("Belediye Personel Profil Kaydı Başarıyla Oluşturuldu...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_BpersonelGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_BpersonelKayit.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncelleme işlemini gerçekleştirebilmek için bir satır seçmelisiniz ! ", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgv_BpersonelKayit.SelectedRows.Count > 1)
            {
                MessageBox.Show("Güncelleme işleminde sadece 1 satır seçili olmalıdır ! ", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_personel
                                            set ad='" + tx_PersonelAd.Text + @"',
                                            soyad='" + tx_PersonelSoyad.Text + @"',
                                            kimlikNo='" + tx_PTCKimlik.Text + @"',
                                            email='" + tx_PersonelEmail.Text + @"',
                                            telefon='" + tx_PersonelTel.Text + @"',
                                            sifre='" + tx_PersonelSifre.Text + @"',
                                            personelAdres_id='" + cbx_PersonelAdresSec.SelectedValue + @"',
                                            birimTur_id='" + cbx_PersonelBirimTurSec.SelectedValue + @"',
                                            personelTur_id='" + cbx_PersonelTurSec.SelectedValue + @"',
                                            iletisim_id='" + cbx_PersoneliletisimSec.SelectedValue + @"'
                                            where personel_id=" + dgv_BpersonelKayit.SelectedRows[0].Cells["personel_id"].Value);

            if (kayitSay > 0) 
            {
                BelediyePersonelKayit_Load(null, null);
                MessageBox.Show("Belediye Personel Kayıt Bilgileri Başarıyla Güncellendi...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_BpersonelSil_Click(object sender, EventArgs e)
        {
            if (dgv_BpersonelKayit.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek Satırı Seçiniz!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_personel where personel_id =" + dgv_BpersonelKayit.SelectedRows[0].Cells["personel_id"].Value);

            if (kayitSay > 0) 
            {
                BelediyePersonelKayit_Load(null, null);
                MessageBox.Show("Belediye Personel Kaydı Başarıyla Silindi...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgv_BpersonelKayit_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_BpersonelKayit.SelectedRows.Count == 0) 
            {
                return;
            }
            tx_PersonelAd.Text = dgv_BpersonelKayit.SelectedRows[0].Cells["ad"].Value.ToString();
            tx_PersonelSoyad.Text = dgv_BpersonelKayit.SelectedRows[0].Cells["soyad"].Value.ToString();
            tx_PTCKimlik.Text = dgv_BpersonelKayit.SelectedRows[0].Cells["kimlikNo"].Value.ToString();
            tx_PersonelEmail.Text = dgv_BpersonelKayit.SelectedRows[0].Cells["email"].Value.ToString();
            tx_PersonelTel.Text = dgv_BpersonelKayit.SelectedRows[0].Cells["telefon"].Value.ToString();
            tx_PersonelSifre.Text = dgv_BpersonelKayit.SelectedRows[0].Cells["sifre"].Value.ToString();

        }

        private void BelediyePersonelKayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa afrm = (AnaSayfa)this.MdiParent;
            afrm.tsbtn_personelSayfa.Enabled = true;
        }

        private void sayfaKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
