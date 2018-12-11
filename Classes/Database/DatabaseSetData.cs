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
using MySql.Data.MySqlClient;                                                                            // Allow to use MySql database
using Encryption_Machine.Classes;                                                                        // Allow to use program classes
using Encryption_Machine.Classes.Database;                                                               // Allow to use program database classes
using System.Data;

namespace Encryption_Machine.Classes.Database
{
    class DatabaseSetData
    {
        DatabaseConnect databaseConnect = new DatabaseConnect();                                         // Create new object of DatabaseConnect
        AppWeb appWeb = new AppWeb();                                                                    // Create new object of AppWeb
        DatabaseGetData getData = new DatabaseGetData();                                                 // Create new object of DatabaseGetData
        public DatabaseSetData()                                                                         // Constructor, empty
        {

        }
        public int insertNewCode(string codeName, string codePassword, string codeAdminPassword,         // This method inserting new code
            string charA, string charB, string charC, string charD, string charE, string charF,          // Arguments are char codes
            string charG, string charH, string charI, string charJ, string charK, string charL,          // Arguments are char codes
            string charM, string charN, string charO, string charP, string charQ, string charR,          // Arguments are char codes
            string charS, string charT, string charU, string charV, string charW, string charX,          // Arguments are char codes
            string charY, string charZ, string char1, string char2, string char3, string char4,          // Arguments are char codes
            string char5, string char6, string char7, string char8, string char9, string char0,          // Arguments are char codes
            string charDOT, string charSPACE)                                                            // Arguments are char codes
        {
            if(appWeb.checkInternetConnection() == 0)                                                    // If there is no internet connection
            {
                return 0;                                                                                // Return 0
            }
            else                                                                                         // If there is internet connection
            {
                var control = getData.checkCodeExist(codeName);                                          // Setting value of control with value returne by method with checking about same code exist
                if(control == 0)                                                                         // If control value is 0
                {
                    return 0;                                                                            // Returne 0
                }
                else if(control == 1)                                                                    // If control value is 1
                {
                    return 1;                                                                            // Returne 1
                }
                else if (control == 2)                                                                   // If control value is 2
                { 
                    return 2;                                                                            // Returne 2
                }
                else if (control == 3)                                                                   // If control value is 3
                {
                    MySqlConnection sqlConnection = new MySqlConnection(                                 // Creating new object of MySqlConnection
                        databaseConnect.returnConnectionString());                                       // As a connection give connectionString returned from DatabaseConnect class
                    string commandString =                                                               // This variable store sql question
                        "INSERT INTO `codes`(`code_name`, `code_password`, `code_admin_password`," +     // Sql question
                        " `charA`, `charB`, `charC`, `charD`, `charE`, `charF`, `charG`, `charH`," +     // Sql question
                        " `charI`, `charJ`, `charK`, `charL`, `charM`, `charN`, `charO`, `charP`," +     // Sql question
                        " `charQ`, `charR`, `charS`, `charT`, `charU`, `charV`, `charW`, `charX`," +     // Sql question
                        " `charY`, `charZ`, `char1`, `char2`, `char3`, `char4`, `char5`, `char6`," +     // Sql question
                        " `char7`, `char8`, `char9`, `char0`, `charDOT`, `charSPACE`) VALUES" +          // Sql question
                        " ('" + codeName +"','" + codePassword + "','" + codeAdminPassword + "'," +      // Sql question
                        " '" + charA + "','" + charB + "','" + charC + "','" + charD + "'," +            // Sql question
                        " '" + charE + "','" + charF + "','" + charG + "','" + charH + "'," +            // Sql question
                        " '" + charI + "','" + charJ + "','" + charK + "','" + charL + "'," +            // Sql question
                        " '" + charM + "','" + charN + "','" + charO + "','" + charP + "'," +            // Sql question
                        " '" + charQ + "','" + charR + "','" + charS + "','" + charT + "'," +            // Sql question
                        " '" + charU + "','" + charV + "','" + charW + "','" + charX + "'," +            // Sql question
                        " '" + charY + "','" + charZ + "','" + char1 + "','" + char2 + "'," +            // Sql question
                        " '" + char3 + "','" + char4 + "','" + char5 + "','" + char6 + "'," +            // Sql question
                        " '" + char7 + "','" + char8 + "','" + char9 + "','" + char0 + "'," +            // Sql question
                        " '" + charDOT + "','" + charSPACE + "');";                                      // Sql question
                    try                                                                                  // Hold errors while working in database                                                
                    {
                        if (sqlConnection.State == ConnectionState.Closed)                               // If connection to database is closed        
                        {
                            sqlConnection.Open();                                                        // Open connection
                        }
                        MySqlCommand sqlCommand =                                                        // Create new object of MySqlCommand
                            new MySqlCommand(commandString, sqlConnection);                              // As parameters give commadnString and sqlConnection
                        MySqlDataReader myReader;                                                        // Create new object of MySqlDataReader
                        myReader = sqlCommand.ExecuteReader();                                           // Execute sql command
                        sqlConnection.Close();                                                           // Closing connection
                        return 4;                                                                        // Return 4
                    }
                    catch (Exception)                                                                    // If some errors found
                    {
                        return 3;                                                                        // Return 3
                    }
                   
                }
                else                                                                                     // Else
                {
                    return 1;                                                                            // Return 1    
                }
            }
        }
        public int deleteCode(string codeName)                                                           // This method deleteing code from database
        {
            if (appWeb.checkInternetConnection() == 0)                                                   // If there is no internet connection
            {
                return 0;                                                                                // Return 0
            }
            else                                                                                         // If there is internet connection
            {
                MySqlConnection sqlConnection = new MySqlConnection(                                     // Creating new object of MySqlConnection
                databaseConnect.returnConnectionString());                                               // As a connection give connectionString returned from DatabaseConnect class
                string commandString = "DELETE FROM `codes` WHERE `code_name` = '" + codeName + "'";     // This variable store sql question

                try                                                                                      // Hold errors while working in database                                                
                {
                    if (sqlConnection.State == ConnectionState.Closed)                                   // If connection to database is closed        
                    {
                        sqlConnection.Open();                                                            // Open connection
                    }
                    MySqlCommand sqlCommand =                                                            // Create new object of MySqlCommand
                    new MySqlCommand(commandString, sqlConnection);                                      // As parameters give commadnString and sqlConnection
                    MySqlDataReader myReader;                                                            // Create new object of MySqlDataReader
                    myReader = sqlCommand.ExecuteReader();                                               // Execute sql command
                    sqlConnection.Close();                                                               // Closing connection
                    return 2;                                                                            // Return 2
                }
                catch (Exception)                                                                        // If some errors found
                {
                    return 1;                                                                            // Return 1
                }

            }
        }
        public int updateValue(string codeName, string toUpdate, string newValue)                        // This method updateing values in database
        {
            if (appWeb.checkInternetConnection() == 0)                                                   // If there is no internet connection
            {
                return 0;                                                                                // Return 0
            }
            else                                                                                         // If there is internet connection
            {
                MySqlConnection sqlConnection = new MySqlConnection(                                     // Creating new object of MySqlConnection
                databaseConnect.returnConnectionString());                                               // As a connection give connectionString returned from DatabaseConnect class
                string commandString = "UPDATE `codes` SET `" + toUpdate + "`= '" + newValue +           // This variable store sql question
                    "' WHERE `code_name` = '" + codeName + "'";                                          // This variable store sql question
                try                                                                                      // Hold errors while working in database                                                
                {
                    if (sqlConnection.State == ConnectionState.Closed)                                   // If connection to database is closed        
                    {
                        sqlConnection.Open();                                                            // Open connection
                    }
                    MySqlCommand sqlCommand =                                                            // Create new object of MySqlCommand
                    new MySqlCommand(commandString, sqlConnection);                                      // As parameters give commadnString and sqlConnection
                    MySqlDataReader myReader;                                                            // Create new object of MySqlDataReader
                    myReader = sqlCommand.ExecuteReader();                                               // Execute sql command
                    sqlConnection.Close();                                                               // Closing connection
                    return 2;                                                                            // Return 2
                }
                catch (Exception)                                                                        // If some errors found
                {
                    return 1;                                                                            // Return 1
                }

            }
        }
    }
}
