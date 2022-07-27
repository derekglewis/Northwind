using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindDatabaseApp
{
    public partial class formDatabaseViewer : Form
    {
        public formDatabaseViewer()
        {
            InitializeComponent();
        }



        public void getCustomerCount()
        {
          
            string connectionString;
            SqlConnection cnn;
            connectionString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            Int32 count = 0;
            string countQuery = "select count(*) from customers;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);

            try
            {
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            labelCustomerCountResult.Text = count.ToString() + " customer records";
            cnn.Close();
        }

        public void getCompanyNames()
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            string sql, Output = "";
            sql = "select substring(ContactName, charindex(' ', ContactName) + 1, len(ContactName) - charindex" +
                " (' ', ContactName)) as Lastname from Customers Order by Lastname;";
            command = new SqlCommand(sql, cnn);

            try
            {
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Output = Output + dataReader.GetValue(0) + "\r\n";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            textBoxQueryResults.Text = Output;
            cnn.Close();
        }



        private void buttonCustomerCount_Click(object sender, EventArgs e)
        {
            getCustomerCount();
        }

        private void buttonGetCompanyNames_Click(object sender, EventArgs e)
        {
            getCompanyNames();
        }
    }
}
