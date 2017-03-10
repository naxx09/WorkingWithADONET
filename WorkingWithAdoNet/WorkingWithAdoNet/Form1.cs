using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingWithAdoNet
{
    public partial class AdoNetForm1 : Form
    {
        private AccessClass StaffDB = new AccessClass();
        public AdoNetForm1()
        {
            InitializeComponent();

            StaffDB.ExecuteQuery("Select * from StaffTable");
            if(StaffDB.exception != string.Empty)
            {
                MessageBox.Show(StaffDB.exception);
            }

            foreach(DataRow dataRow in StaffDB.dbDataTable.Rows)
            {
                lbCustomers.Items.Add((dataRow)["FirstName"] + " " + dataRow["LastName"]);
            }

            dataGridView1.DataSource = StaffDB.dbDataTable;
        }        
        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            StaffDB.AddParam("@FirstName", tbFirstName.Text + "%");
            StaffDB.ExecuteQuery("select * from StaffTable where FirstName like @FirstName");

            if(StaffDB.exception != string.Empty)
            {
                MessageBox.Show(StaffDB.exception);
                return;
            }
            dataGridView1.DataSource = StaffDB.dbDataTable;
        }
        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            StaffDB.AddParam("@LastName", tbLastName.Text + "%");
            StaffDB.ExecuteQuery("select * from StaffTable where LastName like @LastName");

            if (StaffDB.exception != string.Empty)
            {
                MessageBox.Show(StaffDB.exception);
                return;
            }
            dataGridView1.DataSource = StaffDB.dbDataTable;
        }

        private void tbFirstName_GotFocus(object sender, EventArgs e)
        {
            tbLastName.Text = string.Empty;
        }

        private void tbLastName_GotFocus(object sender, EventArgs e)
        {
            tbFirstName.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
