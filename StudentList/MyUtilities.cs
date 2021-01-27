using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentList
{
    public enum QueryType
    {
        QUERY_TEXT,
        STORED_PROC,
        STORED_FUNC
    }
    class MyUtilities
    {
        private static SqlTransaction transaction;

        public bool pass = false;
        public int ifedit = 0;
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable table;
        ConnectionSetup ConnSetup = new ConnectionSetup();

        public string server, database, username, password;
        string ConnString = "data source=LAPTOP-SF9JMU5V;" +
                              "initial catalog=SampleDB;" +
                              "user id=sa;" +
                              "pwd=AimShot123;";
        public SqlConnection OpenConnection()
        {
            connection = new SqlConnection();
            try
            {
                connection.ConnectionString = ConnString;
                connection.Open();
                return connection;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void CloseConnection()
        {
            if (connection != null)
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        public DataTable SelectQuery(string query)
        {
            try
            {
                adapter = new SqlDataAdapter(query, OpenConnection());
                table = new DataTable();
                adapter.Fill(table);
                adapter.Dispose();
                return table;
            }
            catch (Exception e) { return null; }
        }


        //RunSQLCommand with parameters
        public int RunSQLCommand(string query, Dictionary<string, string> param)
        {
            SqlConnection connection = new SqlConnection(ConnString);
            try
            {
                int recordAffected;
                using (SqlCommand cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = query;
                    cmd.Parameters.AddRange(GetParams(param)); //Here is our parameters. Add it before calling ExecuteNonQuery()
                    recordAffected = cmd.ExecuteNonQuery();
                }
                return recordAffected;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return -1;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }

        //We need a method to iterate for each of the items in the dictionary.
        private Array GetParams(Dictionary<string, string> param)
        {
            var parameters = new List<SqlParameter>(); //Each item will be treated as SqlParameter object,
            foreach (KeyValuePair<string, string> entry in param)
            {
                //The key is in format @key
                //The value will be whatever value we need to add 
                parameters.Add(new SqlParameter(entry.Key, entry.Value));
            }
            return parameters.ToArray(); //Since our return type is Array, we need to convert the List<> to Array.
        }
        //Execute Transaction
        public bool RunSqlTransaction(string query, ref Dictionary<string, string> param, string transactionName, ref SqlConnection conn, ref SqlTransaction transaction, QueryType queryType)
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = query;
                    command.Connection = conn;

                    if (queryType == QueryType.QUERY_TEXT)
                        command.CommandType = CommandType.Text;
                    else if (queryType == QueryType.STORED_PROC)
                        command.CommandType = CommandType.StoredProcedure;

                    command.Transaction = transaction;
                    command.Parameters.Clear();
                    command.Parameters.AddRange(GetParams(param));
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return false;
            }
        }

        //Commit Transaction
        public static void CommitTransaction()
        {
            try
            {
                transaction.Commit();
                transaction = null;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                transaction.Rollback();
            }
        }

        //Rollback Transaction
        public static void RollbackTransaction()
        {
            try
            {
                transaction.Rollback();
                transaction = null;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
        }
    }
}
