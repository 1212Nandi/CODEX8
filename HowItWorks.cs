using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CODEX8
{
    public partial class frmHowItWorks : Form
    {
        public frmHowItWorks()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Open the home page.
            frmHomePage HomePage = new frmHomePage();
            HomePage.Show();

            // Hide the How it works page while Home page is open.
            this.Hide();
        }
    }
}
