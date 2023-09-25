using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknicService.Forms
{
    public partial class NewsletterForm : Form
    {
        public NewsletterForm()
        {
            InitializeComponent();
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void NewsletterForm_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.nrk.no/");
        }
    }
}
