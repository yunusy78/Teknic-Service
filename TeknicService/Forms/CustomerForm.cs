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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
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
    }
}
