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

namespace CustomizedDataSet
{
    public partial class CustomizedDataSet : Form
    {
        private SqlConnection myConnection;
        private DataSet myDataSet;
        private SqlCommand myCommand;
        private SqlDataAdapter DataAdapter;

        public CustomizedDataSet()
        {
            InitializeComponent();
            string connectionString =
                            "Server=(localdb)\\ProjectsV13;" +
                            "Trusted_Connection=yes;" +
                            "Integrated Security=True;" +
                            "database=master;";
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();

            // create a DataSet
            myDataSet = new DataSet();
            myDataSet.CaseSensitive = true;

            // create a sql command
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = "Select FirstName, LastName from StaffTable";

            // create a DataAdapter
            DataAdapter = new SqlDataAdapter();
            DataAdapter.SelectCommand = myCommand;
            DataAdapter.TableMappings.Add("Table", "StaffTable");

            // let DataAdapter fill DataSet
            DataAdapter.Fill(myDataSet);

            // show in DataGridView
            dataGridView1.DataSource = myDataSet.Tables["StaffTable"].DefaultView;
        }
    }
}
