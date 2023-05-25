namespace FormController
{
    partial class comboboxcontroller
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
            this.cb_sehir = new System.Windows.Forms.ComboBox();
            this.btn_sec = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_Departman = new System.Windows.Forms.Label();
            this.cb_departman = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_markalar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cb_sehir
            // 
            this.cb_sehir.FormattingEnabled = true;
            this.cb_sehir.Items.AddRange(new object[] {
            "İstanbul",
            "Eskişehir ",
            "İzmir",
            "Adana"});
            this.cb_sehir.Location = new System.Drawing.Point(12, 12);
            this.cb_sehir.Name = "cb_sehir";
            this.cb_sehir.Size = new System.Drawing.Size(194, 24);
            this.cb_sehir.TabIndex = 0;
            this.cb_sehir.Text = "Seçiniz..";
            this.cb_sehir.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_sec
            // 
            this.btn_sec.Location = new System.Drawing.Point(212, 12);
            this.btn_sec.Name = "btn_sec";
            this.btn_sec.Size = new System.Drawing.Size(128, 24);
            this.btn_sec.TabIndex = 1;
            this.btn_sec.Text = "Seç";
            this.btn_sec.UseVisualStyleBackColor = true;
            this.btn_sec.Click += new System.EventHandler(this.btn_sec_Click);
            // 
            // lbl_Departman
            // 
            this.lbl_Departman.AutoSize = true;
            this.lbl_Departman.Location = new System.Drawing.Point(12, 52);
            this.lbl_Departman.Name = "lbl_Departman";
            this.lbl_Departman.Size = new System.Drawing.Size(89, 16);
            this.lbl_Departman.TabIndex = 2;
            this.lbl_Departman.Text = "Departmanlar";
            this.lbl_Departman.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_departman
            // 
            this.cb_departman.FormattingEnabled = true;
            this.cb_departman.Location = new System.Drawing.Point(107, 49);
            this.cb_departman.Name = "cb_departman";
            this.cb_departman.Size = new System.Drawing.Size(173, 24);
            this.cb_departman.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Markalar";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cb_markalar
            // 
            this.cb_markalar.FormattingEnabled = true;
            this.cb_markalar.Location = new System.Drawing.Point(107, 88);
            this.cb_markalar.Name = "cb_markalar";
            this.cb_markalar.Size = new System.Drawing.Size(173, 24);
            this.cb_markalar.TabIndex = 5;
            // 
            // comboboxcontroller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_markalar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_departman);
            this.Controls.Add(this.lbl_Departman);
            this.Controls.Add(this.btn_sec);
            this.Controls.Add(this.cb_sehir);
            this.Name = "comboboxcontroller";
            this.Text = "comboboxcontroller";
            this.Load += new System.EventHandler(this.comboboxcontroller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_sehir;
        private System.Windows.Forms.Button btn_sec;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_Departman;
        private System.Windows.Forms.ComboBox cb_departman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_markalar;
    }
}