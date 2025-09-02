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
    public partial class UserRegistration : Form
    {
        function fn = new function();
        String query;
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try {
                if(!String.IsNullOrEmpty(txtUsername.Text) && !String.IsNullOrEmpty(txtPassword.Text) && !String.IsNullOrEmpty(txtConfirmPassword.Text))
                {
                    if (txtPassword.Text == txtConfirmPassword.Text)
                    {
                        query = "select username from UserRegistration where username='" + txtUsername.Text + "'";
                        DataSet ds = fn.getData(query);
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            query = "insert into UserRegistration (username,userpassword) values ('" + txtUsername.Text + "','" + txtPassword.Text + "')";
                            fn.setDate(query);
                        }
                        else
                            MessageBox.Show("Username Already Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Password doesnt match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Fields are Null or Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Something Went Wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
