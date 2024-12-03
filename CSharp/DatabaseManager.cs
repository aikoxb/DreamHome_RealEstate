using dotenv.net; //For loading environment variables from a .env file
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
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

            //Establish connection to Oracle database using the OracleConnection class
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open(); //Open the connection

                //Create new command object for the query using the OracleCommand class
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

        //Method - Executes a SQL Stored Procedure
        //Dynamically accepts any parameter value's data type through a list of OracleParameter objects.
        public void ExecuteStoredProcedure(string procedureName, List<OracleParameter> parameters)
        {
            //Establish connection to Oracle database using the OracleConnection class
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open(); //Open the connection

                //Create new command object for the stored procedure using the OracleCommand class
                using (OracleCommand command = new OracleCommand(procedureName, connection))
                {
                    //Specify the command object is a stored procedure by setting the CommandType property
                    command.CommandType = CommandType.StoredProcedure;

                    //Loop through each OracleParameter object in the list
                    foreach (var param in parameters)
                    {
                        //Add the OracleParameter to the Parameters property of the OracleCommand
                        //The Parameters property is a part of the OracleCommand class and holds all parameters for the stored procedure
                        command.Parameters.Add(param); 
                    }

                    //Execute the stored procedure with no returned data
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
