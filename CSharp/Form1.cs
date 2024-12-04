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
            /**
            //Load the SQL query from SQL file for Staff, Branch and Client tables
            string queryStaff = dbManager.LoadQueryFromFile("get_staff_data.sql");
            string queryBranch = dbManager.LoadQueryFromFile("get_branch_data.sql");
            string queryClient = dbManager.LoadQueryFromFile("get_client_data.sql");

            //Display Staff, Branch and Client table in according DataGridView by executing the queries loaded
            dataGridViewStaff.DataSource = dbManager.ExecuteQuery(queryStaff);
            dataGridViewBranch.DataSource = dbManager.ExecuteQuery(queryBranch);
            dataGridViewClient.DataSource = dbManager.ExecuteQuery(queryClient);**/
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
                MessageBox.Show($"Error with registering or updating Client data:\n {ex.Message}");
            }
        }

        //Occurs when user clicks cancel in register client page
        private void btnCancelRegisterClient_Click(object sender, EventArgs e)
        {
            ClearControlsClient(); //Clears text fields
        }

        //Method - Clears controls for Client form so that previous information won't affect new actions
        public void ClearControlsClient()
        {
            //Clears all textboxes
            txtClientNo.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtTelephoneNo.Text = "";
            txtStreet.Text = "";
            txtCity.Text = "";
            txtEmail.Text = "";
            txtPreferenceType.Text = "";
            txtMaxRent.Text = "";
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                //Get user inputs from the Client No field
                string clientNo = txtDeleteByClientNo.Text;

                //Use list of the OracleParameter objects to pass parameter to the stored procedure
                List<OracleParameter> parameters = new List<OracleParameter>
                { new OracleParameter("p_clientno", clientNo) };

                //Execute the register client stored procedure
                dbManager.ExecuteStoredProcedure("delete_client_sp", parameters);

                //Show success message
                MessageBox.Show("Client deleted successfully.");

                //Load the SQL query from SQL file for Client Table
                string query = dbManager.LoadQueryFromFile("get_client_data.sql");

                //Display updated client table in DataGridView by executing the query loaded
                dataGridViewClient.DataSource = dbManager.ExecuteQuery(query);
            }
            //Handle any errors that occur during registration or displaying the table
            catch (Exception ex)
            {
                //Output exception message
                MessageBox.Show($"Error with deleting or updating Client data:\n {ex.Message}");
            }
        }

        //Occurs when button to select register client page is clicked
        private void btnSelectRegisterClient_Click(object sender, EventArgs e)
        {
            //Visibility of panels dependent on if the user wants to register or delete a client
            panelRegisterClient.Visible = true;
            panelDeleteClient.Visible = false;
            panelClientSelection.Visible = false;
        }

        //Occurs when button to select delete client page is clicked
        private void btnSelectDeleteClient_Click(object sender, EventArgs e)
        {
            //Visibility of panels dependent on if the user wants to register or delete a client
            panelRegisterClient.Visible = false;
            panelDeleteClient.Visible = true;
            panelClientSelection.Visible = false;
        }

        //Occurs when button to gp to register client page is clicked
        private void btnGoToRegisterClient_Click(object sender, EventArgs e)
        {
            //Visibility of panels dependent on if the user wants to register or delete a client
            panelRegisterClient.Visible = true;
            panelDeleteClient.Visible = false;
            panelClientSelection.Visible = false;
        }

        //Occurs when button to go to delete client page is clicked
        private void btnGoToDeleteClient_Click(object sender, EventArgs e)
        {
            //Visibility of panels dependent on if the user wants to register or delete a client
            panelRegisterClient.Visible = false;
            panelDeleteClient.Visible = true;
            panelClientSelection.Visible = false;
        }

        private void buttonHsClear_Click(object sender, EventArgs e)
        {
            textBoxHsFirstName.Clear();
            textBoxHsLastName.Clear();
            textBoxHsDOB.Clear();
            textBoxHsStaffNo.Clear();
            textBoxHsBranchNo.Clear();
            textBoxHsSex.Clear();
            textBoxHsPosition.Clear();
            textBoxHsSalary.Clear();
            textBoxHsTelephone.Clear();
            textBoxHsMobile.Clear();
            textBoxHsEmail.Clear();
        }

        private void buttonHsHire_Click(object sender, EventArgs e)
        {
            try
            {
                //Get user inputs from the form's fields
                string firstName = textBoxHsFirstName.Text;
                string lastName = textBoxHsLastName.Text;
                DateTime dob = DateTime.Parse(textBoxHsDOB.Text);
                string staffNo = textBoxHsStaffNo.Text;
                string branchNo = textBoxHsBranchNo.Text;
                char sex = textBoxHsSex.Text[0];
                string position = textBoxHsPosition.Text;
                decimal salary = decimal.Parse(textBoxHsSalary.Text);
                string telephone = textBoxHsTelephone.Text;
                string mobile = textBoxHsMobile.Text;
                string email = textBoxHsEmail.Text;

                //Create list of OracleParameter objects to pass to the stored procedure
                List<OracleParameter> parameters = new List<OracleParameter>
                {
                new OracleParameter("p_staffno", staffNo), new OracleParameter("p_fname", firstName),
                new OracleParameter("p_lname", lastName), new OracleParameter("p_position", position),
                new OracleParameter("p_sex", sex), new OracleParameter("p_dob", dob),
                new OracleParameter("p_salary", salary), new OracleParameter("p_branchno", branchNo),
                new OracleParameter("p_telephone", telephone), new OracleParameter("p_mobile", mobile),
                new OracleParameter("p_email", email)
                };

                //Execute the register client stored procedure
                dbManager.ExecuteStoredProcedure("staff_hire_sp", parameters);

                //Show success message
                MessageBox.Show("Staff hired successfully.");

                //Load the SQL query from SQL file for Client Table
                string query = dbManager.LoadQueryFromFile("get_staff_data.sql");

                //Display updated client table in DataGridView by executing the query loaded
                dataGridViewStaff.DataSource = dbManager.ExecuteQuery(query);
            }
            //Handle any errors that occur during registration or displaying the table
            catch (Exception ex)
            {
                //Output exception message
                MessageBox.Show($"Error with hiring or updating Staff data:\n {ex.Message}");
            }
        }

        //button to go to UpdateStaff panel from HireStaff panel
        private void buttonGoToUpdateStaff_Click(object sender, EventArgs e)
        {
            panelUpdateStaff.Visible = true;
            panelHireStaff.Visible = false;
            panelSelectStaffOption.Visible = false;
        }

        //button to go to HireStaff panel from UpdateStaff panel
        private void buttonGoToHireStaff_Click(object sender, EventArgs e)
        {
            panelHireStaff.Visible = true;
            panelUpdateStaff.Visible = false;
            panelSelectStaffOption.Visible = false;
        }

        //button to go to HireStaff panel from Option screen
        private void buttonSelectHireStaff_Click(object sender, EventArgs e)
        {
            panelHireStaff.Visible = true;
            panelUpdateStaff.Visible = false;
            panelSelectStaffOption.Visible = false;
        }

        //button to go to UpdateStaff panel from Option screen
        private void buttonSelectUpdateStaff_Click(object sender, EventArgs e)
        {
            panelUpdateStaff.Visible = true;
            panelHireStaff.Visible = false;
            panelSelectStaffOption.Visible = false;
        }
    }
}
