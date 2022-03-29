namespace Gorsel2_BelediyeProje_CA
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtn_personelSayfa = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_personelTurSayfa = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_BBirimTurSayfa = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_BHizmetSayfa = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_personelAdresSayfa = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_BBirimAdresSayfa = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_BiletisimSayfa = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_SistemKapat = new System.Windows.Forms.ToolStripButton();
            this.notifyIconBelediye = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms_Notify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_saatB = new System.Windows.Forms.Label();
            this.lbl_tarihB = new System.Windows.Forms.Label();
            this.timerSure_saatTarih = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStripMenu.SuspendLayout();
            this.cms_Notify.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_personelSayfa,
            this.tsbtn_personelTurSayfa,
            this.tsbtn_BBirimTurSayfa,
            this.tsbtn_BHizmetSayfa,
            this.tsbtn_personelAdresSayfa,
            this.tsbtn_BBirimAdresSayfa,
            this.tsbtn_BiletisimSayfa,
            this.tsbtn_SistemKapat});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1476, 38);
            this.toolStripMenu.TabIndex = 1;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbtn_personelSayfa
            // 
            this.tsbtn_personelSayfa.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_personelSayfa.Image")));
            this.tsbtn_personelSayfa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_personelSayfa.Name = "tsbtn_personelSayfa";
            this.tsbtn_personelSayfa.Size = new System.Drawing.Size(148, 35);
            this.tsbtn_personelSayfa.Text = "Personel Ekle/Sil/Güncelle";
            this.tsbtn_personelSayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_personelSayfa.Click += new System.EventHandler(this.tsbtn_personelSayfa_Click);
            // 
            // tsbtn_personelTurSayfa
            // 
            this.tsbtn_personelTurSayfa.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_personelTurSayfa.Image")));
            this.tsbtn_personelTurSayfa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_personelTurSayfa.Name = "tsbtn_personelTurSayfa";
            this.tsbtn_personelTurSayfa.Size = new System.Drawing.Size(168, 35);
            this.tsbtn_personelTurSayfa.Text = "Personel Tür Ekle/Sil/Güncelle";
            this.tsbtn_personelTurSayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_personelTurSayfa.Click += new System.EventHandler(this.tsbtn_personelTurSayfa_Click);
            // 
            // tsbtn_BBirimTurSayfa
            // 
            this.tsbtn_BBirimTurSayfa.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_BBirimTurSayfa.Image")));
            this.tsbtn_BBirimTurSayfa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_BBirimTurSayfa.Name = "tsbtn_BBirimTurSayfa";
            this.tsbtn_BBirimTurSayfa.Size = new System.Drawing.Size(195, 35);
            this.tsbtn_BBirimTurSayfa.Text = "Belediye BirimTür Ekle/Sil/Güncelle";
            this.tsbtn_BBirimTurSayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_BBirimTurSayfa.Click += new System.EventHandler(this.tsbtn_BBirimTurSayfa_Click);
            // 
            // tsbtn_BHizmetSayfa
            // 
            this.tsbtn_BHizmetSayfa.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_BHizmetSayfa.Image")));
            this.tsbtn_BHizmetSayfa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_BHizmetSayfa.Name = "tsbtn_BHizmetSayfa";
            this.tsbtn_BHizmetSayfa.Size = new System.Drawing.Size(188, 35);
            this.tsbtn_BHizmetSayfa.Text = "Belediye Hizmet Ekle/Sil/Güncelle";
            this.tsbtn_BHizmetSayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_BHizmetSayfa.Click += new System.EventHandler(this.tsbtn_BHizmetSayfa_Click);
            // 
            // tsbtn_personelAdresSayfa
            // 
            this.tsbtn_personelAdresSayfa.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_personelAdresSayfa.Image")));
            this.tsbtn_personelAdresSayfa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_personelAdresSayfa.Name = "tsbtn_personelAdresSayfa";
            this.tsbtn_personelAdresSayfa.Size = new System.Drawing.Size(181, 35);
            this.tsbtn_personelAdresSayfa.Text = "Personel Adres Ekle/Sil/Güncelle";
            this.tsbtn_personelAdresSayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_personelAdresSayfa.Click += new System.EventHandler(this.tsbtn_personelAdresSayfa_Click);
            // 
            // tsbtn_BBirimAdresSayfa
            // 
            this.tsbtn_BBirimAdresSayfa.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_BBirimAdresSayfa.Image")));
            this.tsbtn_BBirimAdresSayfa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_BBirimAdresSayfa.Name = "tsbtn_BBirimAdresSayfa";
            this.tsbtn_BBirimAdresSayfa.Size = new System.Drawing.Size(211, 35);
            this.tsbtn_BBirimAdresSayfa.Text = "Belediye Birim Adres Ekle/Sil/Güncelle";
            this.tsbtn_BBirimAdresSayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_BBirimAdresSayfa.Click += new System.EventHandler(this.tsbtn_BBirimAdresSayfa_Click);
            // 
            // tsbtn_BiletisimSayfa
            // 
            this.tsbtn_BiletisimSayfa.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_BiletisimSayfa.Image")));
            this.tsbtn_BiletisimSayfa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_BiletisimSayfa.Name = "tsbtn_BiletisimSayfa";
            this.tsbtn_BiletisimSayfa.Size = new System.Drawing.Size(188, 35);
            this.tsbtn_BiletisimSayfa.Text = "Belediye İletişim Ekle/Sil/Güncelle";
            this.tsbtn_BiletisimSayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_BiletisimSayfa.Click += new System.EventHandler(this.tsbtn_BiletisimSayfa_Click);
            // 
            // tsbtn_SistemKapat
            // 
            this.tsbtn_SistemKapat.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_SistemKapat.Image")));
            this.tsbtn_SistemKapat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_SistemKapat.Name = "tsbtn_SistemKapat";
            this.tsbtn_SistemKapat.Size = new System.Drawing.Size(68, 35);
            this.tsbtn_SistemKapat.Text = "S/Kapat";
            this.tsbtn_SistemKapat.Click += new System.EventHandler(this.tsbtn_SistemKapat_Click);
            // 
            // notifyIconBelediye
            // 
            this.notifyIconBelediye.ContextMenuStrip = this.cms_Notify;
            this.notifyIconBelediye.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconBelediye.Icon")));
            this.notifyIconBelediye.Text = "Denizli Büyükşehir Belediyesi";
            this.notifyIconBelediye.Visible = true;
            this.notifyIconBelediye.DoubleClick += new System.EventHandler(this.notifyIconBelediye_DoubleClick);
            // 
            // cms_Notify
            // 
            this.cms_Notify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem,
            this.gizleToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.cms_Notify.Name = "cms_Notify";
            this.cms_Notify.Size = new System.Drawing.Size(109, 70);
            // 
            // gösterToolStripMenuItem
            // 
            this.gösterToolStripMenuItem.Name = "gösterToolStripMenuItem";
            this.gösterToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.gösterToolStripMenuItem.Text = "Göster";
            this.gösterToolStripMenuItem.Click += new System.EventHandler(this.gösterToolStripMenuItem_Click);
            // 
            // gizleToolStripMenuItem
            // 
            this.gizleToolStripMenuItem.Name = "gizleToolStripMenuItem";
            this.gizleToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.gizleToolStripMenuItem.Text = "Gizle";
            this.gizleToolStripMenuItem.Click += new System.EventHandler(this.gizleToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // lbl_saatB
            // 
            this.lbl_saatB.AutoSize = true;
            this.lbl_saatB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saatB.Location = new System.Drawing.Point(1303, 78);
            this.lbl_saatB.Name = "lbl_saatB";
            this.lbl_saatB.Size = new System.Drawing.Size(33, 13);
            this.lbl_saatB.TabIndex = 3;
            this.lbl_saatB.Text = "Saat";
            // 
            // lbl_tarihB
            // 
            this.lbl_tarihB.AutoSize = true;
            this.lbl_tarihB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tarihB.Location = new System.Drawing.Point(1296, 134);
            this.lbl_tarihB.Name = "lbl_tarihB";
            this.lbl_tarihB.Size = new System.Drawing.Size(36, 13);
            this.lbl_tarihB.TabIndex = 5;
            this.lbl_tarihB.Text = "Tarih";
            // 
            // timerSure_saatTarih
            // 
            this.timerSure_saatTarih.Enabled = true;
            this.timerSure_saatTarih.Tick += new System.EventHandler(this.timerSure_saatTarih_Tick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(1316, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 37);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(1319, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 41);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1476, 406);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_tarihB);
            this.Controls.Add(this.lbl_saatB);
            this.Controls.Add(this.toolStripMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaSayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaSayfa_FormClosing);
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.cms_Notify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        public System.Windows.Forms.ToolStripButton tsbtn_personelTurSayfa;
        public System.Windows.Forms.ToolStripButton tsbtn_BBirimTurSayfa;
        public System.Windows.Forms.ToolStripButton tsbtn_BHizmetSayfa;
        public System.Windows.Forms.ToolStripButton tsbtn_personelAdresSayfa;
        public System.Windows.Forms.ToolStripButton tsbtn_BBirimAdresSayfa;
        public System.Windows.Forms.ToolStripButton tsbtn_BiletisimSayfa;
        public System.Windows.Forms.ToolStripButton tsbtn_personelSayfa;
        private System.Windows.Forms.NotifyIcon notifyIconBelediye;
        private System.Windows.Forms.ContextMenuStrip cms_Notify;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbtn_SistemKapat;
        private System.Windows.Forms.Label lbl_saatB;
        private System.Windows.Forms.Label lbl_tarihB;
        private System.Windows.Forms.Timer timerSure_saatTarih;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}