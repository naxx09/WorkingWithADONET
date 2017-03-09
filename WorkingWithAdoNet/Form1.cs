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
        public AdoNetForm1()
        {
            InitializeComponent();
            /*
            SqlConnection con = new SqlConnection("Server=(localdb)\\ProjectsV13;" +
                "Trusted_Connection=yes;" +
                "Integrated Security=True;" +
                "database=master;");
            SqlCommand cmd = new SqlCommand("Select * From StaffTable", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            */
            string connectionString =
                "Server=(localdb)\\ProjectsV13;" +
                "Trusted_Connection=yes;" +
                "Integrated Security=True;" +
                "database=master;";

            string commandString = "Select FirstName, LastName from StaffTable";

            SqlDataAdapter DataAdapter = new SqlDataAdapter(commandString, connectionString);

            DataSet DataSet = new DataSet();

            DataAdapter.Fill(DataSet, "StaffTable");

            DataTable DataTable = DataSet.Tables[0];

            foreach(DataRow dataRow in DataTable.Rows)
            {
                lbCustomers.Items.Add((dataRow)["FirstName"] + " " + dataRow["LastName"]);
            }
        }
    }
}
