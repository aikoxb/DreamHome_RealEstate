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
            this.tabControlMain.SuspendLayout();
            this.tabStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.tabBranch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBranch)).BeginInit();
            this.tabClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
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
            this.tabControlMain.Size = new System.Drawing.Size(1499, 835);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabStaff
            // 
            this.tabStaff.Controls.Add(this.dataGridViewStaff);
            this.tabStaff.Controls.Add(this.buttonLoadStaff);
            this.tabStaff.Location = new System.Drawing.Point(4, 29);
            this.tabStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabStaff.Name = "tabStaff";
            this.tabStaff.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabStaff.Size = new System.Drawing.Size(1491, 802);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 863);
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
    }
}

