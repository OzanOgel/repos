namespace DialogPenceleri
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_yeni = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ac = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_kaydey = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_farklikaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_kapat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tspb_dosya = new System.Windows.Forms.ToolStripButton();
            this.tspb_FarklıKaydet = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tspb_kaydet = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_yeni,
            this.TSMI_ac,
            this.TSMI_kaydey,
            this.TSMI_farklikaydet,
            this.TSMI_kapat});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // TSMI_yeni
            // 
            this.TSMI_yeni.Name = "TSMI_yeni";
            this.TSMI_yeni.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.TSMI_yeni.Size = new System.Drawing.Size(266, 26);
            this.TSMI_yeni.Text = "Yeni";
            this.TSMI_yeni.Click += new System.EventHandler(this.TSMI_yeni_Click);
            // 
            // TSMI_ac
            // 
            this.TSMI_ac.Name = "TSMI_ac";
            this.TSMI_ac.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.TSMI_ac.Size = new System.Drawing.Size(266, 26);
            this.TSMI_ac.Text = "Aç";
            this.TSMI_ac.Click += new System.EventHandler(this.TSMI_ac_Click);
            // 
            // TSMI_kaydey
            // 
            this.TSMI_kaydey.Name = "TSMI_kaydey";
            this.TSMI_kaydey.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.TSMI_kaydey.Size = new System.Drawing.Size(266, 26);
            this.TSMI_kaydey.Text = "Kaydet";
            this.TSMI_kaydey.Click += new System.EventHandler(this.TSMI_kaydey_Click);
            // 
            // TSMI_farklikaydet
            // 
            this.TSMI_farklikaydet.Name = "TSMI_farklikaydet";
            this.TSMI_farklikaydet.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.TSMI_farklikaydet.Size = new System.Drawing.Size(266, 26);
            this.TSMI_farklikaydet.Text = "Farklı Kaydet";
            this.TSMI_farklikaydet.Click += new System.EventHandler(this.TSMI_farklikaydet_Click);
            // 
            // TSMI_kapat
            // 
            this.TSMI_kapat.Name = "TSMI_kapat";
            this.TSMI_kapat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.TSMI_kapat.Size = new System.Drawing.Size(266, 26);
            this.TSMI_kapat.Text = "Kapat";
            this.TSMI_kapat.Click += new System.EventHandler(this.TSMI_kapat_Click);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.richTextBox1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 395);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 28);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 422);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspb_dosya,
            this.tspb_kaydet,
            this.tspb_FarklıKaydet});
            this.toolStrip1.Location = new System.Drawing.Point(12, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(100, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tspb_dosya
            // 
            this.tspb_dosya.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspb_dosya.Image = ((System.Drawing.Image)(resources.GetObject("tspb_dosya.Image")));
            this.tspb_dosya.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspb_dosya.Name = "tspb_dosya";
            this.tspb_dosya.Size = new System.Drawing.Size(29, 24);
            this.tspb_dosya.Text = "Dosya";
            this.tspb_dosya.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tspb_FarklıKaydet
            // 
            this.tspb_FarklıKaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspb_FarklıKaydet.Image = ((System.Drawing.Image)(resources.GetObject("tspb_FarklıKaydet.Image")));
            this.tspb_FarklıKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspb_FarklıKaydet.Name = "tspb_FarklıKaydet";
            this.tspb_FarklıKaydet.Size = new System.Drawing.Size(29, 24);
            this.tspb_FarklıKaydet.Text = "Kaydet";
            this.tspb_FarklıKaydet.ToolTipText = "FarklıKaydet";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 395);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tspb_kaydet
            // 
            this.tspb_kaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspb_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("tspb_kaydet.Image")));
            this.tspb_kaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspb_kaydet.Name = "tspb_kaydet";
            this.tspb_kaydet.Size = new System.Drawing.Size(29, 24);
            this.tspb_kaydet.Text = "toolStripButton1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_yeni;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ac;
        private System.Windows.Forms.ToolStripMenuItem TSMI_kaydey;
        private System.Windows.Forms.ToolStripMenuItem TSMI_farklikaydet;
        private System.Windows.Forms.ToolStripMenuItem TSMI_kapat;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tspb_dosya;
        private System.Windows.Forms.ToolStripButton tspb_FarklıKaydet;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripButton tspb_kaydet;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

