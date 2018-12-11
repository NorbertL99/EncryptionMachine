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
using Encryption_Machine.Classes;                                                       // Allow to use program classes
using Encryption_Machine.Classes.Database;                                              // Allow to use program database classes

namespace Encryption_Machine.Windows.UserPanel
{
    public partial class codesettings : UserControl
    {
        AppErrors appErrors = new AppErrors();                                          // Create new object of AppErrors
        AppInfos appInfos = new AppInfos();                                             // Create new object of AppInfos
        public codesettings()                                                           // Constructor, empty
        {
            InitializeComponent();                                                      // Initialize components
        }

        private async void logIn_Click(object sender, EventArgs e)                      // This method run when logIn click
        {
            logCreate.Visible = true;                                                   // Visiable log
            logCreate.Text = "Checking for empty gaps";                                 // inform user about current operation
            if (codename.Text == "" || codepassword.Text == "")                         // If password or code name is empty
            {
                logCreate.Visible = false;                                              // Unvisiable log
                MessageBox.Show(appErrors.emptyGap(), appErrors.textError(),            // Inform user about some empty gaps
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                        // Set buttons and icon of messagebox
            }
            else                                                                        // Else
            {
                logCreate.Text = "Checking login data";                                 // inform user about current operation
                int asyncControl = await checkLoginData();                              // Seting asyncControl variable value as a value returned by async method checkLoginData
                if(asyncControl == 0)                                                   // If asyncControl value is 0
                {
                    logCreate.Visible = false;                                          // Unvisiable log
                    MessageBox.Show(appErrors.noInternet(), appErrors.webError(),       // Inform user about no internet connection
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                    // Set buttons and icon for messagebox
                }
                else if(asyncControl == 1)                                              // If asyncControl value is 1
                {
                    logCreate.Visible = false;                                          // Unvisiable log
                    MessageBox.Show(appErrors.databaseFail(), appErrors.databaseError(),// Inform user about error while working in database  
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                    // Set buttons and icon for messagebox
                }
                else if (asyncControl == 2)                                             // If asyncControl value is 2
                {
                    logCreate.Visible = false;                                          // Unvisiable log
                    MessageBox.Show(appErrors.wrongLogin(), appErrors.databaseError(),  // Inform user about wrong login data
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                    // Set buttons and icon for messagebox
                }
                else if (asyncControl == 3)                                             // If asyncControl value is 3
                {
                    logCreate.Text = "Creating temporary file";                         // inform user about current operation
                    asyncControl = await checkFileStatus();                             // Seting asyncControl variable value as a value returned by async method checkFileStatus
                    if(asyncControl == 0)                                               // If asyncControl value is 0
                    {
                        logCreate.Visible = false;                                      // Unvisiable log
                        MessageBox.Show(appErrors.fileFail(), appErrors.fileError(),    // Inform user about error while creating temporary file
                            MessageBoxButtons.OK, MessageBoxIcon.Error);                // Set buttons and icon for messagebox
                    }
                    else
                    {
                        logCreate.Visible = false;                                      // Unvisiable log
                        MessageBox.Show(appInfos.loginFine(), appInfos.everythingFine(),// Inform user about successfull login
                            MessageBoxButtons.OK, MessageBoxIcon.Information);          // Set buttons and icon for messagebox                        
                        after.BringToFront();                                           // Bring after to front
                    }
                }
            }
        }

        private async Task<int> checkLoginData()                                        // This method checking value returned after trying to login                                  
        {
            DatabaseGetData getData = new DatabaseGetData();                            // Create new object of DatabaseGetData
            return await Task.Run(() =>                                                 // Run new task for operation
            {
                return getData.checkLoginData(codename.Text, codepassword.Text);        // Return value returned by checkLogiData method from DatabaseGetData
            });
        }

        private async Task<int> checkFileStatus()                                       // This method checking value returned after setting temporary code name                                 
        {
            AppFile appFile = new AppFile();                                            // Createing new object of AppFile
            return await Task.Run(() =>                                                 // Run new task for operation
            {
                return appFile.createTemporaryLoginFile(codename.Text);                 // Return value returned by method with is creating temporary file with code name
            });
        }
    }
}
