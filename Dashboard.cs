using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using Microsoft.VisualBasic.Devices;
using System.Net;

namespace CODEX8
{
    public partial class frmAdminDashboard : Form
    {
        string usersFile = Path.Combine(Application.StartupPath, "CODEX8.txt");
        string donationFile = Path.Combine(Application.StartupPath, "donations.txt");
        string requestsFile = Path.Combine(Application.StartupPath, "requests.txt");
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void LoadAllData()
        {
            LoadUsers();
            LoadDonations();
            LoadRequests();
        }

        //LOAD USERS
        private void LoadUsers()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Full Name");
            dt.Columns.Add("Email Address");
            dt.Columns.Add("Phone Number");
            dt.Columns.Add("Role");
            dt.Columns.Add("status");

            if (!File.Exists(usersFile))
            {
                using (StreamReader sr = new StreamReader(usersFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        if (data.Length >= 6)
                        {
                            dt.Rows.Add(data[0], data[1], data[2], data[3], data[5]);
                        }
                        else if (data.Length == 5)
                        {
                            dt.Rows.Add(data[0], data[1], data[2], data[3], "Pending");
                        }
                    }
                }
            }
            dgvUsers.DataSource = dt;
        }

        //LOAD DONATIONS
        private void LoadDonations()

        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Item Name");
            dt.Columns.Add("Food Category");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Expiry Date");

            if (!File.Exists(donationFile))
            {
                using (StreamReader sr = new StreamReader(donationFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        if (data.Length >= 4)
                        {
                            dt.Rows.Add(data[0], data[1], data[2], data[3]);
                        }
                    }
                }
            }
            dgvDonations.DataSource = dt;
        }

        //LOAD REQUESTS
        private void LoadRequests()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Item Requested");
            dt.Columns.Add("Organisation");
            dt.Columns.Add("People");
            dt.Columns.Add("Location");
            dt.Columns.Add("Reason");
            dt.Columns.Add("Urgency");
            dt.Columns.Add("Status");

            if (!File.Exists(requestsFile))
            {
                using (StreamReader sr = new StreamReader(requestsFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        if (data.Length >= 12)
                        {
                            dt.Rows.Add(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[11]);
                        }
                    }
                }
            }
            dgvRequests.DataSource = dt;
        }

        //Apprrove user button 
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllData();
            MessageBox.Show("Dashboard updated!", "refreshed");
        }

        //LOGOUT BUTTON
        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Navigate back to the login form
            frmLogin loginForm = new frmLogin();
            loginForm.Show();

            // Close the admin dashboard
            this.Close();
        }

        // Approve user button 
        private void btnApproveUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to approve.", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedEmail = dgvUsers.SelectedRows[0].Cells["sizwelkhumalo01@gmail.com"].Value.ToString();
            string SelectedName = dgvUsers.SelectedRows[0].Cells["Sizwe Khuamalo"].Value.ToString();

            bool emailSent = SendApprovalEmail(selectedEmail, SelectedName);

            if (emailSent)
            {
                MessageBox.Show($"{SelectedName} has beeen approve and an notified via email!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
            else
            {
                MessageBox.Show("User approved locally, but the email failed to send. check your intrenet or App Password.", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            LoadUsers();
        }

        //EMAIL SENDER
        private bool SendApprovalEmail(string toEmail, string userName)
        {
            try
            {
                
                string fromEmail = "sizwelkhumalo01@gmail.com";
                string appPassword = "Mashobane01"; 
                
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                mail.To.Add(toEmail);
                mail.Subject = "Heart of hope - Account Approved1";
                mail.Body = $"Hello {userName},\n\nGreat news! Your account has been reviewed and approved by our Admin team. \n\nYou can log in to the Heart of Hope application to start donating or requesting food.\n\nThank you for joining us in the fight against hunger.\n\nBest regards,\nThe CodeX8 Team";
                mail.IsBodyHtml = false;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(fromEmail, appPassword);
                smtp.EnableSsl = true;

                smtp.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Approve request button

        private void btnApproveRequest_Click(object sender, EventArgs e)
        {
            if (dgvRequests.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a request from the list to approve.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedItem = dgvRequests.SelectedRows[0].Cells["Item Requested"].Value.ToString();

            try
            {
                string requestsFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "requests.txt");

                if (File.Exists(requestsFile))
                {
                    string[] allLines = File.ReadAllLines(requestsFile);

                    for (int i = 0; i < allLines.Length; i++)
                    {
                        string[] parts = allLines[i].Split(',');

                        if (parts.Length >= 3 && parts[0] == selectedItem && parts[2] == "Pending")
                        {
                            allLines[i] = $"{parts[0]},{parts[1]},Approved";
                            break;
                        }
                    }

                    File.WriteAllLines(requestsFile, allLines);

                    MessageBox.Show($"Request for '{selectedItem}' has been approved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadRequests();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating request: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
