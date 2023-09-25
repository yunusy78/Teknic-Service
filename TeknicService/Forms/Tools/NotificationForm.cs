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

namespace TeknicService.Forms.Tools
{
    public partial class NotificationForm : Form
    {
        public NotificationForm()
        {
            InitializeComponent();
        }

        DbTeknicServiceEntities db = new DbTeknicServiceEntities();
        private void NotificationForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource =db.Notifications.Where(x=>x.Status==false).ToList();
            gridControl2.DataSource=db.Notifications.Where(x=> x.Status==true).ToList();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Notifications notifications = new Notifications();
            notifications.NotificationID=Guid.NewGuid();
            notifications.Status = checkEdit1.Checked;
            notifications.Title = textTitle.Text;
            notifications.Content=richTextBoxContent.Text;
            db.Notifications.Add(notifications);
            db.SaveChanges();
            MessageBox.Show("Notification added successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.Notifications.Where(x => x.Status == false).ToList();
            gridControl2.DataSource = db.Notifications.Where(x => x.Status == true).ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textNotificationId.Text = gridView1.GetFocusedRowCellValue("NotificationID").ToString();
            textTitle.Text=gridView1.GetFocusedRowCellValue("Title").ToString();
            richTextBoxContent.Text=gridView1.GetFocusedRowCellValue("Content").ToString();
            checkEdit1.Checked = (bool)gridView1.GetFocusedRowCellValue("Status");

        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textNotificationId.Text = gridView2.GetFocusedRowCellValue("NotificationID").ToString();
            textTitle.Text = gridView2.GetFocusedRowCellValue("Title").ToString();
            richTextBoxContent.Text = gridView2.GetFocusedRowCellValue("Content").ToString();
            checkEdit1.Checked = (bool)gridView2.GetFocusedRowCellValue("Status");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(textNotificationId.Text);
            var result = db.Notifications.Find(id);
            db.Notifications.Remove(result);
            db.SaveChanges();
            MessageBox.Show("The Notification Deleted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(textNotificationId.Text);
            var result = db.Notifications.Find(id);
            result.Title = textTitle.Text;
            result.Content = richTextBoxContent.Text;
            result.Status = checkEdit1.Checked;
            db.SaveChanges();
            MessageBox.Show("The Notification Updated successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
