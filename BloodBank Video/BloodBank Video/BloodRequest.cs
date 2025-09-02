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
    public partial class BloodRequest : Form
    {
        function fn = new function();
        String query;

        public BloodRequest()
        {
            InitializeComponent();
        }

        int user_fk;
        public BloodRequest(int user_fk)
        {
            InitializeComponent();
            this.user_fk = user_fk;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRequestForBlood_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select count(*) from stock where blood_group='" + txtBloodGroup.Text + "' and quantity>=" + txtUnits.Text + "";
                DataSet ds = fn.getData(query);
                if (int.Parse(ds.Tables[0].Rows[0][0].ToString()) == 1)
                {
                    query = "insert into bloodRequest (user_fk,bloodgroup,requiredunit,reqdate,status) values (" + user_fk + ",'" + txtBloodGroup.Text + "','" + txtUnits.Text + "',GETDATE(),'Requested')";
                    fn.setDate(query);
                }
                else
                {
                    MessageBox.Show("Required Unit not available in Stock.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Something Went Wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
