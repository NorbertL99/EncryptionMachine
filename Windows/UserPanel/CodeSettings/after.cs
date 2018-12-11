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
using Encryption_Machine.Classes.Database;                                                          // This namespace allow to use program database classes
using Encryption_Machine.Classes;                                                                   // This namespace allow to use program classes

namespace Encryption_Machine.Windows.UserPanel.CodeSettings
{
    public partial class after : UserControl
    {
        AppErrors appErrors = new AppErrors();                                                      // Create new object of AppErrors
        AppInfos appInfos = new AppInfos();                                                         // Create new object of AppInfos
        DatabaseGetData getData = new DatabaseGetData();                                            // Create new object of DatabaseGetData
        DatabaseSetData setData = new DatabaseSetData();                                            // Create new object of DatabaseSetData
        AppFile appFile = new AppFile();                                                            // Create new object of AppFile
        public after()                                                                              // This method run when user panel open
        {
            InitializeComponent();                                                                  // Initialize components         
        }

        private void refresh_Click(object sender, EventArgs e)                                      // This method run when refresh button clicked
        {
            codeView.DataSource = getData.getFullCode(appFile.getCodeName());                       // Setting codeView with new dataSource with is returned from database by code name from temporary file
            logCreate.Visible = false;                                                              // Unvisable log info
            logCreate.Font = new Font("Microsoft Sans Serif", 12);                                  // Set normal font for log info
        }

