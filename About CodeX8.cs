using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CODEX8
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            // Open the Home page.
            frmHomePage HomePage = new frmHomePage();
            HomePage.Show();

            // Hide the About Us while Home Page is open.
            this.Hide();
        }
    }
}
