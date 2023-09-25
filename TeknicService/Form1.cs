using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknicService
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RibbonForm1_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.ProductList fr = new Forms.ProductList();
            fr.MdiParent = this;
            fr.Show();

        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.CustomerCityStatistic fr = new Forms.CustomerCityStatistic();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.NewProduct fr = new Forms.NewProduct();
            fr.Show();
        }

        private void btnCategoryList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.CategoryList fr = new Forms.CategoryList();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnNewCategory_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.NewCategory newCategory = new Forms.NewCategory();
            newCategory.Show();
        }

        private void btnProductChart_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.ProductCharts fr = new Forms.ProductCharts();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnBrandChart_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.BrandForm fr = new Forms.BrandForm();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.CustomerForm fr = new Forms.CustomerForm();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem4_ItemClick_1(object sender, ItemClickEventArgs e)
        {
           
            Forms.NewCustomer customer = new Forms.NewCustomer();
            customer.Show();
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.DepartmentForm department = new Forms.DepartmentForm();
            department.MdiParent = this;
            department.Show();
        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.NewDepartment department =new Forms.NewDepartment();
            department.Show();
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.EmployeeForm employee = new Forms.EmployeeForm();
            employee.MdiParent = this;
            employee.Show();
        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.NewEmployee newEmployee = new Forms.NewEmployee();
            newEmployee.Show();
        }

        private void btnCalculator_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void btnCurrency_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.CurrencyForm currency = new Forms.CurrencyForm();
            currency.MdiParent=this;
            currency.Show();
        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.NewsletterForm currency = new Forms.NewsletterForm();
            currency.MdiParent = this;
            currency.Show();
        }

        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void barButtonItem33_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Tools.NotificationForm notification = new Forms.Tools.NotificationForm();
            notification.MdiParent = this;
            notification.Show();
        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Tools.NewNotification newNotification = new Forms.Tools.NewNotification();
            newNotification.Show();
        }
    }
}