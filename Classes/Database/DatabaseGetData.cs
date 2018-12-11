// Created by Norbert Lubaszka
// Contact: norbert.lubaszka@gmail.com
// All rights reserved ©
// If you want to use the source code contact me
                                                                                                // References
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;                                                                   // Allow to use MySql database
using Encryption_Machine.Classes;                                                               // Allow to use program classes
using Encryption_Machine.Classes.Database;                                                      // Allow to use program database classes
using System.Data;

namespace Encryption_Machine.Classes.Database
{
    class DatabaseGetData
    {
        DatabaseConnect databaseConnect = new DatabaseConnect();                                // Creating new object of DatabaseConnection
        AppWeb appWeb = new AppWeb();                                                           // Create new object of AppWeb
        public DatabaseGetData()                                                                // Constructor, empty   
        {

        }
        public int checkCodeExist(string codeName)                                              // This method checking of code exist
        {
            if(appWeb.checkInternetConnection() == 0)                                           // If there is no internet connection
            {
                return 0;
            }
            else                                                                                // If there is internet connection
            {
                MySqlConnection sqlConnection = new MySqlConnection(                            // Creating new object of MySqlConnection
                    databaseConnect.returnConnectionString());                                  // As a connection give connectionString from DatabaseConnect class
                string commandString =                                                          // This variable story MySql command
                    "SELECT `code_name` FROM `codes` WHERE `code_name` = '" + codeName + "'";   // MySql command
                try                                                                             // Hold errors while connecting to database
                { 
                    if (sqlConnection.State == ConnectionState.Closed)                          // If connection is close
                    {
                        sqlConnection.Open();                                                   // Open it
                    }
                    MySqlCommand sqlCommand =                                                   // Creating new object of MySqlCommand
                        new MySqlCommand(commandString, sqlConnection);                         // As parameters give commandString and sqlConnection
                    MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(sqlCommand);             // Create new object of MySqlDataAdapter, as parameters give sqlCommand
                    DataSet ds = new DataSet();                                                 // Create new object of DataSet
                    sqlAdapter.Fill(ds);                                                        // File sql result into ds
                    sqlConnection.Close();                                                      // Closing connection
                    int value = ds.Tables[0].Rows.Count;                                        // Creating variable with store value of record returned in row 0
                    if (value == 0)                                                             // If this value is 0
                    {
                        return 3;                                                               // Return 3
                    }
                    else if (value > 0)                                                         // If there are some records
                    {
                        return 2;                                                               // Return 2
                    }
                }
                catch (Exception)                                                               // If some exception catched                    
                {
                    return 1;                                                                   // Return 1
                }
                return 1;                                                                       // Return 1
            }
        }
        public int checkLoginData(string codeName, string password)                             // This method check about code login datas are correct
        {
            if(appWeb.checkInternetConnection() == 0)                                           // If there is no internet connection
            {
                return 0;                                                                       // Return 0
            }
            else                                                                                // If there is internet connection
            {
                MySqlConnection sqlConnection = new MySqlConnection(                            // Creating new object of MySqlConnection
                   databaseConnect.returnConnectionString());                                   // As a connection give connectionString from DatabaseConnect class
                string commandString =                                                          // This variable story MySql command
                    "SELECT `code_name`, `code_admin_password` FROM `codes` WHERE" +            // MySql command
                    " `code_name` = '" + codeName + "' AND `code_admin_password`" +             // MySql command
                    " = '" + password + "' ";                                                   // MySql command
                try                                                                             // Hold errors while connecting to database
                {
                    if (sqlConnection.State == ConnectionState.Closed)                          // If connection is close
                    {
                        sqlConnection.Open();                                                   // Open it
                    }
                    MySqlCommand sqlCommand =                                                   // Creating new object of MySqlCommand
                        new MySqlCommand(commandString, sqlConnection);                         // As parameters give commandString and sqlConnection
                    MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(sqlCommand);             // Create new object of MySqlDataAdapter, as parameters give sqlCommand
                    DataSet ds = new DataSet();                                                 // Create new object of DataSet
                    sqlAdapter.Fill(ds);                                                        // File sql result into ds
                    sqlConnection.Close();                                                      // Closing connection
                    int value = ds.Tables[0].Rows.Count;                                        // Creating variable with store value of record returned in row 0
                    if (value == 0)                                                             // If this value is 0
                    {
                        return 2;                                                               // Return 2
                    }
                    else if (value > 0)                                                         // If there are some records
                    {
                        return 3;                                                               // Return 3
                    }
                }
                catch (Exception)                                                               // If some exception catched                    
                {
                    return 1;                                                                   // Return 1
                }
                return 1;                                                                       // Return 1
            }
        }
        public DataTable getFullCode(string codeName)                                           // This method return whole code for given table name
        {
            try                                                                                 // Hold errors while working in database
            {
                MySqlConnection sqlConnection = new MySqlConnection(                            // Creating new object of MySqlConnection
                        databaseConnect.returnConnectionString());                              // As a connection give connectionString from DatabaseConnect class
                string commandString =                                                          // This variable store sql command with counting code
                    "SELECT * FROM `codes` WHERE `code_name` = '" + codeName + "' ";            // Sql question
                if (sqlConnection.State == ConnectionState.Closed)                              // If sql connection is closed                                                    
                {
                    sqlConnection.Open();                                                       // Opening it
                }
                MySqlCommand sqlCommand = new MySqlCommand(commandString, sqlConnection);       // Creating new object of MySqlCommand
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);             // Creating new object of MySqlDataAdapter
                sqlDataAdapter.SelectCommand = sqlCommand;                                      // Executing command                                                        
                DataTable dTable = new DataTable();                                             // Creating new object of DataTable
                sqlDataAdapter.Fill(dTable);                                                    // Fill data in table
                sqlConnection.Close();                                                          // Closing connection
                return dTable;                                                                  // Return table
            }
            catch (Exception)                                                                   // If some errors catched
            {
                return null;                                                                    // Return null
            }
        }
        public DataTable getSpecificChar(string codeName, string charForCode)                   // This method return code for given char
        {
            try                                                                                 // Hold errors while working in database
            {
                MySqlConnection sqlConnection = new MySqlConnection(                            // Creating new object of MySqlConnection
                        databaseConnect.returnConnectionString());                              // As a connection give connectionString from DatabaseConnect class
                string commandString =                                                          // This variable store sql command with counting code
                    "SELECT `" + charForCode + "` FROM `codes` WHERE" +                         // Sql question
                    " `code_name` = '" + codeName + "' ";                                       // Sql question
                if (sqlConnection.State == ConnectionState.Closed)                              // If sql connection is closed                                                    
                {
                    sqlConnection.Open();                                                       // Opening it
                }
                MySqlCommand sqlCommand = new MySqlCommand(commandString, sqlConnection);       // Creating new object of MySqlCommand
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);             // Creating new object of MySqlDataAdapter
                sqlDataAdapter.SelectCommand = sqlCommand;                                      // Executing command                                                        
                DataTable dTable = new DataTable();                                             // Creating new object of DataTable
                sqlDataAdapter.Fill(dTable);                                                    // Fill data in table
                sqlConnection.Close();                                                          // Closing connection
                return dTable;                                                                  // Return table
            }
            catch (Exception)                                                                   // If some errors catched
            {
                return null;                                                                    // Return null
            }
        }
        public string returnCodeForChar(string codeName, string charName)                       // This method return code for char
        {
            try                                                                                 // Support errors while geting data from database
            {
                MySqlConnection sqlConnection = new MySqlConnection(                            // Creating new object of MySqlConnection
                    databaseConnect.returnConnectionString());                                  // As a connection give connectionString from DatabaseConnect class
                string commandString =                                                          // Thsi variable store sql question
                    "SELECT `" + charName + "` FROM `codes` WHERE" +                            // Sql question
                    " `code_name` = '" + codeName + "' ;";                                      // Sql question
                if (sqlConnection.State == ConnectionState.Closed)                              // If sql connection is closed
                {
                    sqlConnection.Open();                                                       // Opening it
                }
                MySqlCommand sqlCommand = new MySqlCommand(commandString, sqlConnection);       // Creating new object of MySqlCommand
                MySqlDataReader sqlReader;                                                      // Creating new object of MySqlReader
                sqlReader = sqlCommand.ExecuteReader();                                         // Execute sqlCommand with sqlReader
                string effect = "";                                                             // Create variable with will store returned code for given char
                while (sqlReader.Read())                                                        // While we can read
                {
                    effect = sqlReader.GetValue(0).ToString();                                  // Effect value is code returned from database
                }
                sqlConnection.Close();                                                          // Closeing connection
                return effect;                                                                  // Returning founded data
            }
            catch (Exception)                                                                   // If some error found
            {
                return string.Empty;                                                            // Returne empty string
            }
        }
        public int checkCodeData(string codeName, string password)                              // This method check about code login datas are correct
        {
            if (appWeb.checkInternetConnection() == 0)                                          // If there is no internet connection
            {
                return 0;                                                                       // Return 0
            }
            else                                                                                // If there is internet connection
            {
                MySqlConnection sqlConnection = new MySqlConnection(                            // Creating new object of MySqlConnection
                   databaseConnect.returnConnectionString());                                   // As a connection give connectionString from DatabaseConnect class
                string commandString =                                                          // This variable story MySql command
                    "SELECT `code_name`, `code_password` FROM `codes` WHERE" +                  // MySql command
                    " `code_name` = '" + codeName + "' AND `code_password`" +                   // MySql command
                    " = '" + password + "' ";                                                   // MySql command
                try                                                                             // Hold errors while connecting to database
                {
                    if (sqlConnection.State == ConnectionState.Closed)                          // If connection is close
                    {
                        sqlConnection.Open();                                                   // Open it
                    }
                    MySqlCommand sqlCommand =                                                   // Creating new object of MySqlCommand
                        new MySqlCommand(commandString, sqlConnection);                         // As parameters give commandString and sqlConnection
                    MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(sqlCommand);             // Create new object of MySqlDataAdapter, as parameters give sqlCommand
                    DataSet ds = new DataSet();                                                 // Create new object of DataSet
                    sqlAdapter.Fill(ds);                                                        // File sql result into ds
                    sqlConnection.Close();                                                      // Closing connection
                    int value = ds.Tables[0].Rows.Count;                                        // Creating variable with store value of record returned in row 0
                    if (value == 0)                                                             // If this value is 0
                    {
                        return 2;                                                               // Return 2
                    }
                    else if (value > 0)                                                         // If there are some records
                    {
                        return 3;                                                               // Return 3
                    }
                }
                catch (Exception)                                                               // If some exception catched                    
                {
                    return 1;                                                                   // Return 1
                }
                return 1;                                                                       // Return 1
            }
        }
        public int returnCharForCode(string codeName, string charName, string charCode)         // This method searching for char with given code
        {
            try                                                                                 // Support errors while creating new table
            {
                MySqlConnection sqlConnection = new MySqlConnection(                            // Creating new object of MySqlConnection
                  databaseConnect.returnConnectionString());                                    // As a connection give connectionString from DatabaseConnect class
                string commandString =                                                          // This variable store sql command with checking chars
                    "SELECT `" + charName + "` FROM `codes` WHERE `"                            // Sql question
                    + charName + "` = '" + charCode + "' AND `code_name` = '" + codeName + "';";// Sql question         
                if (sqlConnection.State == ConnectionState.Closed)                              // If sql connection is closed                                                    
                {
                    sqlConnection.Open();                                                       // Opening it
                }
                MySqlCommand sqlCommand = new MySqlCommand(commandString, sqlConnection);       // Creating new object of MySqlCommand 
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);             // Creating new object of MySqlDataAdapter
                DataSet dataSet = new DataSet();                                                // Creating new object of DataSet
                sqlDataAdapter.Fill(dataSet);                                                   // Puting data to collection
                sqlConnection.Close();                                                          // Closing connection
                int value = dataSet.Tables[0].Rows.Count;                                       // Creating new variable with store number of results
                if (value == 0)                                                                 // If there is no records
                {
                    return 1;                                                                   // Return 1
                }
                else if (value > 0)                                                             // If there are some record
                {
                    return 2;                                                                   // Return 2
                }
            }
            catch (Exception)                                                                   // If some errors found
            {
                return 0;                                                                       // Return 0
            }
            return 0;                                                                           // Return 0
        }
    }
}
