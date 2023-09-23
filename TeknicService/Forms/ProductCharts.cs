using DevExpress.Data.Linq.Helpers;
using DevExpress.XtraEditors;
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
    public partial class ProductCharts : Form
    {
        public ProductCharts()
        {
            InitializeComponent();
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
        DbTeknicServiceEntities db = new DbTeknicServiceEntities();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            labelControl2.Text=db.Products.Count().ToString();
            labelControl5.Text =db.Categories.Count().ToString();
            labelControl3.Text =db.Products.Sum(x=>x.UnitsInStock).ToString();
            labelControl55.Text=(from x in db.Products orderby x.UnitsInStock descending select x.ProductName).FirstOrDefault();
            labelControl19.Text = (from x in db.Products orderby x.UnitsInStock ascending select x.ProductName).FirstOrDefault();
            labelControl13.Text= (from x in db.Products orderby x.UnitPrice ascending select x.ProductName).FirstOrDefault();
            labelControl17.Text = (from x in db.Products orderby x.UnitPrice descending select x.ProductName).FirstOrDefault();
            labelControl43.Text = (from x in db.Products select x.ProductBrand).Distinct().Count().ToString();
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
