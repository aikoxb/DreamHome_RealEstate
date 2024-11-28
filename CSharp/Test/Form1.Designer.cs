namespace Test
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
            this.btnLoadStaff = new System.Windows.Forms.Button();
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadStaff
            // 
            this.btnLoadStaff.Location = new System.Drawing.Point(119, 62);
            this.btnLoadStaff.Name = "btnLoadStaff";
            this.btnLoadStaff.Size = new System.Drawing.Size(75, 23);
            this.btnLoadStaff.TabIndex = 0;
            this.btnLoadStaff.Text = "load staff";
            this.btnLoadStaff.UseVisualStyleBackColor = true;
            this.btnLoadStaff.Click += new System.EventHandler(this.btnLoadStaff_Click);
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Location = new System.Drawing.Point(298, 54);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.RowHeadersWidth = 51;
            this.dataGridViewStaff.RowTemplate.Height = 24;
            this.dataGridViewStaff.Size = new System.Drawing.Size(473, 259);
            this.dataGridViewStaff.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewStaff);
            this.Controls.Add(this.btnLoadStaff);
            this.Name = "Form1";
            this.Text = "Load Staff";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadStaff;
        private System.Windows.Forms.DataGridView dataGridViewStaff;
    }
}

