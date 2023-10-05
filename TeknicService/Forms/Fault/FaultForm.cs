using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknicService.Forms.Fault
{
    public partial class FaultForm : Form
    {
        public FaultForm()
        {
            InitializeComponent();
        }

        DbTeknicServiceEntities db = new DbTeknicServiceEntities();
        void FaultListMethod()
        {
            var values = from item in db.TeknicService
                         select new
                         {
                             item.ProcessID,
                             Product=item.Products.ProductName,
                             Customer=item.Customers.FirstName + " " + item.Customers.LastName,
                             Employee=item.Employees.FirstName + " " + item.Employees.LastName,
                             item.TheArrivalDate,
                             item.TheReleaseDate

                         };
            gridControl1.DataSource = values.ToList();


        }

        private void FaultForm_Load(object sender, EventArgs e)
        {
            FaultListMethod();
        }
    }
}
