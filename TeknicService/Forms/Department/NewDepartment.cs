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
    public partial class NewDepartment : Form
    {
        public NewDepartment()
        {
            InitializeComponent();
        }
        DbTeknicServiceEntities db = new DbTeknicServiceEntities();

        private void btnSave1_Click(object sender, EventArgs e)
        {
            Departments departments = new Departments();
            if ((txtName.Text).Length <= 30 && txtName.Text.Length >= 1)
            {
                departments.Name = txtName.Text;
                departments.Status = bool.Parse(textStatus.Text);
                departments.DepartmentID = Guid.NewGuid();
                db.Departments.Add(departments);
                db.SaveChanges();
                MessageBox.Show("Department added successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Department can not added ", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
