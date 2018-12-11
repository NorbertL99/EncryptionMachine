// Created by Norbert Lubaszka
// Contact: norbert.lubaszka@gmail.com
// All rights reserved ©
// If you want to use the source code contact me

                                                                                        // References
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encryption_Machine.Classes;                                                       // This namespace allow to use program classes

namespace Encryption_Machine
{
    public partial class MainWindow : Form
    {
        public MainWindow()                                                             // This method run when window open
        {
            InitializeComponent();                                                      // Initialize components
        }

        private void dashboardButton_Click(object sender, EventArgs e)                  // This method run when dashboardButton clicked
        {
            dashboard.BringToFront();                                                   // Bringing dashboard user panel to front
        }

        private void encryptdecryptButton_Click(object sender, EventArgs e)             // This method run when encryptdecryptButton clicked
        {
            encryptdecrypt.BringToFront();                                              // Bringing encryptdecrypt user panel to front
        }

        private void createcodeButton_Click(object sender, EventArgs e)                 // This method run when createcodeButton clicked
        {
            createcode.BringToFront();                                                  // Bringing createcode user panel to front
        }

        private void codesettingsButton_Click(object sender, EventArgs e)               // This method run when codesettingsButton clicked
        {
            codesettings.BringToFront();                                                // Bringing codesettings user panel to front
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)      // This method run when window is closing
        {
            AppFile appFile = new AppFile();                                            // Creating new object of AppFile
            appFile.remoweTemporaryLoginFile();                                         // Remoweing temporary file with code name
        }
    }
}
