namespace FormController
{
    partial class RadioButtonKontroller
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
            this.rb_erkek = new System.Windows.Forms.RadioButton();
            this.rb_kadın = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_goruntule = new System.Windows.Forms.Button();
            this.rb_bekar = new System.Windows.Forms.RadioButton();
            this.rb_evli = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_sozlesme = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lbl_diller = new System.Windows.Forms.Label();
            this.btn_tumu = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_aktar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_erkek
            // 
            this.rb_erkek.AutoSize = true;
            this.rb_erkek.Location = new System.Drawing.Point(10, 31);
            this.rb_erkek.Name = "rb_erkek";
            this.rb_erkek.Size = new System.Drawing.Size(62, 20);
            this.rb_erkek.TabIndex = 0;
            this.rb_erkek.TabStop = true;
            this.rb_erkek.Text = "erkek";
            this.rb_erkek.UseVisualStyleBackColor = true;
            // 
            // rb_kadın
            // 
            this.rb_kadın.AutoSize = true;
            this.rb_kadın.Location = new System.Drawing.Point(109, 31);
            this.rb_kadın.Name = "rb_kadın";
            this.rb_kadın.Size = new System.Drawing.Size(61, 20);
            this.rb_kadın.TabIndex = 1;
            this.rb_kadın.TabStop = true;
            this.rb_kadın.Text = "kadın";
            this.rb_kadın.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Birden Çok Seçenek Sadece Birini Seçmek İçin Kullanılır";
            // 
            // btn_goruntule
            // 
            this.btn_goruntule.Location = new System.Drawing.Point(76, 325);
            this.btn_goruntule.Name = "btn_goruntule";
            this.btn_goruntule.Size = new System.Drawing.Size(100, 39);
            this.btn_goruntule.TabIndex = 3;
            this.btn_goruntule.Text = "Goruntule";
            this.btn_goruntule.UseVisualStyleBackColor = true;
            this.btn_goruntule.Click += new System.EventHandler(this.btn_goruntule_Click);
            // 
            // rb_bekar
            // 
            this.rb_bekar.AutoSize = true;
            this.rb_bekar.Location = new System.Drawing.Point(109, 44);
            this.rb_bekar.Name = "rb_bekar";
            this.rb_bekar.Size = new System.Drawing.Size(64, 20);
            this.rb_bekar.TabIndex = 4;
            this.rb_bekar.TabStop = true;
            this.rb_bekar.Text = "Bekar";
            this.rb_bekar.UseVisualStyleBackColor = true;
            // 
            // rb_evli
            // 
            this.rb_evli.AutoSize = true;
            this.rb_evli.Location = new System.Drawing.Point(23, 44);
            this.rb_evli.Name = "rb_evli";
            this.rb_evli.Size = new System.Drawing.Size(50, 20);
            this.rb_evli.TabIndex = 5;
            this.rb_evli.TabStop = true;
            this.rb_evli.Text = "Evli";
            this.rb_evli.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_bekar);
            this.groupBox1.Controls.Add(this.rb_evli);
            this.groupBox1.Location = new System.Drawing.Point(44, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_kadın);
            this.groupBox2.Controls.Add(this.rb_erkek);
            this.groupBox2.Location = new System.Drawing.Point(44, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // cb_sozlesme
            // 
            this.cb_sozlesme.AutoSize = true;
            this.cb_sozlesme.Location = new System.Drawing.Point(44, 276);
            this.cb_sozlesme.Name = "cb_sozlesme";
            this.cb_sozlesme.Size = new System.Drawing.Size(171, 20);
            this.cb_sozlesme.TabIndex = 7;
            this.cb_sozlesme.Text = "Sözleşmeyi kabul ettiniz";
            this.cb_sozlesme.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Türkçe",
            "Ingilizce",
            "Almanca",
            "Amerikanca"});
            this.checkedListBox1.Location = new System.Drawing.Point(373, 94);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(152, 157);
            this.checkedListBox1.TabIndex = 8;
            // 
            // lbl_diller
            // 
            this.lbl_diller.AutoSize = true;
            this.lbl_diller.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_diller.Location = new System.Drawing.Point(412, 59);
            this.lbl_diller.Name = "lbl_diller";
            this.lbl_diller.Size = new System.Drawing.Size(71, 15);
            this.lbl_diller.TabIndex = 9;
            this.lbl_diller.Text = "Bilinin diller";
            // 
            // btn_tumu
            // 
            this.btn_tumu.Location = new System.Drawing.Point(336, 266);
            this.btn_tumu.Name = "btn_tumu";
            this.btn_tumu.Size = new System.Drawing.Size(100, 39);
            this.btn_tumu.TabIndex = 10;
            this.btn_tumu.Text = "Tümünü Seç";
            this.btn_tumu.UseVisualStyleBackColor = true;
            this.btn_tumu.Click += new System.EventHandler(this.btn_tumu_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(563, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 148);
            this.listBox1.TabIndex = 11;
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(442, 266);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(100, 39);
            this.btn_temizle.TabIndex = 12;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_aktar
            // 
            this.btn_aktar.Location = new System.Drawing.Point(383, 325);
            this.btn_aktar.Name = "btn_aktar";
            this.btn_aktar.Size = new System.Drawing.Size(100, 39);
            this.btn_aktar.TabIndex = 13;
            this.btn_aktar.Text = "aktar";
            this.btn_aktar.UseVisualStyleBackColor = true;
            this.btn_aktar.Click += new System.EventHandler(this.btn_aktar_Click);
            // 
            // RadioButtonKontroller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_aktar);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_tumu);
            this.Controls.Add(this.lbl_diller);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.cb_sozlesme);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_goruntule);
            this.Controls.Add(this.label1);
            this.Name = "RadioButtonKontroller";
            this.Text = "RadioButtonKontroller";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_erkek;
        private System.Windows.Forms.RadioButton rb_kadın;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_goruntule;
        private System.Windows.Forms.RadioButton rb_bekar;
        private System.Windows.Forms.RadioButton rb_evli;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_sozlesme;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lbl_diller;
        private System.Windows.Forms.Button btn_tumu;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_aktar;
    }
}