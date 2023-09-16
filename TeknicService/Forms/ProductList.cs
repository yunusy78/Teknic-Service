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
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
        }
        void ProductListMethod()
        {
            var values = from product in dbTeknicServiceEntities.Products
                         select new
                         {
                             product.ProductID,
                             product.ProductName,
                            CategoryName= product.Categories.Name,
                             product.UnitPrice,
                             product.PurchasePrice,
                             product.UnitsInStock,
                             product.Status,

                         };
            gridControl1.DataSource = values.ToList();
           

        }
        DbTeknicServiceEntities dbTeknicServiceEntities = new DbTeknicServiceEntities();
        private void ProductList_Load(object sender, EventArgs e)
        {
            //List
            /// var values = dbTeknicServiceEntities.Products.ToList();
            /// 
            ProductListMethod();
            lookUpEdit1.Properties.DataSource = dbTeknicServiceEntities.Categories.ToList();

        }
            

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void btnSvae_Click(object sender, EventArgs e)
        {
            Products product = new Products();
            product.ProductID = Guid.NewGuid();
            product.ProductName = txtProductName.Text;
            product.PurchasePrice= decimal.Parse(txtPurchasePrice.Text);
            product.UnitPrice= decimal.Parse(txtUnitPrice.Text);
            product.UnitsInStock = short.Parse(txtUnitInStock.Text);
            product.Status = true;
            product.CategoryID =Guid.Parse(lookUpEdit1.EditValue.ToString());
            dbTeknicServiceEntities.Products.Add(product);
            dbTeknicServiceEntities.SaveChanges();
            MessageBox.Show("Product added successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ProductListMethod();
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textProductId.Text=gridView1.GetFocusedRowCellValue("ProductID").ToString();
            txtProductName.Text=gridView1.GetFocusedRowCellValue("ProductName").ToString();
            txtPurchasePrice.Text = gridView1.GetFocusedRowCellValue("PurchasePrice").ToString();
            txtUnitPrice.Text=gridView1.GetFocusedRowCellValue("UnitPrice").ToString() ;
            txtUnitInStock.Text = gridView1.GetFocusedRowCellValue("UnitsInStock").ToString();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(textProductId.Text);
            var result =dbTeknicServiceEntities.Products.Find(id);
            dbTeknicServiceEntities.Products.Remove(result);
            dbTeknicServiceEntities.SaveChanges();
            MessageBox.Show("Product Deleted successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(textProductId.Text);
            var result = dbTeknicServiceEntities.Products.Find(id);
            result.ProductName = txtProductName.Text;
            result.PurchasePrice= decimal.Parse( txtPurchasePrice.Text);
            result.UnitPrice = decimal.Parse( txtUnitPrice.Text);
            result.UnitsInStock = short.Parse(txtUnitInStock.Text);
            result.CategoryID= Guid.Parse(lookUpEdit1.EditValue.ToString());
            dbTeknicServiceEntities.SaveChanges();
            MessageBox.Show("Product Updated successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
