using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace CODEX8
{
    public partial class frmRegistration : Form
    {
        private readonly ErrorProvider errors = new ErrorProvider();

        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "CODEX8.txt");
        public frmRegistration()
        {
            InitializeComponent();

            // Populate the Role dropdown
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Donor");
            cmbRole.Items.Add("Beneficiary");
        }

        //SHOW/HIDE PASSWORD CHECKBOX
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }
        private void PasswordFields_TextChanged(object? sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string confirm = txtConfirmPassword.Text;

            bool length = password.Length >= 8;
            bool upper = Regex.IsMatch(password, "[A-Z]");
            bool lower = Regex.IsMatch(password, "[a-z]");
            bool number = Regex.IsMatch(password, "[0-9]");
            bool special = Regex.IsMatch(password, "[^a-zA-Z0-9]");

            lblPasswordRequirements.Text =
                (length ? "✓" : "✗") + " At least 8 characters\n" +
                (upper ? "✓" : "✗") + " One uppercase letter\n" +
                (lower ? "✓" : "✗") + " One lowercase letter\n" +
                (number ? "✓" : "✗") + " One number\n" +
                (special ? "✓" : "✗") + " One special character";

            lblPasswordRequirements.ForeColor =
                length && upper && lower && number && special
                    ? Color.DarkGreen
                    : Color.DarkRed;

            if (confirm.Length > 0 && password != confirm)
            {
                errors.SetError(txtConfirmPassword, "Passwords do not match.");
            }
            else
            {
                errors.SetError(txtConfirmPassword, "");
            }
        }

        private bool ValidateRegistration()
        {
            bool valid = true;
            errors.Clear();

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                errors.SetError(txtFullName, "Enter your full name.");
                valid = false;
            }

            if (!Regex.IsMatch(txtEmail.Text.Trim(),
                @"^[^\s@]+@[^\s@]+\.[^\s@]+$"))
            {
                errors.SetError(txtEmail, "Enter a valid email address.");
                valid = false;
            }

            if (txtPhone.Text.Trim().Length != 10 || !Regex.IsMatch(txtPhone.Text.Trim(), @"^\d{10}$"))
            {
                errors.SetError(txtPhone, "Enter a valid phone number.");
                valid = false;
            }
            else
            {
                errors.SetError(txtPhone, "");
            }

            if (cmbRole.SelectedIndex == -1)
            {
                errors.SetError(cmbRole, "Choose Donor or Beneficiary.");
                valid = false;
            }

            string password = txtPassword.Text;
            if (password.Length < 8 ||
                !Regex.IsMatch(password, "[A-Z]") ||
                !Regex.IsMatch(password, "[a-z]") ||
                !Regex.IsMatch(password, "[0-9]") ||
                !Regex.IsMatch(password, "[^a-zA-Z0-9]"))
            {
                errors.SetError(txtPassword,
                    "Use at least 8 characters with uppercase, lowercase, number, and special character.");
                valid = false;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                errors.SetError(txtConfirmPassword, "Passwords do not match.");
                valid = false;
            }

            if (!chkTerms.Checked)
            {
                errors.SetError(chkTerms, "Accept the terms and privacy notice to continue.");
                valid = false;
            }

            return valid;
        }

        //SUBMIT APPLICATION BUTTON
        private void btnSubmitApplication_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text) ||
                cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please fill in all required fields.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(txtPhone.Text, @"^\d{10}$"))
            {
                MessageBox.Show(
                    "Please enter a valid 10-digit phone number.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^\s@]+@[^\s@]+\.[^\s@]+$"))
            {
                MessageBox.Show(
                    "Please enter a valid email address.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            { 
                MessageBox.Show(
                    "Passwords do not match.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string fullName = txtFullName.Text.Trim();
                string email = txtEmail.Text.Trim();
                string phone = txtPhone.Text.Trim();
                string role = cmbRole.SelectedItem.ToString();
                string password = txtPassword.Text;

                string userData = $"{fullName},{email},{phone},{role},{password},Pending\n";

                File.AppendAllText(filePath, userData);

                MessageBox.Show("Account created successfully! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmLogin loginForm = new frmLogin();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object? sender, EventArgs e)
        {

            // Open the Login page.
            frmLogin LoginPage = new frmLogin();
            LoginPage.FormClosed += (s, args) => this.Close();
            LoginPage.Show();

            // Hide the Registration page while Login is open.
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Open the Home page.
            frmHomePage HomePage = new frmHomePage();
            HomePage.Show();

            // Hide the Registration page while Home is open.
            this.Hide();
        }

        
    }

    public class DonorQuestionsForm : Form
    {

        private string fullName;
        private string email;
        private string phone;
        private string password;
        private TextBox txtFoodType;
        private TextBox txtQuantity;
        private DateTimePicker dateExpiry;
        private ComboBox cboMethod;
        private TextBox txtLocation;

        public DonorQuestionsForm(string donorName, string donorEmail, string donorPhone, string donorPassword)
        {

            StreamWriter writer = new StreamWriter(@"C:\Users\nandi\OneDrive\Desktop\CodeX8.txt");
            
            using(writer)
            {
                writer.WriteLine("Full name: " + donorName);
                writer.WriteLine("Email: " + donorEmail);
                writer.WriteLine("Phone: " + donorPhone);
                writer.WriteLine("Password: " + donorPassword);
                writer.WriteLine("HEART OF HOPE - Donor Information");
            }
            
           
        }

        private void SubmitDonorInformation(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFoodType.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                cboMethod.SelectedIndex < 0 || string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Complete all donor questions before continuing.", "Incomplete donor information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Donor application information captured for review.", "Application ready", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class BeneficiaryQuestionsForm : Form
    {
        private string fullName;
        private string email;
        private int phone;
        private string password;
        private TextBox txtOrganisation;
        private TextBox txtPeople;
        private TextBox txtNeededFood;
        private TextBox txtReason;

        public BeneficiaryQuestionsForm(string beneficiaryName, string beneficiaryEmail, int beneficiaryPhone, string beneficiaryPassword)
        {
            fullName = beneficiaryName;
            email = beneficiaryEmail;
            phone = beneficiaryPhone;
            password = beneficiaryPassword;
            Text = "HEART OF HOPE - Beneficiary Information";
           
        }

       
        private void SubmitBeneficiaryInformation(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrganisation.Text) || string.IsNullOrWhiteSpace(txtPeople.Text) ||
                string.IsNullOrWhiteSpace(txtNeededFood.Text) || string.IsNullOrWhiteSpace(txtReason.Text))
            {
                MessageBox.Show("Complete all beneficiary questions before continuing.", "Incomplete beneficiary information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Beneficiary information captured for review.", "Application ready", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    public class LoginForm : Form
    {
        private TextBox txtEmail;
        private TextBox txtPassword;

        public LoginForm()
        {
            Text = "HEART OF HOPE - Log In";
            StartPosition = FormStartPosition.CenterScreen;
            Width = 550;
            Height = 400;
        }


        private void LoginClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Enter your email address and password.", "Incomplete login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Login validation is ready. Connect this button to the database authentication code.", "Login page", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        string userData = "fullname | email | password | role";
        //File.AppendAllText(@"C:\Users\Public\Documents\HeartOfHope\userData.txt", userData + Environment.NewLine);
    }
}
