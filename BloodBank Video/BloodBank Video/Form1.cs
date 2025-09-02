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
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHideShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btnHideShow.Text == "Show")
            {
                btnHideShow.Text = "Hide";
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                btnHideShow.Text = "Show";
                txtPassword.PasswordChar = '*';
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtUsername.Text) && !String.IsNullOrEmpty(txtPassword.Text))
            {
                query = "select * from UserRegistration where username='" + txtUsername.Text + "' and userpassword='" + txtPassword.Text + "'";
                DataSet ds = fn.getData(query);

                if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
                {
                    Dashboard db = new Dashboard();
                    db.Show();
                    this.Hide();
                }
                else if (ds.Tables[0].Rows.Count>0 && ds.Tables[0].Rows[0][1].Equals(txtUsername.Text) && ds.Tables[0].Rows[0][2].Equals(txtPassword.Text))
                {
                    UserDashboard ud = new UserDashboard(int.Parse(ds.Tables[0].Rows[0][0].ToString()));
                    ud.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Enter Valid Username OR Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Field is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserRegistration ur = new UserRegistration();
            this.Hide();
            ur.Show();
        }
    }
}
