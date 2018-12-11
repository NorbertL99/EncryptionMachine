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
    class AppInfos
    {
        public AppInfos()                                       // Constructor, empty
        {

        }
        #region error types
        public string everythingFine()                          // This method return title about some operation went fine
        {
            return "Success";
        }
        #endregion
        #region error info
        public string insertingFine()                           // This method return information about inserting went fine
        {
            return "Insert completed successfull!";             // Return info text
        }
        public string loginFine()                               // This method return information about login went fine
        {
            return "Login completed successfull!";              // Return info text
        }
        public string deleteingFine()                           // This method return informationa about deleteing went fine
        {
            return "Deleteing code completed successfull!";     // Return info text
        }
        public string updateingFine()                           // This method return informationa about updateing went fine
        {
            return "Updateing code completed successfull!";     // Return info text
        }
        public string encryptFine()                             // This method return information about encrypting went fine
        {
            return "Encrypting completed successfull!";         // Return info text
        }
        public string decryptionFine()                          // This method return information about decrypting went fine
        {
            return "Decryption completed successfull!";         // Return info text
        }
        #endregion
    }
}
