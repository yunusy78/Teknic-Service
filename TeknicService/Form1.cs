using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknicService
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RibbonForm1_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.ProductList fr = new Forms.ProductList();
            fr.MdiParent = this;
            fr.Show();

        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.NewProduct fr = new Forms.NewProduct();
            fr.Show();
        }

        private void btnCategoryList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.CategoryList fr = new Forms.CategoryList();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnNewCategory_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.NewCategory newCategory = new Forms.NewCategory();
            newCategory.Show();
        }

        private void btnProductChart_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.ProductCharts fr = new Forms.ProductCharts();
            fr.MdiParent = this;
            fr.Show();
        }
    }
}