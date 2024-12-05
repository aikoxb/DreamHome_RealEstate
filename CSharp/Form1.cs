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

        //Occurs when a different tab is changed - The selection panel is visible
        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Make Staff's slection panel visible
            panelUpdateStaff.Visible = false;
            panelHireStaff.Visible = false;
            panelSelectStaffOption.Visible = true;

            //Make Branch's selction panel visible
            panelIdentifyBranchAddress.Visible = false;
            panelUpdateBranch.Visible = false;
            panelOpenBranch.Visible = false;
            panelSelectBranchOption.Visible = true;

            //Make Client's selction panel visible
            panelRegisterClient.Visible = false;
            panelDeleteClient.Visible = false;
            panelClientSelection.Visible = true;
        }

        private void buttonHsClear_Click(object sender, EventArgs e)
        {
            textBoxHsFirstName.Clear();
            textBoxHsLastName.Clear();
            textBoxHsDOB.Clear();
            textBoxHsStaffNo.Clear();
            textBoxHsBranchNo.Clear();
            comboBoxHsSex.SelectedIndex = 0;
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
                char sex = comboBoxHsSex.SelectedItem.ToString()[0];
                string position = textBoxHsPosition.Text;
                decimal salary = decimal.Parse(textBoxHsSalary.Text);
                string telephone = textBoxHsTelephone.Text;
                string mobile = textBoxHsMobile.Text;
                string email = textBoxHsEmail.Text;

                textBoxHsFirstName.Clear();
                textBoxHsLastName.Clear();
                textBoxHsDOB.Clear();
                textBoxHsStaffNo.Clear();
                textBoxHsBranchNo.Clear();
                comboBoxHsSex.SelectedIndex = 0;
                textBoxHsPosition.Clear();
                textBoxHsSalary.Clear();
                textBoxHsTelephone.Clear();
                textBoxHsMobile.Clear();
                textBoxHsEmail.Clear();

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

        //button to go to HireStaff panel from Option screen
        private void buttonSelectHireStaff_Click(object sender, EventArgs e)
        {
            panelHireStaff.Visible = true;
            panelUpdateStaff.Visible = false;
            panelSelectStaffOption.Visible = false;
            comboBoxHsSex.SelectedIndex = 0;
        }

        //button to go to HireStaff panel from UpdateStaff panel
        private void buttonGoToHireStaff_Click(object sender, EventArgs e)
        {
            panelHireStaff.Visible = true;
            panelUpdateStaff.Visible = false;
            panelSelectStaffOption.Visible = false;
            comboBoxHsSex.SelectedIndex = 0;
        }

        //button to go to UpdateStaff panel from Option screen
        private void buttonSelectUpdateStaff_Click(object sender, EventArgs e)
        {
            panelUpdateStaff.Visible = true;
            panelHireStaff.Visible = false;
            panelSelectStaffOption.Visible = false;
        }

        //button to go to UpdateStaff panel from HireStaff panel
        private void buttonGoToUpdateStaff_Click(object sender, EventArgs e)
        {
            panelUpdateStaff.Visible = true;
            panelHireStaff.Visible = false;
            panelSelectStaffOption.Visible = false;
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

        //REPLACE WITH BRANCH TASKS

        private void buttonSelectIdentifyBranchAddress_Click(object sender, EventArgs e)
        {
            panelIdentifyBranchAddress.Visible = true;
            panelUpdateBranch.Visible = false;
            panelOpenBranch.Visible = false;
            panelSelectBranchOption.Visible = false;
        }

        private void buttonSelectUpdateBranch_Click(object sender, EventArgs e)
        {
            panelIdentifyBranchAddress.Visible = false;
            panelUpdateBranch.Visible = true;
            panelOpenBranch.Visible = false;
            panelSelectBranchOption.Visible = false;
        }

        private void buttonSelectOpenBranch_Click(object sender, EventArgs e)
        {
            panelIdentifyBranchAddress.Visible = false;
            panelUpdateBranch.Visible = false;
            panelOpenBranch.Visible = true;
            panelSelectBranchOption.Visible = false;
        }

        private void buttonGoToUpdateBranchFromIdentifyBranch_Click(object sender, EventArgs e)
        {
            panelIdentifyBranchAddress.Visible = false;
            panelUpdateBranch.Visible = true;
            panelOpenBranch.Visible = false;
            panelSelectBranchOption.Visible = false;
        }

        private void buttonGoToOpenBranchFromIdentifyBranch_Click(object sender, EventArgs e)
        {
            panelIdentifyBranchAddress.Visible = false;
            panelUpdateBranch.Visible = false;
            panelOpenBranch.Visible = true;
            panelSelectBranchOption.Visible = false;
        }

        private void buttonGoToIdentifyBranchAddressFromUpdateBranch_Click(object sender, EventArgs e)
        {
            panelIdentifyBranchAddress.Visible = true;
            panelUpdateBranch.Visible = false;
            panelOpenBranch.Visible = false;
            panelSelectBranchOption.Visible = false;
        }

        private void buttonGoToOpenBranchFromUpdateBranch_Click(object sender, EventArgs e)
        {
            panelIdentifyBranchAddress.Visible = false;
            panelUpdateBranch.Visible = false;
            panelOpenBranch.Visible = true;
            panelSelectBranchOption.Visible = false;
        }

        private void buttonGoToIdentifyBranchFromOpenBranch_Click(object sender, EventArgs e)
        {
            panelIdentifyBranchAddress.Visible = true;
            panelUpdateBranch.Visible = false;
            panelOpenBranch.Visible = false;
            panelSelectBranchOption.Visible = false;
        }

        private void buttonGoToUpdateBranchFromOpenBranch_Click(object sender, EventArgs e)
        {
            panelIdentifyBranchAddress.Visible = false;
            panelUpdateBranch.Visible = true;
            panelOpenBranch.Visible = false;
            panelSelectBranchOption.Visible = false;
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

        private void buttonIbSubmitBranchNo_Click(object sender, EventArgs e)
        {
            try
            {
                string branchNo = textBoxUbEnterBranchNo.Text;

                if (string.IsNullOrEmpty(branchNo))
                {
                    MessageBox.Show("Please enter a branch number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string address = dbManager.GetBranchAddress(branchNo);

                // Display the result
                textBoxUbBranchAddress.Text = address;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error finding branch address: {ex.Message}");
            }
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

        //When "Register Client" button is clicked, the client information that the user inputted gets stored in the database
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

        //Occurs user clicks cancel in register client page
        private void btnCancelRegisterClient_Click(object sender, EventArgs e)
        {
            ClearControlsClient(); //Clears text fields
        }

        //When delete button in client panel is clicked, the record according to the client number is deleted
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

        //When button to select register client is clicked, register client panel becomes visible
        private void btnSelectRegisterClient_Click(object sender, EventArgs e)
        {
            //Visibility of client menu panels
            panelRegisterClient.Visible = true;
            panelDeleteClient.Visible = false;
            panelClientSelection.Visible = false;
        }

        //When button to select delete client is clicked, delete client panel becomes visible
        private void btnSelectDeleteClient_Click(object sender, EventArgs e)
        {
            //Visibility of client menu panels
            panelRegisterClient.Visible = false;
            panelDeleteClient.Visible = true;
            panelClientSelection.Visible = false;
        }

        //When button to go to register client is clicked, register client panel becomes visible
        private void btnGoToRegisterClient_Click(object sender, EventArgs e)
        {
            //Visibility of client menu panels
            panelRegisterClient.Visible = true;
            panelDeleteClient.Visible = false;
            panelClientSelection.Visible = false;
        }

        //When button to go to delete client is clicked, delete client panel becomes visible
        private void btnGoToDeleteClient_Click(object sender, EventArgs e)
        {
            //Visibility of client menu panels
            panelRegisterClient.Visible = false;
            panelDeleteClient.Visible = true;
            panelClientSelection.Visible = false;
        }

    }
}
