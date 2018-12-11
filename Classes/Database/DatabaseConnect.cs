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
using MySql.Data.MySqlClient;                                               // Allow to use MySql database

namespace Encryption_Machine.Classes.Database
{
    class DatabaseConnect
    {
        public DatabaseConnect()                                            // Constructor, empty                          
        {

        }
        static string datasource = "datasource=127.0.0.1;";                 // Database ip
        static string port = "port=3306;";                                  // Database port
        static string username = "username=root;";                          // Database user
        static string password = "password=;";                              // Database user password
        static string database = "database=encryption_machine;";            // Database name
        static string sslmode = "sslmode=none;";                            // Database sslmode
        static string connectionString = datasource + port + username       // This variable story completed connection info
            + password + database + sslmode;                                // This variable story completed connection info
        public string returnConnectionString()                              // This method returning connection string
        {
            return connectionString;                                        // Returning connection string
        }
    }
}
