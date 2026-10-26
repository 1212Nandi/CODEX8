namespace CODEX8
{
    partial class frmLogin
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
            panel1 = new Panel();
            chkshowPassword = new CheckBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            linkLabel1 = new LinkLabel();
            btnRegister1 = new Button();
            btnLogin1 = new Button();
            chkRememberMe = new CheckBox();
            label3 = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            btnRegister = new Button();
            btnLogin = new Button();
            btnHome = new Button();
            btnHow = new Button();
            btnAbout = new Button();
            btnContact = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(chkshowPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(btnRegister1);
            panel1.Controls.Add(btnLogin1);
            panel1.Controls.Add(chkRememberMe);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(692, 262);
            panel1.Name = "panel1";
            panel1.Size = new Size(510, 431);
            panel1.TabIndex = 0;
            // 
            // chkshowPassword
            // 
            chkshowPassword.AutoSize = true;
            chkshowPassword.Location = new Point(361, 205);
            chkshowPassword.Name = "chkshowPassword";
            chkshowPassword.Size = new Size(132, 24);
            chkshowPassword.TabIndex = 21;
            chkshowPassword.Text = "Show Password";
            chkshowPassword.UseVisualStyleBackColor = true;
            chkshowPassword.CheckedChanged += chkshowPassword_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(41, 48);
            label1.Name = "label1";
            label1.Size = new Size(383, 38);
            label1.TabIndex = 0;
            label1.Text = "Login In to HEART OF HOPE";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.transparent_background;
            pictureBox2.Location = new Point(16, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(112, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.DarkGreen;
            linkLabel1.Location = new Point(120, 351);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(271, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "New to HEART OF HOPE? Register here.";
            // 
            // btnRegister1
            // 
            btnRegister1.BackColor = Color.Orange;
            btnRegister1.ForeColor = Color.White;
            btnRegister1.Location = new Point(177, 374);
            btnRegister1.Name = "btnRegister1";
            btnRegister1.Size = new Size(159, 34);
            btnRegister1.TabIndex = 7;
            btnRegister1.Text = "Register";
            btnRegister1.UseVisualStyleBackColor = false;
            btnRegister1.Click += btnRegister1_Click;
            // 
            // btnLogin1
            // 
            btnLogin1.BackColor = Color.Orange;
            btnLogin1.ForeColor = Color.White;
            btnLogin1.Location = new Point(41, 293);
            btnLogin1.Name = "btnLogin1";
            btnLogin1.Size = new Size(432, 29);
            btnLogin1.TabIndex = 6;
            btnLogin1.Text = "Log In";
            btnLogin1.UseVisualStyleBackColor = false;
            btnLogin1.Click += btnLogin1_Click;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.ForeColor = Color.DarkGreen;
            chkRememberMe.Location = new Point(41, 250);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(129, 24);
            chkRememberMe.TabIndex = 5;
            chkRememberMe.Text = "Remember me";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(41, 182);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(41, 205);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(262, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(41, 131);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(421, 27);
            txtEmail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(41, 108);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 1;
            label2.Text = "Email address";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.White;
            btnRegister.Location = new Point(950, 12);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(99, 34);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Orange;
            btnLogin.Location = new Point(1070, 12);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 34);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.ForeColor = Color.DarkGreen;
            btnHome.Location = new Point(331, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(86, 36);
            btnHome.TabIndex = 14;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // btnHow
            // 
            btnHow.ForeColor = Color.DarkGreen;
            btnHow.Location = new Point(440, 0);
            btnHow.Name = "btnHow";
            btnHow.Size = new Size(132, 36);
            btnHow.TabIndex = 15;
            btnHow.Text = "How it Works";
            btnHow.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            btnAbout.ForeColor = Color.DarkGreen;
            btnAbout.Location = new Point(599, 0);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(94, 36);
            btnAbout.TabIndex = 16;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            // 
            // btnContact
            // 
            btnContact.ForeColor = Color.DarkGreen;
            btnContact.Location = new Point(716, 0);
            btnContact.Name = "btnContact";
            btnContact.Size = new Size(102, 36);
            btnContact.TabIndex = 17;
            btnContact.Text = "Contact";
            btnContact.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(240, 109);
            label4.Name = "label4";
            label4.Size = new Size(332, 54);
            label4.TabIndex = 18;
            label4.Text = "HEART OF HOPE";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.make_background_colour_255_255_192_colour_code1;
            pictureBox1.Location = new Point(2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(91, 174);
            label5.Name = "label5";
            label5.Size = new Size(250, 46);
            label5.TabIndex = 20;
            label5.Text = "Welcome back";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(91, 220);
            label6.Name = "label6";
            label6.Size = new Size(433, 46);
            label6.TabIndex = 21;
            label6.Text = "Log in to HEART OF HOPE";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(91, 272);
            label7.Name = "label7";
            label7.Size = new Size(301, 44);
            label7.TabIndex = 22;
            label7.Text = "Together we reduce food waste and\r\nbuild stronger, helthier communities.";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.Create_a_picture_of_8_people_donating_food_2_boys_and_6_girl1;
            pictureBox4.Location = new Point(55, 319);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(544, 374);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 26;
            pictureBox4.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1244, 694);
            Controls.Add(pictureBox4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(btnContact);
            Controls.Add(btnAbout);
            Controls.Add(btnHow);
            Controls.Add(btnHome);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(panel1);
            Name = "frmLogin";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnRegister1;
        private Button btnLogin1;
        private CheckBox chkRememberMe;
        private Label label3;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
        private LinkLabel linkLabel1;
        private Button btnRegister;
        private Button btnLogin;
        private Button btnHome;
        private Button btnHow;
        private Button btnAbout;
        private Button btnContact;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox4;
        private CheckBox chkshowPassword;
    }
}