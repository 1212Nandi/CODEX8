namespace CODEX8
{
    partial class frmRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnSubmitApplication = new Button();
            btnLogin = new Button();
            cmbRole = new ComboBox();
            lblFullName = new Label();
            lblEmail = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            chkTerms = new CheckBox();
            lblPasswordRequirements = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            btnBack = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            chkShowPassword = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(25, 173);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(198, 27);
            txtFullName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(304, 173);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(25, 247);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(198, 27);
            txtPhone.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(25, 320);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(198, 27);
            txtPassword.TabIndex = 3;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(304, 320);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(200, 27);
            txtConfirmPassword.TabIndex = 4;
            // 
            // btnSubmitApplication
            // 
            btnSubmitApplication.BackColor = Color.Orange;
            btnSubmitApplication.ForeColor = Color.White;
            btnSubmitApplication.Location = new Point(25, 481);
            btnSubmitApplication.Name = "btnSubmitApplication";
            btnSubmitApplication.Size = new Size(479, 29);
            btnSubmitApplication.TabIndex = 5;
            btnSubmitApplication.Text = "Submit Application";
            btnSubmitApplication.UseVisualStyleBackColor = false;
            btnSubmitApplication.Click += btnSubmitApplication_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Orange;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(25, 597);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(126, 31);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Beneficiary", "Donor" });
            cmbRole.Location = new Point(304, 246);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(200, 28);
            cmbRole.TabIndex = 7;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.DarkGreen;
            lblFullName.Location = new Point(19, 150);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(80, 20);
            lblFullName.TabIndex = 8;
            lblFullName.Text = "Full Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.DarkGreen;
            lblEmail.Location = new Point(304, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(105, 20);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(25, 224);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 10;
            label3.Text = "Phone number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(304, 223);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 11;
            label4.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(25, 297);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 12;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(304, 297);
            label6.Name = "label6";
            label6.Size = new Size(137, 20);
            label6.TabIndex = 13;
            label6.Text = "Confirm Password";
            // 
            // chkTerms
            // 
            chkTerms.AutoSize = true;
            chkTerms.ForeColor = Color.DarkGreen;
            chkTerms.Location = new Point(162, 421);
            chkTerms.Name = "chkTerms";
            chkTerms.Size = new Size(205, 24);
            chkTerms.TabIndex = 14;
            chkTerms.Text = "I agree to the terms of use";
            chkTerms.UseVisualStyleBackColor = true;
            // 
            // lblPasswordRequirements
            // 
            lblPasswordRequirements.AutoSize = true;
            lblPasswordRequirements.ForeColor = Color.DarkGreen;
            lblPasswordRequirements.Location = new Point(25, 557);
            lblPasswordRequirements.Name = "lblPasswordRequirements";
            lblPasswordRequirements.Size = new Size(223, 20);
            lblPasswordRequirements.TabIndex = 15;
            lblPasswordRequirements.Text = "Already have an account? Log in";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(19, 10);
            label1.Name = "label1";
            label1.Size = new Size(477, 62);
            label1.TabIndex = 16;
            label1.Text = "Create Your Account";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(25, 72);
            label2.Name = "label2";
            label2.Size = new Size(337, 40);
            label2.TabIndex = 17;
            label2.Text = "Join HEART OF HOPE and help reduce food waste\r\nwhile supporting communities.";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(chkShowPassword);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(btnSubmitApplication);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblFullName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(lblPasswordRequirements);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(chkTerms);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(cmbRole);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtPhone);
            panel1.Location = new Point(777, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 665);
            panel1.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.PaleGreen;
            label11.ForeColor = Color.DarkGreen;
            label11.Location = new Point(25, 380);
            label11.Name = "label11";
            label11.Size = new Size(403, 20);
            label11.TabIndex = 18;
            label11.Text = "Administrator accounts are created by authorised staff only.";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Orange;
            btnBack.Location = new Point(22, 694);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(105, 41);
            btnBack.TabIndex = 19;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Create_a_picture_of_8_people_donating_food_2_boys_and_6_girl;
            pictureBox1.Location = new Point(12, 200);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(746, 577);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 255, 192);
            pictureBox2.Image = Properties.Resources.make_background_colour_255_255_192_colour_code;
            pictureBox2.Location = new Point(83, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(113, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(223, 12);
            label7.Name = "label7";
            label7.Size = new Size(332, 54);
            label7.TabIndex = 23;
            label7.Text = "HEART OF HOPE";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(83, 70);
            label8.Name = "label8";
            label8.Size = new Size(321, 38);
            label8.TabIndex = 24;
            label8.Text = "Stronger Communities.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Orange;
            label9.Location = new Point(83, 113);
            label9.Name = "label9";
            label9.Size = new Size(273, 38);
            label9.TabIndex = 25;
            label9.Text = "Better Food Access.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(83, 167);
            label10.Name = "label10";
            label10.Size = new Size(327, 60);
            label10.TabIndex = 26;
            label10.Text = "Join HEART OF HOPE to help reduce food waste\r\nand support people in need through community\r\nfood donation";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Orange;
            label12.Location = new Point(561, 37);
            label12.Name = "label12";
            label12.Size = new Size(281, 23);
            label12.TabIndex = 27;
            label12.Text = "Connecting hearts, inspiring hope";
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(304, 350);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(138, 24);
            chkShowPassword.TabIndex = 19;
            chkShowPassword.Text = "Show Passwords";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1384, 747);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(btnBack);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "frmRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HEART OF HOPE - Create Your Account";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnSubmitApplication;
        private Button btnLogin;
        private ComboBox cmbRole;
        private Label lblFullName;
        private Label lblEmail;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox chkTerms;
        private Label lblPasswordRequirements;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button btnBack;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private CheckBox chkShowPassword;
    }
}