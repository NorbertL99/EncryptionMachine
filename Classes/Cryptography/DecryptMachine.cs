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
using Encryption_Machine.Classes.Database;                                                  // Allow to use program database classes

namespace Encryption_Machine.Classes.Cryptography
{
    class DecryptMachine
    {
        public DecryptMachine()                                                             // Constructor, empty
        {

        }
        public string getChar(string codeName, string charCode)                             // This method returning char for given code
        {
            DatabaseGetData getData = new DatabaseGetData();                                // Create new objectof DatabaseGetData
            if (getData.returnCharForCode(codeName, "charA", charCode) == 2)                // Checking every possible char if the method return 2, return giid char
                return "a";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charB", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "b";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charC", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "c";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charD", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "d";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charE", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "e";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charF", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "f";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charG", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "g";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charH", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "h";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charI", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "i";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charJ", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "j";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charK", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "k";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charL", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "l";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charM", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "m";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charN", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "n";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charO", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "o";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charP", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "p";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charQ", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "q";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charR", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "r";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charS", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "s";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charT", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "t";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charU", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "u";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charV", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "v";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charW", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "w";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charX", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "x";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charY", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "y";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charZ", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "z";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "char1", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "1";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "char2", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "2";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "char3", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "3";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "char4", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "4";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "char5", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "5";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "char6", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "6";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "char7", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "7";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "char8", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "8";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "char9", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "9";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "char0", charCode) == 2)           // Checking every possible char if the method return 2, return giid char
                return "0";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charDOT", charCode) == 2)         // Checking every possible char if the method return 2, return giid char
                return ".";                                                                 // Return char
            else if (getData.returnCharForCode(codeName, "charSPACE", charCode) == 2)       // Checking every possible char if the method return 2, return giid char
                return " ";                                                                 // Return char
            else                                                                            // Else
                return string.Empty;                                                        // Return char
        }
    }
}
