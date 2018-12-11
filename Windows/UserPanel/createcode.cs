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
using Encryption_Machine.Classes;                                                                       // This namespace allow to use program classes
using Encryption_Machine.Classes.Database;                                                              // This namespace allow to use program classes database

namespace Encryption_Machine.Windows.UserPanel
{
    public partial class createcode : UserControl
    {
        AppErrors appErrors = new AppErrors();                                                          // Creating new object of AppErrors
        AppInfos appInfos = new AppInfos();                                                             // Creating new object of AppInfos
        public createcode()                                                                             // This method run when user panel open
        {
            InitializeComponent();                                                                      // Initialize components
        }

        private async void createButton_Click(object sender, EventArgs e)                               // This method run when createButton clicked
        {
            logCreate.Visible = true;                                                                   // Visiable log
            logCreate.Text = "Checking for empty gaps";                                                 // inform user about current operation
            int asyncControl = await checkForSomeEmptyGaps();                                           // Seting asyncControl variable value as a value returned by async method checkForSomeEmptyGaps
            if (asyncControl == 0)                                                                      // If asyncControl value is 0
            {
                logCreate.Visible = false;                                                              // Unvisiable log
                MessageBox.Show(appErrors.emptyGap(), appErrors.textError(),                            // Inform user about some empty gaps
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                                        // Set buttons and icon for messagebox
                return;                                                                                 // Stoping create code
            }
            else                                                                                        // Else
            {
                logCreate.Text = "Checking for some replaced char codes";                               // inform user about current operation
                asyncControl = await checkForSomeReplaceCode();                                         // Seting asyncControl variable value as a value returned by async method checkForSomeReplaceCode
                if(asyncControl == 0)                                                                   // If asyncControl value is 0
                {
                    logCreate.Visible = false;                                                          // Unvisiable log
                    MessageBox.Show(appErrors.codeReplace(), appErrors.textError(),                     // Inform user about same code given two times
                         MessageBoxButtons.OK, MessageBoxIcon.Error);                                   // Set buttons and icon for messagebox
                    return;                                                                             // Stoping create code
                }
                else                                                                                    // Else
                {
                    logCreate.Text = "Inserting new code to database";                                  // Inform user about current operation
                    asyncControl = await insertNewCode();                                               // Seting asyncControl variable value as a value returned by async method insertNewCode
                    if(asyncControl == 0)                                                               // If asyncControl value is 0                                                  
                    {
                        logCreate.Visible = false;                                                      // Unvisiable log
                        MessageBox.Show(appErrors.noInternet(), appErrors.webError(),                   // Inform user about no internet connection
                            MessageBoxButtons.OK, MessageBoxIcon.Error);                                // Set buttons and icon for messagebox
                    }
                    else if(asyncControl == 1)                                                          // If asyncControl value is 1                                      
                    {
                        logCreate.Visible = false;                                                      // Unvisiable log
                        MessageBox.Show(appErrors.databaseFail(), appErrors.databaseError(),            // Inform user about some error while working in database
                            MessageBoxButtons.OK, MessageBoxIcon.Error);                                // Set buttons and icon for messagebox
                    }                                                                                   
                    else if (asyncControl == 2)                                                         // If asyncControl value is 2  
                    {
                        logCreate.Visible = false;                                                      // Unvisiable log
                        MessageBox.Show(appErrors.codeExist(), appErrors.databaseError(),               // Inform user about code with given name already exist
                            MessageBoxButtons.OK, MessageBoxIcon.Error);                                // Set buttons and icon for messagebox
                    }
                    else if (asyncControl == 3)                                                         // If asyncControl value is 3  
                    {
                        logCreate.Visible = false;                                                      // Unvisiable log
                        MessageBox.Show(appErrors.insertFail(), appErrors.databaseError(),              // Inform user about some error while inserting new code
                            MessageBoxButtons.OK, MessageBoxIcon.Error);                                // Set buttons and icon for messagebox
                    }
                    else if (asyncControl == 4)                                                         // If asyncControl value is 4  
                    {
                        logCreate.Visible = false;                                                      // Unvisiable log
                        MessageBox.Show(appInfos.insertingFine(), appInfos.everythingFine(),            // Inform user about successfull operation
                            MessageBoxButtons.OK, MessageBoxIcon.Information);                          // Set buttons and icon for messagebox)
                    }
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)                                      // This method run when clearButton clicked
        {
            foreach (Control control in Controls)                                                       // Foreach control in controls
            {
                if(control is TextBox)                                                                  // If control is textbox
                {
                    if(control.Tag == "char")                                                           // If control tag is char
                    {
                        control.Text = "";                                                              // Clearing control text
                    }
                }
            }
        }

        private async Task<int> checkForSomeEmptyGaps()                                                 // This method checking about some empty gaps                                     
        {
            return await Task.Run(() =>                                                                 // Run new task for operation
            {
                foreach (Control control in Controls)                                                   // Foreach control in controls
                {
                    if (control is TextBox)                                                             // If control is textbox
                    {
                        if (control.Tag == "char")                                                      // If control tag is char
                        {
                            if (control.Text == "")                                                     // If control text is empty
                            {
                                return 0;                                                               // Return 0
                            }
                        }
                    }
                }
                return 1;                                                                               // If there is no empty gap return 1                                               
            });
        }

        private async Task<int> checkForSomeReplaceCode()                                               // This method checking about some empty gaps                                     
        {
            return await Task.Run(() =>                                                                 // Run new task for operation
            {
                List<string> charCodes = new List<string>();                                            // Create list of string with will store codes
                foreach (Control control in Controls)                                                   // Foreach control in controls                              
                {
                    if (control is TextBox)                                                             // If control is textbox
                    {
                        if (control.Tag == "char")                                                      // If control tag is char
                        {
                            foreach (var text in charCodes)                                             // Foreach text in charCodes
                            {
                                if (control.Text == text)                                               // If control text is same as text
                                {
                                    return 0;                                                           // Return 0
                                }
                            }
                            charCodes.Add(control.Text);                                                // Adding text to code charCode list
                        }
                    }
                }
                return 1;                                                                               // If there is no replaced code return 1
            });
        }

        private async Task<int> insertNewCode()                                                         // This method checking value returned after inserting new code to database                                   
        {
            DatabaseSetData setData = new DatabaseSetData();                                            // Create new object of DatabaseSetData
            return await Task.Run(() =>                                                                 // Run new task for operation
            {
                return setData.insertNewCode(codeName.Text,codePassword.Text,codeAdminPassword.Text,    // Return value with was returned by insertNewCode method from DatabaseSetData class
                    codeA.Text, codeB.Text, codeC.Text, codeD.Text, codeE.Text, codeF.Text, codeG.Text, // As parameters send char codes
                    codeH.Text, codeI.Text, codeJ.Text, codeK.Text, codeL.Text, codeM.Text, codeN.Text, // As parameters send char codes
                    codeO.Text, codeP.Text, codeQ.Text, codeR.Text, codeS.Text, codeT.Text, codeU.Text, // As parameters send char codes
                    codeV.Text, codeW.Text, codeX.Text, codeY.Text, codeZ.Text, code1.Text, code2.Text, // As parameters send char codes
                    code3.Text, code4.Text, code5.Text, code6.Text, code7.Text, code8.Text, code9.Text, // As parameters send char codes
                    code0.Text, codeDOT.Text, codeSPACE.Text);                                          // As parameters send char codes
            });
        }
    }
}
