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
    public partial class CheckRequestStatus : Form
    {
        function fn = new function();
        String query;
        public CheckRequestStatus()
        {
            InitializeComponent();
        }

        int user_fk;
        public CheckRequestStatus(int user_fk)
        {
            InitializeComponent();
            this.user_fk = user_fk;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckRequestStatus_Load(object sender, EventArgs e)
        {
            query = "select bloodgroup,requiredunit,reqdate,status,reason from bloodRequest where user_fk=" + user_fk+"";
            DataSet ds = fn.getData(query);

            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
