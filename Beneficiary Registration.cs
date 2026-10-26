using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CODEX8
{
    public partial class frmBeneficiaryQuestions : Form
    {
        private NotifyIcon notificationIcon;
        private string fullName, email, phone, password; 
        public frmBeneficiaryQuestions()
        {
            InitializeComponent();

            
            notificationIcon = new NotifyIcon
            {
                Icon = SystemIcons.Information,
                Visible = false
            };
        }
        public frmBeneficiaryQuestions(string _fullName, string _email, string _phone, string _password) : this()
        {
            _fullName = fullName;
            _email = email;
            _phone = phone;
            _password = password;
        }

        public frmBeneficiaryQuestions(string savedName) : this(savedName, "", "", "")
        {

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!Validate())
            {
                MessageBox.Show(
                    "Please complete the highlighted fields before submitting your request.",
                    "Incomplete beneficiary request",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "CodeX8.txt");
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("====================");
                writer.WriteLine($"Date: {DateTime.Now}");
                writer.WriteLine($"Role Chosen: Beneficiary");
                writer.WriteLine($"Full name: {txtOrganisationName.Text}");
                writer.WriteLine($"Beneficiary Type: {cmbBeneficiaryTypes.Text}");
                writer.WriteLine($"People Count: {txtPeopleCount.Text}");
                writer.WriteLine($"Food Needed: {txtFoodNeeded.Text}");
                writer.WriteLine($"Location: {txtLocation.Text}");
                writer.WriteLine($"Reason: {txtReason.Text}");
                writer.WriteLine($"====================");

            }

            string requestReference = "BEN-" + DateTime.Now.ToString("yyyyMMddHHmmss");
            lblNotificationIcon.Text = "Notification: request " + requestReference + " was sent for administrator review.";
            SendNotification(requestReference);

            MessageBox.Show(
                "Your beneficiary request has been submitted successfully.\n\nReference: " + requestReference + "\n\nAn administrator notification has been created for review.",
                "Request submitted",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void SendNotification(string requestReference)
        {
            notificationIcon = new NotifyIcon();
            notificationIcon.Icon = SystemIcons.Information;
            if (notificationIcon == null)
            {
                notificationIcon = new NotifyIcon();
                notificationIcon.Icon = SystemIcons.Information;
            }

            notificationIcon.Visible = true;
            notificationIcon.BalloonTipTitle = "HEART OF HOPE request submitted";
            notificationIcon.BalloonTipText = "Beneficiary request " + requestReference + " was sent for administrator review.";

            // This is an in-app desktop notification. Email or SMS delivery requires a configured service.
        }

        private void OpenMap(object sender, EventArgs e)
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
                MessageBox.Show("The map could not be opened. Check your internet connection.\n\n" + ex.Message, "Map error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm(object sender, EventArgs e)
        {
            txtOrganisationName.Clear();
            cmbBeneficiaryTypes.SelectedIndex = -1;
            txtPeopleCount.Clear();
            cmbUrgency.SelectedIndex = -1;
            txtFoodNeeded.Clear();
            cmbFoodCategory.SelectedIndex = -1;
            txtLocation.Clear();
            txtReason.Clear();
            cmbSupportFrequency.SelectedIndex = -1;
            radReceiptYes.Checked = false;
            radReceiptNo.Checked = false;
            chkAnonymous.Checked = false;
            chkInformationCorrect.Checked = false;
            errorProvider.Clear();
            if (lblNotificationIcon != null)
            {
                lblNotificationIcon.Text = string.Empty;
            }
            if (notificationIcon != null)
            {
                notificationIcon.Visible = false;
            }
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
                MessageBox.Show("The map could not be opened. Check your internet connection.\n\n" + ex.Message, "Map error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOrganisationName.Clear();
            cmbBeneficiaryTypes.SelectedIndex = -1;
            txtPeopleCount.Clear();
            cmbUrgency.SelectedIndex = -1;
            txtFoodNeeded.Clear();
            cmbFoodCategory.SelectedIndex = -1;
            txtLocation.Clear();
            txtReason.Clear();
            cmbSupportFrequency.SelectedIndex = -1;
            radReceiptYes.Checked = false;
            radReceiptNo.Checked = false;
            chkAnonymous.Checked = false;
            chkInformationCorrect.Checked = false;
            errorProvider.Clear();
            if (lblNotificationIcon != null)
            {
                lblNotificationIcon.Text = string.Empty;
            }
            if (notificationIcon != null)
            {
                notificationIcon.Visible = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Open the Registration page.
            frmRegistration RegistrationPage = new frmRegistration();
            RegistrationPage.Show();

            // Hide the Beneficiary Page while Registration is open.
            this.Hide();
        }
    }
}

