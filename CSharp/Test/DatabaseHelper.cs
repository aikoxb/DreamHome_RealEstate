﻿using dotenv.net; // For loading environment variables from a .env file
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class DatabaseHelper
    {
        private string connectionString;

        // Constructor to initialize the connection string
        public DatabaseHelper()
        {
            // Load the .env file
            DotEnv.Load();

            // Retrieve the connection string
            connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");

            // Validate connection string
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("Connection string is not set. Check your .env file.");
            }
        }

        // Method to test the connection
        public void TestConnection()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connected to Oracle Database!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Example method to retrieve data from the dh_staff table
        public DataTable GetStaffData()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM dh_staff";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return dataTable;
        }
    }
}
