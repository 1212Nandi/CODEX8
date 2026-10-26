using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Web;
using System.Drawing.Text;

namespace CODEX8
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Open the Registration page.
            frmRegistration RegistrationPage = new frmRegistration();
            RegistrationPage.Show();

            // Hide the Login page while Registration is open.
            this.Hide();
        }

        private void btnRegister1_Click(object sender, EventArgs e)
        {
            // Open the Registration page.
            frmRegistration RegistrationPage = new frmRegistration();
            RegistrationPage.Show();

            // Hide the Home page while Registration is open.
            this.Hide();
        }


        private void btnLogin1_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Enter your Email address and password.", "Incomplete login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (email == "admin@codex8.com" && password == "admin@2026")
            {
                MessageBox.Show("Welcome, System Administrator!", "admin Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmAdminDashboard adminForm = new frmAdminDashboard();
                adminForm.Show();
                this.Hide();
                return;
            }


            //Donor and Beneficiary Check
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "CODEX8.txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("No registered users found. Please register first.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool found = false;

            using (StreamReader reader = new StreamReader(filePath))
            {
                String line;
                while ((line = reader.ReadLine()) != null)
                {

                    string[] parts = line.Split(',');

                    if (parts.Length >= 5)
                    {
                        string savedEmail = parts[1].Trim();
                        string savedPassword = parts[4].Trim();
                        string savedRole = parts[3].Trim();
                        string savedName = parts[0].Trim();

                        if (savedEmail.Equals(email, StringComparison.OrdinalIgnoreCase) && savedPassword == password)
                        {
                            found = true;
                            MessageBox.Show($"Welcome {savedName}!", "Login Successful");

                            if (savedRole == "Donor")
                            {
                                frmDonorDashboard donorForm = new frmDonorDashboard();
                                donorForm.Show();
                            }
                            else if (savedRole == "Beneficiary")
                            {
                                frmBeneficiaryDashboard beneficiaryForm = new frmBeneficiaryDashboard();
                                beneficiaryForm.Show();
                            }
                            this.Hide();
                            break;
                        }
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show("Invalid email or password. Check your registration details.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkshowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '\0'; // Show password
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}

