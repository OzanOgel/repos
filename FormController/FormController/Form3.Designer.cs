namespace FormController
{
    partial class Form3
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
            this.nud_1 = new System.Windows.Forms.NumericUpDown();
            this.nud2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cıkar = new System.Windows.Forms.Button();
            this.topla = new System.Windows.Forms.Button();
            this.btn_bol = new System.Windows.Forms.Button();
            this.btn_carp = new System.Windows.Forms.Button();
            this.tb_sonuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_1
            // 
            this.nud_1.Location = new System.Drawing.Point(201, 31);
            this.nud_1.Name = "nud_1";
            this.nud_1.Size = new System.Drawing.Size(180, 22);
            this.nud_1.TabIndex = 0;
            // 
            // nud2
            // 
            this.nud2.Location = new System.Drawing.Point(201, 80);
            this.nud2.Name = "nud2";
            this.nud2.Size = new System.Drawing.Size(180, 22);
            this.nud2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "sayı1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "sayı2";
            // 
            // btn_cıkar
            // 
            this.btn_cıkar.Location = new System.Drawing.Point(225, 137);
            this.btn_cıkar.Name = "btn_cıkar";
            this.btn_cıkar.Size = new System.Drawing.Size(75, 23);
            this.btn_cıkar.TabIndex = 4;
            this.btn_cıkar.Text = "çıkar";
            this.btn_cıkar.UseVisualStyleBackColor = true;
            this.btn_cıkar.Click += new System.EventHandler(this.btn_cıkar_Click);
            // 
            // topla
            // 
            this.topla.Location = new System.Drawing.Point(143, 137);
            this.topla.Name = "topla";
            this.topla.Size = new System.Drawing.Size(75, 23);
            this.topla.TabIndex = 5;
            this.topla.Text = "btn_topla";
            this.topla.UseVisualStyleBackColor = true;
            this.topla.Click += new System.EventHandler(this.topla_Click);
            // 
            // btn_bol
            // 
            this.btn_bol.Location = new System.Drawing.Point(306, 137);
            this.btn_bol.Name = "btn_bol";
            this.btn_bol.Size = new System.Drawing.Size(75, 23);
            this.btn_bol.TabIndex = 6;
            this.btn_bol.Text = "böl";
            this.btn_bol.UseVisualStyleBackColor = true;
            this.btn_bol.Click += new System.EventHandler(this.btn_bol_Click);
            // 
            // btn_carp
            // 
            this.btn_carp.Location = new System.Drawing.Point(387, 137);
            this.btn_carp.Name = "btn_carp";
            this.btn_carp.Size = new System.Drawing.Size(75, 23);
            this.btn_carp.TabIndex = 7;
            this.btn_carp.Text = "çarp";
            this.btn_carp.UseVisualStyleBackColor = true;
            this.btn_carp.Click += new System.EventHandler(this.btn_carp_Click);
            // 
            // tb_sonuc
            // 
            this.tb_sonuc.Location = new System.Drawing.Point(201, 195);
            this.tb_sonuc.Name = "tb_sonuc";
            this.tb_sonuc.Size = new System.Drawing.Size(180, 22);
            this.tb_sonuc.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "sonuç";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_sonuc);
            this.Controls.Add(this.btn_carp);
            this.Controls.Add(this.btn_bol);
            this.Controls.Add(this.topla);
            this.Controls.Add(this.btn_cıkar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud2);
            this.Controls.Add(this.nud_1);
            this.Name = "Form3";
            this.Text = "Form3";
            
            ((System.ComponentModel.ISupportInitialize)(this.nud_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_1;
        private System.Windows.Forms.NumericUpDown nud2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cıkar;
        private System.Windows.Forms.Button topla;
        private System.Windows.Forms.Button btn_bol;
        private System.Windows.Forms.Button btn_carp;
        private System.Windows.Forms.TextBox tb_sonuc;
        private System.Windows.Forms.Label label3;
    }
}