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
    public partial class UserProfile : Form
    {
        function fn = new function();
        String query;
        Boolean exist = false;

        public UserProfile()
        {
            InitializeComponent();
        }

        int user_fk;
        public UserProfile(int user_fk)
        {
            InitializeComponent();
            this.user_fk = user_fk;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtFather.Text) && !String.IsNullOrEmpty(txtMobile.Text) &&
                    !String.IsNullOrEmpty(txtMother.Text) && !String.IsNullOrEmpty(txtGender.Text) && !String.IsNullOrEmpty(txtDOB.Text))
                {
                    if (!exist)
                    {
                        query = "insert into userDetail (user_fk,uname,fname,mname,dob,mobile,gender) values (" + user_fk + ",'" + txtName.Text + "','" + txtFather.Text + "','" + txtMother.Text + "','" + txtDOB.Text + "'," + Int64.Parse(txtMobile.Text) + ",'" + txtGender.Text + "')";
                        fn.setDate(query);
                    }
                    else
                    {
                        query = "update userDetail set uname='" + txtName.Text + "',fname='" + txtFather.Text + "',mname='" + txtMother.Text + "',dob='" + txtDOB.Text + "',mobile=" + Int64.Parse(txtMobile.Text) + ",gender='" + txtGender.Text + "' where user_fk="+ user_fk + "";
                        fn.setDate(query);
                    }
                }
                else
                {
                    MessageBox.Show("Field is Empty or Null", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Something Went Wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            try
            {
                query = "select * from userDetail where user_fk="+ user_fk + "";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtFather.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtMother.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtMobile.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtGender.Text = ds.Tables[0].Rows[0][7].ToString();
                    txtDOB.Text = ds.Tables[0].Rows[0][5].ToString();
                    exist = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Something Went Wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UserProfile_Load(this,null);
        }
    }
}
