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

namespace Encryption_Machine.Classes
{
    class AppErrors
    {
        public AppErrors()                                              // Constructor, empty
        {

        }

        #region error types
        public string textError()                                       // This method return text error
        {
            return "Text error";                                        // Return error title
        }
        public string webError()                                        // This method return web error
        {
            return "Web error";                                         // Return error title
        }
        public string databaseError()                                   // This method return database error
        {
            return "Database error";                                    // Return error title
        }
        public string fileError()                                       // This method return file error
        {
            return "File error";                                        // Return error title
        }
        #endregion

        #region error info
        public string emptyGap()                                        // This method return info about some empty gap
        {
            return "Some gap is empty!";                                // Return error text
        }
        public string codeReplace()                                     // This method return info about some code replace
        {
            return "Some char code was given two times!";               // Return error text
        }
        public string noInternet()                                      // This method return info about no internet connection
        {
            return "There is no internet connection!";                  // Return error text
        }
        public string databaseFail()                                    // This method return info about some error while connecting to database
        {
            return "Some error while working in database!";             // Return error text
        }
        public string codeExist()                                       // This method return info about code with this name already exist
        {
            return "Code with given name already exist!";               // Return error text
        }
        public string insertFail()                                      // This method return info about some error while inserting data
        {
            return "Some error while inserting new data!";              // Return error text
        }
        public string wrongLogin()                                      // This method return info about wrong login data
        {
            return "Wrong code name or password!";                      // Return error text
        }
        public string fileFail()                                        // This method return info about error while working with temporary file
        {
            return "Error while working with temporary file!";          // Return error text
        }
        #endregion
    }
}
