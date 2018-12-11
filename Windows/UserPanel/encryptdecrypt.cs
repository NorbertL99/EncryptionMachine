// Created by Norbert Lubaszka
// Contact: norbert.lubaszka@gmail.com
// All rights reserved ©
// If you want to use the source code contact me
                                                                                                // References
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encryption_Machine.Classes.Database;                                                      // Allow to use program database classes
using Encryption_Machine.Classes.Cryptography;                                                  // Allow to use program encryption classes
using Encryption_Machine.Classes;                                                               // Allow to use program classes
using System.IO;                                                                                // Allow to work on file (used to file dialogs)

namespace Encryption_Machine.Windows.UserPanels
{
    public partial class encryptdecrypt : UserControl
    {
        AppErrors appErrors = new AppErrors();                                                  // Create new object of AppErrors
        AppInfos appInfos = new AppInfos();                                                     // Create new object of AppInfos
        public encryptdecrypt()                                                                 // Constructor, empty
        {
            InitializeComponent();                                                              // Initializeing component
        }

        private void clereCodeInfo_Click(object sender, EventArgs e)                            // This method run when click on button clearCodeInfo
        {
            codeName.Text = "";                                                                 // Clearing codeName text
            codePassword.Text = "";                                                             // Clearing codePassword text
        }

        private void clearText_Click(object sender, EventArgs e)                                // This method run when click on button clearText
        {
            textRTB.Text = "";                                                                  // Clearing textRTB text
        }

        private void clearEffect_Click(object sender, EventArgs e)                              // This method run when click on button clearEffect
        {
            effectRTB.Text = "";                                                                // Clearing effectRTB text
        }

        private void clearAll_Click(object sender, EventArgs e)                                 // This method run when click on button clearAll
        {
            effectRTB.Text = "";                                                                // Clearing effectRTB text
            textRTB.Text = "";                                                                  // Clearing textRTB text
            codePassword.Text = "";                                                             // Clearing codePassword text
            codeName.Text = "";                                                                 // Clearing codeName text
        }

