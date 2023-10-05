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
    public partial class BrandForm : Form
    {
        public BrandForm()
        {
            InitializeComponent();
        }

        DbTeknicServiceEntities db =new DbTeknicServiceEntities();

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void BrandForm_Load(object sender, EventArgs e)
        {
            var values = db.Products
                .OrderBy(x => x.ProductBrand)
                .GroupBy(y => y.ProductBrand)
                .Select(z => new
                {
                    ProductBrand = z.Key,
                    BrandCount = z.Count() // Doğru kullanım, Count işlevini çağırın.
                }).ToList();

            gridControl1.DataSource = values;
            labelControl1.Text=(from x in db.Products select x.ProductBrand).Distinct().Count().ToString();
            labelControl43.Text = db.Products.Count().ToString();
            labelControl5.Text = (from x in db.Products orderby x.UnitPrice descending select x.ProductName).FirstOrDefault();
            var mostCommonBrand = db.Products.GroupBy(p => p.ProductBrand).Select(group => new{ Brand = group.Key, Count = group.Count()}).OrderByDescending(item => item.Count).FirstOrDefault();
            labelControl3.Text = mostCommonBrand.Brand;
            var brandCounts = db.Products.GroupBy(p => p.ProductBrand).Select(group => new{  Brand = group.Key, Count = group.Count()}).OrderByDescending(item => item.Count).ToList();
            foreach (var brandCount in brandCounts)
            {
                chartControl1.Series["Series 1"].Points.AddPoint(brandCount.Brand, brandCount.Count);
            }


            var CategoryCounts = db.Products.GroupBy(p => p.CategoryID) // Kategoriye göre grupla
           .Select(group => new { CategoryId = group.Key, Count = group.Count() }) // Her kategorinin ürün sayısını hesapla
           .OrderByDescending(item => item.Count)
           .ToList();

            foreach (var categoryCount in CategoryCounts)
            {
                var categoryName = db.Categories.FirstOrDefault(c => c.CategoryId == categoryCount.CategoryId)?.Name; // Kategori adını al
                chartControl2.Series["Series 1"].Points.AddPoint(categoryName, categoryCount.Count);
            }




        }

        private void chartControl2_Click(object sender, EventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
