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
    public partial class NewCategory : Form
    {
        public NewCategory()
        {
            InitializeComponent();
        }

        private void textEdit5_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCategory_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            DbTeknicServiceEntities db = new DbTeknicServiceEntities();
            Categories categories = new Categories();
            categories.CategoryId = Guid.NewGuid();
            categories.Name = txtCategory.Text;
            categories.Status = true;
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Category added Succesfylly");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
