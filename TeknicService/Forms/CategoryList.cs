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
    public partial class CategoryList : Form
    {
        public CategoryList()
        {
            InitializeComponent();
        }
        DbTeknicServiceEntities db = new DbTeknicServiceEntities();
        void CategoryListMethod()
        {
            var values = from category in db.Categories
                         select new
                         {
                            category.CategoryId,
                            category.Name,
                            category.Status
                         };
            gridControl1.DataSource = values.ToList();


        }
       
        private void gridControl1_Click(object sender, EventArgs e)
        {
            //var values =db.Categories.ToList();
            //gridControl1.DataSource = values;
            CategoryListMethod();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.Name=txtCategoryName.Text;
            categories.CategoryId=Guid.NewGuid();
            categories.Status = true;
            db.Categories.Add(categories);
            db.SaveChanges();

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            CategoryListMethod();
        }


        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textCategoryId.Text = gridView1.GetFocusedRowCellValue("CategoryId").ToString();
            txtCategoryName.Text = gridView1.GetFocusedRowCellValue("Name").ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(textCategoryId.Text);
            var result = db.Categories.Find(id);
            result.Name = txtCategoryName.Text;
            db.SaveChanges();
            MessageBox.Show("Category Updated successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(textCategoryId.Text);
            var result = db.Categories.Find(id);
            db.Categories.Remove(result);
            db.SaveChanges();
            MessageBox.Show("Category Deleted successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
