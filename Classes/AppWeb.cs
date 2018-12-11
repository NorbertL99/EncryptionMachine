// Created by Norbert Lubaszka
// Contact: norbert.lubaszka@gmail.com
// All rights reserved ©
// If you want to use the source code contact me
                                                                                    // References
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;                                                                   // This namespace allow to use net classes
using System.Text;
using System.Threading.Tasks;

namespace Encryption_Machine.Classes
{
    class AppWeb
    {
        public AppWeb()                                                             // Constructor, empty
        {

        }
        public int checkInternetConnection()                                        // Method with is checking internet connection by trying to read datas from www.google.com
        {
            try                                                                     // Supports errors while trying to read datas
            {
                using (var client = new WebClient())                                // Creating net client
                {
                    using (var stream = client.OpenRead("http://www.google.com"))   // Using client, trying to read datas from www.googl.com
                    {
                        return 1;                                                   // If read gone sucessfull, return 1
                    }
                }
            }
            catch (Exception)                                                       // If there will be error while trying to read datas
            {
                return 0;                                                           // Return 0
            }
        }
    }
}
