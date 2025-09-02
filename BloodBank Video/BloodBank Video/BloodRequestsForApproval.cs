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
    public partial class BloodRequestsForApproval : Form
    {
        function fn = new function();
        String query;
        public BloodRequestsForApproval()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BloodRequestsForApproval_Load(object sender, EventArgs e)
        {
            query = "select * from bloodRequest order by reqdate desc";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (row.Cells[5].Value.ToString() == "Requested")
            {
                this.Hide();
                RequestAction ra = new RequestAction(int.Parse(row.Cells[0].Value.ToString()), int.Parse(row.Cells[1].Value.ToString()), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString());
                ra.Show();
            }
            else
            {
                MessageBox.Show("Already Processed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
