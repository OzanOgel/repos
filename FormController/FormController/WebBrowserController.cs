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
    public partial class WebBrowserController : Form
    {
        public WebBrowserController()
        {
            InitializeComponent();
        }

        private void WebBrowserController_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("C:\\Users\\ozano\\Desktop\\FrotEndKonulari\\JQuery\\pnlodev.htm");
        }
    }
}
