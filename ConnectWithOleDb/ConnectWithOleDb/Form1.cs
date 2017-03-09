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

            string connectionString =
                "provider=Microsoft.JET.OLEDB.4.0;" +
                "data source = Database\\staff.mdb";
            string commandString = "Select FirstName, LastName from staffTable";

            OleDbDataAdapter DataAdapter = new OleDbDataAdapter(commandString, connectionString);

            DataSet DataSet = new DataSet();

            DataAdapter.Fill(DataSet, "staffTable");

            DataTable DataTable = DataSet.Tables[0];

            foreach(DataRow DataRow in DataTable.Rows)
            {
                lbCustomers.Items.Add(DataRow["FirstName"] + " " + DataRow["LastName"]);
            }
        }
    }
}
