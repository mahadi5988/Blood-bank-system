using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank_Video
{
    class function
    {
        
        protected SqlConnection getConnection()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-P4I5NJ1;database = bloodbank;integrated security =True";
                return con;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new SqlConnection();
        }

        public DataSet getData(String query)  //Get data form database
        {
            try
            {
                SqlConnection con = getConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch(SqlException sq)
            {
                Console.WriteLine(sq);
                MessageBox.Show("Something went wrong while performing database operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new DataSet();
        }

        public void setDate(String query) // Insertion Deletion Updation
        {
            try
            {
                SqlConnection con = getConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Processed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setDateWithoutMessage(String query)
        {
            try
            {
                SqlConnection con = getConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
