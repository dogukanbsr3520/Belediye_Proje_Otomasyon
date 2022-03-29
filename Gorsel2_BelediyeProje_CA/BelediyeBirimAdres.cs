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
    public partial class BelediyeBirimAdres : Form
    {
        public BelediyeBirimAdres()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();//köprü kurulmasını sağlar SQL
        private void BelediyeBirimAdres_Load(object sender, EventArgs e)
        {
            dgv_BadresKayitlar.DataSource = vt.Select("select belediyeBirimAdres_id,mahalle,sokak,il,ilce from tbl_belediyeBirimAdres");
            dgv_BadresKayitlar.Columns[0].Visible = false;
        }

        private void btn_BadresEkle_Click(object sender, EventArgs e)
        {
            if (tx_Bmahallegir.Text.Trim().Length == 0) //textbox'ta ==0 ifadesi varsa boştur yoksa doludur.Trim'de textbox'ın içinde giriş yapıldımı yapılmadımı diye kontrol eder.
            {
                MessageBox.Show("Mahalle Girdi Alanı Boş Bırakılmamalıdır!... ", "!Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (tx_Bsokakgir.Text.Trim().Length == 0)
            {
                MessageBox.Show("Sokak Girdi Alanı Boş Bırakılmamalıdır!... ", "!Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (tx_Bilgir.Text.Trim().Length == 0)
            {
                MessageBox.Show("İl Girdi Alanı Boş Bırakılmamalıdır!... ", "!Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (tx_Bilcegir.Text.Trim().Length == 0)
            {
                MessageBox.Show("İlçe Girdi Alanı Boş Bırakılmamalıdır!... ", "!Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            int kayitSay = vt.UpdateDelete("insert into tbl_belediyeBirimAdres(mahalle,sokak,il,ilce)values('" + tx_Bmahallegir.Text + "', '" + tx_Bsokakgir.Text + "', '" + tx_Bilgir.Text + "', '" + tx_Bilcegir.Text + "')");

            if (kayitSay>0)//+1 true
            {
                BelediyeBirimAdres_Load(null, null);
                MessageBox.Show("Belediye Birim Adres Kaydı Başarıyla Eklendi...","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btn_BadresGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_BadresKayitlar.SelectedRows.Count == 0)//seçili değilse 0'dır seçili ise 1'dir
            {
                MessageBox.Show("Güncelleme işlemini gerçekleştirebilmek için bir satır seçmelisiniz ! ", "!!Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgv_BadresKayitlar.SelectedRows.Count > 1)//0 olmaması lazım > kullanımı şart sağlanmış oldu >1 sadece 1 satır 
            {
                MessageBox.Show("Güncelleme işleminde sadece 1 satır seçili olmalıdır ! ", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_belediyeBirimAdres
                                        set mahalle='" + tx_Bmahallegir.Text + @"',
                                        sokak='" + tx_Bsokakgir.Text + @"',
                                        il='" + tx_Bilgir.Text + @"',
                                        ilce='" + tx_Bilcegir.Text + @"'
                                        where belediyeBirimAdres_id=" + dgv_BadresKayitlar.SelectedRows[0].Cells["belediyeBirimAdres_id"].Value);

            if (kayitSay > 0) 
            {
                BelediyeBirimAdres_Load(null, null);
                MessageBox.Show("Seçili Belediye Birim Adres Kaydı Başarıyla Güncellendi...");
            }

        }

        private void btn_BadresSil_Click(object sender, EventArgs e)
        {
            if (dgv_BadresKayitlar.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Silinecek Satırı Seçiniz!","!!HATA!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_belediyeBirimAdres where belediyeBirimAdres_id=" + dgv_BadresKayitlar.SelectedRows[0].Cells["belediyeBirimAdres_id"].Value);
            if (kayitSay > 0) 
            {
                BelediyeBirimAdres_Load(null, null);
                MessageBox.Show("Seçili Belediye Birim Adres Kaydı Başarıyla Silindi...");
            }

        }

        private void dgv_BadresKayitlar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_BadresKayitlar.SelectedRows.Count == 0) 
            {
                return;
            }
            tx_Bmahallegir.Text = dgv_BadresKayitlar.SelectedRows[0].Cells["mahalle"].Value.ToString();
            tx_Bsokakgir.Text = dgv_BadresKayitlar.SelectedRows[0].Cells["sokak"].Value.ToString();
            tx_Bilgir.Text = dgv_BadresKayitlar.SelectedRows[0].Cells["il"].Value.ToString();
            tx_Bilcegir.Text = dgv_BadresKayitlar.SelectedRows[0].Cells["ilce"].Value.ToString();

        }
        private void belediyeİletişimSayfasınaGeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Belediyeiletisim bifrm = new Belediyeiletisim();
            bifrm.MdiParent = this.MdiParent;
            bifrm.Show();
            return;
        }
        private void BelediyeBirimAdres_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa afrm = (AnaSayfa)this.MdiParent;//işlem uygula
            afrm.tsbtn_BBirimAdresSayfa.Enabled = true;//aktifken pasif hale getir
        }

        private void sayfaKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
