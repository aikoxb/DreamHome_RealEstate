namespace CSharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabStaff = new System.Windows.Forms.TabPage();
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.buttonLoadStaff = new System.Windows.Forms.Button();
            this.tabBranch = new System.Windows.Forms.TabPage();
            this.dataGridViewBranch = new System.Windows.Forms.DataGridView();
            this.buttonLoadBranch = new System.Windows.Forms.Button();
            this.tabClient = new System.Windows.Forms.TabPage();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
<<<<<<< Updated upstream
            this.btnRegisterClient = new System.Windows.Forms.Button();
            this.txtClientNo = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtTelephoneNo = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtMaxRent = new System.Windows.Forms.TextBox();
            this.txtPreferenceType = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
=======
            this.buttonLoadClient = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHireStaff = new System.Windows.Forms.TabPage();
            this.tabUpdateStaff = new System.Windows.Forms.TabPage();
            this.textBoxHireStaffFirstName = new System.Windows.Forms.TextBox();
            this.textBoxHireStaffSalary = new System.Windows.Forms.TextBox();
            this.textBoxHireStaffBranchNo = new System.Windows.Forms.TextBox();
            this.textBoxHireStaffLastName = new System.Windows.Forms.TextBox();
            this.textBoxHireStaffTelephone = new System.Windows.Forms.TextBox();
            this.textBoxHireStaffEmail = new System.Windows.Forms.TextBox();
            this.textBoxHireStaffDOB = new System.Windows.Forms.TextBox();
            this.textBoxHireStaffPosition = new System.Windows.Forms.TextBox();
            this.textBoxHireStaffMobile = new System.Windows.Forms.TextBox();
            this.labelHireStaffFirstName = new System.Windows.Forms.Label();
            this.labelHireStaffLastName = new System.Windows.Forms.Label();
            this.labelHireStaffPosition = new System.Windows.Forms.Label();
            this.labelHireStaffDOB = new System.Windows.Forms.Label();
            this.labelHireStaffSalary = new System.Windows.Forms.Label();
            this.labelHireTelephone = new System.Windows.Forms.Label();
            this.labelHireStaffMobile = new System.Windows.Forms.Label();
            this.labelHireStaffBranchNo = new System.Windows.Forms.Label();
            this.labelHireStaffEmail = new System.Windows.Forms.Label();
            this.buttonHireStaffHire = new System.Windows.Forms.Button();
            this.buttonHireStaffCancel = new System.Windows.Forms.Button();
            this.textBoxHireStaffSex = new System.Windows.Forms.TextBox();
            this.labelHireStaffSex = new System.Windows.Forms.Label();
            this.labelHireStaffStaffNo = new System.Windows.Forms.Label();
            this.textBoxHireStaffStaffNo = new System.Windows.Forms.TextBox();
>>>>>>> Stashed changes
            this.tabControlMain.SuspendLayout();
            this.tabStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.tabBranch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBranch)).BeginInit();
            this.tabClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabHireStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabStaff);
            this.tabControlMain.Controls.Add(this.tabBranch);
            this.tabControlMain.Controls.Add(this.tabClient);
            this.tabControlMain.Location = new System.Drawing.Point(14, 15);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
<<<<<<< Updated upstream
            this.tabControlMain.Size = new System.Drawing.Size(1499, 835);
=======
            this.tabControlMain.Size = new System.Drawing.Size(933, 528);
>>>>>>> Stashed changes
            this.tabControlMain.TabIndex = 0;
            // 
            // tabStaff
            // 
            this.tabStaff.Controls.Add(this.tabControl1);
            this.tabStaff.Controls.Add(this.dataGridViewStaff);
            this.tabStaff.Controls.Add(this.buttonLoadStaff);
            this.tabStaff.Location = new System.Drawing.Point(4, 29);
            this.tabStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabStaff.Name = "tabStaff";
<<<<<<< Updated upstream
            this.tabStaff.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabStaff.Size = new System.Drawing.Size(1491, 802);
