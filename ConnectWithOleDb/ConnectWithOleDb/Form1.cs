using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectWithOleDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // connect with staff database
            string connectionString =
                "provider=Microsoft.JET.OLEDB.4.0;" +
                "data source = Database\\staff.mdb";

            // get data from staffTable
            string commandString = "Select FirstName, LastName from staffTable";

            // create a dataset
            OleDbDataAdapter DataAdapter = new OleDbDataAdapter(commandString, connectionString);

            DataSet DataSet = new DataSet();

            // fill dataset
            DataAdapter.Fill(DataSet, "staffTable");

            // get a table from dataset
            DataTable DataTable = DataSet.Tables[0];

            // bing dataset with listbox
            foreach(DataRow DataRow in DataTable.Rows)
            {
                lbCustomers.Items.Add(DataRow["FirstName"] + " " + DataRow["LastName"]);
            }

            // bind dataset with datagridview
            dgvStaff.DataSource = DataSet.Tables["staffTable"].DefaultView;
        }
    }
}
