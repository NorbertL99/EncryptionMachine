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

namespace Encryption_Machine.Windows.UserPanels
{
    public partial class dashboard : UserControl
    {
        public dashboard()                                                      // This method run when user panel open
        {
            InitializeComponent();                                              // Initialize components
        }

        private void authorButton_Click(object sender, EventArgs e)             // This method run when authorButton clicked
        {
            MessageBox.Show(                                                    // Showing messagebox with information about author
                "Created by: Norbert Lubaszka \n" +                             // Inform about author name
                "Contact: norbert.lubaszka@gmail.com \n" +                      // Inform about contact to author
                "All rights reserved © \n" +                                    // Inform about all rights reserved
                "If you want to use the source code contact me",                // Inform about what to do if you want to use source code
                "Author info",                                                  // Title of messagebox
                MessageBoxButtons.OK,MessageBoxIcon.Information);               // Set messagebos buttons and icon
        }
    }
}
