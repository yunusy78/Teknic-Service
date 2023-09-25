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
    public partial class NewNotification : Form
    {
        public NewNotification()
        {
            InitializeComponent();
        }
        
        DbTeknicServiceEntities db =new DbTeknicServiceEntities();

        private void btnSave1_Click(object sender, EventArgs e)
        {
            Notifications notifications = new Notifications();
            notifications.NotificationID=Guid.NewGuid();
            notifications.Title = txtTitle.Text;
            notifications.Content= txtContent.Text;
            notifications.Status = txtStatus.Checked;
            db.Notifications.Add(notifications);
            db.SaveChanges();
            MessageBox.Show("Notification added successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
