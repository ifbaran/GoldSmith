namespace GoldSmith
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolKullaniciIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.toolYetkilendirmeIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAltin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAltinTipiIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.altınKuruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToptanci = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToptanciIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDepo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDepoIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.toolPersonel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolPersonelIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSubeler = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSubeIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.toolFatura = new System.Windows.Forms.ToolStripMenuItem();
            this.toolFaturaIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSatis = new System.Windows.Forms.ToolStripMenuItem();
            this.satışİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMusteri = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSiparis = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adminEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabForms = new System.Windows.Forms.TabControl();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAdmin,
            this.toolAltin,
            this.toolToptanci,
            this.toolDepo,
            this.toolPersonel,
            this.toolSubeler,
            this.toolFatura,
            this.toolSatis,
            this.toolMusteri,
            this.toolSiparis});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.ShowItemToolTips = true;
            this.menuStrip.Size = new System.Drawing.Size(1331, 84);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolAdmin
            // 
            this.toolAdmin.AutoSize = false;
            this.toolAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolKullaniciIslemleri,
            this.toolYetkilendirmeIslemleri});
            this.toolAdmin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolAdmin.Image = ((System.Drawing.Image)(resources.GetObject("toolAdmin.Image")));
            this.toolAdmin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolAdmin.Name = "toolAdmin";
            this.toolAdmin.Size = new System.Drawing.Size(122, 80);
            this.toolAdmin.Text = "Admin";
            this.toolAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolKullaniciIslemleri
            // 
            this.toolKullaniciIslemleri.Name = "toolKullaniciIslemleri";
            this.toolKullaniciIslemleri.Size = new System.Drawing.Size(208, 22);
            this.toolKullaniciIslemleri.Text = "Kullanıcı İşlemleri";
            this.toolKullaniciIslemleri.Click += new System.EventHandler(this.toolKullaniciIslemleri_Click);
            // 
            // toolYetkilendirmeIslemleri
            // 
            this.toolYetkilendirmeIslemleri.Name = "toolYetkilendirmeIslemleri";
            this.toolYetkilendirmeIslemleri.Size = new System.Drawing.Size(208, 22);
            this.toolYetkilendirmeIslemleri.Text = "Yetkilendirme İşlemleri";
            this.toolYetkilendirmeIslemleri.Click += new System.EventHandler(this.toolYetkilendirmeIslemleri_Click);
            // 
            // toolAltin
            // 
            this.toolAltin.AutoSize = false;
            this.toolAltin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAltinTipiIslemleri,
            this.altınKuruToolStripMenuItem});
            this.toolAltin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.toolAltin.Image = ((System.Drawing.Image)(resources.GetObject("toolAltin.Image")));
            this.toolAltin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolAltin.Name = "toolAltin";
            this.toolAltin.Size = new System.Drawing.Size(122, 80);
            this.toolAltin.Text = "Altın";
            this.toolAltin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolAltinTipiIslemleri
            // 
            this.toolAltinTipiIslemleri.Name = "toolAltinTipiIslemleri";
            this.toolAltinTipiIslemleri.Size = new System.Drawing.Size(176, 22);
            this.toolAltinTipiIslemleri.Text = "Altın Tipi İşlemleri";
            this.toolAltinTipiIslemleri.Click += new System.EventHandler(this.toolAltinTipiIslemleri_Click);
            // 
            // altınKuruToolStripMenuItem
            // 
            this.altınKuruToolStripMenuItem.Name = "altınKuruToolStripMenuItem";
            this.altınKuruToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.altınKuruToolStripMenuItem.Text = "Altın Kuru";
            this.altınKuruToolStripMenuItem.Click += new System.EventHandler(this.altınKuruToolStripMenuItem_Click);
            // 
            // toolToptanci
            // 
            this.toolToptanci.AutoSize = false;
            this.toolToptanci.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolToptanciIslemleri});
            this.toolToptanci.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.toolToptanci.Image = ((System.Drawing.Image)(resources.GetObject("toolToptanci.Image")));
            this.toolToptanci.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolToptanci.Name = "toolToptanci";
            this.toolToptanci.Size = new System.Drawing.Size(122, 80);
            this.toolToptanci.Text = "Toptancı";
            this.toolToptanci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolToptanciIslemleri
            // 
            this.toolToptanciIslemleri.Name = "toolToptanciIslemleri";
            this.toolToptanciIslemleri.Size = new System.Drawing.Size(179, 22);
            this.toolToptanciIslemleri.Text = "Toptancı İşlemleri";
            this.toolToptanciIslemleri.Click += new System.EventHandler(this.toolToptanciIslemleri_Click);
            // 
            // toolDepo
            // 
            this.toolDepo.AutoSize = false;
            this.toolDepo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDepoIslemleri});
            this.toolDepo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.toolDepo.Image = ((System.Drawing.Image)(resources.GetObject("toolDepo.Image")));
            this.toolDepo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolDepo.Name = "toolDepo";
            this.toolDepo.Size = new System.Drawing.Size(122, 80);
            this.toolDepo.Text = "Depo";
            this.toolDepo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolDepoIslemleri
            // 
            this.toolDepoIslemleri.Name = "toolDepoIslemleri";
            this.toolDepoIslemleri.Size = new System.Drawing.Size(160, 22);
            this.toolDepoIslemleri.Text = "Depo İşlemleri";
            this.toolDepoIslemleri.Click += new System.EventHandler(this.toolDepoIslemleri_Click);
            // 
            // toolPersonel
            // 
            this.toolPersonel.AutoSize = false;
            this.toolPersonel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolPersonelIslemleri});
            this.toolPersonel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.toolPersonel.Image = ((System.Drawing.Image)(resources.GetObject("toolPersonel.Image")));
            this.toolPersonel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolPersonel.Name = "toolPersonel";
            this.toolPersonel.Size = new System.Drawing.Size(122, 80);
            this.toolPersonel.Text = "Personel";
            this.toolPersonel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolPersonelIslemleri
            // 
            this.toolPersonelIslemleri.Name = "toolPersonelIslemleri";
            this.toolPersonelIslemleri.Size = new System.Drawing.Size(171, 22);
            this.toolPersonelIslemleri.Text = "Çalışan İşlemleri";
            this.toolPersonelIslemleri.Click += new System.EventHandler(this.toolPersonelIslemleri_Click);
            // 
            // toolSubeler
            // 
            this.toolSubeler.AutoSize = false;
            this.toolSubeler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSubeIslemleri});
            this.toolSubeler.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.toolSubeler.Image = ((System.Drawing.Image)(resources.GetObject("toolSubeler.Image")));
            this.toolSubeler.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolSubeler.Name = "toolSubeler";
            this.toolSubeler.Size = new System.Drawing.Size(122, 80);
            this.toolSubeler.Text = "Şube";
            this.toolSubeler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolSubeIslemleri
            // 
            this.toolSubeIslemleri.Name = "toolSubeIslemleri";
            this.toolSubeIslemleri.Size = new System.Drawing.Size(157, 22);
            this.toolSubeIslemleri.Text = "Şube İşlemleri";
            this.toolSubeIslemleri.Click += new System.EventHandler(this.toolSubeIslemleri_Click);
            // 
            // toolFatura
            // 
            this.toolFatura.AutoSize = false;
            this.toolFatura.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFaturaIslemleri});
            this.toolFatura.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.toolFatura.Image = ((System.Drawing.Image)(resources.GetObject("toolFatura.Image")));
            this.toolFatura.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolFatura.Name = "toolFatura";
            this.toolFatura.Size = new System.Drawing.Size(122, 80);
            this.toolFatura.Text = "Fatura";
            this.toolFatura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolFaturaIslemleri
            // 
            this.toolFaturaIslemleri.Name = "toolFaturaIslemleri";
            this.toolFaturaIslemleri.Size = new System.Drawing.Size(164, 22);
            this.toolFaturaIslemleri.Text = "Fatura İşlemleri";
            // 
            // toolSatis
            // 
            this.toolSatis.AutoSize = false;
            this.toolSatis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satışİşlemleriToolStripMenuItem});
            this.toolSatis.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolSatis.Image = ((System.Drawing.Image)(resources.GetObject("toolSatis.Image")));
            this.toolSatis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolSatis.Name = "toolSatis";
            this.toolSatis.Size = new System.Drawing.Size(122, 80);
            this.toolSatis.Text = "Satış";
            this.toolSatis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // satışİşlemleriToolStripMenuItem
            // 
            this.satışİşlemleriToolStripMenuItem.Name = "satışİşlemleriToolStripMenuItem";
            this.satışİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.satışİşlemleriToolStripMenuItem.Text = "Satış İşlemleri";
            this.satışİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.satışİşlemleriToolStripMenuItem_Click);
            // 
            // toolMusteri
            // 
            this.toolMusteri.AutoSize = false;
            this.toolMusteri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriİşlemleriToolStripMenuItem});
            this.toolMusteri.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.toolMusteri.Image = ((System.Drawing.Image)(resources.GetObject("toolMusteri.Image")));
            this.toolMusteri.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolMusteri.Name = "toolMusteri";
            this.toolMusteri.Size = new System.Drawing.Size(122, 80);
            this.toolMusteri.Text = "Müşteri";
            this.toolMusteri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // müşteriİşlemleriToolStripMenuItem
            // 
            this.müşteriİşlemleriToolStripMenuItem.Name = "müşteriİşlemleriToolStripMenuItem";
            this.müşteriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.müşteriİşlemleriToolStripMenuItem.Text = "Müşteri İşlemleri";
            this.müşteriİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.müşteriİşlemleriToolStripMenuItem_Click);
            // 
            // toolSiparis
            // 
            this.toolSiparis.AutoSize = false;
            this.toolSiparis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişİşlemleriToolStripMenuItem});
            this.toolSiparis.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.toolSiparis.Image = ((System.Drawing.Image)(resources.GetObject("toolSiparis.Image")));
            this.toolSiparis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolSiparis.Name = "toolSiparis";
            this.toolSiparis.Size = new System.Drawing.Size(122, 80);
            this.toolSiparis.Text = "Sipariş";
            this.toolSiparis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // siparişİşlemleriToolStripMenuItem
            // 
            this.siparişİşlemleriToolStripMenuItem.Name = "siparişİşlemleriToolStripMenuItem";
            this.siparişİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.siparişİşlemleriToolStripMenuItem.Text = "Sipariş İşlemleri";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminEkleToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 20);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // adminEkleToolStripMenuItem
            // 
            this.adminEkleToolStripMenuItem.Name = "adminEkleToolStripMenuItem";
            this.adminEkleToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.adminEkleToolStripMenuItem.Text = "Admin Ekle";
            // 
            // tabForms
            // 
            this.tabForms.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabForms.Location = new System.Drawing.Point(0, 84);
            this.tabForms.Name = "tabForms";
            this.tabForms.SelectedIndex = 0;
            this.tabForms.Size = new System.Drawing.Size(1331, 26);
            this.tabForms.TabIndex = 4;
            this.tabForms.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 698);
            this.Controls.Add(this.tabForms);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altın Depo Yönetimi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.MdiChildActivate += new System.EventHandler(this.Main_MdiChildActivate);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adminEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolAdmin;
        private System.Windows.Forms.ToolStripMenuItem toolToptanci;
        private System.Windows.Forms.ToolStripMenuItem toolPersonel;
        private System.Windows.Forms.ToolStripMenuItem toolAltin;
        private System.Windows.Forms.ToolStripMenuItem toolDepo;
        private System.Windows.Forms.ToolStripMenuItem toolSubeler;
        private System.Windows.Forms.ToolStripMenuItem toolFatura;
        private System.Windows.Forms.ToolStripMenuItem toolKullaniciIslemleri;
        private System.Windows.Forms.ToolStripMenuItem toolYetkilendirmeIslemleri;
        private System.Windows.Forms.ToolStripMenuItem toolAltinTipiIslemleri;
        private System.Windows.Forms.ToolStripMenuItem toolToptanciIslemleri;
        private System.Windows.Forms.ToolStripMenuItem toolDepoIslemleri;
        private System.Windows.Forms.ToolStripMenuItem toolPersonelIslemleri;
        private System.Windows.Forms.ToolStripMenuItem toolSubeIslemleri;
        private System.Windows.Forms.ToolStripMenuItem toolFaturaIslemleri;
        private System.Windows.Forms.TabControl tabForms;
        private System.Windows.Forms.ToolStripMenuItem toolSatis;
        private System.Windows.Forms.ToolStripMenuItem toolMusteri;
        private System.Windows.Forms.ToolStripMenuItem toolSiparis;
        private System.Windows.Forms.ToolStripMenuItem satışİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altınKuruToolStripMenuItem;
    }
}

