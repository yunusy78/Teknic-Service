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
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }
        DbTeknicServiceEntities db = new DbTeknicServiceEntities();

        void DeparmentListMethod()
        {
            var values = from item in db.Departments
                         select new
                         {
                            item.DepartmentID,
                            item.Name,
                            item.Status

                         };
            gridControl1.DataSource = values.ToList();

        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            DeparmentListMethod();

            labelControl43.Text = db.Departments.Count().ToString();
            labelControl15.Text = db.Employees.Count().ToString();
            var mostCommonDepartment = db.Employees.GroupBy(p => p.DeparmentId).Select(group => new { DeparmentId = group.Key, Count = group.Count() }).OrderByDescending(item => item.Count).FirstOrDefault();
            Guid DepartmentID=mostCommonDepartment.DeparmentId;
            var result = db.Departments.Find(DepartmentID);
            labelControl13.Text = result.Name;
            var leastCommonDepartment = db.Employees.GroupBy(p => p.DeparmentId).Select(group => new { DeparmentId = group.Key, Count = group.Count() }).OrderBy(item => item.Count).FirstOrDefault();
            Guid DepartmentID2 = leastCommonDepartment.DeparmentId;
            var result2 = db.Departments.Find(DepartmentID2);
            labelControl19.Text = result2.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           Departments departments = new Departments();
            if((textDeparmentName.Text).Length<=30 && textDeparmentName.Text.Length>=1)
            {
                departments.Name = textDeparmentName.Text;
                departments.Status = bool.Parse(textDeparmentStatus.Text);
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

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textDeparmentId.Text = gridView1.GetFocusedRowCellValue("DepartmentID").ToString();
            textDeparmentName.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
            textDeparmentStatus.Text = gridView1.GetFocusedRowCellValue("Status").ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(textDeparmentId.Text);
            var result = db.Departments.Find(id);
            db.Departments.Remove(result);
            db.SaveChanges();
            MessageBox.Show("Department Deleted successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(textDeparmentId.Text);
            var department = db.Departments.Find(id);
            if ((textDeparmentName.Text).Length <= 30 && textDeparmentName.Text.Length >= 1)
            {
                department.Name = textDeparmentName.Text;
                department.Status = bool.Parse(textDeparmentStatus.Text);
                db.SaveChanges();
                MessageBox.Show("The Department Updated successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("The Department can not Updated ", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }


        }

        private void btnList_Click(object sender, EventArgs e)
        {
            DeparmentListMethod();
        }
    }
}
