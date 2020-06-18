using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Blood_Bank.App_Code
{
    class DataConnection
    {
        SqlConnection con;
        public DataConnection()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Learning\learningC#\Blood Bank\Connection\dbBloodBank.mdf;Integrated Security=True");
        }
        private void openConnection()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        private void closeConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public DataTable getTable(string SQL)
        {
            DataTable tb = new DataTable();
            openConnection();
            SqlDataAdapter adp = new SqlDataAdapter(SQL, con);
            adp.Fill(tb);
            closeConnection();
            return tb;
        }
        public void executeSQL(string SQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.ExecuteNonQuery();
            closeConnection();
        }
    }
}
