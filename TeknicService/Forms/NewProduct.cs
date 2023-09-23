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
    public partial class NewProduct : Form
    {
        public NewProduct()
        {
            InitializeComponent();
        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void NewProduct_Load(object sender, EventArgs e)
        {

        }

        private void pictureEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            DbTeknicServiceEntities db = new DbTeknicServiceEntities();
            Products product = new Products();
            product.ProductName = txtProductName2.Text;
            product.ProductBrand = txtProductBrand.Text;
            product.ProductID = Guid.NewGuid();
            product.ProductName = txtProductName2.Text;
            product.PurchasePrice = decimal.Parse(textPurchasePrice.Text);
            product.UnitPrice = decimal.Parse(txtUnitPrice.Text);
            product.UnitsInStock = short.Parse(txtStock.Text);
            product.CategoryID = Guid.Parse(txtCategory.Text);
            product.Status = true;
            db.Products.Add(product);
            db.SaveChanges();
            MessageBox.Show("Product added Succesfylly");
        }
    }
}
