using DevExpress.Utils.Html.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknicService.Forms.Order
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        DbTeknicServiceEntities db = new DbTeknicServiceEntities();
        void OrderMethod()
        {
           var values = from x in db.ProductMovement
            select new
            {
                x.MovementID,
                Product = x.Products.ProductName,
                Customer = x.Customers.FirstName + " " + x.Customers.LastName,
                Employee = x.Employees.FirstName + " " + x.Employees.LastName,
                x.MovementType,
                x.MovementDate,
                x.Quantity,
                x.Price

            };
            gridControl1.DataSource = values.ToList();
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
           
            var productCounts = db.ProductMovement.GroupBy(p => p.Products.ProductName).Select(group => new { Product = group.Key, Count = group.Count() }).OrderByDescending(item => item.Count).ToList();
            foreach (var productCount in productCounts)
            {
                chartControl1.Series["Series 1"].Points.AddPoint(productCount.Product, productCount.Count);
            }


            var employeeCounts = db.ProductMovement.GroupBy(p => p.EmployeeID) // Employee göre grupla
           .Select(group => new { EmployeeId = group.Key, Count = group.Count() }) // Her kategorinin ürün sayısını hesapla
           .OrderByDescending(item => item.Count)
           .ToList();

            foreach (var employeeCount in employeeCounts)
            {
                var employeeName = db.Employees.FirstOrDefault(c => c.EmployeeID == employeeCount.EmployeeId).FirstName + " " + db.Employees.FirstOrDefault(c => c.EmployeeID == employeeCount.EmployeeId).LastName; // Kategori adını al
                chartControl2.Series["Series 1"].Points.AddPoint(employeeName, employeeCount.Count);
            }

            OrderMethod();

            labelControl1.Text = (from x in db.ProductMovement select x.Price).Sum().ToString();
            labelControl43.Text = db.ProductMovement.Count().ToString();
            var mostCommonProduct = db.ProductMovement.GroupBy(p => p.Products.ProductName).Select(group => new { Product = group.Key, Count = group.Count() }).OrderByDescending(item => item.Count).FirstOrDefault();
            labelControl3.Text = mostCommonProduct.Product;
            var mostCommonEmployee = db.ProductMovement
             .GroupBy(p => new { p.Employees.FirstName, p.Employees.LastName })
          .Select(group => new { Employee = group.Key.FirstName + " " + group.Key.LastName, Count = group.Count() })
          .OrderByDescending(item => item.Count)
           .FirstOrDefault();

            labelControl5.Text = mostCommonEmployee?.Employee;


        }
    }
}
