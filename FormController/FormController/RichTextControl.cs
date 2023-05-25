using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormController
{
    public partial class RichTextControl : Form
    {
        public RichTextControl()
        {
            InitializeComponent();
        }

        private void RichTextControl_Load(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("C://Lorem.rtf");
        }

        private void btn_kayıt_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile("C://Kaydedilen/LoremGopya.rtf");
        }
    }
}
