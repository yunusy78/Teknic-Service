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
    public partial class NewOrder : Form
    {
        public NewOrder()
        {
            InitializeComponent();
        }
        
        DbTeknicServiceEntities db = new DbTeknicServiceEntities();

        private void lookUpProduct_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            lookUpProduct.Properties.DataSource = db.Products.Select(x => new
            {
                ProductId = x.ProductID,
                ProductName = x.ProductName,
                Price=x.UnitPrice
            }).ToList();

            lookUpCustomer.Properties.DataSource = db.Customers.Select(x => new
            {
                CustomerId = x.CustomerID,
                CustomerName = x.FirstName + " " + x.LastName,
            }).ToList();

            lookUpEmployee.Properties.DataSource = db.Employees.Select(x => new
            {
                EmployeeId = x.EmployeeID,
                EmployeeName = x.FirstName + " " + x.LastName
            }).ToList();
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            ProductMovement productMovement = new ProductMovement();

            productMovement.MovementID = Guid.NewGuid();
            productMovement.ProductID =Guid.Parse( lookUpProduct.EditValue.ToString());
            productMovement.CustomerID=Guid.Parse( lookUpCustomer.EditValue.ToString());
            productMovement.EmployeeID=Guid.Parse(lookUpEmployee.EditValue.ToString());
            productMovement.MovementType = textType.Text;
            productMovement.MovementDate= DateTime.Now;
            productMovement.Quantity=short.Parse(txtquantity.Text);
            var product = db.Products.Find(Guid.Parse(lookUpProduct.EditValue.ToString()));
            productMovement.Price = (decimal)(short.Parse(txtquantity.Text) * product.UnitPrice);
            db.ProductMovement.Add(productMovement);
            db.SaveChanges();
            MessageBox.Show("Order added successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
