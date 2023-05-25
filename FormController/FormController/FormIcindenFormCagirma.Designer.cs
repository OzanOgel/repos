namespace FormController
{
    partial class FormIcindenFormCagirma
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
            this.btn_hesapmakinesi = new System.Windows.Forms.Button();
            this.btn_lb = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_hesapmakinesi
            // 
            this.btn_hesapmakinesi.Location = new System.Drawing.Point(36, 12);
            this.btn_hesapmakinesi.Name = "btn_hesapmakinesi";
            this.btn_hesapmakinesi.Size = new System.Drawing.Size(175, 57);
            this.btn_hesapmakinesi.TabIndex = 0;
            this.btn_hesapmakinesi.Text = "Hesap Makinesi";
            this.btn_hesapmakinesi.UseVisualStyleBackColor = true;
            this.btn_hesapmakinesi.Click += new System.EventHandler(this.btn_hesapmakinesi_Click);
            // 
            // btn_lb
            // 
            this.btn_lb.Location = new System.Drawing.Point(36, 90);
            this.btn_lb.Name = "btn_lb";
            this.btn_lb.Size = new System.Drawing.Size(175, 42);
            this.btn_lb.TabIndex = 1;
            this.btn_lb.Text = "ListBoxController";
            this.btn_lb.UseVisualStyleBackColor = true;
            this.btn_lb.Click += new System.EventHandler(this.btn_lb_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormIcindenFormCagirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_lb);
            this.Controls.Add(this.btn_hesapmakinesi);
            this.Name = "FormIcindenFormCagirma";
            this.Text = "FormIcindenFormCagirma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_hesapmakinesi;
        private System.Windows.Forms.Button btn_lb;
        private System.Windows.Forms.Button button2;
    }
}