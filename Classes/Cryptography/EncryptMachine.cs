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
using Encryption_Machine.Classes.Database;                                          // This namespace allow to use program classes

namespace Encryption_Machine.Classes.Cryptography
{
    class EncryptMachine
    {
        public EncryptMachine()                                                     // Constructor, empty
        {

        }
        public string returnCodeForChar(string givenChar, string codeName)          // This method return code for char
        {
            DatabaseGetData getData = new DatabaseGetData();                        // Create new object of DatabaseGetData   
            if (givenChar == "A" || givenChar == "a")                               // If char is like
                return getData.returnCodeForChar(codeName, "charA");                // Return code for given char
            else if (givenChar == "B" || givenChar == "b")                          // If char is like
                return getData.returnCodeForChar(codeName, "charB");                // Return code for given char
            else if (givenChar == "C" || givenChar == "c")                          // If char is like
                return getData.returnCodeForChar(codeName, "charC");                // Return code for given char
            else if (givenChar == "D" || givenChar == "d")                          // If char is like
                return getData.returnCodeForChar(codeName, "charD");                // Return code for given char
            else if (givenChar == "E" || givenChar == "e")                          // If char is like
                return getData.returnCodeForChar(codeName, "charE");                // Return code for given char
            else if (givenChar == "F" || givenChar == "f")                          // If char is like
                return getData.returnCodeForChar(codeName, "charF");                // Return code for given char
            else if (givenChar == "G" || givenChar == "g")                          // If char is like
                return getData.returnCodeForChar(codeName, "charG");                // Return code for given char
            else if (givenChar == "H" || givenChar == "h")                          // If char is like
                return getData.returnCodeForChar(codeName, "charH");                // Return code for given char
            else if (givenChar == "I" || givenChar == "i")                          // If char is like
                return getData.returnCodeForChar(codeName, "charI");                // Return code for given char
            else if (givenChar == "J" || givenChar == "j")                          // If char is like
                return getData.returnCodeForChar(codeName, "charJ");                // Return code for given char
            else if (givenChar == "K" || givenChar == "k")                          // If char is like
                return getData.returnCodeForChar(codeName, "charK");                // Return code for given char
            else if (givenChar == "L" || givenChar == "l")                          // If char is like
                return getData.returnCodeForChar(codeName, "charL");                // Return code for given char
            else if (givenChar == "M" || givenChar == "m")                          // If char is like
                return getData.returnCodeForChar(codeName, "charM");                // Return code for given char
            else if (givenChar == "N" || givenChar == "n")                          // If char is like
                return getData.returnCodeForChar(codeName, "charN");                // Return code for given char
            else if (givenChar == "O" || givenChar == "o")                          // If char is like
                return getData.returnCodeForChar(codeName, "charO");                // Return code for given char
            else if (givenChar == "P" || givenChar == "p")                          // If char is like
                return getData.returnCodeForChar(codeName, "charP");                // Return code for given char
            else if (givenChar == "Q" || givenChar == "q")                          // If char is like
                return getData.returnCodeForChar(codeName, "charQ");                // Return code for given char
            else if (givenChar == "R" || givenChar == "r")                          // If char is like
                return getData.returnCodeForChar(codeName, "charR");                // Return code for given char
            else if (givenChar == "S" || givenChar == "s")                          // If char is like
                return getData.returnCodeForChar(codeName, "charS");                // Return code for given char
            else if (givenChar == "T" || givenChar == "t")                          // If char is like
                return getData.returnCodeForChar(codeName, "charT");                // Return code for given char
            else if (givenChar == "U" || givenChar == "u")                          // If char is like
                return getData.returnCodeForChar(codeName, "charU");                // Return code for given char
            else if (givenChar == "V" || givenChar == "v")                          // If char is like
                return getData.returnCodeForChar(codeName, "charV");                // Return code for given char
            else if (givenChar == "W" || givenChar == "w")                          // If char is like
                return getData.returnCodeForChar(codeName, "charW");                // Return code for given char
            else if (givenChar == "X" || givenChar == "x")                          // If char is like
                return getData.returnCodeForChar(codeName, "charX");                // Return code for given char
            else if (givenChar == "Y" || givenChar == "y")                          // If char is like
                return getData.returnCodeForChar(codeName, "charY");                // Return code for given char
            else if (givenChar == "Z" || givenChar == "z")                          // If char is like
                return getData.returnCodeForChar(codeName, "charZ");                // Return code for given char
            else if (givenChar == "1")                                              // If char is like
                return getData.returnCodeForChar(codeName, "char1");                // Return code for given char
            else if (givenChar == "2")                                              // If char is like
                return getData.returnCodeForChar(codeName, "char2");                // Return code for given char
            else if (givenChar == "3")                                              // If char is like
                return getData.returnCodeForChar(codeName, "char3");                // Return code for given char
            else if (givenChar == "4")                                              // If char is like
                return getData.returnCodeForChar(codeName, "char4");                // Return code for given char
            else if (givenChar == "5")                                              // If char is like
                return getData.returnCodeForChar(codeName, "char5");                // Return code for given char
            else if (givenChar == "6")                                              // If char is like
                return getData.returnCodeForChar(codeName, "char6");                // Return code for given char
            else if (givenChar == "7")                                              // If char is like
                return getData.returnCodeForChar(codeName, "char7");                // Return code for given char
            else if (givenChar == "8")                                              // If char is like
                return getData.returnCodeForChar(codeName, "char8");                // Return code for given char
            else if (givenChar == "9")                                              // If char is like
                return getData.returnCodeForChar(codeName, "char9");                // Return code for given char
            else if (givenChar == "0")                                              // If char is like
                return getData.returnCodeForChar(codeName, "char0");                // Return code for given char
            else if (givenChar == "DOT")                                            // If char is like
                return getData.returnCodeForChar(codeName, "charDOT");              // Return code for given char
            else if (givenChar == " ")                                              // If char is like
                return getData.returnCodeForChar(codeName, "charSPACE");            // Return code for given char
            else                                                                    // Else
                return string.Empty;                                                // Return empty string
        }
    }
}