        private async void encrypt_Click(object sender, EventArgs e)                            // This method run when click on button encrypt
        {
            logCreate.Visible = true;                                                           // Visiable log
            logCreate.Text = "Checking for empty gaps";                                         // inform user about current operation
            if(codeName.Text == "" || codePassword.Text == "")                                  // If some gap is empty
            {
                logCreate.Visible = false;                                                      // Visiable log
                MessageBox.Show(appErrors.emptyGap(), appErrors.textError(),                    // Inform user about some empty gaps
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                                // Set buttons and icon of messagebox
            }
            else                                                                                // Else
            {
                logCreate.Text = "Checking for code data are correct";                          // Inform user about current operation
                var asyncControl = await checkCodeData();                                       // Set value of asyncControl with value returned by async method checkCodeData
                if(asyncControl == 0)                                                           // If asyncControl is 0
                {
                    logCreate.Visible = false;                                                  // Visiable log
                    MessageBox.Show(appErrors.noInternet(), appErrors.webError(),               // Inform user about no internet connection
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                            // Set buttons and icon for messagebox
                }
                else if(asyncControl == 1)                                                      // If asyncControl is 1
                {
                    logCreate.Visible = false;                                                  // Visiable log
                    MessageBox.Show(appErrors.databaseFail(), appErrors.databaseError(),        // Inform user about error while working in database  
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                            // Set buttons and icon for messagebox
                }
                else if (asyncControl == 2)                                                     // If asyncControl is 2
                {
                    logCreate.Visible = false;                                                  // Visiable log
                    MessageBox.Show(appErrors.wrongLogin(), appErrors.databaseError(),          // Inform user about wrong login data
                         MessageBoxButtons.OK, MessageBoxIcon.Error);                           // Set buttons and icon for messagebox
                }
                else if (asyncControl == 3)                                                     // If asyncControl is 3
                {
                    int textLength = textRTB.TextLength;                                        // Set value of variable with textRTB length
                    logCreate.Text = "Encrypting, char 0/" + textLength.ToString();             // Inform user about current operation
                    for (int i = 0; i < textLength; i++)                                        // For each char in textRTB
                    {
                        effectRTB.Text = effectRTB.Text +                                       // Adding to effect text
                            await returnCodeForChar(                                            // Value returned by async method returnCodeForChar
                                textRTB.Text[i].ToString()) + "\n";                             // Seting it in new line
                        logCreate.Text = "Encrypting, char " + i.ToString() + "/" +             // Inform user about current operation progress
                            textLength.ToString();                                              // Inform user about current operation progress
                    }
                    logCreate.Visible = false;                                                  // Visiable log
                    effectRTB.Text = effectRTB.Text + "!CONTROL VALUE";                         // Adding control value to effect
                    MessageBox.Show(appInfos.encryptFine(), appInfos.everythingFine(),          // Inform user about successfull encryption
                        MessageBoxButtons.OK, MessageBoxIcon.Information);                      // Set buttons and icon for messagebox
                }
            }
        }

        private async void decrypt_Click(object sender, EventArgs e)                            // This method run when click on button decrypt
        {
            string charCode = "";                                                               // Creating new variable with store charCode
            logCreate.Visible = true;                                                           // Visiable log
            logCreate.Text = "Checking for empty gaps";                                         // inform user about current operation
            if (codeName.Text == "" || codePassword.Text == "")                                 // If some gap is empty
            {
                logCreate.Visible = false;                                                      // Visiable log
                MessageBox.Show(appErrors.emptyGap(), appErrors.textError(),                    // Inform user about some empty gaps
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                                // Set buttons and icon of messagebox
            }
            else                                                                                // Else
            {
                logCreate.Text = "Checking for code data are correct";                          // Inform user about current operation
                var asyncControl = await checkCodeData();                                       // Set value of asyncControl with value returned by async method checkCodeData
                if (asyncControl == 0)                                                           // If asyncControl is 0
                {
                    logCreate.Visible = false;                                                  // Visiable log
                    MessageBox.Show(appErrors.noInternet(), appErrors.webError(),               // Inform user about no internet connection
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                            // Set buttons and icon for messagebox
                }
                else if (asyncControl == 1)                                                     // If asyncControl is 1
                {
                    logCreate.Visible = false;                                                  // Visiable log
                    MessageBox.Show(appErrors.databaseFail(), appErrors.databaseError(),        // Inform user about error while working in database  
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                            // Set buttons and icon for messagebox
                }
                else if (asyncControl == 2)                                                     // If asyncControl is 2
                {
                    logCreate.Visible = false;                                                  // Visiable log
                    MessageBox.Show(appErrors.wrongLogin(), appErrors.databaseError(),          // Inform user about wrong login data
                         MessageBoxButtons.OK, MessageBoxIcon.Error);                           // Set buttons and icon for messagebox
                }
                else if (asyncControl == 3)                                                     // If asyncControl is 3
                {
                    int textLength = textRTB.Text.Length;                                       // Set value of variable with textRTB length
                    logCreate.Text = "Decrypting, char 0/" + textLength.ToString();             // Inform user about current operation
                    for (int i = 0; i < textLength; i++)                                        // For each line in textRTB
                    {
                        if (textRTB.Text[i] != '\n')                                            // If char is not next line
                        {
                            charCode = charCode + textRTB.Text[i];                              // Add char to code
                        }
                        else                                                                    // Else
                        {
                            effectRTB.Text = effectRTB.Text +                                   // Adding to effect text
                                await returnCharForCode(charCode);                              // Value returned by async method returnCharForCode
                            logCreate.Text = "Encrypting, char " + i.ToString() + "/" +         // Inform user about current operation progress
                                textLength.ToString();                                          // Inform user about current operation progress
                            charCode = "";                                                      // Seting value of charCode as a empty
                        }
                    }
                    logCreate.Visible = false;                                                  // Visiable log
                    MessageBox.Show(appInfos.decryptionFine(), appInfos.everythingFine(),       // Inform user about successfull decryption
                        MessageBoxButtons.OK, MessageBoxIcon.Information);                      // Set buttons and icon for messagebox
                }
            }
        }

        private void saveFileEffect_Click(object sender, EventArgs e)                           // This method run when click on button saveFileEffect
        {
            if (saveDialog.ShowDialog() == DialogResult.OK)                                     // If dialog result is ok
            {
                Stream fileStream = saveDialog.OpenFile();                                      // Create new stream to file
                StreamWriter streamWriter = new StreamWriter(fileStream);                       // Create new stream writer to fileStream
                streamWriter.Write(effectRTB.Text);                                             // Write file text with effectRTB text
                streamWriter.Close();                                                           // Closeing stream
                MessageBox.Show("Saved properly", "Information",                                // Inform user about proper load from file
                    MessageBoxButtons.OK, MessageBoxIcon.Information);                          // Set buttons and icon of messagebox
            }
        }

        private void saveFileText_Click(object sender, EventArgs e)                             // This method run when click on button saveFileText
        {
            if (saveDialog.ShowDialog() == DialogResult.OK)                                     // If dialog result is ok
            {
                Stream fileStream = saveDialog.OpenFile();                                      // Create new stream to file
                StreamWriter streamWriter = new StreamWriter(fileStream);                       // Create new stream writer to fileStream
                streamWriter.Write(textRTB.Text);                                               // Write file text with textRTB text
                streamWriter.Close();                                                           // Closeing stream
                MessageBox.Show("Saved properly", "Information",                                // Inform user about proper load from file
                    MessageBoxButtons.OK, MessageBoxIcon.Information);                          // Set buttons and icon of messagebox
            }
        }

        private void loadFromText_Click(object sender, EventArgs e)                             // This method run when click on button loadFromText
        {
            if (readDialog.ShowDialog() == DialogResult.OK)                                     // If dialog result is ok
            {
                StreamReader streamReader = new StreamReader(readDialog.FileName);              // Create new stream to file
                textRTB.Text = streamReader.ReadToEnd();                                        // Read value from file and puting it inside textRTB
                streamReader.Close();                                                           // Closeing file
            }
        }

        private async Task<int> checkCodeData()                                                 // This method checking value returned after trying to code exist                                 
        {
            DatabaseGetData getData = new DatabaseGetData();                                    // Create new object of DatabaseGetData
            return await Task.Run(() =>                                                         // Run new task for operation
            {
                return getData.checkCodeData(codeName.Text, codePassword.Text);                 // Return value returned by checkLogiData method from DatabaseGetData
            });
        }

        private async Task<string> returnCodeForChar(string givenChar)                          // This method returning code for char                              
        {
            EncryptMachine encryptMachine = new EncryptMachine();                               // Creating new object of EncryptionMachine
            return await Task.Run(() =>                                                         // Run new task for operation
            {
                return encryptMachine.returnCodeForChar(givenChar, codeName.Text);              // Return code for given char
            });
        }

        private async Task<string> returnCharForCode(string givenCode)                          // This method returning char for code                              
        {
            DecryptMachine decryptMachine = new DecryptMachine();                               // Creating new object of DecryptionMachine
            return await Task.Run(() =>                                                         // Run new task for operation
            {
                return decryptMachine.getChar(codeName.Text, givenCode);                        // Return value returned by getChar method from DecryptionMachine class
            });
        }
    }
}
