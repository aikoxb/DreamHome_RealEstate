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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabStaff = new System.Windows.Forms.TabPage();
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.buttonLoadStaff = new System.Windows.Forms.Button();
            this.tabBranch = new System.Windows.Forms.TabPage();
            this.dataGridViewBranch = new System.Windows.Forms.DataGridView();
            this.buttonLoadBranch = new System.Windows.Forms.Button();
            this.tabClient = new System.Windows.Forms.TabPage();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.btnRegisterClient = new System.Windows.Forms.Button();
            this.txtClientNo = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtTelephoneNo = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
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
            this.btnCancelRegisterClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.panelRegisterClient = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSelectRegisterClient = new System.Windows.Forms.Button();
            this.btnSelectDeleteClient = new System.Windows.Forms.Button();
            this.panelDeleteClient = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDeleteByClientNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panelClientSelection = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGoToRegisterClient = new System.Windows.Forms.Button();
            this.btnGoToDeleteClient = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtMaxRent = new System.Windows.Forms.TextBox();
            this.tabControlMain.SuspendLayout();
            this.tabStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.tabBranch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBranch)).BeginInit();
            this.tabClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.panelRegisterClient.SuspendLayout();
            this.panelDeleteClient.SuspendLayout();
            this.panelClientSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabStaff);
            this.tabControlMain.Controls.Add(this.tabBranch);
            this.tabControlMain.Controls.Add(this.tabClient);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1545, 711);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabStaff
            // 
            this.tabStaff.Controls.Add(this.dataGridViewStaff);
            this.tabStaff.Controls.Add(this.buttonLoadStaff);
            this.tabStaff.Location = new System.Drawing.Point(4, 34);
            this.tabStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabStaff.Name = "tabStaff";
            this.tabStaff.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabStaff.Size = new System.Drawing.Size(1537, 660);
            this.tabStaff.TabIndex = 0;
            this.tabStaff.Text = "Staff Menu";
            this.tabStaff.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Location = new System.Drawing.Point(160, 71);
            this.dataGridViewStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.RowHeadersWidth = 51;
            this.dataGridViewStaff.RowTemplate.Height = 24;
            this.dataGridViewStaff.Size = new System.Drawing.Size(683, 399);
            this.dataGridViewStaff.TabIndex = 1;
            // 
            // buttonLoadStaff
            // 
            this.buttonLoadStaff.Location = new System.Drawing.Point(45, 71);
            this.buttonLoadStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLoadStaff.Name = "buttonLoadStaff";
            this.buttonLoadStaff.Size = new System.Drawing.Size(84, 37);
            this.buttonLoadStaff.TabIndex = 0;
            this.buttonLoadStaff.Text = "Load Staff";
            this.buttonLoadStaff.UseVisualStyleBackColor = true;
            this.buttonLoadStaff.Click += new System.EventHandler(this.buttonLoadStaff_Click);
            // 
            // tabBranch
            // 
            this.tabBranch.Controls.Add(this.dataGridViewBranch);
            this.tabBranch.Controls.Add(this.buttonLoadBranch);
            this.tabBranch.Location = new System.Drawing.Point(4, 34);
            this.tabBranch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBranch.Name = "tabBranch";
            this.tabBranch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBranch.Size = new System.Drawing.Size(1537, 660);
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
            this.buttonLoadBranch.Size = new System.Drawing.Size(119, 42);
            this.buttonLoadBranch.TabIndex = 0;
            this.buttonLoadBranch.Text = "Load Branch";
            this.buttonLoadBranch.UseVisualStyleBackColor = true;
            this.buttonLoadBranch.Click += new System.EventHandler(this.buttonLoadBranch_Click);
            // 
            // tabClient
            // 
            this.tabClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.tabClient.Controls.Add(this.dataGridViewClient);
            this.tabClient.Controls.Add(this.panelRegisterClient);
            this.tabClient.Controls.Add(this.panelDeleteClient);
            this.tabClient.Controls.Add(this.panelClientSelection);
            this.tabClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tabClient.Location = new System.Drawing.Point(4, 39);
            this.tabClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabClient.Name = "tabClient";
            this.tabClient.Size = new System.Drawing.Size(1537, 668);
            this.tabClient.TabIndex = 2;
            this.tabClient.Text = "Client Menu";
            this.tabClient.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.dataGridViewClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(164)))), ((int)(((byte)(114)))));
            this.dataGridViewClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewClient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClient.ColumnHeadersHeight = 34;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClient.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewClient.EnableHeadersVisualStyles = false;
            this.dataGridViewClient.GridColor = System.Drawing.Color.White;
            this.dataGridViewClient.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClient.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewClient.RowHeadersVisible = false;
            this.dataGridViewClient.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.dataGridViewClient.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewClient.RowTemplate.Height = 24;
            this.dataGridViewClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClient.Size = new System.Drawing.Size(997, 668);
            this.dataGridViewClient.StandardTab = true;
            this.dataGridViewClient.TabIndex = 1;
            // 
            // btnRegisterClient
            // 
            this.btnRegisterClient.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegisterClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.btnRegisterClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRegisterClient.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.btnRegisterClient.Location = new System.Drawing.Point(381, 560);
            this.btnRegisterClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegisterClient.Name = "btnRegisterClient";
            this.btnRegisterClient.Size = new System.Drawing.Size(141, 92);
            this.btnRegisterClient.TabIndex = 0;
            this.btnRegisterClient.Text = "REGISTER";
            this.btnRegisterClient.UseVisualStyleBackColor = false;
            this.btnRegisterClient.Click += new System.EventHandler(this.btnRegisterClient_Click);
            // 
            // txtClientNo
            // 
            this.txtClientNo.BackColor = System.Drawing.Color.White;
            this.txtClientNo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientNo.ForeColor = System.Drawing.Color.Black;
            this.txtClientNo.Location = new System.Drawing.Point(26, 125);
            this.txtClientNo.Name = "txtClientNo";
            this.txtClientNo.Size = new System.Drawing.Size(116, 35);
            this.txtClientNo.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.Location = new System.Drawing.Point(26, 218);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(235, 35);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.Location = new System.Drawing.Point(280, 218);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(237, 35);
            this.txtLastName.TabIndex = 4;
            // 
            // txtTelephoneNo
            // 
            this.txtTelephoneNo.BackColor = System.Drawing.Color.White;
            this.txtTelephoneNo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephoneNo.ForeColor = System.Drawing.Color.Black;
            this.txtTelephoneNo.Location = new System.Drawing.Point(281, 128);
            this.txtTelephoneNo.Name = "txtTelephoneNo";
            this.txtTelephoneNo.Size = new System.Drawing.Size(210, 35);
            this.txtTelephoneNo.TabIndex = 5;
            // 
            // txtStreet
            // 
            this.txtStreet.BackColor = System.Drawing.Color.White;
            this.txtStreet.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.ForeColor = System.Drawing.Color.Black;
            this.txtStreet.Location = new System.Drawing.Point(26, 311);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(235, 35);
            this.txtStreet.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.White;
            this.txtCity.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.Color.Black;
            this.txtCity.Location = new System.Drawing.Point(280, 311);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(237, 35);
            this.txtCity.TabIndex = 7;
            // 
            // txtPreferenceType
            // 
            this.txtPreferenceType.BackColor = System.Drawing.Color.White;
            this.txtPreferenceType.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreferenceType.ForeColor = System.Drawing.Color.Black;
            this.txtPreferenceType.Location = new System.Drawing.Point(26, 497);
            this.txtPreferenceType.Name = "txtPreferenceType";
            this.txtPreferenceType.Size = new System.Drawing.Size(235, 35);
            this.txtPreferenceType.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(26, 404);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(491, 35);
            this.txtEmail.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(21, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Client No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(21, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(276, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(276, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(21, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Street";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(276, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Telephone No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(275, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Max Rent";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(21, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Preference Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(27, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Email";
            // 
            // btnCancelRegisterClient
            // 
            this.btnCancelRegisterClient.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelRegisterClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.btnCancelRegisterClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelRegisterClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelRegisterClient.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelRegisterClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.btnCancelRegisterClient.Location = new System.Drawing.Point(199, 576);
            this.btnCancelRegisterClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelRegisterClient.Name = "btnCancelRegisterClient";
            this.btnCancelRegisterClient.Size = new System.Drawing.Size(145, 61);
            this.btnCancelRegisterClient.TabIndex = 20;
            this.btnCancelRegisterClient.Text = "CLEAR TEXT";
            this.btnCancelRegisterClient.UseVisualStyleBackColor = false;
            this.btnCancelRegisterClient.Click += new System.EventHandler(this.btnCancelRegisterClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteClient.Location = new System.Drawing.Point(376, 540);
            this.btnDeleteClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(141, 47);
            this.btnDeleteClient.TabIndex = 21;
            this.btnDeleteClient.Text = "Delete";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // panelRegisterClient
            // 
            this.panelRegisterClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRegisterClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(164)))), ((int)(((byte)(114)))));
            this.panelRegisterClient.Controls.Add(this.txtMaxRent);
            this.panelRegisterClient.Controls.Add(this.btnGoToDeleteClient);
            this.panelRegisterClient.Controls.Add(this.btnCancelRegisterClient);
            this.panelRegisterClient.Controls.Add(this.label10);
            this.panelRegisterClient.Controls.Add(this.txtClientNo);
            this.panelRegisterClient.Controls.Add(this.label19);
            this.panelRegisterClient.Controls.Add(this.label1);
            this.panelRegisterClient.Controls.Add(this.label2);
            this.panelRegisterClient.Controls.Add(this.btnRegisterClient);
            this.panelRegisterClient.Controls.Add(this.txtFirstName);
            this.panelRegisterClient.Controls.Add(this.label7);
            this.panelRegisterClient.Controls.Add(this.label3);
            this.panelRegisterClient.Controls.Add(this.txtLastName);
            this.panelRegisterClient.Controls.Add(this.txtPreferenceType);
            this.panelRegisterClient.Controls.Add(this.label8);
            this.panelRegisterClient.Controls.Add(this.label6);
            this.panelRegisterClient.Controls.Add(this.txtTelephoneNo);
            this.panelRegisterClient.Controls.Add(this.txtEmail);
            this.panelRegisterClient.Controls.Add(this.label9);
            this.panelRegisterClient.Controls.Add(this.label5);
            this.panelRegisterClient.Controls.Add(this.txtStreet);
            this.panelRegisterClient.Controls.Add(this.txtCity);
            this.panelRegisterClient.Controls.Add(this.label4);
            this.panelRegisterClient.Location = new System.Drawing.Point(992, 0);
            this.panelRegisterClient.Name = "panelRegisterClient";
            this.panelRegisterClient.Size = new System.Drawing.Size(549, 669);
            this.panelRegisterClient.TabIndex = 23;
            this.panelRegisterClient.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(108, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(347, 61);
            this.label10.TabIndex = 20;
            this.label10.Text = "REGISTER CLIENT";
            // 
            // btnSelectRegisterClient
            // 
            this.btnSelectRegisterClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectRegisterClient.Location = new System.Drawing.Point(107, 288);
            this.btnSelectRegisterClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectRegisterClient.Name = "btnSelectRegisterClient";
            this.btnSelectRegisterClient.Size = new System.Drawing.Size(141, 47);
            this.btnSelectRegisterClient.TabIndex = 24;
            this.btnSelectRegisterClient.Text = "Register Client";
            this.btnSelectRegisterClient.UseVisualStyleBackColor = true;
            this.btnSelectRegisterClient.Click += new System.EventHandler(this.btnSelectRegisterClient_Click);
            // 
            // btnSelectDeleteClient
            // 
            this.btnSelectDeleteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectDeleteClient.Location = new System.Drawing.Point(281, 285);
            this.btnSelectDeleteClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectDeleteClient.Name = "btnSelectDeleteClient";
            this.btnSelectDeleteClient.Size = new System.Drawing.Size(141, 47);
            this.btnSelectDeleteClient.TabIndex = 25;
            this.btnSelectDeleteClient.Text = "Delete Client";
            this.btnSelectDeleteClient.UseVisualStyleBackColor = true;
            this.btnSelectDeleteClient.Click += new System.EventHandler(this.btnSelectDeleteClient_Click);
            // 
            // panelDeleteClient
            // 
            this.panelDeleteClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDeleteClient.Controls.Add(this.btnGoToRegisterClient);
            this.panelDeleteClient.Controls.Add(this.label11);
            this.panelDeleteClient.Controls.Add(this.txtDeleteByClientNo);
            this.panelDeleteClient.Controls.Add(this.label12);
            this.panelDeleteClient.Controls.Add(this.btnDeleteClient);
            this.panelDeleteClient.Location = new System.Drawing.Point(992, 0);
            this.panelDeleteClient.Name = "panelDeleteClient";
            this.panelDeleteClient.Size = new System.Drawing.Size(549, 664);
            this.panelDeleteClient.TabIndex = 24;
            this.panelDeleteClient.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(119, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(263, 56);
            this.label11.TabIndex = 20;
            this.label11.Text = "Delete Client";
            // 
            // txtDeleteByClientNo
            // 
            this.txtDeleteByClientNo.Location = new System.Drawing.Point(188, 240);
            this.txtDeleteByClientNo.MinimumSize = new System.Drawing.Size(0, 50);
            this.txtDeleteByClientNo.Name = "txtDeleteByClientNo";
            this.txtDeleteByClientNo.Size = new System.Drawing.Size(115, 50);
            this.txtDeleteByClientNo.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(204, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Client No:";
            // 
            // panelClientSelection
            // 
            this.panelClientSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClientSelection.Controls.Add(this.label13);
            this.panelClientSelection.Controls.Add(this.btnSelectDeleteClient);
            this.panelClientSelection.Controls.Add(this.btnSelectRegisterClient);
            this.panelClientSelection.Location = new System.Drawing.Point(992, 0);
            this.panelClientSelection.Name = "panelClientSelection";
            this.panelClientSelection.Size = new System.Drawing.Size(549, 661);
            this.panelClientSelection.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Rockwell Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(498, 56);
            this.label13.TabIndex = 20;
            this.label13.Text = "Please, select an option:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGoToRegisterClient
            // 
            this.btnGoToRegisterClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoToRegisterClient.Location = new System.Drawing.Point(34, 506);
            this.btnGoToRegisterClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGoToRegisterClient.Name = "btnGoToRegisterClient";
            this.btnGoToRegisterClient.Size = new System.Drawing.Size(104, 92);
            this.btnGoToRegisterClient.TabIndex = 25;
            this.btnGoToRegisterClient.Text = "Go To Register Client";
            this.btnGoToRegisterClient.UseVisualStyleBackColor = true;
            this.btnGoToRegisterClient.Click += new System.EventHandler(this.btnGoToRegisterClient_Click);
            // 
            // btnGoToDeleteClient
            // 
            this.btnGoToDeleteClient.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGoToDeleteClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.btnGoToDeleteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoToDeleteClient.FlatAppearance.BorderSize = 10;
            this.btnGoToDeleteClient.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToDeleteClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.btnGoToDeleteClient.Location = new System.Drawing.Point(26, 560);
            this.btnGoToDeleteClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGoToDeleteClient.Name = "btnGoToDeleteClient";
            this.btnGoToDeleteClient.Size = new System.Drawing.Size(135, 92);
            this.btnGoToDeleteClient.TabIndex = 26;
            this.btnGoToDeleteClient.Text = "GO TO DELETE CLIENT";
            this.btnGoToDeleteClient.UseVisualStyleBackColor = false;
            this.btnGoToDeleteClient.Click += new System.EventHandler(this.btnGoToDeleteClient_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(27, 187);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 25);
            this.label19.TabIndex = 12;
            this.label19.Text = "First Name";
            // 
            // txtMaxRent
            // 
            this.txtMaxRent.BackColor = System.Drawing.Color.White;
            this.txtMaxRent.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxRent.ForeColor = System.Drawing.Color.Black;
            this.txtMaxRent.Location = new System.Drawing.Point(280, 498);
            this.txtMaxRent.Name = "txtMaxRent";
            this.txtMaxRent.Size = new System.Drawing.Size(235, 35);
            this.txtMaxRent.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(164)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(1545, 711);
            this.Controls.Add(this.tabControlMain);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Dream House";
            this.tabControlMain.ResumeLayout(false);
            this.tabStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            this.tabBranch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBranch)).EndInit();
            this.tabClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.panelRegisterClient.ResumeLayout(false);
            this.panelRegisterClient.PerformLayout();
            this.panelDeleteClient.ResumeLayout(false);
            this.panelDeleteClient.PerformLayout();
            this.panelClientSelection.ResumeLayout(false);
            this.panelClientSelection.PerformLayout();
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
        private System.Windows.Forms.Button btnCancelRegisterClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Panel panelRegisterClient;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelDeleteClient;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDeleteByClientNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSelectDeleteClient;
        private System.Windows.Forms.Button btnSelectRegisterClient;
        private System.Windows.Forms.Panel panelClientSelection;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGoToRegisterClient;
        private System.Windows.Forms.Button btnGoToDeleteClient;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtMaxRent;
    }
}

