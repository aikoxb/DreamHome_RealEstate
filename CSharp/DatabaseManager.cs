using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class DatabaseManager
    {
        private string connectionString;

        public DatabaseManager(string username, string password)
        {
            connectionString = $"User Id={username};Password={password};Data Source=199.212.26.208:1521/SQLD";
        }

        //this method grabs the queries we want to run from sql files
        public string LoadQueryFromFile(string fileName)
        {
            string path = Path.Combine("..", "..", "..", "sql", fileName); //only checks for files in our sql folder

            if (!File.Exists(path))
            {
                throw new FileNotFoundException("SQL file not found: " + path);
            }

            return File.ReadAllText(path);
        }

        //this method actually executes queries and then returns the result as a DataTable
        public DataTable ExecuteQuery(string query)
        {
            DataTable table = new DataTable();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }

            return table;
        }
    }
}
