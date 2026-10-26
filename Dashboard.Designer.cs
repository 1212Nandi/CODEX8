namespace CODEX8
{
    partial class frmAdminDashboard
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            dgvRoles = new TabControl();
            tabPage1 = new TabPage();
            dgvUsers = new DataGridView();
            tabPage2 = new TabPage();
            dgvDonations = new DataGridView();
            tabPage3 = new TabPage();
            btnApproveRequest = new Button();
            dgvRequests = new DataGridView();
            btnApproveUser = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            dgvRoles.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonations).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 51, 35);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 80);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(255, 191, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(733, 20);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(449, 38);
            label1.TabIndex = 0;
            label1.Text = "System Administrator dashboard";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(10, 51, 35);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(103, 409);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Refresh List";
            button2.UseVisualStyleBackColor = false;
            // 
            // dgvRoles
            // 
            dgvRoles.Controls.Add(tabPage1);
            dgvRoles.Controls.Add(tabPage2);
            dgvRoles.Controls.Add(tabPage3);
            dgvRoles.Location = new Point(103, 86);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.SelectedIndex = 0;
            dgvRoles.Size = new Size(545, 276);
            dgvRoles.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnApproveUser);
            tabPage1.Controls.Add(dgvUsers);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(537, 243);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registered Users";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Top;
            dgvUsers.Location = new Point(3, 3);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(531, 167);
            dgvUsers.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvDonations);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(537, 243);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Food Donations";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvDonations
            // 
            dgvDonations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonations.Dock = DockStyle.Fill;
            dgvDonations.Location = new Point(3, 3);
            dgvDonations.Name = "dgvDonations";
            dgvDonations.RowHeadersWidth = 51;
            dgvDonations.Size = new Size(531, 237);
            dgvDonations.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnApproveRequest);
            tabPage3.Controls.Add(dgvRequests);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(537, 243);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Beneficiary Requests";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnApproveRequest
            // 
            btnApproveRequest.BackColor = Color.FromArgb(217, 119, 6);
            btnApproveRequest.FlatStyle = FlatStyle.Flat;
            btnApproveRequest.ForeColor = Color.White;
            btnApproveRequest.Location = new Point(21, 197);
            btnApproveRequest.Name = "btnApproveRequest";
            btnApproveRequest.Size = new Size(228, 29);
            btnApproveRequest.TabIndex = 1;
            btnApproveRequest.Text = "Approve Selected  Request";
            btnApproveRequest.UseVisualStyleBackColor = false;
            btnApproveRequest.Click += btnApproveRequest_Click;
            // 
            // dgvRequests
            // 
            dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequests.Dock = DockStyle.Top;
            dgvRequests.Location = new Point(3, 3);
            dgvRequests.Name = "dgvRequests";
            dgvRequests.RowHeadersWidth = 51;
            dgvRequests.Size = new Size(531, 188);
            dgvRequests.TabIndex = 0;
            // 
            // btnApproveUser
            // 
            btnApproveUser.BackColor = Color.FromArgb(217, 119, 6);
            btnApproveUser.ForeColor = Color.White;
            btnApproveUser.Location = new Point(17, 193);
            btnApproveUser.Name = "btnApproveUser";
            btnApproveUser.Size = new Size(179, 29);
            btnApproveUser.TabIndex = 1;
            btnApproveUser.Text = "Approve Selected User";
            btnApproveUser.UseVisualStyleBackColor = false;
            btnApproveUser.Click += btnApproveUser_Click;
            // 
            // frmAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(833, 450);
            Controls.Add(dgvRoles);
            Controls.Add(button2);
            Controls.Add(panel1);
            Name = "frmAdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            dgvRoles.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDonations).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSource1;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button2;
        private TabControl dgvRoles;
        private TabPage tabPage1;
        private Button btnApproveUser;
        private DataGridView dgvUsers;
        private TabPage tabPage2;
        private DataGridView dgvDonations;
        private TabPage tabPage3;
        private DataGridView dgvRequests;
        private Button btnApproveRequest;
    }
}