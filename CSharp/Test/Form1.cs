using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {

        private DatabaseHelper dbHelper;
        public Form1()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper(); // Initialize the helper class
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadStaff_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve data and bind to DataGridView
                var staffData = dbHelper.GetStaffData();
                dataGridViewStaff.DataSource = staffData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
