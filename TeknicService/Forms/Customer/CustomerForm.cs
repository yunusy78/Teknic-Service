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
using System.Data.Entity;

namespace TeknicService.Forms
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            lookUpCity.Properties.DataSource = db.Cities.ToList();

        }

        DbTeknicServiceEntities db=new DbTeknicServiceEntities();
        void CustomerListMethod()
        {
            var values = from item in db.Customers
                         select new
                         {
                         item.CustomerID, item.FirstName,item.LastName, 
                             item.Email,item.Title, item.Address, item.City, 
                             item.Region, item.PostalCode, item.Country,
                             item.Phone,item.Bank

                         };
            gridControl1.DataSource = values.ToList();


        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource=db.Customers.ToList();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            CustomerListMethod();
        }


        private void CustomerForm_Load(object sender, EventArgs e)
        {
            CustomerListMethod();

            labelControl43.Text = db.Customers.Count().ToString();
            labelControl15.Text = db.Customers.Where(x => x.Status == true).Count().ToString();
            labelControl17.Text = (from x in db.Customers select x.City).Distinct().Count().ToString();
            var mostCommonCity = db.Customers.GroupBy(p => p.City).Select(group => new { City= group.Key, Count = group.Count() }).OrderByDescending(item => item.Count).FirstOrDefault();
            labelControl13.Text = mostCommonCity.City;

            var leastCommonCity = db.Customers.GroupBy(p => p.City).Select(group => new { City = group.Key, Count = group.Count() }).OrderBy(item => item.Count).FirstOrDefault();
            labelControl19.Text = leastCommonCity.City;
        }

       

        private void btnSvae_Click(object sender, EventArgs e)
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
            customer.City = lookUpCity.EditValue.ToString();
            var cityInfo = db.Cities.FirstOrDefault(c => c.CityName == lookUpCity.EditValue.ToString());
            customer.Region = cityInfo.StateName;
            customer.PostalCode = cityInfo.PostalCode;
            customer.Country = "Norway";
            db.Customers.Add(customer);
            db.SaveChanges();
            MessageBox.Show("Customer added successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridControl1_FocusedViewChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textCustomerId.Text = gridView1.GetFocusedRowCellValue("CustomerID").ToString();
            textFirstName.Text = gridView1.GetFocusedRowCellValue("FirstName").ToString();
            textLastName.Text = gridView1.GetFocusedRowCellValue("LastName").ToString();
            textEmail.Text = gridView1.GetFocusedRowCellValue("Email").ToString();
            textTitle.Text = gridView1.GetFocusedRowCellValue("Title").ToString();
            textAddress.Text = gridView1.GetFocusedRowCellValue("Address").ToString();
            textPhone.Text = gridView1.GetFocusedRowCellValue("Phone").ToString();
            textBank.Text = gridView1.GetFocusedRowCellValue("Bank").ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(textCustomerId.Text);
            var result = db.Customers.Find(id);
            db.Customers.Remove(result);
            db.SaveChanges();
            MessageBox.Show("Customer Deleted successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(textCustomerId.Text);
            var customer = db.Customers.Find(id);
            customer.FirstName = textFirstName.Text;
            customer.LastName = textLastName.Text;
            customer.Address = textAddress.Text;
            customer.Bank = textBank.Text;
            customer.Email = textEmail.Text;
            customer.Phone = textPhone.Text;
            customer.Title = textTitle.Text;
            customer.City = lookUpCity.EditValue.ToString();
            var cityInfo = db.Cities.FirstOrDefault(c => c.CityName == lookUpCity.EditValue.ToString());
            customer.Region = cityInfo.StateName;
            customer.PostalCode = cityInfo.PostalCode;
            customer.Country = "Norway";
            db.SaveChanges();
            MessageBox.Show("Customer Updated successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
