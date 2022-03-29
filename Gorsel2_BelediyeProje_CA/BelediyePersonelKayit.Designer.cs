namespace Gorsel2_BelediyeProje_CA
{
    partial class BelediyePersonelKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BelediyePersonelKayit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_PersonelAd = new System.Windows.Forms.TextBox();
            this.tx_PTCKimlik = new System.Windows.Forms.TextBox();
            this.tx_PersonelSoyad = new System.Windows.Forms.TextBox();
            this.tx_PersonelEmail = new System.Windows.Forms.TextBox();
            this.tx_PersonelTel = new System.Windows.Forms.TextBox();
            this.tx_PersonelSifre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_PersonelAdresSec = new System.Windows.Forms.ComboBox();
            this.cbx_PersonelBirimTurSec = new System.Windows.Forms.ComboBox();
            this.cbx_PersoneliletisimSec = new System.Windows.Forms.ComboBox();
            this.cbx_PersonelTurSec = new System.Windows.Forms.ComboBox();
            this.btn_BpersonelSil = new System.Windows.Forms.Button();
            this.btn_BpersonelGuncelle = new System.Windows.Forms.Button();
            this.btn_BpersonelEkle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pbx_personelFoto = new System.Windows.Forms.PictureBox();
            this.btn_personelFotoEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_BpersonelKayit = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.ofd_personelFotoYukle = new System.Windows.Forms.OpenFileDialog();
            this.cms_BelediyePersonelKayit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.belediyePersonelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.belediyePersonelGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.belediyePersonelSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sayfaKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_personelFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BpersonelKayit)).BeginInit();
            this.cms_BelediyePersonelKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Ad Giriniz : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel Soyad Giriniz : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "T.C. Kimlik No Giriniz : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Personel Email Giriniz : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Personel Telefon No Giriniz : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Personel Sistem Şifresi Oluşturunuz : ";
            // 
            // tx_PersonelAd
            // 
            this.tx_PersonelAd.Location = new System.Drawing.Point(565, 198);
            this.tx_PersonelAd.Name = "tx_PersonelAd";
            this.tx_PersonelAd.Size = new System.Drawing.Size(100, 20);
            this.tx_PersonelAd.TabIndex = 6;
            // 
            // tx_PTCKimlik
            // 
            this.tx_PTCKimlik.Location = new System.Drawing.Point(565, 281);
            this.tx_PTCKimlik.Name = "tx_PTCKimlik";
            this.tx_PTCKimlik.Size = new System.Drawing.Size(100, 20);
            this.tx_PTCKimlik.TabIndex = 7;
            // 
            // tx_PersonelSoyad
            // 
            this.tx_PersonelSoyad.Location = new System.Drawing.Point(564, 238);
            this.tx_PersonelSoyad.Name = "tx_PersonelSoyad";
            this.tx_PersonelSoyad.Size = new System.Drawing.Size(100, 20);
            this.tx_PersonelSoyad.TabIndex = 8;
            // 
            // tx_PersonelEmail
            // 
            this.tx_PersonelEmail.Location = new System.Drawing.Point(564, 322);
            this.tx_PersonelEmail.Name = "tx_PersonelEmail";
            this.tx_PersonelEmail.Size = new System.Drawing.Size(100, 20);
            this.tx_PersonelEmail.TabIndex = 9;
            // 
            // tx_PersonelTel
            // 
            this.tx_PersonelTel.Location = new System.Drawing.Point(565, 361);
            this.tx_PersonelTel.Name = "tx_PersonelTel";
            this.tx_PersonelTel.Size = new System.Drawing.Size(100, 20);
            this.tx_PersonelTel.TabIndex = 10;
            // 
            // tx_PersonelSifre
            // 
            this.tx_PersonelSifre.Location = new System.Drawing.Point(565, 396);
            this.tx_PersonelSifre.Name = "tx_PersonelSifre";
            this.tx_PersonelSifre.Size = new System.Drawing.Size(100, 20);
            this.tx_PersonelSifre.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(661, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Personel Adres Bilgisi Seçiniz : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(984, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = " Personel Birim Tür Bilgisi Seçiniz : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(667, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Personel Tür Seçiniz : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(984, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Personel İletisim Bilgilerini Seçiniz : ";
            // 
            // cbx_PersonelAdresSec
            // 
            this.cbx_PersonelAdresSec.FormattingEnabled = true;
            this.cbx_PersonelAdresSec.Location = new System.Drawing.Point(820, 53);
            this.cbx_PersonelAdresSec.Name = "cbx_PersonelAdresSec";
            this.cbx_PersonelAdresSec.Size = new System.Drawing.Size(121, 21);
            this.cbx_PersonelAdresSec.TabIndex = 16;
            // 
            // cbx_PersonelBirimTurSec
            // 
            this.cbx_PersonelBirimTurSec.FormattingEnabled = true;
            this.cbx_PersonelBirimTurSec.Location = new System.Drawing.Point(1160, 53);
            this.cbx_PersonelBirimTurSec.Name = "cbx_PersonelBirimTurSec";
            this.cbx_PersonelBirimTurSec.Size = new System.Drawing.Size(121, 21);
            this.cbx_PersonelBirimTurSec.TabIndex = 17;
            // 
            // cbx_PersoneliletisimSec
            // 
            this.cbx_PersoneliletisimSec.FormattingEnabled = true;
            this.cbx_PersoneliletisimSec.Location = new System.Drawing.Point(1160, 171);
            this.cbx_PersoneliletisimSec.Name = "cbx_PersoneliletisimSec";
            this.cbx_PersoneliletisimSec.Size = new System.Drawing.Size(121, 21);
            this.cbx_PersoneliletisimSec.TabIndex = 18;
            // 
            // cbx_PersonelTurSec
            // 
            this.cbx_PersonelTurSec.FormattingEnabled = true;
            this.cbx_PersonelTurSec.Location = new System.Drawing.Point(820, 166);
            this.cbx_PersonelTurSec.Name = "cbx_PersonelTurSec";
            this.cbx_PersonelTurSec.Size = new System.Drawing.Size(121, 21);
            this.cbx_PersonelTurSec.TabIndex = 19;
            // 
            // btn_BpersonelSil
            // 
            this.btn_BpersonelSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BpersonelSil.BackgroundImage")));
            this.btn_BpersonelSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_BpersonelSil.Location = new System.Drawing.Point(1100, 247);
            this.btn_BpersonelSil.Name = "btn_BpersonelSil";
            this.btn_BpersonelSil.Size = new System.Drawing.Size(55, 50);
            this.btn_BpersonelSil.TabIndex = 22;
            this.btn_BpersonelSil.UseVisualStyleBackColor = true;
            this.btn_BpersonelSil.Click += new System.EventHandler(this.btn_BpersonelSil_Click);
            // 
            // btn_BpersonelGuncelle
            // 
            this.btn_BpersonelGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BpersonelGuncelle.BackgroundImage")));
            this.btn_BpersonelGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_BpersonelGuncelle.Location = new System.Drawing.Point(937, 247);
            this.btn_BpersonelGuncelle.Name = "btn_BpersonelGuncelle";
            this.btn_BpersonelGuncelle.Size = new System.Drawing.Size(55, 50);
            this.btn_BpersonelGuncelle.TabIndex = 21;
            this.btn_BpersonelGuncelle.UseVisualStyleBackColor = true;
            this.btn_BpersonelGuncelle.Click += new System.EventHandler(this.btn_BpersonelGuncelle_Click);
            // 
            // btn_BpersonelEkle
            // 
            this.btn_BpersonelEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BpersonelEkle.BackgroundImage")));
            this.btn_BpersonelEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_BpersonelEkle.Location = new System.Drawing.Point(770, 247);
            this.btn_BpersonelEkle.Name = "btn_BpersonelEkle";
            this.btn_BpersonelEkle.Size = new System.Drawing.Size(55, 50);
            this.btn_BpersonelEkle.TabIndex = 20;
            this.btn_BpersonelEkle.UseVisualStyleBackColor = true;
            this.btn_BpersonelEkle.Click += new System.EventHandler(this.btn_BpersonelEkle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(381, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Personel Foto Ekle";
            // 
            // pbx_personelFoto
            // 
            this.pbx_personelFoto.Location = new System.Drawing.Point(384, 34);
            this.pbx_personelFoto.Name = "pbx_personelFoto";
            this.pbx_personelFoto.Size = new System.Drawing.Size(138, 155);
            this.pbx_personelFoto.TabIndex = 24;
            this.pbx_personelFoto.TabStop = false;
            // 
            // btn_personelFotoEkle
            // 
            this.btn_personelFotoEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_personelFotoEkle.BackgroundImage")));
            this.btn_personelFotoEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_personelFotoEkle.Location = new System.Drawing.Point(538, 79);
            this.btn_personelFotoEkle.Name = "btn_personelFotoEkle";
            this.btn_personelFotoEkle.Size = new System.Drawing.Size(55, 50);
            this.btn_personelFotoEkle.TabIndex = 25;
            this.btn_personelFotoEkle.UseVisualStyleBackColor = true;
            this.btn_personelFotoEkle.Click += new System.EventHandler(this.btn_personelFotoEkle_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(-1, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(358, 687);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgv_BpersonelKayit
            // 
            this.dgv_BpersonelKayit.AllowUserToAddRows = false;
            this.dgv_BpersonelKayit.AllowUserToDeleteRows = false;
            this.dgv_BpersonelKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BpersonelKayit.Location = new System.Drawing.Point(376, 422);
            this.dgv_BpersonelKayit.Name = "dgv_BpersonelKayit";
            this.dgv_BpersonelKayit.ReadOnly = true;
            this.dgv_BpersonelKayit.Size = new System.Drawing.Size(905, 266);
            this.dgv_BpersonelKayit.TabIndex = 27;
            this.dgv_BpersonelKayit.SelectionChanged += new System.EventHandler(this.dgv_BpersonelKayit_SelectionChanged);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(670, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(633, 91);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ofd_personelFotoYukle
            // 
            this.ofd_personelFotoYukle.FileName = "openFileDialog1";
            // 
            // cms_BelediyePersonelKayit
            // 
            this.cms_BelediyePersonelKayit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.belediyePersonelEkleToolStripMenuItem,
            this.belediyePersonelGüncelleToolStripMenuItem,
            this.belediyePersonelSilToolStripMenuItem,
            this.sayfaKapatToolStripMenuItem});
            this.cms_BelediyePersonelKayit.Name = "cms_BelediyePersonelKayit";
            this.cms_BelediyePersonelKayit.Size = new System.Drawing.Size(216, 92);
            // 
            // belediyePersonelEkleToolStripMenuItem
            // 
            this.belediyePersonelEkleToolStripMenuItem.Name = "belediyePersonelEkleToolStripMenuItem";
            this.belediyePersonelEkleToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.belediyePersonelEkleToolStripMenuItem.Text = "Belediye Personel Ekle";
            this.belediyePersonelEkleToolStripMenuItem.Click += new System.EventHandler(this.btn_BpersonelEkle_Click);
            // 
            // belediyePersonelGüncelleToolStripMenuItem
            // 
            this.belediyePersonelGüncelleToolStripMenuItem.Name = "belediyePersonelGüncelleToolStripMenuItem";
            this.belediyePersonelGüncelleToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.belediyePersonelGüncelleToolStripMenuItem.Text = "Belediye Personel Güncelle";
            this.belediyePersonelGüncelleToolStripMenuItem.Click += new System.EventHandler(this.btn_BpersonelGuncelle_Click);
            // 
            // belediyePersonelSilToolStripMenuItem
            // 
            this.belediyePersonelSilToolStripMenuItem.Name = "belediyePersonelSilToolStripMenuItem";
            this.belediyePersonelSilToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.belediyePersonelSilToolStripMenuItem.Text = "Belediye Personel Sil";
            this.belediyePersonelSilToolStripMenuItem.Click += new System.EventHandler(this.btn_BpersonelSil_Click);
            // 
            // sayfaKapatToolStripMenuItem
            // 
            this.sayfaKapatToolStripMenuItem.Name = "sayfaKapatToolStripMenuItem";
            this.sayfaKapatToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.sayfaKapatToolStripMenuItem.Text = "Sayfa Kapat";
            this.sayfaKapatToolStripMenuItem.Click += new System.EventHandler(this.sayfaKapatToolStripMenuItem_Click);
            // 
            // BelediyePersonelKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 689);
            this.ContextMenuStrip = this.cms_BelediyePersonelKayit;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgv_BpersonelKayit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_personelFotoEkle);
            this.Controls.Add(this.pbx_personelFoto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_BpersonelSil);
            this.Controls.Add(this.btn_BpersonelGuncelle);
            this.Controls.Add(this.btn_BpersonelEkle);
            this.Controls.Add(this.cbx_PersonelTurSec);
            this.Controls.Add(this.cbx_PersoneliletisimSec);
            this.Controls.Add(this.cbx_PersonelBirimTurSec);
            this.Controls.Add(this.cbx_PersonelAdresSec);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tx_PersonelSifre);
            this.Controls.Add(this.tx_PersonelTel);
            this.Controls.Add(this.tx_PersonelEmail);
            this.Controls.Add(this.tx_PersonelSoyad);
            this.Controls.Add(this.tx_PTCKimlik);
            this.Controls.Add(this.tx_PersonelAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BelediyePersonelKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BelediyePersonelKayit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BelediyePersonelKayit_FormClosing);
            this.Load += new System.EventHandler(this.BelediyePersonelKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_personelFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BpersonelKayit)).EndInit();
            this.cms_BelediyePersonelKayit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tx_PersonelAd;
        private System.Windows.Forms.TextBox tx_PTCKimlik;
        private System.Windows.Forms.TextBox tx_PersonelSoyad;
        private System.Windows.Forms.TextBox tx_PersonelEmail;
        private System.Windows.Forms.TextBox tx_PersonelTel;
        private System.Windows.Forms.TextBox tx_PersonelSifre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_PersonelAdresSec;
        private System.Windows.Forms.ComboBox cbx_PersonelBirimTurSec;
        private System.Windows.Forms.ComboBox cbx_PersoneliletisimSec;
        private System.Windows.Forms.ComboBox cbx_PersonelTurSec;
        private System.Windows.Forms.Button btn_BpersonelSil;
        private System.Windows.Forms.Button btn_BpersonelGuncelle;
        private System.Windows.Forms.Button btn_BpersonelEkle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pbx_personelFoto;
        private System.Windows.Forms.Button btn_personelFotoEkle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_BpersonelKayit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog ofd_personelFotoYukle;
        private System.Windows.Forms.ContextMenuStrip cms_BelediyePersonelKayit;
        private System.Windows.Forms.ToolStripMenuItem belediyePersonelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem belediyePersonelGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem belediyePersonelSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sayfaKapatToolStripMenuItem;
    }
}