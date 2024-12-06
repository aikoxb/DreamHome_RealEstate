using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

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

            //Loads Client No for user to delete during selection
            LoadClientNo();
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

        //STAFF TASKS

        //button to go to HireStaff panel from Option screen
        private void buttonSelectHireStaff_Click(object sender, EventArgs e)
        {
            panelHireStaff.Visible = true;
            panelUpdateStaff.Visible = false;
            panelSelectStaffOption.Visible = false;
            comboBoxHsSex.SelectedIndex = 0;

            PopulateBranchDropDownInHireStaff();
        }

        //button to go to HireStaff panel from UpdateStaff panel
        private void buttonGoToHireStaff_Click(object sender, EventArgs e)
        {
            panelHireStaff.Visible = true;
            panelUpdateStaff.Visible = false;
            panelSelectStaffOption.Visible = false;
            comboBoxHsSex.SelectedIndex = 0;

            PopulateBranchDropDownInHireStaff();
        }

        //button to go to UpdateStaff panel from Option screen
        private void buttonSelectUpdateStaff_Click(object sender, EventArgs e)
        {
            panelUpdateStaff.Visible = true;
            panelHireStaff.Visible = false;
            panelSelectStaffOption.Visible = false;

            LoadUpdateStaffData();
            PopulateUpdateStaffDropdown();
        }

        //button to go to UpdateStaff panel from HireStaff panel
        private void buttonGoToUpdateStaff_Click(object sender, EventArgs e)
        {
            panelUpdateStaff.Visible = true;
            panelHireStaff.Visible = false;
            panelSelectStaffOption.Visible = false;

            LoadUpdateStaffData();
            PopulateUpdateStaffDropdown();
        }

        private void PopulateBranchDropDownInHireStaff()
        {
            try
            {
                string branchDropdown = dbManager.LoadQueryFromFile("fetch_branchNo.sql");

                DataTable branchData = dbManager.ExecuteQuery(branchDropdown);

                //clear the ComboBox to avoid duplicate rows
                comboBoxHsBranchNo.Items.Clear();

                comboBoxHsBranchNo.Items.Add("Select One");

                foreach (DataRow row in branchData.Rows)
                {
                    comboBoxHsBranchNo.Items.Add(row["branchno"].ToString());
                }

                //display "Select One" automatically
                comboBoxHsBranchNo.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading branch numbers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHsClear_Click(object sender, EventArgs e)
        {
            textBoxHsFirstName.Clear();
            textBoxHsLastName.Clear();
            textBoxHsDOB.Clear();
            textBoxHsStaffNo.Clear();
            comboBoxHsBranchNo.SelectedIndex = 0;
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
                string branchNo = comboBoxHsBranchNo.SelectedItem.ToString();
                string sex = comboBoxHsSex.SelectedItem.ToString();
                string position = textBoxHsPosition.Text;
                decimal salary = decimal.Parse(textBoxHsSalary.Text);
                string telephone = textBoxHsTelephone.Text;
                string mobile = textBoxHsMobile.Text;
                string email = textBoxHsEmail.Text;

                textBoxHsFirstName.Clear();
                textBoxHsLastName.Clear();
                textBoxHsDOB.Clear();
                textBoxHsStaffNo.Clear();
                comboBoxHsBranchNo.SelectedIndex = 0;
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

                //Execute the register staff stored procedure
                dbManager.ExecuteStoredProcedure("staff_hire_sp", parameters);

                //Show success message
                MessageBox.Show("Staff hired successfully.");

                //Load the SQL query from SQL file for staff Table
                string query = dbManager.LoadQueryFromFile("get_staff_data.sql");

                //Display updated staff table in DataGridView by executing the query loaded
                dataGridViewStaff.DataSource = dbManager.ExecuteQuery(query);
            }
            //Handle any errors that occur during registration or displaying the table
            catch (Exception ex)
            {
                //Output exception message
                MessageBox.Show($"Error with hiring or updating Staff data:\n {ex.Message}");
            }
        }

        private void LoadUpdateStaffData()
        {

            string queryUpdateStaff = dbManager.LoadQueryFromFile("fetch_editable_staff_data.sql");
            dataGridViewUpdateStaff.DataSource = dbManager.ExecuteQuery(queryUpdateStaff);
            
            dataGridViewUpdateStaff.ReadOnly = false;
            dataGridViewUpdateStaff.AllowUserToAddRows = false;
            dataGridViewUpdateStaff.AllowUserToDeleteRows = false;
            dataGridViewUpdateStaff.SelectionMode = DataGridViewSelectionMode.CellSelect;

            //only allow editing of specific columns
            ConfigureUpdateStaffDataGridView();
            
        }

        private void PopulateUpdateStaffDropdown()
        {
            string queryStaffDropdown = "SELECT staffno, fname || ' ' || lname AS fullname FROM dh_staff";

            DataTable staffData = dbManager.ExecuteQuery(queryStaffDropdown);

            //clear the dropdown menu and add a "Show All" option
            comboBoxUsSelectStaffToUpdate.Items.Clear();
            comboBoxUsSelectStaffToUpdate.Items.Add("Show All");

            //also add each staff number and name to the dropdown
            foreach (DataRow row in staffData.Rows)
            {
                comboBoxUsSelectStaffToUpdate.Items.Add($"{row["staffno"]}: {row["fullname"]}");
            }

            //make "Show All" the default selection of the dropdown
            comboBoxUsSelectStaffToUpdate.SelectedIndex = 0;
        }

        private void comboBoxUsSelectStaffToUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUsSelectStaffToUpdate.SelectedIndex == 0) //show all option
            {
                LoadUpdateStaffData();
            }
            else
            {
                //get the selected staff number from the ComboBox
                string selectedStaff = comboBoxUsSelectStaffToUpdate.SelectedItem.ToString();
                string staffNo = selectedStaff.Split(':')[0];

                //filter the table to get only the row of the selected staff number
                string queryFilteredStaff = dbManager.LoadQueryFromFile("filter_staff.sql");

                queryFilteredStaff = queryFilteredStaff.Replace("{staffno}", staffNo);

                //load the filtered table 
                dataGridViewUpdateStaff.DataSource = dbManager.ExecuteQuery(queryFilteredStaff);

                // Allow editing only for specific columns
                ConfigureUpdateStaffDataGridView();
            }
        }

        private void ConfigureUpdateStaffDataGridView()
        {
            foreach (DataGridViewColumn column in dataGridViewUpdateStaff.Columns)
            {
                if (column.Name == "SALARY" || column.Name == "TELEPHONE" || column.Name == "EMAIL")
                {
                    column.ReadOnly = false;
                }
                else
                {
                    column.ReadOnly = true;
                }
            }
        }

        private void buttonUsSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewUpdateStaff.Rows)
                {
                    //get the staff number aka the primary key 
                    string staffNo = row.Cells["STAFFNO"].Value.ToString();

                    if (row.Cells["SALARY"].Value == null || string.IsNullOrWhiteSpace(row.Cells["SALARY"].Value.ToString()))
                    {
                        MessageBox.Show($"Salary cannot be empty for Staff No: {staffNo}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; //exit the method because user updated cell incorrectly
                    }

                    if (row.Cells["TELEPHONE"].Value == null || string.IsNullOrWhiteSpace(row.Cells["TELEPHONE"].Value.ToString()))
                    {
                        MessageBox.Show($"Telephone cannot be empty for Staff No: {staffNo}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (row.Cells["EMAIL"].Value == null || string.IsNullOrWhiteSpace(row.Cells["EMAIL"].Value.ToString()))
                    {
                        MessageBox.Show($"Email cannot be empty for Staff No: {staffNo}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //get the updated values that user entered
                    decimal newSalary = Convert.ToDecimal(row.Cells["SALARY"].Value);
                    string newTelephone = row.Cells["TELEPHONE"].Value.ToString();
                    string newEmail = row.Cells["EMAIL"].Value.ToString();

                    // Call the stored procedure with all updated values
                    dbManager.ExecuteStoredProcedure("update_staff_sp", new List<OracleParameter>
                    {
                        new OracleParameter("p_staffno", OracleDbType.Varchar2) { Value = staffNo },
                        new OracleParameter("p_salary", OracleDbType.Decimal) { Value = newSalary },
                        new OracleParameter("p_telephone", OracleDbType.Varchar2) { Value = newTelephone },
                        new OracleParameter("p_email", OracleDbType.Varchar2) { Value = newEmail }
                    });
                }

                MessageBox.Show("Your update was successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //load the table back up with the new changes present
                LoadUpdateStaffData();

                string queryStaff = dbManager.LoadQueryFromFile("get_staff_data.sql");
                dataGridViewStaff.DataSource = dbManager.ExecuteQuery(queryStaff);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving changes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //BRANCH TASKS
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

            LoadUpdateBranchData();
            PopulateUpdateBranchDropdown();
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

            LoadUpdateBranchData();
            PopulateUpdateBranchDropdown();
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

            LoadUpdateBranchData();
            PopulateUpdateBranchDropdown();
        }

        private void buttonIbSubmitBranchNo_Click(object sender, EventArgs e)
        {
            try
            {
                string branchNo = textBoxUbEnterBranchNo.Text.Trim();

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

        private void LoadUpdateBranchData()
        {

            string queryUpdateBranch = dbManager.LoadQueryFromFile("get_branch_data.sql");
            dataGridViewUpdateBranch.DataSource = dbManager.ExecuteQuery(queryUpdateBranch);

            dataGridViewUpdateBranch.ReadOnly = false;
            dataGridViewUpdateBranch.AllowUserToAddRows = false;
            dataGridViewUpdateBranch.AllowUserToDeleteRows = false;
            dataGridViewUpdateBranch.SelectionMode = DataGridViewSelectionMode.CellSelect;

            //only allow editing of specific columns
            ConfigureUpdateBranchDataGridView();

        }

        private void PopulateUpdateBranchDropdown()
        {
            string queryBranchDropdown = dbManager.LoadQueryFromFile("fetch_branchNo.sql");

            DataTable branchData = dbManager.ExecuteQuery(queryBranchDropdown);

            //clear the dropdown menu and add a "Show All" option
            comboBoxUbSelectABranchToUpdate.Items.Clear();
            comboBoxUbSelectABranchToUpdate.Items.Add("Show All");

            //also add each branch number and name to the dropdown
            foreach (DataRow row in branchData.Rows)
            {
                comboBoxUbSelectABranchToUpdate.Items.Add($"{row["branchno"]}");
            }

            //make "Show All" the default selection of the dropdown
            comboBoxUbSelectABranchToUpdate.SelectedIndex = 0;
        }

        private void comboBoxUbSelectABranchToUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUbSelectABranchToUpdate.SelectedIndex == 0) //show all option
            {
                LoadUpdateBranchData();
            }
            else
            {
                //get the selected branch number from the ComboBox
                string branchNo = comboBoxUbSelectABranchToUpdate.SelectedItem.ToString();

                //filter the table to get only the row of the selected branch
                //string queryFilteredBranch = $"SELECT branchno, street, city, postcode FROM dh_branch WHERE branchno = '{branchNo}'";
                string queryFilteredBranch = dbManager.LoadQueryFromFile("filter_branch.sql");

                queryFilteredBranch = queryFilteredBranch.Replace("{branchno}", branchNo);

                //load the filtered table 
                dataGridViewUpdateBranch.DataSource = dbManager.ExecuteQuery(queryFilteredBranch);

                // Allow editing only for specific columns
                ConfigureUpdateBranchDataGridView();
            }
        }

        private void ConfigureUpdateBranchDataGridView()
        {
            foreach (DataGridViewColumn column in dataGridViewUpdateBranch.Columns)
            {
                if (column.Name == "STREET" || column.Name == "CITY" || column.Name == "POSTCODE")
                {
                    column.ReadOnly = false;
                }
                else
                {
                    column.ReadOnly = true;
                }
            }
        }
        private void buttonUbSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewUpdateBranch.Rows)
                {
                    //get the branch number aka the primary key 
                    string branchNo = row.Cells["BRANCHNO"].Value.ToString();

                    if (row.Cells["STREET"].Value == null || string.IsNullOrWhiteSpace(row.Cells["STREET"].Value.ToString()))
                    {
                        MessageBox.Show($"Street cannot be empty for Branch No: {branchNo}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; //exit the method because user updated cell incorrectly
                    }

                    if (row.Cells["CITY"].Value == null || string.IsNullOrWhiteSpace(row.Cells["CITY"].Value.ToString()))
                    {
                        MessageBox.Show($"City cannot be empty for Branch No: {branchNo}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (row.Cells["POSTCODE"].Value == null || string.IsNullOrWhiteSpace(row.Cells["POSTCODE"].Value.ToString()))
                    {
                        MessageBox.Show($"POSTCODE cannot be empty for Branch No: {branchNo}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //get the updated values that user entered
                    string newStreet = row.Cells["STREET"].Value.ToString();
                    string newCity = row.Cells["CITY"].Value.ToString();
                    string newPostcode = row.Cells["POSTCODE"].Value.ToString();

                    // Call the stored procedure with all updated values
                    dbManager.ExecuteStoredProcedure("update_branch_sp", new List<OracleParameter>
                    {
                        new OracleParameter("p_branchno", OracleDbType.Varchar2) { Value = branchNo },
                        new OracleParameter("p_street", OracleDbType.Varchar2) { Value = newStreet },
                        new OracleParameter("p_city", OracleDbType.Varchar2) { Value = newCity },
                        new OracleParameter("p_postcode", OracleDbType.Varchar2) { Value = newPostcode }
                    });
                }

                MessageBox.Show("Your update was successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //load the table back up with the new changes present
                LoadUpdateBranchData();

                string queryBranch = dbManager.LoadQueryFromFile("get_branch_data.sql");
                dataGridViewBranch.DataSource = dbManager.ExecuteQuery(queryBranch);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving changes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //CLIENT TASKS

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
            cboPreferenceType.SelectedIndex = -1;
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
                string preferenceType = cboPreferenceType.SelectedItem.ToString();
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

                //Clears and resets the controls, so the user's next action in the form doesn't get affected
                ClearControlsClient();
                LoadClientNo();
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

        // Method to populate drop down list by getting Client No from database
        public void LoadClientNo()
        {
            //Load the SQL query from SQL file for Client table's Client No
            string queryClientNo = dbManager.LoadQueryFromFile("get_clientno.sql");

            //Execute query and get result as DataTable
            cboDeleteByClientNo.DataSource = dbManager.ExecuteQuery(queryClientNo);

            //Set DisplayMember to database's column name that should appear in ComboBox
            cboDeleteByClientNo.DisplayMember = "ClientNo";

            //Set ValueMember to database's column name that represents value for each item
            cboDeleteByClientNo.ValueMember = "ClientNo";
        }

        //When delete button in client panel is clicked, the record according to the client number is deleted
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                //Ensure client number is selected
                if (cboDeleteByClientNo.SelectedValue == null)
                {
                    MessageBox.Show("Please select a client to delete.\n {ex.Message}");
                }

                //Get user's selected ClientNo from ComboBox
                string clientNo = cboDeleteByClientNo.SelectedValue.ToString();

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

                //Update Client No in the dropdown list
                LoadClientNo();
            }
            //Handle any errors that occur during registration or displaying the table
            catch (Exception ex)
            {
                //Output exception message
                MessageBox.Show($"Error with deleting Client data:\n {ex.Message}");
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
