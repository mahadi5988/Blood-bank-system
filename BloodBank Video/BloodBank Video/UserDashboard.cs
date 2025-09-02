using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank_Video
{
    public partial class UserDashboard : Form
    {
        function fn = new function();
        String query;
        public UserDashboard()
        {
            InitializeComponent();
        }

        int userfk;

        public UserDashboard(int i)
        {
            InitializeComponent();
            Console.WriteLine(i);
            userfk = i;
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {

        }

        private void deleteDonorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void donorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserProfile up = new UserProfile(userfk);
            if (Application.OpenForms.OfType<UserProfile>().Count() == 0)
            {
                up.Show();
            }
            else
            {
                MessageBox.Show("Form is alread open.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void ViewAvailableBloodStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            if (Application.OpenForms.OfType<Stock>().Count() == 0)
            {
                stock.Show();
            }
            else
            {
                MessageBox.Show("Form is alread open.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void requestForBloodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select * from userDetail where user_fk="+ userfk + "";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    BloodRequest bloodRequest = new BloodRequest(userfk);
                    if (Application.OpenForms.OfType<BloodRequest>().Count() == 0)
                    {
                        bloodRequest.Show();
                    }
                    else
                    {
                        MessageBox.Show("Form is alread open.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Complete your profile first before requesting for blood.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkRequestStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckRequestStatus crs = new CheckRequestStatus(userfk);
            crs.Show();
        }
    }
}