=======
            this.tabStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabStaff.Size = new System.Drawing.Size(925, 499);
>>>>>>> Stashed changes
            this.tabStaff.TabIndex = 0;
            this.tabStaff.Text = "Staff Menu";
            this.tabStaff.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< Updated upstream
            this.dataGridViewStaff.Location = new System.Drawing.Point(160, 71);
            this.dataGridViewStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.RowHeadersWidth = 51;
            this.dataGridViewStaff.RowTemplate.Height = 24;
            this.dataGridViewStaff.Size = new System.Drawing.Size(683, 399);
=======
            this.dataGridViewStaff.Location = new System.Drawing.Point(23, 389);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.RowHeadersWidth = 51;
            this.dataGridViewStaff.RowTemplate.Height = 24;
            this.dataGridViewStaff.Size = new System.Drawing.Size(883, 93);
>>>>>>> Stashed changes
            this.dataGridViewStaff.TabIndex = 1;
            // 
            // buttonLoadStaff
            // 
<<<<<<< Updated upstream
            this.buttonLoadStaff.Location = new System.Drawing.Point(45, 71);
            this.buttonLoadStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
=======
            this.buttonLoadStaff.Location = new System.Drawing.Point(23, 350);
>>>>>>> Stashed changes
            this.buttonLoadStaff.Name = "buttonLoadStaff";
            this.buttonLoadStaff.Size = new System.Drawing.Size(84, 29);
            this.buttonLoadStaff.TabIndex = 0;
            this.buttonLoadStaff.Text = "Load Staff";
            this.buttonLoadStaff.UseVisualStyleBackColor = true;
            this.buttonLoadStaff.Click += new System.EventHandler(this.buttonLoadStaff_Click);
            // 
            // tabBranch
            // 
            this.tabBranch.Controls.Add(this.dataGridViewBranch);
            this.tabBranch.Controls.Add(this.buttonLoadBranch);
            this.tabBranch.Location = new System.Drawing.Point(4, 29);
            this.tabBranch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBranch.Name = "tabBranch";
            this.tabBranch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBranch.Size = new System.Drawing.Size(1491, 802);
            this.tabBranch.TabIndex = 1;
            this.tabBranch.Text = "Branch Menu";
            this.tabBranch.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBranch
            // 
            this.dataGridViewBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBranch.Location = new System.Drawing.Point(198, 50);
            this.dataGridViewBranch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewBranch.Name = "dataGridViewBranch";
            this.dataGridViewBranch.RowHeadersWidth = 51;
            this.dataGridViewBranch.RowTemplate.Height = 24;
            this.dataGridViewBranch.Size = new System.Drawing.Size(647, 424);
            this.dataGridViewBranch.TabIndex = 1;
            // 
            // buttonLoadBranch
            // 
            this.buttonLoadBranch.Location = new System.Drawing.Point(43, 50);
            this.buttonLoadBranch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLoadBranch.Name = "buttonLoadBranch";
            this.buttonLoadBranch.Size = new System.Drawing.Size(119, 29);
            this.buttonLoadBranch.TabIndex = 0;
            this.buttonLoadBranch.Text = "Load Branch";
            this.buttonLoadBranch.UseVisualStyleBackColor = true;
            this.buttonLoadBranch.Click += new System.EventHandler(this.buttonLoadBranch_Click);
            // 
            // tabClient
            // 
            this.tabClient.Controls.Add(this.label7);
            this.tabClient.Controls.Add(this.label8);
            this.tabClient.Controls.Add(this.label9);
            this.tabClient.Controls.Add(this.label4);
            this.tabClient.Controls.Add(this.label5);
            this.tabClient.Controls.Add(this.label6);
            this.tabClient.Controls.Add(this.label3);
            this.tabClient.Controls.Add(this.label2);
            this.tabClient.Controls.Add(this.label1);
            this.tabClient.Controls.Add(this.txtMaxRent);
            this.tabClient.Controls.Add(this.txtPreferenceType);
            this.tabClient.Controls.Add(this.txtEmail);
            this.tabClient.Controls.Add(this.txtCity);
            this.tabClient.Controls.Add(this.txtStreet);
            this.tabClient.Controls.Add(this.txtTelephoneNo);
            this.tabClient.Controls.Add(this.txtLastName);
            this.tabClient.Controls.Add(this.txtFirstName);
            this.tabClient.Controls.Add(this.txtClientNo);
            this.tabClient.Controls.Add(this.dataGridViewClient);
            this.tabClient.Controls.Add(this.btnRegisterClient);
            this.tabClient.Location = new System.Drawing.Point(4, 29);
            this.tabClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabClient.Name = "tabClient";
            this.tabClient.Size = new System.Drawing.Size(1491, 802);
            this.tabClient.TabIndex = 2;
            this.tabClient.Text = "Client Menu";
            this.tabClient.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Location = new System.Drawing.Point(525, 4);
            this.dataGridViewClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.RowHeadersWidth = 51;
            this.dataGridViewClient.RowTemplate.Height = 24;
            this.dataGridViewClient.Size = new System.Drawing.Size(963, 794);
            this.dataGridViewClient.TabIndex = 1;
            // 
            // btnRegisterClient
            // 
            this.btnRegisterClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterClient.Location = new System.Drawing.Point(336, 561);
            this.btnRegisterClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegisterClient.Name = "btnRegisterClient";
            this.btnRegisterClient.Size = new System.Drawing.Size(141, 47);
            this.btnRegisterClient.TabIndex = 0;
            this.btnRegisterClient.Text = "Register Client";
            this.btnRegisterClient.UseVisualStyleBackColor = true;
            this.btnRegisterClient.Click += new System.EventHandler(this.btnRegisterClient_Click);
            // 
            // txtClientNo
            // 
            this.txtClientNo.Location = new System.Drawing.Point(231, 34);
            this.txtClientNo.Name = "txtClientNo";
            this.txtClientNo.Size = new System.Drawing.Size(100, 26);
            this.txtClientNo.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(231, 92);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 26);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(231, 150);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 26);
            this.txtLastName.TabIndex = 4;
            // 
            // txtTelephoneNo
            // 
            this.txtTelephoneNo.Location = new System.Drawing.Point(231, 208);
            this.txtTelephoneNo.Name = "txtTelephoneNo";
            this.txtTelephoneNo.Size = new System.Drawing.Size(100, 26);
            this.txtTelephoneNo.TabIndex = 5;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(231, 266);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 26);
            this.txtStreet.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(231, 324);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 26);
            this.txtCity.TabIndex = 7;
            // 
            // txtMaxRent
            // 
            this.txtMaxRent.Location = new System.Drawing.Point(231, 498);
            this.txtMaxRent.Name = "txtMaxRent";
            this.txtMaxRent.Size = new System.Drawing.Size(100, 26);
            this.txtMaxRent.TabIndex = 10;
            // 
            // txtPreferenceType
            // 
            this.txtPreferenceType.Location = new System.Drawing.Point(231, 440);
            this.txtPreferenceType.Name = "txtPreferenceType";
            this.txtPreferenceType.Size = new System.Drawing.Size(100, 26);
            this.txtPreferenceType.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(231, 382);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 26);
            this.txtEmail.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Client No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Street";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Telephone No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 501);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Max Rent";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Preference Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Email";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHireStaff);
            this.tabControl1.Controls.Add(this.tabUpdateStaff);
            this.tabControl1.Location = new System.Drawing.Point(23, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 323);
            this.tabControl1.TabIndex = 2;
            // 
            // tabHireStaff
            // 
            this.tabHireStaff.Controls.Add(this.textBoxHireStaffStaffNo);
            this.tabHireStaff.Controls.Add(this.labelHireStaffStaffNo);
            this.tabHireStaff.Controls.Add(this.labelHireStaffSex);
            this.tabHireStaff.Controls.Add(this.textBoxHireStaffSex);
            this.tabHireStaff.Controls.Add(this.buttonHireStaffCancel);
            this.tabHireStaff.Controls.Add(this.buttonHireStaffHire);
            this.tabHireStaff.Controls.Add(this.labelHireStaffEmail);
            this.tabHireStaff.Controls.Add(this.labelHireStaffBranchNo);
            this.tabHireStaff.Controls.Add(this.labelHireStaffMobile);
            this.tabHireStaff.Controls.Add(this.labelHireTelephone);
            this.tabHireStaff.Controls.Add(this.labelHireStaffSalary);
            this.tabHireStaff.Controls.Add(this.labelHireStaffDOB);
            this.tabHireStaff.Controls.Add(this.labelHireStaffPosition);
            this.tabHireStaff.Controls.Add(this.labelHireStaffLastName);
            this.tabHireStaff.Controls.Add(this.labelHireStaffFirstName);
            this.tabHireStaff.Controls.Add(this.textBoxHireStaffMobile);
            this.tabHireStaff.Controls.Add(this.textBoxHireStaffPosition);
            this.tabHireStaff.Controls.Add(this.textBoxHireStaffDOB);
            this.tabHireStaff.Controls.Add(this.textBoxHireStaffEmail);
            this.tabHireStaff.Controls.Add(this.textBoxHireStaffTelephone);
            this.tabHireStaff.Controls.Add(this.textBoxHireStaffLastName);
            this.tabHireStaff.Controls.Add(this.textBoxHireStaffBranchNo);
            this.tabHireStaff.Controls.Add(this.textBoxHireStaffSalary);
            this.tabHireStaff.Controls.Add(this.textBoxHireStaffFirstName);
            this.tabHireStaff.Location = new System.Drawing.Point(4, 25);
            this.tabHireStaff.Name = "tabHireStaff";
            this.tabHireStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabHireStaff.Size = new System.Drawing.Size(875, 294);
            this.tabHireStaff.TabIndex = 0;
            this.tabHireStaff.Text = "Hire Staff";
            this.tabHireStaff.UseVisualStyleBackColor = true;
            // 
            // tabUpdateStaff
            // 
            this.tabUpdateStaff.Location = new System.Drawing.Point(4, 25);
            this.tabUpdateStaff.Name = "tabUpdateStaff";
            this.tabUpdateStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdateStaff.Size = new System.Drawing.Size(714, 173);
            this.tabUpdateStaff.TabIndex = 1;
            this.tabUpdateStaff.Text = "Update Staff Information";
            this.tabUpdateStaff.UseVisualStyleBackColor = true;
            // 
            // textBoxHireStaffFirstName
            // 
            this.textBoxHireStaffFirstName.Location = new System.Drawing.Point(162, 47);
            this.textBoxHireStaffFirstName.Name = "textBoxHireStaffFirstName";
            this.textBoxHireStaffFirstName.Size = new System.Drawing.Size(100, 22);
            this.textBoxHireStaffFirstName.TabIndex = 0;
            // 
            // textBoxHireStaffSalary
            // 
            this.textBoxHireStaffSalary.Location = new System.Drawing.Point(162, 149);
            this.textBoxHireStaffSalary.Name = "textBoxHireStaffSalary";
            this.textBoxHireStaffSalary.Size = new System.Drawing.Size(100, 22);
            this.textBoxHireStaffSalary.TabIndex = 1;
            // 
            // textBoxHireStaffBranchNo
            // 
            this.textBoxHireStaffBranchNo.Location = new System.Drawing.Point(730, 47);
            this.textBoxHireStaffBranchNo.Name = "textBoxHireStaffBranchNo";
            this.textBoxHireStaffBranchNo.Size = new System.Drawing.Size(100, 22);
            this.textBoxHireStaffBranchNo.TabIndex = 2;
            // 
            // textBoxHireStaffLastName
            // 
            this.textBoxHireStaffLastName.Location = new System.Drawing.Point(293, 47);
            this.textBoxHireStaffLastName.Name = "textBoxHireStaffLastName";
            this.textBoxHireStaffLastName.Size = new System.Drawing.Size(100, 22);
            this.textBoxHireStaffLastName.TabIndex = 3;
            // 
            // textBoxHireStaffTelephone
            // 
            this.textBoxHireStaffTelephone.Location = new System.Drawing.Point(293, 149);
            this.textBoxHireStaffTelephone.Name = "textBoxHireStaffTelephone";
            this.textBoxHireStaffTelephone.Size = new System.Drawing.Size(100, 22);
            this.textBoxHireStaffTelephone.TabIndex = 4;
            // 
            // textBoxHireStaffEmail
            // 
            this.textBoxHireStaffEmail.Location = new System.Drawing.Point(576, 149);
            this.textBoxHireStaffEmail.Name = "textBoxHireStaffEmail";
            this.textBoxHireStaffEmail.Size = new System.Drawing.Size(100, 22);
            this.textBoxHireStaffEmail.TabIndex = 5;
            // 
            // textBoxHireStaffDOB
            // 
            this.textBoxHireStaffDOB.Location = new System.Drawing.Point(31, 149);
            this.textBoxHireStaffDOB.Name = "textBoxHireStaffDOB";
            this.textBoxHireStaffDOB.Size = new System.Drawing.Size(100, 22);
            this.textBoxHireStaffDOB.TabIndex = 6;
            // 
            // textBoxHireStaffPosition
            // 
            this.textBoxHireStaffPosition.Location = new System.Drawing.Point(437, 47);
            this.textBoxHireStaffPosition.Name = "textBoxHireStaffPosition";
            this.textBoxHireStaffPosition.Size = new System.Drawing.Size(100, 22);
            this.textBoxHireStaffPosition.TabIndex = 7;
            // 
            // textBoxHireStaffMobile
            // 
            this.textBoxHireStaffMobile.Location = new System.Drawing.Point(423, 149);
            this.textBoxHireStaffMobile.Name = "textBoxHireStaffMobile";
            this.textBoxHireStaffMobile.Size = new System.Drawing.Size(100, 22);
            this.textBoxHireStaffMobile.TabIndex = 8;
            // 
            // labelHireStaffFirstName
            // 
            this.labelHireStaffFirstName.AutoSize = true;
            this.labelHireStaffFirstName.Location = new System.Drawing.Point(159, 23);
            this.labelHireStaffFirstName.Name = "labelHireStaffFirstName";
            this.labelHireStaffFirstName.Size = new System.Drawing.Size(75, 16);
            this.labelHireStaffFirstName.TabIndex = 9;
            this.labelHireStaffFirstName.Text = "First Name:";
            // 
            // labelHireStaffLastName
            // 
            this.labelHireStaffLastName.AutoSize = true;
            this.labelHireStaffLastName.Location = new System.Drawing.Point(299, 23);
            this.labelHireStaffLastName.Name = "labelHireStaffLastName";
            this.labelHireStaffLastName.Size = new System.Drawing.Size(75, 16);
            this.labelHireStaffLastName.TabIndex = 10;
            this.labelHireStaffLastName.Text = "Last Name:";
            // 
            // labelHireStaffPosition
            // 
            this.labelHireStaffPosition.AutoSize = true;
            this.labelHireStaffPosition.Location = new System.Drawing.Point(438, 23);
            this.labelHireStaffPosition.Name = "labelHireStaffPosition";
            this.labelHireStaffPosition.Size = new System.Drawing.Size(58, 16);
            this.labelHireStaffPosition.TabIndex = 11;
            this.labelHireStaffPosition.Text = "Position:";
            // 
            // labelHireStaffDOB
            // 
            this.labelHireStaffDOB.AutoSize = true;
            this.labelHireStaffDOB.Location = new System.Drawing.Point(28, 120);
            this.labelHireStaffDOB.Name = "labelHireStaffDOB";
            this.labelHireStaffDOB.Size = new System.Drawing.Size(118, 16);
            this.labelHireStaffDOB.TabIndex = 12;
            this.labelHireStaffDOB.Text = "DOB (YY-MM-DD):";
            // 
            // labelHireStaffSalary
            // 
            this.labelHireStaffSalary.AutoSize = true;
            this.labelHireStaffSalary.Location = new System.Drawing.Point(159, 120);
            this.labelHireStaffSalary.Name = "labelHireStaffSalary";
            this.labelHireStaffSalary.Size = new System.Drawing.Size(49, 16);
            this.labelHireStaffSalary.TabIndex = 13;
            this.labelHireStaffSalary.Text = "Salary:";
            // 
            // labelHireTelephone
            // 
            this.labelHireTelephone.AutoSize = true;
            this.labelHireTelephone.Location = new System.Drawing.Point(290, 120);
            this.labelHireTelephone.Name = "labelHireTelephone";
            this.labelHireTelephone.Size = new System.Drawing.Size(76, 16);
            this.labelHireTelephone.TabIndex = 14;
            this.labelHireTelephone.Text = "Telephone:";
            // 
            // labelHireStaffMobile
            // 
            this.labelHireStaffMobile.AutoSize = true;
            this.labelHireStaffMobile.Location = new System.Drawing.Point(420, 120);
            this.labelHireStaffMobile.Name = "labelHireStaffMobile";
            this.labelHireStaffMobile.Size = new System.Drawing.Size(51, 16);
            this.labelHireStaffMobile.TabIndex = 15;
            this.labelHireStaffMobile.Text = "Mobile:";
            // 
            // labelHireStaffBranchNo
            // 
            this.labelHireStaffBranchNo.AutoSize = true;
            this.labelHireStaffBranchNo.Location = new System.Drawing.Point(727, 23);
            this.labelHireStaffBranchNo.Name = "labelHireStaffBranchNo";
            this.labelHireStaffBranchNo.Size = new System.Drawing.Size(73, 16);
            this.labelHireStaffBranchNo.TabIndex = 16;
            this.labelHireStaffBranchNo.Text = "Branch No:";
            // 
            // labelHireStaffEmail
            // 
            this.labelHireStaffEmail.AutoSize = true;
            this.labelHireStaffEmail.Location = new System.Drawing.Point(573, 120);
            this.labelHireStaffEmail.Name = "labelHireStaffEmail";
            this.labelHireStaffEmail.Size = new System.Drawing.Size(44, 16);
            this.labelHireStaffEmail.TabIndex = 17;
            this.labelHireStaffEmail.Text = "Email:";
            // 
            // buttonHireStaffHire
            // 
            this.buttonHireStaffHire.Location = new System.Drawing.Point(772, 235);
            this.buttonHireStaffHire.Name = "buttonHireStaffHire";
            this.buttonHireStaffHire.Size = new System.Drawing.Size(75, 23);
            this.buttonHireStaffHire.TabIndex = 18;
            this.buttonHireStaffHire.Text = "Hire";
            this.buttonHireStaffHire.UseVisualStyleBackColor = true;
            this.buttonHireStaffHire.Click += new System.EventHandler(this.buttonHireStaffHire_Click);
            // 
            // buttonHireStaffCancel
            // 
            this.buttonHireStaffCancel.Location = new System.Drawing.Point(21, 235);
            this.buttonHireStaffCancel.Name = "buttonHireStaffCancel";
            this.buttonHireStaffCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonHireStaffCancel.TabIndex = 19;
            this.buttonHireStaffCancel.Text = "Cancel";
            this.buttonHireStaffCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxHireStaffSex
            // 
            this.textBoxHireStaffSex.Location = new System.Drawing.Point(576, 47);
            this.textBoxHireStaffSex.Name = "textBoxHireStaffSex";
            this.textBoxHireStaffSex.Size = new System.Drawing.Size(100, 22);
            this.textBoxHireStaffSex.TabIndex = 20;
            // 
            // labelHireStaffSex
            // 
            this.labelHireStaffSex.AutoSize = true;
            this.labelHireStaffSex.Location = new System.Drawing.Point(578, 23);
            this.labelHireStaffSex.Name = "labelHireStaffSex";
            this.labelHireStaffSex.Size = new System.Drawing.Size(33, 16);
            this.labelHireStaffSex.TabIndex = 21;
            this.labelHireStaffSex.Text = "Sex:";
            // 
            // labelHireStaffStaffNo
            // 
            this.labelHireStaffStaffNo.AutoSize = true;
            this.labelHireStaffStaffNo.Location = new System.Drawing.Point(39, 23);
            this.labelHireStaffStaffNo.Name = "labelHireStaffStaffNo";
            this.labelHireStaffStaffNo.Size = new System.Drawing.Size(57, 16);
            this.labelHireStaffStaffNo.TabIndex = 22;
            this.labelHireStaffStaffNo.Text = "Staff No:";
            // 
            // textBoxHireStaffStaffNo
            // 
            this.textBoxHireStaffStaffNo.Location = new System.Drawing.Point(31, 47);
            this.textBoxHireStaffStaffNo.Name = "textBoxHireStaffStaffNo";
            this.textBoxHireStaffStaffNo.Size = new System.Drawing.Size(100, 22);
            this.textBoxHireStaffStaffNo.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< Updated upstream
            this.ClientSize = new System.Drawing.Size(1525, 863);
