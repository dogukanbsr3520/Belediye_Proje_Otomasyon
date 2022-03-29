namespace Gorsel2_BelediyeProje_CA
{
    partial class BelediyeHizmetler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BelediyeHizmetler));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_BhizmetNo = new System.Windows.Forms.TextBox();
            this.tx_BhizmetAd = new System.Windows.Forms.TextBox();
            this.btn_BhizmetSil = new System.Windows.Forms.Button();
            this.btn_BhizmetGuncelle = new System.Windows.Forms.Button();
            this.btn_BhizmetEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_BhizmetlerKayitlar = new System.Windows.Forms.DataGridView();
            this.cms_BelediyeHizmet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.belediyeHizmetEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.belediyeHizmetGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.belediyeHizmetSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sayfaKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BhizmetlerKayitlar)).BeginInit();
            this.cms_BelediyeHizmet.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hizmet No : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hizmet Ad : ";
            // 
            // tx_BhizmetNo
            // 
            this.tx_BhizmetNo.Location = new System.Drawing.Point(385, 125);
            this.tx_BhizmetNo.Name = "tx_BhizmetNo";
            this.tx_BhizmetNo.Size = new System.Drawing.Size(100, 20);
            this.tx_BhizmetNo.TabIndex = 2;
            // 
            // tx_BhizmetAd
            // 
            this.tx_BhizmetAd.Location = new System.Drawing.Point(462, 191);
            this.tx_BhizmetAd.Name = "tx_BhizmetAd";
            this.tx_BhizmetAd.Size = new System.Drawing.Size(100, 20);
            this.tx_BhizmetAd.TabIndex = 3;
            // 
            // btn_BhizmetSil
            // 
            this.btn_BhizmetSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BhizmetSil.BackgroundImage")));
            this.btn_BhizmetSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_BhizmetSil.Location = new System.Drawing.Point(634, 329);
            this.btn_BhizmetSil.Name = "btn_BhizmetSil";
            this.btn_BhizmetSil.Size = new System.Drawing.Size(60, 50);
            this.btn_BhizmetSil.TabIndex = 19;
            this.btn_BhizmetSil.UseVisualStyleBackColor = true;
            this.btn_BhizmetSil.Click += new System.EventHandler(this.btn_BhizmetSil_Click);
            // 
            // btn_BhizmetGuncelle
            // 
            this.btn_BhizmetGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BhizmetGuncelle.BackgroundImage")));
            this.btn_BhizmetGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_BhizmetGuncelle.Location = new System.Drawing.Point(634, 243);
            this.btn_BhizmetGuncelle.Name = "btn_BhizmetGuncelle";
            this.btn_BhizmetGuncelle.Size = new System.Drawing.Size(55, 50);
            this.btn_BhizmetGuncelle.TabIndex = 18;
            this.btn_BhizmetGuncelle.UseVisualStyleBackColor = true;
            this.btn_BhizmetGuncelle.Click += new System.EventHandler(this.btn_BhizmetGuncelle_Click);
            // 
            // btn_BhizmetEkle
            // 
            this.btn_BhizmetEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BhizmetEkle.BackgroundImage")));
            this.btn_BhizmetEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_BhizmetEkle.Location = new System.Drawing.Point(634, 154);
            this.btn_BhizmetEkle.Name = "btn_BhizmetEkle";
            this.btn_BhizmetEkle.Size = new System.Drawing.Size(55, 50);
            this.btn_BhizmetEkle.TabIndex = 17;
            this.btn_BhizmetEkle.UseVisualStyleBackColor = true;
            this.btn_BhizmetEkle.Click += new System.EventHandler(this.btn_BhizmetEkle_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 376);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(268, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(480, 71);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgv_BhizmetlerKayitlar
            // 
            this.dgv_BhizmetlerKayitlar.AllowUserToAddRows = false;
            this.dgv_BhizmetlerKayitlar.AllowUserToDeleteRows = false;
            this.dgv_BhizmetlerKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BhizmetlerKayitlar.Location = new System.Drawing.Point(322, 238);
            this.dgv_BhizmetlerKayitlar.Name = "dgv_BhizmetlerKayitlar";
            this.dgv_BhizmetlerKayitlar.ReadOnly = true;
            this.dgv_BhizmetlerKayitlar.Size = new System.Drawing.Size(240, 150);
            this.dgv_BhizmetlerKayitlar.TabIndex = 22;
            this.dgv_BhizmetlerKayitlar.SelectionChanged += new System.EventHandler(this.dgv_BhizmetlerKayitlar_SelectionChanged);
            // 
            // cms_BelediyeHizmet
            // 
            this.cms_BelediyeHizmet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.belediyeHizmetEkleToolStripMenuItem,
            this.belediyeHizmetGüncelleToolStripMenuItem,
            this.belediyeHizmetSilToolStripMenuItem,
            this.sayfaKapatToolStripMenuItem});
            this.cms_BelediyeHizmet.Name = "cms_BelediyeHizmet";
            this.cms_BelediyeHizmet.Size = new System.Drawing.Size(209, 92);
            // 
            // belediyeHizmetEkleToolStripMenuItem
            // 
            this.belediyeHizmetEkleToolStripMenuItem.Name = "belediyeHizmetEkleToolStripMenuItem";
            this.belediyeHizmetEkleToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.belediyeHizmetEkleToolStripMenuItem.Text = "Belediye Hizmet Ekle";
            this.belediyeHizmetEkleToolStripMenuItem.Click += new System.EventHandler(this.btn_BhizmetEkle_Click);
            // 
            // belediyeHizmetGüncelleToolStripMenuItem
            // 
            this.belediyeHizmetGüncelleToolStripMenuItem.Name = "belediyeHizmetGüncelleToolStripMenuItem";
            this.belediyeHizmetGüncelleToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.belediyeHizmetGüncelleToolStripMenuItem.Text = "Belediye Hizmet Güncelle";
            this.belediyeHizmetGüncelleToolStripMenuItem.Click += new System.EventHandler(this.btn_BhizmetGuncelle_Click);
            // 
            // belediyeHizmetSilToolStripMenuItem
            // 
            this.belediyeHizmetSilToolStripMenuItem.Name = "belediyeHizmetSilToolStripMenuItem";
            this.belediyeHizmetSilToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.belediyeHizmetSilToolStripMenuItem.Text = "Belediye Hizmet Sil";
            this.belediyeHizmetSilToolStripMenuItem.Click += new System.EventHandler(this.btn_BhizmetSil_Click);
            // 
            // sayfaKapatToolStripMenuItem
            // 
            this.sayfaKapatToolStripMenuItem.Name = "sayfaKapatToolStripMenuItem";
            this.sayfaKapatToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.sayfaKapatToolStripMenuItem.Text = "Sayfa Kapat";
            this.sayfaKapatToolStripMenuItem.Click += new System.EventHandler(this.sayfaKapatToolStripMenuItem_Click);
            // 
            // BelediyeHizmetler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 400);
            this.ContextMenuStrip = this.cms_BelediyeHizmet;
            this.Controls.Add(this.dgv_BhizmetlerKayitlar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_BhizmetSil);
            this.Controls.Add(this.btn_BhizmetGuncelle);
            this.Controls.Add(this.btn_BhizmetEkle);
            this.Controls.Add(this.tx_BhizmetAd);
            this.Controls.Add(this.tx_BhizmetNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BelediyeHizmetler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BelediyeHizmetler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BelediyeHizmetler_FormClosing);
            this.Load += new System.EventHandler(this.BelediyeHizmetler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BhizmetlerKayitlar)).EndInit();
            this.cms_BelediyeHizmet.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_BhizmetNo;
        private System.Windows.Forms.TextBox tx_BhizmetAd;
        private System.Windows.Forms.Button btn_BhizmetSil;
        private System.Windows.Forms.Button btn_BhizmetGuncelle;
        private System.Windows.Forms.Button btn_BhizmetEkle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv_BhizmetlerKayitlar;
        private System.Windows.Forms.ContextMenuStrip cms_BelediyeHizmet;
        private System.Windows.Forms.ToolStripMenuItem belediyeHizmetEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem belediyeHizmetGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem belediyeHizmetSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sayfaKapatToolStripMenuItem;
    }
}