namespace Gorsel2_BelediyeProje_CA
{
    partial class personelGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personelGiris));
            this.tx_kullaniciAd = new System.Windows.Forms.TextBox();
            this.tx_sifre = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.btn_kayitCikis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tx_kullaniciAd
            // 
            this.tx_kullaniciAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tx_kullaniciAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_kullaniciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_kullaniciAd.Location = new System.Drawing.Point(124, 171);
            this.tx_kullaniciAd.Name = "tx_kullaniciAd";
            this.tx_kullaniciAd.Size = new System.Drawing.Size(116, 20);
            this.tx_kullaniciAd.TabIndex = 2;
            this.tx_kullaniciAd.Enter += new System.EventHandler(this.tx_kullaniciAd_Enter);
            this.tx_kullaniciAd.Leave += new System.EventHandler(this.tx_kullaniciAd_Leave);
            // 
            // tx_sifre
            // 
            this.tx_sifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tx_sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_sifre.Location = new System.Drawing.Point(124, 262);
            this.tx_sifre.Name = "tx_sifre";
            this.tx_sifre.Size = new System.Drawing.Size(116, 20);
            this.tx_sifre.TabIndex = 3;
            this.tx_sifre.Enter += new System.EventHandler(this.tx_sifre_Enter);
            this.tx_sifre.Leave += new System.EventHandler(this.tx_sifre_Leave);
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.Green;
            this.btn_giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_giris.BackgroundImage")));
            this.btn_giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_giris.Location = new System.Drawing.Point(277, 35);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(75, 32);
            this.btn_giris.TabIndex = 4;
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // btn_kayitCikis
            // 
            this.btn_kayitCikis.BackColor = System.Drawing.Color.Red;
            this.btn_kayitCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kayitCikis.BackgroundImage")));
            this.btn_kayitCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_kayitCikis.Location = new System.Drawing.Point(368, 35);
            this.btn_kayitCikis.Name = "btn_kayitCikis";
            this.btn_kayitCikis.Size = new System.Drawing.Size(75, 32);
            this.btn_kayitCikis.TabIndex = 5;
            this.btn_kayitCikis.UseVisualStyleBackColor = false;
            this.btn_kayitCikis.Click += new System.EventHandler(this.btn_kayitCikis_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(148, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 48);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(148, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 46);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(12, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "PERSONEL GİRİŞ EKRANINA HOŞGELDİNİZ...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "version 1.0.2 WXCEFG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // personelGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(789, 423);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_kayitCikis);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.tx_sifre);
            this.Controls.Add(this.tx_kullaniciAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "personelGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Giriş";
            this.Load += new System.EventHandler(this.personelGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tx_kullaniciAd;
        private System.Windows.Forms.TextBox tx_sifre;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button btn_kayitCikis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

