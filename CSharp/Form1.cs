using Oracle.ManagedDataAccess.Client;
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

            //Load the SQL query from SQL file for Staff, Branch and Client tables
            string queryStaff = dbManager.LoadQueryFromFile("get_staff_data.sql");
            string queryBranch = dbManager.LoadQueryFromFile("get_branch_data.sql");
            string queryClient = dbManager.LoadQueryFromFile("get_client_data.sql");

            //Display Staff, Branch and Client table in according DataGridView by executing the queries loaded
            dataGridViewStaff.DataSource = dbManager.ExecuteQuery(queryStaff);
            dataGridViewBranch.DataSource = dbManager.ExecuteQuery(queryBranch);
            dataGridViewClient.DataSource = dbManager.ExecuteQuery(queryClient);
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

        //Occurs when "Register Client" button is clicked
        private void btnRegisterClient_Click(object sender, EventArgs e)
        {
            try
            {
                //Get user inputs from the form's fields
                string clientNo = txtClientNo.Text;
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;        
                string telephoneNo = txtTelephoneNo.Text;
                string street = txtStreet.Text;
                string city = txtCity.Text;
                string email = txtEmail.Text;
                string preferenceType = txtPreferenceType.Text;
                int maxRent = Convert.ToInt32(txtMaxRent.Text);

                //Create list of OracleParameter objects to pass to the stored procedure
                List<OracleParameter> parameters = new List<OracleParameter>
                { 
                new OracleParameter("p_clientno", clientNo), new OracleParameter("p_fname", firstName),
                new OracleParameter("p_lname", lastName), new OracleParameter("p_telno", telephoneNo),          
                new OracleParameter("p_street", street), new OracleParameter("p_city", city),
                new OracleParameter("p_email", email), new OracleParameter("p_preftype", preferenceType),
                new OracleParameter("p_maxrent", maxRent)
                };

                //Execute the register client stored procedure
                dbManager.ExecuteStoredProcedure("client_register_sp", parameters);

                //Show success message
                MessageBox.Show("Client registered successfully.");

                //Load the SQL query from SQL file for Client Table
                string query = dbManager.LoadQueryFromFile("get_client_data.sql");

                //Display updated client table in DataGridView by executing the query loaded
                dataGridViewClient.DataSource = dbManager.ExecuteQuery(query);
            }
            //Handle any errors that occur during registration or displaying the table
            catch (Exception ex)
            {
                //Output exception message
                MessageBox.Show($"Error with registering or loading Client data:\n {ex.Message}");
            }
        }

        private void buttonHireStaffHire_Click(object sender, EventArgs e)
        {
            
        }

    }
}

