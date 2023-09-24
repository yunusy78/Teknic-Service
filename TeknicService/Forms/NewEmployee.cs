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
    public partial class NewEmployee : Form
    {
        public NewEmployee()
        {
            InitializeComponent();
            lookUpDepartment.Properties.DataSource = db.Departments.Select(x => new
            {
                DepartmentID = x.DepartmentID,
                Name = x.Name
            }).ToList();

        }
        DbTeknicServiceEntities db = new DbTeknicServiceEntities();

        private void btnSave1_Click(object sender, EventArgs e)
        {
            Employees employee = new Employees();
            employee.EmployeeID = Guid.NewGuid();
            employee.FirstName = textFirstName.Text;
            employee.LastName = textLastName.Text;
            employee.PhotoPath = textPhotoPath.Text;
            employee.Email = textEmail.Text;
            employee.PhoneNumber = textPhone.Text;
            employee.DeparmentId = Guid.Parse(lookUpDepartment.EditValue.ToString());
            db.Employees.Add(employee);
            db.SaveChanges();
            MessageBox.Show("Employee added successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
