using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithAdoNet
{
    public class AccessClass
    {
        private SqlConnection dbConnection = new SqlConnection(
            "Server=(localdb)\\ProjectsV13;" +
            "Trusted_Connection=yes;" +
            "Integrated Security=True;" +
            "database=master;");

        private SqlCommand dbCommand;
        public SqlDataAdapter dbDataAdapter;
        //public DataSet dbDataSet;
        public DataTable dbDataTable;
        public List<SqlParameter> Params = new List<SqlParameter>();
        public int RecordCount;
        public string exception;

        public void ExecuteQuery(string QueryString)
        {
            RecordCount = 0;
            exception = string.Empty;
            try
            {
                dbConnection.Open();
                dbCommand = new SqlCommand(QueryString, dbConnection);
                foreach(SqlParameter p in Params)
                {
                    dbCommand.Parameters.Add(p);
                }
                Params.Clear();
                dbDataTable = new DataTable();
                dbDataAdapter = new SqlDataAdapter(dbCommand);
                RecordCount = dbDataAdapter.Fill(dbDataTable);
            }
            catch(Exception ex)
            {
                exception = ex.Message;
            }
            if(dbConnection.State == ConnectionState.Open)
            {
                dbConnection.Close();
            }
        }
        public void AddParam(string Name, object value)
        {
            SqlParameter NewParam = new SqlParameter(Name, value);
            Params.Add(NewParam);
        }
    }
}
