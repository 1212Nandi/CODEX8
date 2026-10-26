using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.IO;

namespace CODEX8
{

    public partial class frmDonorQuestions : Form
    {
        string filePath = Path.Combine(Application.StartupPath, "donations.txt");
        public frmDonorQuestions()
        {
            InitializeComponent();
        }

        private bool ValidateDonation()
        {
            errorProvider.Clear();
            bool valid = true;

            if (cmbDonorType.SelectedIndex < 0)
            {
                errorProvider.SetError(cmbDonorType, "Select a donor type.");
                valid = false;
            }

            if (!radReceiptYes.Checked && !radReceiptNo.Checked)
            {
                errorProvider.SetError(radReceiptYes, "Choose Yes or No.");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtFoodDescription.Text))
            {
                errorProvider.SetError(txtFoodDescription, "Describe the food you want to donate.");
                valid = false;
            }

            if (cmbFoodCategory.SelectedIndex < 0)
            {
                errorProvider.SetError(cmbFoodCategory, "Select a food category.");
                valid = false;
            }

            if (numQuantity.Value < 1)
            {
                errorProvider.SetError(numQuantity, "Quantity must be greater than zero.");
                valid = false;
            }

            if (cmbQuantityUnit.SelectedIndex < 0)
            {
                errorProvider.SetError(cmbQuantityUnit, "Select the quantity unit.");
                valid = false;
            }

            if (cmbFoodCondition.SelectedIndex < 0)
            {
                errorProvider.SetError(cmbFoodCondition, "Select the food condition.");
                valid = false;
            }

            if (dtpExpiryDate.Value.Date < DateTime.Today)
            {
                errorProvider.SetError(dtpExpiryDate, "Expiry date cannot be earlier than today.");
                valid = false;
            }

            if (dtpAvailableDate.Value.Date < DateTime.Today)
            {
                errorProvider.SetError(dtpAvailableDate, "Available date cannot be earlier than today.");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtLocation.Text) || txtLocation.Text.Trim().Length < 3)
            {
                errorProvider.SetError(txtLocation, "Enter a valid location.");
                valid = false;
            }

            if (!radDeliver.Checked && !radCollection.Checked)
            {
                errorProvider.SetError(radDeliver, "Choose delivery or collection.");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtCollectionAddress.Text))
            {
                errorProvider.SetError(txtCollectionAddress, "Enter the collection or delivery address.");
                valid = false;
            }

            if (cmbPreferredTime.SelectedIndex < 0)
            {
                errorProvider.SetError(cmbPreferredTime, "Select a preferred time.");
                valid = false;
            }

            if (!chkFoodSafety.Checked)
            {
                errorProvider.SetError(chkFoodSafety, "Confirm that the donation information is accurate and safe.");
                valid = false;
            }

            return valid;
        }

        private void btnsubmitDonation_Click(object sender, EventArgs e)
        {
       
            

            if (!ValidateDonation())
            {
                MessageBox.Show(
                    "Please complete the highlighted fields before submitting your donation.",
                    "Incomplete donation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string donationReference = "DON-" + DateTime.Now.ToString("yyyyMMddHHmmss");
            lblNotification.Text = "Notification: donation " + donationReference + " was submitted for review.";

            notificationIcon.Visible = true;
            notificationIcon.BalloonTipTitle = "CODEX8 donation submitted";
            notificationIcon.BalloonTipText = "Donation " + donationReference + " was sent for administrator review.";
            notificationIcon.ShowBalloonTip(5000);

            MessageBox.Show(
                "Your donation has been submitted successfully.\n\nReference: " + donationReference + "\n\nAn administrator notification has been created for review.",
                "Donation submitted",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnOpenMap_Click(object sender, EventArgs e)
        {
            string location = txtLocation.Text.Trim();
            if (location.Length < 3)
            {
                errorProvider.SetError(txtLocation, "Enter a location before opening the map.");
                MessageBox.Show("Enter a location or address first.", "Location required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocation.Focus();
                return;
            }

            string mapUrl = "https://www.google.com/maps/search/?api=1&query=" + Uri.EscapeDataString(location);
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = mapUrl,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("The map could not be opened.\n\n" + ex.Message, "Map error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbDonorType.SelectedIndex = -1;
            cmbDonationFrequency.SelectedIndex = -1;
            txtFoodDescription.Clear();
            cmbFoodCategory.SelectedIndex = -1;
            numQuantity.Value = 1;
            cmbQuantityUnit.SelectedIndex = -1;
            cmbFoodCondition.SelectedIndex = -1;
            dtpExpiryDate.Value = DateTime.Today;
            dtpAvailableDate.Value = DateTime.Today;
            txtLocations.Clear();
            cmbPreferredTime.SelectedIndex = -1;
            radReceiptYes.Checked = false;
            radReceiptNo.Checked = false;
            radDeliver.Checked = false;
            radCollection.Checked = false;
            txtCollectionAddress.Clear();
            rtbAdditionalNotes.Clear();
            chkAnonymous.Checked = false;
            chkFoodSafety.Checked = false;
            lblNotification.Text = string.Empty;
            errorProvider.Clear();
            notificationIcon.Visible = false;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (notificationIcon != null)
            {
                notificationIcon.Visible = false;
                notificationIcon.Dispose();
            }
            base.OnFormClosed(e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Open the Registration page.
            frmRegistration RegistrationPage = new frmRegistration();
            RegistrationPage.Show();

            // Hide the donor page while Registration is open.
            this.Hide();
        }

        private void txtFoodDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
