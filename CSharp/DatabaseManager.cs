using dotenv.net; //For loading environment variables from a .env file
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

        public DatabaseManager()
        {
            //Load the .env file
            DotEnv.Load();

            //Retrieve the environment variables
            string username = Environment.GetEnvironmentVariable("DB_USERNAME");
            string password = Environment.GetEnvironmentVariable("DB_PASSWORD");
            string dataSource = Environment.GetEnvironmentVariable("DB_DATA_SOURCE");

            //Validate the environment variables
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(dataSource))
            {
                //Throws an exception if credentials in .env file are not set or missing
                throw new Exception("Database credentials are not set. Check your .env file.");
            }

            //Build the connection string using database credentials from environment variables
            connectionString = $"User Id={username};Password={password};Data Source={dataSource}";
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
