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
            this.tabBranch = new System.Windows.Forms.TabPage();
            this.tabClient = new System.Windows.Forms.TabPage();
            this.buttonLoadStaff = new System.Windows.Forms.Button();
            this.buttonLoadBranch = new System.Windows.Forms.Button();
            this.buttonLoadClient = new System.Windows.Forms.Button();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.dataGridViewBranch = new System.Windows.Forms.DataGridView();
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.tabControlMain.SuspendLayout();
            this.tabStaff.SuspendLayout();
            this.tabBranch.SuspendLayout();
            this.tabClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabStaff);
            this.tabControlMain.Controls.Add(this.tabBranch);
            this.tabControlMain.Controls.Add(this.tabClient);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(776, 426);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabStaff
            // 
            this.tabStaff.Controls.Add(this.dataGridViewStaff);
            this.tabStaff.Controls.Add(this.buttonLoadStaff);
            this.tabStaff.Location = new System.Drawing.Point(4, 25);
            this.tabStaff.Name = "tabStaff";
            this.tabStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabStaff.Size = new System.Drawing.Size(768, 397);
            this.tabStaff.TabIndex = 0;
            this.tabStaff.Text = "Staff Menu";
            this.tabStaff.UseVisualStyleBackColor = true;
            // 
            // tabBranch
            // 
            this.tabBranch.Controls.Add(this.dataGridViewBranch);
            this.tabBranch.Controls.Add(this.buttonLoadBranch);
            this.tabBranch.Location = new System.Drawing.Point(4, 25);
            this.tabBranch.Name = "tabBranch";
            this.tabBranch.Padding = new System.Windows.Forms.Padding(3);
            this.tabBranch.Size = new System.Drawing.Size(768, 397);
            this.tabBranch.TabIndex = 1;
            this.tabBranch.Text = "Branch Menu";
            this.tabBranch.UseVisualStyleBackColor = true;
            // 
            // tabClient
            // 
            this.tabClient.Controls.Add(this.dataGridViewClient);
            this.tabClient.Controls.Add(this.buttonLoadClient);
            this.tabClient.Location = new System.Drawing.Point(4, 25);
            this.tabClient.Name = "tabClient";
            this.tabClient.Size = new System.Drawing.Size(768, 397);
            this.tabClient.TabIndex = 2;
            this.tabClient.Text = "Client Menu";
            this.tabClient.UseVisualStyleBackColor = true;
            // 
            // buttonLoadStaff
            // 
            this.buttonLoadStaff.Location = new System.Drawing.Point(40, 57);
            this.buttonLoadStaff.Name = "buttonLoadStaff";
            this.buttonLoadStaff.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadStaff.TabIndex = 0;
            this.buttonLoadStaff.Text = "Load Staff";
            this.buttonLoadStaff.UseVisualStyleBackColor = true;
            this.buttonLoadStaff.Click += new System.EventHandler(this.buttonLoadStaff_Click);
            // 
            // buttonLoadBranch
            // 
            this.buttonLoadBranch.Location = new System.Drawing.Point(38, 40);
            this.buttonLoadBranch.Name = "buttonLoadBranch";
            this.buttonLoadBranch.Size = new System.Drawing.Size(106, 23);
            this.buttonLoadBranch.TabIndex = 0;
            this.buttonLoadBranch.Text = "Load Branch";
            this.buttonLoadBranch.UseVisualStyleBackColor = true;
            this.buttonLoadBranch.Click += new System.EventHandler(this.buttonLoadBranch_Click);
            // 
            // buttonLoadClient
            // 
            this.buttonLoadClient.Location = new System.Drawing.Point(46, 41);
            this.buttonLoadClient.Name = "buttonLoadClient";
            this.buttonLoadClient.Size = new System.Drawing.Size(95, 23);
            this.buttonLoadClient.TabIndex = 0;
            this.buttonLoadClient.Text = "Load Client";
            this.buttonLoadClient.UseVisualStyleBackColor = true;
            this.buttonLoadClient.Click += new System.EventHandler(this.buttonLoadClient_Click);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Location = new System.Drawing.Point(301, 41);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.RowHeadersWidth = 51;
            this.dataGridViewClient.RowTemplate.Height = 24;
            this.dataGridViewClient.Size = new System.Drawing.Size(434, 329);
            this.dataGridViewClient.TabIndex = 1;
            // 
            // dataGridViewBranch
            // 
            this.dataGridViewBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBranch.Location = new System.Drawing.Point(346, 40);
            this.dataGridViewBranch.Name = "dataGridViewBranch";
            this.dataGridViewBranch.RowHeadersWidth = 51;
            this.dataGridViewBranch.RowTemplate.Height = 24;
            this.dataGridViewBranch.Size = new System.Drawing.Size(346, 266);
            this.dataGridViewBranch.TabIndex = 1;
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Location = new System.Drawing.Point(364, 57);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.RowHeadersWidth = 51;
            this.dataGridViewStaff.RowTemplate.Height = 24;
            this.dataGridViewStaff.Size = new System.Drawing.Size(359, 245);
            this.dataGridViewStaff.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControlMain.ResumeLayout(false);
            this.tabStaff.ResumeLayout(false);
            this.tabBranch.ResumeLayout(false);
            this.tabClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
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
        private System.Windows.Forms.Button buttonLoadClient;
        private System.Windows.Forms.DataGridView dataGridViewStaff;
        private System.Windows.Forms.DataGridView dataGridViewBranch;
    }
}