        private async void delete_Click(object sender, EventArgs e)                                 // This method run when delete button clicked
        {
            logCreate.Visible = true;                                                               // Unvisable log info
            logCreate.Text = "Deleteing code from database";                                        // Inform user about current operation
            var asyncControl = await deleteCode();                                                  // Setting value of variable with value returned by deleteCode async method
            if(asyncControl == 0)
            {
                logCreate.Visible = false;                                                          // Unvisable log info
                MessageBox.Show(appErrors.noInternet(), appErrors.webError(),                       // Inform user about no internet connection
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                                    // Set buttons and icon of messagebox
            }
            else if(asyncControl == 1)
            {
                logCreate.Visible = false;                                                          // Unvisable log info
                MessageBox.Show(appErrors.databaseFail(), appErrors.databaseError(),                // Inform user about error while working in database
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                                    // Set buttons and icon of messagebox
            }
            else if (asyncControl == 2)
            {
                logCreate.Font = new Font("Microsoft Sans Serif", 26);                              // Set normal font for log info 
                logCreate.Text = "CODE DELETED, REFRESH";                                           // Inform user about current situation
                MessageBox.Show(appInfos.deleteingFine(), appInfos.everythingFine(),                // Inform user about deleteing went fine
                    MessageBoxButtons.OK, MessageBoxIcon.Information);                              // Set buttons and icon of messagebox
            }
        }

        private void show_Click(object sender, EventArgs e)                                         // This method run when show button clicked
        {
            if(charListShow.SelectedItem.ToString() == "")                                          // If charListShow current item is null
            {
                MessageBox.Show(appErrors.emptyGap(), appErrors.textError(),                        // Inform user about some empty gap
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                                    // Set buttons and icon of messagebox
            }
            else                                                                                    // Else
            {
                codeView.DataSource = getData.getSpecificChar(appFile.getCodeName(),                // Set new data source fore codeView with table returned
                    charListShow.SelectedItem.ToString());                                          // By getSpecificChar method, as parameters code name and selected char
            }
        }

        private async void changeChar_Click(object sender, EventArgs e)                             // This method run when changeChar button clicked
        {
            logCreate.Visible = true;                                                               // Unvisable log info
            logCreate.Text = "Checking for empty gaps";                                             // Inform user about current operation
            if (charListChange.SelectedItem.ToString() == "" || newCode.Text == "")                 // If charListShow current item is null
            {
                logCreate.Visible = false;                                                          // Unvisable log info
                MessageBox.Show(appErrors.emptyGap(), appErrors.textError(),                        // Inform user about some empty gap
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                                    // Set buttons and icon of messagebox
            }
            else                                                                                    // Else
            {
                logCreate.Text = "Updateing value";                                                 // Inform user about current operation
                var asyncControl = await                                                            // This variable store value returned by async method updateValue
                    updateValue(charListChange.SelectedItem.ToString(), newCode.Text);              // As parameters send current selected item and new value
                if(asyncControl == 0)                                                               // If asyncControl value is 0
                {
                    logCreate.Visible = false;                                                      // Unvisable log info
                    MessageBox.Show(appErrors.noInternet(), appErrors.webError(),                   // Inform user about no internet connection
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                                // Set buttons and icon for messagebox
                }
                else if(asyncControl == 1)                                                          // If asyncControl value is 1
                {
                    logCreate.Visible = false;                                                      // Unvisable log info
                    MessageBox.Show(appErrors.databaseFail(), appErrors.databaseError(),            // Inform user about error while working in database
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                                // Set buttons and icon for messagebox
                }
                else if (asyncControl == 2)                                                         // If asyncControl value is 2
                {
                    logCreate.Visible = false;                                                      // Unvisable log info
                    MessageBox.Show(appInfos.updateingFine(), appInfos.everythingFine(),            // Inform user about successfull updateing
                        MessageBoxButtons.OK, MessageBoxIcon.Information);                          // Set buttons and icon for messagebox
                }
            }
        }

        private async void changeName_Click(object sender, EventArgs e)                             // This method run when changeName button clicked
        {
            logCreate.Visible = true;                                                               // Unvisable log info
            logCreate.Text = "Checking for empty gaps";                                             // Inform user about current operation
            if (newName.Text == "")                                                                 // If new name is empty
            {
                logCreate.Visible = false;                                                          // Unvisable log info
                MessageBox.Show(appErrors.emptyGap(), appErrors.textError(),                        // Inform user about some empty gap
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                                    // Set buttons and icon of messagebox
            }
            else                                                                                    // Else
            {
                logCreate.Text = "Checking code";                                                   // Inform user about current operation
                var asyncControl = await checkCodeExist(newName.Text);                              // This variable store value returned by checkCodeExist async method
                if(asyncControl == 0)                                                               // If asyncControl value is 0
                {
                    logCreate.Visible = false;                                                      // Unvisable log info
                    MessageBox.Show(appErrors.noInternet(), appErrors.webError(),                   // Inform user about no internet connection
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                                // Set buttons and icon for messagebox
                }
                else if(asyncControl == 1)                                                          // If asyncControl value is 1
                {
                    logCreate.Visible = false;                                                      // Unvisable log info
                    MessageBox.Show(appErrors.databaseFail(), appErrors.databaseError(),            // Inform user about error while working in database
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                                // Set buttons and icon for messagebox
                }
                else if (asyncControl == 2)                                                         // If asyncControl value is 2
                {
                    logCreate.Visible = false;                                                      // Unvisable log info
                    MessageBox.Show(appErrors.codeExist(), appErrors.databaseError(),               // Inform user about code with this name exist
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                                // Set buttons and icon for messagebox
                }
                else if (asyncControl == 3)                                                         // If asyncControl value is 3
                {
                    logCreate.Text = "Updateing value";                                             // Inform user about current operation
                    asyncControl = await updateValue("code_name", newName.Text);                    // This variable store value returned by async method updateValue as parameters send code_name and new value
                    if (asyncControl == 0)                                                          // If asyncControl value is 0
                    {
                        logCreate.Visible = false;                                                  // Unvisable log info
                        MessageBox.Show(appErrors.noInternet(), appErrors.webError(),               // Inform user about no internet connection
                            MessageBoxButtons.OK, MessageBoxIcon.Error);                            // Set buttons and icon for messagebox
                    }
                    else if (asyncControl == 1)                                                     // If asyncControl value is 1
                    {
                        logCreate.Visible = false;                                                  // Unvisable log info
                        MessageBox.Show(appErrors.databaseFail(), appErrors.databaseError(),        // Inform user about error while working in database
                            MessageBoxButtons.OK, MessageBoxIcon.Error);                            // Set buttons and icon for messagebox
                    }
                    else if (asyncControl == 2)                                                     // If asyncControl value is 2
                    {
                        appFile.refreshTemporary(newName.Text);                                     // Updateing temporary file
                        logCreate.Visible = false;                                                  // Unvisable log info
                        MessageBox.Show(appInfos.updateingFine(), appInfos.everythingFine(),        // Inform user about successfull updateing
                            MessageBoxButtons.OK, MessageBoxIcon.Information);                      // Set buttons and icon for messagebox
                    }
                }
            }
        }

        private async void changePassword_Click(object sender, EventArgs e)                         // This method run when changePassword button clicked
        {
            logCreate.Visible = true;                                                               // Unvisable log info
            logCreate.Text = "Checking for empty gaps";                                             // Inform user about current operation
            if (newPassword.Text == "")                                                             // If new password is empty
            {
                logCreate.Visible = false;                                                          // Unvisable log info
                MessageBox.Show(appErrors.emptyGap(), appErrors.textError(),                        // Inform user about some empty gap
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                                    // Set buttons and icon of messagebox
            }
            else                                                                                    // Else
            {
                logCreate.Text = "Updateing value";                                                 // Inform user about current operation
                var asyncControl = await                                                            // This variable store value returned by async method updateValue
                    updateValue("code_password", newPassword.Text);                                 // As parameters send code_password and new value
                if (asyncControl == 0)                                                              // If asyncControl value is 0
                {
                    logCreate.Visible = false;                                                      // Unvisable log info
                    MessageBox.Show(appErrors.noInternet(), appErrors.webError(),                   // Inform user about no internet connection
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                                // Set buttons and icon for messagebox
                }
                else if (asyncControl == 1)                                                          // If asyncControl value is 1
                {
                    logCreate.Visible = false;                                                      // Unvisable log info
                    MessageBox.Show(appErrors.databaseFail(), appErrors.databaseError(),            // Inform user about error while working in database
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                                // Set buttons and icon for messagebox
                }
                else if (asyncControl == 2)                                                         // If asyncControl value is 2
                {
                    logCreate.Visible = false;                                                      // Unvisable log info
                    MessageBox.Show(appInfos.updateingFine(), appInfos.everythingFine(),            // Inform user about successfull updateing
                        MessageBoxButtons.OK, MessageBoxIcon.Information);                          // Set buttons and icon for messagebox
                }
            }
        }

        private async void changeAdminPassword_Click(object sender, EventArgs e)                    // This method run when changeAdminPassword button clicked
        {
            logCreate.Visible = true;                                                               // Unvisable log info
            logCreate.Text = "Checking for empty gaps";                                             // Inform user about current operation
            if (newAdminPassword.Text == "")                                                        // If new admin password is empty
            {
                logCreate.Visible = false;                                                          // Unvisable log info
                MessageBox.Show(appErrors.emptyGap(), appErrors.textError(),                        // Inform user about some empty gap
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                                    // Set buttons and icon of messagebox
            }
            else                                                                                    // Else
            {
                logCreate.Text = "Updateing value";                                                 // Inform user about current operation
                var asyncControl = await                                                            // This variable store value returned by async method updateValue
                    updateValue("code_admin_password", newAdminPassword.Text);                      // As parameters send code_admin_password and new value
                if (asyncControl == 0)                                                              // If asyncControl value is 0
                {
                    logCreate.Visible = false;                                                      // Unvisable log info
                    MessageBox.Show(appErrors.noInternet(), appErrors.webError(),                   // Inform user about no internet connection
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                                // Set buttons and icon for messagebox
                }
                else if (asyncControl == 1)                                                          // If asyncControl value is 1
                {
                    logCreate.Visible = false;                                                      // Unvisable log info
                    MessageBox.Show(appErrors.databaseFail(), appErrors.databaseError(),            // Inform user about error while working in database
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                                // Set buttons and icon for messagebox
                }
                else if (asyncControl == 2)                                                         // If asyncControl value is 2
                {
                    logCreate.Visible = false;                                                      // Unvisable log info
                    MessageBox.Show(appInfos.updateingFine(), appInfos.everythingFine(),            // Inform user about successfull updateing
                        MessageBoxButtons.OK, MessageBoxIcon.Information);                          // Set buttons and icon for messagebox
                }
            }
        }

        private async Task<int> deleteCode()                                                        // This method checking value returned after deleteing code from database                                   
        {
            return await Task.Run(() =>                                                             // Run new task for operation
            {
                return setData.deleteCode(appFile.getCodeName());                                   // Returning value returned by deleteCode method from DatabaseSetData class

            });
        }

        private async Task<int> updateValue(string toUpdate, string value)                          // This method checking value returned after updating values in database                                  
        {
            return await Task.Run(() =>                                                             // Run new task for operation
            {
                return setData.updateValue(appFile.getCodeName(), toUpdate, value);                 // Returning value returned by method with is updating value in database

            });
        }

        private async Task<int> checkCodeExist(string codeName)                                     // This method checking value returned after checking that code with given name already exist                                  
        {
            return await Task.Run(() =>                                                             // Run new task for operation
            {
                return getData.checkCodeExist(codeName);                                            // Return value returned by checkCodeExist method

            });
        }
    }
}