=======
            this.ClientSize = new System.Drawing.Size(957, 552);
>>>>>>> Stashed changes
            this.Controls.Add(this.tabControlMain);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControlMain.ResumeLayout(false);
            this.tabStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            this.tabBranch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBranch)).EndInit();
            this.tabClient.ResumeLayout(false);
            this.tabClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabHireStaff.ResumeLayout(false);
            this.tabHireStaff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabStaff;
        private System.Windows.Forms.TabPage tabBranch;
        private System.Windows.Forms.TabPage tabClient;
        private System.Windows.Forms.Button buttonLoadStaff;
        private System.Windows.Forms.Button buttonLoadBranch;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.Button btnRegisterClient;
        private System.Windows.Forms.DataGridView dataGridViewStaff;
        private System.Windows.Forms.DataGridView dataGridViewBranch;
<<<<<<< Updated upstream
        private System.Windows.Forms.TextBox txtMaxRent;
        private System.Windows.Forms.TextBox txtPreferenceType;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtTelephoneNo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtClientNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
=======
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHireStaff;
        private System.Windows.Forms.TabPage tabUpdateStaff;
        private System.Windows.Forms.Label labelHireStaffFirstName;
        private System.Windows.Forms.TextBox textBoxHireStaffMobile;
        private System.Windows.Forms.TextBox textBoxHireStaffPosition;
        private System.Windows.Forms.TextBox textBoxHireStaffDOB;
        private System.Windows.Forms.TextBox textBoxHireStaffEmail;
        private System.Windows.Forms.TextBox textBoxHireStaffTelephone;
        private System.Windows.Forms.TextBox textBoxHireStaffLastName;
        private System.Windows.Forms.TextBox textBoxHireStaffBranchNo;
        private System.Windows.Forms.TextBox textBoxHireStaffSalary;
        private System.Windows.Forms.TextBox textBoxHireStaffFirstName;
        private System.Windows.Forms.Label labelHireStaffLastName;
        private System.Windows.Forms.Label labelHireStaffEmail;
        private System.Windows.Forms.Label labelHireStaffBranchNo;
        private System.Windows.Forms.Label labelHireStaffMobile;
        private System.Windows.Forms.Label labelHireTelephone;
        private System.Windows.Forms.Label labelHireStaffSalary;
        private System.Windows.Forms.Label labelHireStaffDOB;
        private System.Windows.Forms.Label labelHireStaffPosition;
        private System.Windows.Forms.Button buttonHireStaffCancel;
        private System.Windows.Forms.Button buttonHireStaffHire;
        private System.Windows.Forms.TextBox textBoxHireStaffStaffNo;
        private System.Windows.Forms.Label labelHireStaffStaffNo;
        private System.Windows.Forms.Label labelHireStaffSex;
        private System.Windows.Forms.TextBox textBoxHireStaffSex;
>>>>>>> Stashed changes
    }
}

