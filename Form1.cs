using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CODEX8
{
    public partial class frmContact : Form
    {
        public frmContact()
        {
            InitializeComponent();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            // Open the Home page.
            frmHomePage RegistrationPage = new frmHomePage();
            RegistrationPage.Show();

            // Hide the Contact page while Home Page is open.
            this.Hide();
        }
    }
}
