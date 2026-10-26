namespace CODEX8
{
    partial class frmDonorDashboard
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
            btnLogout = new Button();
            label1 = new Label();
            label2 = new Label();
            txtItemName = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            label3 = new Label();
            txtCategory = new TextBox();
            label4 = new Label();
            dtpExpiry = new DateTimePicker();
            btnAddDonation = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 51, 35);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 80);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(217, 119, 6);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(593, 27);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 42);
            label1.Name = "label1";
            label1.Size = new Size(465, 38);
            label1.TabIndex = 0;
            label1.Text = "Donor Dashboard - Heart of Hope";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(229, 112);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 1;
            label2.Text = "Item Name";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(364, 112);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(248, 27);
            txtItemName.TabIndex = 2;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(229, 152);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(65, 20);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(363, 155);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(249, 27);
            txtQuantity.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 192);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "Category";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(363, 195);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(249, 27);
            txtCategory.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 233);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 7;
            label4.Tag = "";
            label4.Text = "Expiry Date";
            // 
            // dtpExpiry
            // 
            dtpExpiry.Location = new Point(362, 234);
            dtpExpiry.Name = "dtpExpiry";
            dtpExpiry.Size = new Size(250, 27);
            dtpExpiry.TabIndex = 8;
            // 
            // btnAddDonation
            // 
            btnAddDonation.BackColor = Color.FromArgb(217, 119, 6);
            btnAddDonation.FlatStyle = FlatStyle.Flat;
            btnAddDonation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddDonation.ForeColor = Color.White;
            btnAddDonation.Location = new Point(238, 280);
            btnAddDonation.Name = "btnAddDonation";
            btnAddDonation.Size = new Size(145, 38);
            btnAddDonation.TabIndex = 9;
            btnAddDonation.Text = "Submit Donation";
            btnAddDonation.UseVisualStyleBackColor = false;
            btnAddDonation.Click += btnAddDonation_Click;
            // 
            // frmDonorDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddDonation);
            Controls.Add(dtpExpiry);
            Controls.Add(label4);
            Controls.Add(txtCategory);
            Controls.Add(label3);
            Controls.Add(txtQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(txtItemName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "frmDonorDashboard";
            Text = "frmDonorDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnLogout;
        private Label label1;
        private Label label2;
        private TextBox txtItemName;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Label label3;
        private TextBox txtCategory;
        private Label label4;
        private DateTimePicker dtpExpiry;
        private Button btnAddDonation;
    }
}