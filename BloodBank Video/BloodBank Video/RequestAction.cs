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
    public partial class RequestAction : Form
    {
        function fn = new function();
        String query;

        public RequestAction()
        {
            InitializeComponent();
        }

        int bloodreq_id;
        int user_fk;
        String bloodgroup;
        String requiredunit;
        String reqdate;
        String status;
        String reason;

        public RequestAction(int bloodreq_id,int user_fk,String bloodgroup,String requiredunit,String reqdate,String status,String reason)
        {
            InitializeComponent();
            this.bloodreq_id = bloodreq_id;
            this.user_fk = user_fk;
            this.bloodgroup = bloodgroup;
            this.requiredunit = requiredunit;
            this.reqdate = reqdate;
            this.status = status;
            this.reason = reason;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            BloodRequestsForApproval brfa = new BloodRequestsForApproval();
            brfa.Show();
        }

        private void RequestAction_Load(object sender, EventArgs e)
        {
            labelReason.Visible = false;
            txtReason.Visible = false;

            txtBloodGroup.Text = bloodgroup;
            txtRequestedDate.Text = reqdate;
            txtRequired.Text = requiredunit;
            txtStatus.Text = status;
            txtReason.Text = reason;
        }

        private void txtStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtStatus.SelectedIndex == 1)
            {
                labelReason.Visible = false;
                txtReason.Visible = false;
             }
            else if(txtStatus.SelectedIndex == 2)
            {
                labelReason.Visible = true;
                txtReason.Visible = true;
            }
            else
            {
                labelReason.Visible = false;
                txtReason.Visible = false;
            }
        }

        private void btnCheckBloodStock_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.Show();
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select count(*) from stock where blood_group='"+bloodgroup+"' and quantity>="+requiredunit+"";
                DataSet ds = fn.getData(query);
                if (int.Parse(ds.Tables[0].Rows[0][0].ToString()) == 1)
                {
                    query = "update bloodRequest set status='" + txtStatus.Text + "', reason='" + txtReason.Text + "' where bloodreq_id=" + bloodreq_id + "";
                    fn.setDate(query);
                    if(txtStatus.Text.Equals("Approved"))
                    {
                        query = "update stock set quantity=quantity-"+requiredunit+" where blood_group='"+bloodgroup+"'";
                        fn.setDateWithoutMessage(query);
                    }
                }
                else
                {
                    MessageBox.Show("Blood is out of Stock.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Something Went Wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
