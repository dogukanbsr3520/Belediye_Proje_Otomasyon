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
    public partial class BelediyePersonelAdres : Form
    {
        public BelediyePersonelAdres()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void BelediyePersonelAdres_Load(object sender, EventArgs e)
        {
            dgv_BpersonelAdresKayitlar.DataSource = vt.Select("select personelAdres_id,mahalle,sokak,il,ilce from tbl_personelAdres");

            dgv_BpersonelAdresKayitlar.Columns[0].Visible = false;
        }

        private void btn_BpersonelAdresEkle_Click(object sender, EventArgs e)
        {
            if (tx_personelMahalle.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mahalle alanı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_personelSokak.Text.Trim().Length == 0)
            {
                MessageBox.Show("Sokak alanı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_personeLil.Text.Trim().Length == 0)
            {
                MessageBox.Show("İl alanı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_personelilce.Text.Trim().Length == 0)
            {
                MessageBox.Show("İlce alanı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"insert into tbl_personelAdres(mahalle,sokak,il,ilce)
                                            values('" + tx_personelMahalle.Text + "','" + tx_personelSokak.Text + "','" + tx_personeLil.Text + "','" + tx_personelilce.Text + "')");

            if (kayitSay > 0) 
            {
                BelediyePersonelAdres_Load(null, null);
                MessageBox.Show("Belediye Personel Adres Kaydı Başarıyla Oluşturuldu...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_BpersonelAdresGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_BpersonelAdresKayitlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncelleme işlemini gerçekleştirebilmek için bir satır seçmelisiniz ! ", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgv_BpersonelAdresKayitlar.SelectedRows.Count > 1)
            {
                MessageBox.Show("Güncelleme işleminde sadece 1 satır seçili olmalıdır ! ", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_personelAdres
                                            set mahalle='" + tx_personelMahalle.Text + @"',
                                            sokak='" + tx_personelSokak.Text + @"',
                                            il='" + tx_personeLil.Text + @"',
                                            ilce='" + tx_personelilce.Text + @"'
                                            where personelAdres_id=" + dgv_BpersonelAdresKayitlar.SelectedRows[0].Cells["personelAdres_id"].Value);

            if (kayitSay > 0) 
            {
                BelediyePersonelAdres_Load(null, null);
                MessageBox.Show("Belediye Personel Adres Kaydı Başarıyla Güncellendi...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_BpersonelAdresSil_Click(object sender, EventArgs e)
        {
            if (dgv_BpersonelAdresKayitlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek Satırı Seçiniz!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_personelAdres where personelAdres_id =" + dgv_BpersonelAdresKayitlar.SelectedRows[0].Cells["personelAdres_id"].Value);

            if (kayitSay > 0) 
            {
                BelediyePersonelAdres_Load(null, null);
                MessageBox.Show("Belediye Personal Adres Kaydı Başarıyla Silindi...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgv_BpersonelAdresKayitlar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_BpersonelAdresKayitlar.SelectedRows.Count == 0) 
            {
                return;
            }
            tx_personelMahalle.Text = dgv_BpersonelAdresKayitlar.SelectedRows[0].Cells["mahalle"].Value.ToString();
            tx_personelSokak.Text = dgv_BpersonelAdresKayitlar.SelectedRows[0].Cells["sokak"].Value.ToString();
            tx_personeLil.Text = dgv_BpersonelAdresKayitlar.SelectedRows[0].Cells["il"].Value.ToString();
            tx_personelilce.Text = dgv_BpersonelAdresKayitlar.SelectedRows[0].Cells["ilce"].Value.ToString();

        }

        private void BelediyePersonelAdres_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa afrm = (AnaSayfa)this.MdiParent;
            afrm.tsbtn_personelAdresSayfa.Enabled = true;
        }

        private void sayfaKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
