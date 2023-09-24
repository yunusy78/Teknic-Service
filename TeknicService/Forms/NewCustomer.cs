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
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        DbTeknicServiceEntities db = new DbTeknicServiceEntities();

        private void btnSave1_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.CustomerID = Guid.NewGuid();
            customer.FirstName = textFirstName.Text;
            customer.LastName = textLastName.Text;
            customer.Address = textAddress.Text;
            customer.Bank = textBank.Text;
            customer.Email = textEmail.Text;
            customer.Phone = textPhone.Text;
            customer.Title = textTitle.Text;
            customer.Status = true;
            customer.City = textCity.Text;
            var cityInfo = db.Cities.FirstOrDefault(c => c.CityName == textCity.Text);
            customer.Region = cityInfo.StateName;
            customer.PostalCode = cityInfo.PostalCode;
            customer.Country = "Norway";
            db.Customers.Add(customer);
            db.SaveChanges();
            MessageBox.Show("Customer added successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
