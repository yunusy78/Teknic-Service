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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        DbTeknicServiceEntities db = new DbTeknicServiceEntities();
        void EmployeeListMethod()
        {
            var values = from item in db.Employees
                         select new
                         {
                             item.EmployeeID,
                             item.DeparmentId,
                             item.FirstName,
                             item.LastName,
                             item.Email,
                             item.PhoneNumber,
                             item.PhotoPath

                         };
            gridControl1.DataSource = values.ToList();


        }


        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            EmployeeListMethod();
            lookUpDepartment.Properties.DataSource = db.Departments.Select(x => new
            {
                DepartmentID = x.DepartmentID,
                Name = x.Name
            }).ToList();

            labelControl43.Text = db.Departments.Count().ToString();
            labelControl15.Text = db.Employees.Count().ToString();
            var mostCommonDepartment = db.Employees.GroupBy(p => p.DeparmentId).Select(group => new { DeparmentId = group.Key, Count = group.Count() }).OrderByDescending(item => item.Count).FirstOrDefault();
            Guid DepartmentID = mostCommonDepartment.DeparmentId;
            var result = db.Departments.Find(DepartmentID);
            labelControl13.Text = result.Name;
            var leastCommonDepartment = db.Employees.GroupBy(p => p.DeparmentId).Select(group => new { DeparmentId = group.Key, Count = group.Count() }).OrderBy(item => item.Count).FirstOrDefault();
            Guid DepartmentID2 = leastCommonDepartment.DeparmentId;
            var result2 = db.Departments.Find(DepartmentID2);
            labelControl19.Text = result2.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employees employee = new Employees();
            employee.EmployeeID = Guid.NewGuid();
            employee.FirstName = textFirstName.Text;
            employee.LastName = textLastName.Text;
            employee.PhotoPath = textPhotoPath.Text;
            employee.Email = textEmail.Text;
            employee.PhoneNumber = textPhone.Text;
            employee.DeparmentId =Guid.Parse(lookUpDepartment.EditValue.ToString());
            db.Employees.Add(employee);
            db.SaveChanges();
            MessageBox.Show("Employee added successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(textEmployeeId.Text);
            var result = db.Employees.Find(id);
            db.Employees.Remove(result);
            db.SaveChanges();
            MessageBox.Show("Employee Deleted successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(textEmployeeId.Text);
            var employee = db.Employees.Find(id);
            employee.FirstName = textFirstName.Text;
            employee.LastName = textLastName.Text;
            employee.Email = textEmail.Text;
            employee.PhoneNumber = textPhone.Text;
            employee.PhotoPath = textPhotoPath.Text;
            employee.DeparmentId = Guid.Parse(lookUpDepartment.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Customer Updated successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            EmployeeListMethod();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textEmployeeId.Text = gridView1.GetFocusedRowCellValue("EmployeeID").ToString();
            textFirstName.Text = gridView1.GetFocusedRowCellValue("FirstName").ToString();
            textLastName.Text = gridView1.GetFocusedRowCellValue("LastName").ToString();
            textEmail.Text = gridView1.GetFocusedRowCellValue("Email").ToString();
            textPhotoPath.Text = gridView1.GetFocusedRowCellValue("PhotoPath").ToString();
            textPhone.Text = gridView1.GetFocusedRowCellValue("PhoneNumber").ToString();
           
        }
    }
}
