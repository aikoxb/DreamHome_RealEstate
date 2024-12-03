using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp
{
    public partial class Form1 : Form
    {

        private DatabaseManager dbManager;
        public Form1()
        {
            InitializeComponent();

            dbManager = new DatabaseManager();
        }

        private void buttonLoadStaff_Click(object sender, EventArgs e)
        {
            try
            {
                //load the SQL query for staff
                string query = dbManager.LoadQueryFromFile("staff.sql");

                //execute the query and display the data in the DataGridView
                dataGridViewStaff.DataSource = dbManager.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading Staff data: {ex.Message}");
            }
        }

        private void buttonLoadBranch_Click(object sender, EventArgs e)
        {
            try
            {
                //load the SQL query for branch
                string query = dbManager.LoadQueryFromFile("branch.sql");

                //execute the query and display the data in the DataGridView
                dataGridViewBranch.DataSource = dbManager.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading Branch data: {ex.Message}");
            }
        }

        private void buttonLoadClient_Click(object sender, EventArgs e)
        {
            try
            {
                //load the SQL query for client
                string query = dbManager.LoadQueryFromFile("client.sql");

                //execute the query and display the data in the DataGridView
                dataGridViewClient.DataSource = dbManager.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading Client data: {ex.Message}");
            }
        }
    }
}
