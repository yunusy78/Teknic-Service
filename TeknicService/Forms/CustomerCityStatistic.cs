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
    public partial class CustomerCityStatistic : Form
    {
        public CustomerCityStatistic()
        {
            InitializeComponent();
        }
        DbTeknicServiceEntities db = new DbTeknicServiceEntities();
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerCityStatistic_Load(object sender, EventArgs e)
        {
            var cityCounts = db.Customers.GroupBy(p => p.City).Select(group => new { City = group.Key, Count = group.Count() }).OrderByDescending(item => item.Count).ToList();
            foreach (var cityCount in cityCounts)
            {
                chartControl1.Series["Series 1"].Points.AddPoint(cityCount.City, cityCount.Count);
            }

            gridControl1.DataSource = db.Customers.OrderBy(x => x.City).GroupBy(y => y.City).Select(z => new { City = z.Key,Total=z.Count()}).ToList();
        }
    }
}
