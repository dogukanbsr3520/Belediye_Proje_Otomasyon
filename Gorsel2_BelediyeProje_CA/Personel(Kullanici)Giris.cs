using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VTI;

namespace Gorsel2_BelediyeProje_CA
{
    public partial class personelGiris : Form
    {
        public personelGiris()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (tx_kullaniciAd.Text == "" || tx_sifre.Text == "")
            {
                MessageBox.Show("İlgili Alanlar Boş Bırakılamaz ! ", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable dtSonuc = vt.Select("select * from tbl_personel where ad = '" + tx_kullaniciAd.Text + "' and sifre = '" + vt.MD5Sifrele(tx_sifre.Text) + "'");
            if (dtSonuc.Rows.Count == 0)
            {
                MessageBox.Show("Kullanıcı ad veya Şifreniz Hatalı !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }  
            this.Hide();
            AnaSayfa afrm = new AnaSayfa();

            //--------------------------------------------------------------------
            //ANASAYFA YETKİ VERME KISMI;

            int personel_id = Convert.ToInt32(dtSonuc.Rows[0]["personel_id"]);
            if (personel_id != 1)//belediye başkanı hariç personel
            {
                afrm.tsbtn_BBirimTurSayfa.Visible = false;
                afrm.tsbtn_BHizmetSayfa.Visible = false;
                afrm.tsbtn_personelTurSayfa.Visible = false;
            }

            afrm.Show();
            return;
        }

        private void btn_kayitCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tx_kullaniciAd_Enter(object sender, EventArgs e)
        {
            if (tx_kullaniciAd.Text == "kullanıcı Ad giriniz...")
            {
                tx_kullaniciAd.Text = "";
                tx_kullaniciAd.ForeColor = Color.Black;

            }

        }

        private void tx_kullaniciAd_Leave(object sender, EventArgs e)
        {
            if (tx_kullaniciAd.Text == "")
            {
                tx_kullaniciAd.Text = "kullanıcı Ad giriniz...";
                tx_kullaniciAd.ForeColor = Color.Gray;

            }

        }

        private void tx_sifre_Enter(object sender, EventArgs e)
        {
            if (tx_sifre.Text == "Şifre giriniz...")
            {
                tx_sifre.Text = "";
                tx_sifre.ForeColor = Color.Black;
                tx_sifre.PasswordChar = '*';
            }

        }

        private void tx_sifre_Leave(object sender, EventArgs e)
        {
            if (tx_sifre.Text == "")
            {
                tx_sifre.Text = "Şifre giriniz...";
                tx_sifre.ForeColor = Color.Gray;
                tx_sifre.PasswordChar = '\0';
            }
        }

        private void personelGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
