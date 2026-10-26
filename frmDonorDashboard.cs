using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CODEX8
{
    public partial class frmDonorDashboard : Form
    {
        string donationsFile = Path.Combine(Application.StartupPath, "donations.txt");
        public frmDonorDashboard()
        {
            InitializeComponent();
        }

        private void btnAddDonation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemName.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text) || string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Please fill in the Item Name, Quantity, and Category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //SAVE TO DONATIONS FILE
            try
            {
                string donationsData = $"{txtItemName.Text},{txtQuantity.Text},{txtCategory.Text},{dtpExpiry.Value.ToShortDateString()}\n";

                File.AppendAllText(Path.Combine(Application.StartupPath, "donations.txt"), donationsData);

                MessageBox.Show("Thank you! Your donation has been submitted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtItemName.Clear();
                txtQuantity.Clear();
                txtCategory.Clear();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving donation: " + ex.Message);
            }

        }

        //LOGOUT BUTTON
        private void btnLogout_Click(object sender, EventArgs e)
        { 
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Close();
        }
    }
}
