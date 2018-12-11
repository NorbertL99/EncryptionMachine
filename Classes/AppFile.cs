// Created by Norbert Lubaszka
// Contact: norbert.lubaszka@gmail.com
// All rights reserved ©
// If you want to use the source code contact me
                                                                                                    // References
using System;
using System.Collections.Generic;
using System.IO;                                                                                    // This namespace allow to work with files
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_Machine.Classes
{
    class AppFile
    {
        public AppFile()                                                                            // Constructor, empty
        {

        }
        public int createTemporaryLoginFile(string codeName)                                        // This method creating temporary file for code name
        {
            try                                                                                     // Hold errors while working with files
            {
                remoweTemporaryLoginFile();                                                         // Remowe temporary file if it exist
                if (!File.Exists("../../Files/Temp/codename.txt"))                                  // If codename file doesnt exist
                {
                    StreamWriter streamWriter = File.CreateText("../../Files/Temp/codename.txt");   // Create this text and stream write to this txt
                    streamWriter.WriteLine(codeName);                                               // Write codeName inside
                    streamWriter.Close();                                                           // Close streamWrite to file
                    return 1;                                                                       // Return 1
                }
            }
            catch (Exception)                                                                       // If some exception catched
            {
                return 0;                                                                           // Return 0
            }
            return 0;                                                                               // Return 0
        }
        public void remoweTemporaryLoginFile()                                                      // This method remowe temporary file with code name
        {
            if(!File.Exists("../../Files/Temp/codename.txt"))                                       // If this file doesnt exist
            {
                return;                                                                             // Stop method
            }
            else                                                                                    // If it exist
            {
                File.Delete("../../Files/Temp/codename.txt");                                       // Remove the file
            }
        }
        public string getCodeName()                                                                 // This method returning code name from file
        {
            StreamReader streamReader = new StreamReader("../../Files/Temp/codename.txt");          // Create new object of StreamReader and connect it to code name file
            string codeName = streamReader.ReadLine();                                              // Reading line from file and puting value to variable
            streamReader.Close();                                                                   // Closing file
            return codeName;                                                                        // Returning codeName
        }
        public void refreshTemporary(string codeName)                                               // This method refreshing temporary code name
        {
            remoweTemporaryLoginFile();                                                             // Remowe temporary file if it exist
            if (!File.Exists("../../Files/Temp/codename.txt"))                                      // If codename file doesnt exist
            {
                StreamWriter streamWriter = File.CreateText("../../Files/Temp/codename.txt");       // Create this text and stream write to this txt
                streamWriter.WriteLine(codeName);                                                   // Write codeName inside
                streamWriter.Close();                                                               // Close streamWrite to file                                                                        // Return 1
            }
        }
    }
}
