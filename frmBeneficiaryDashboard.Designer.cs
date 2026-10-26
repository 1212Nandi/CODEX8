namespace CODEX8
{
    partial class frmBeneficiaryDashboard
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
            label1 = new Label();
            b = new Panel();
            btnRequestFood = new Button();
            dgvAvailableFood = new DataGridView();
            lblFoodStatus = new Label();
            panelForm = new Panel();
            lblFoodCategory = new Label();
            btnBackToList = new Button();
            btnSubmit = new Button();
            lblNotificationIcon = new Label();
            lblReceiptQuestion = new Label();
            chkAnonymous = new CheckBox();
            grpReceipt = new GroupBox();
            radReceiptYes = new RadioButton();
            radReceiptNo = new RadioButton();
            chkInformationCorrect = new CheckBox();
            cmbFrequency = new ComboBox();
            label7 = new Label();
            cmbCategory = new ComboBox();
            label6 = new Label();
            txtPeople = new TextBox();
            label5 = new Label();
            cmbType = new ComboBox();
            label4 = new Label();
            txtOrgName = new TextBox();
            label2 = new Label();
            lblRequestHeading = new Label();
            cmbUrgency = new ComboBox();
            label3 = new Label();
            btnOpenMap = new Button();
            txtReason = new TextBox();
            label8 = new Label();
            txtLocation = new TextBox();
            errorProvider = new ErrorProvider(components);
            b.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableFood).BeginInit();
            panelForm.SuspendLayout();
            grpReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(20, 18);
            label1.Name = "label1";
            label1.Size = new Size(446, 38);
            label1.TabIndex = 0;
            label1.Text = "Beneficiary dashboard - CODEX8";
            // 
            // b
            // 
            b.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b.Controls.Add(btnRequestFood);
            b.Controls.Add(dgvAvailableFood);
            b.Controls.Add(lblFoodStatus);
            b.Location = new Point(174, 92);
            b.Name = "b";
            b.Size = new Size(1043, 517);
            b.TabIndex = 1;
            // 
            // btnRequestFood
            // 
            btnRequestFood.BackColor = Color.Orange;
            btnRequestFood.ForeColor = Color.White;
            btnRequestFood.Location = new Point(399, 409);
            btnRequestFood.Name = "btnRequestFood";
            btnRequestFood.Size = new Size(237, 52);
            btnRequestFood.TabIndex = 2;
            btnRequestFood.Text = "Request Selected Food";
            btnRequestFood.UseVisualStyleBackColor = false;
            // 
            // dgvAvailableFood
            // 
            dgvAvailableFood.AllowUserToAddRows = false;
            dgvAvailableFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAvailableFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableFood.Location = new Point(27, 53);
            dgvAvailableFood.MultiSelect = false;
            dgvAvailableFood.Name = "dgvAvailableFood";
            dgvAvailableFood.ReadOnly = true;
            dgvAvailableFood.RowHeadersVisible = false;
            dgvAvailableFood.RowHeadersWidth = 51;
            dgvAvailableFood.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailableFood.Size = new Size(980, 350);
            dgvAvailableFood.TabIndex = 1;
            // 
            // lblFoodStatus
            // 
            lblFoodStatus.AutoSize = true;
            lblFoodStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoodStatus.ForeColor = Color.DarkGreen;
            lblFoodStatus.Location = new Point(417, 15);
            lblFoodStatus.Name = "lblFoodStatus";
            lblFoodStatus.Size = new Size(237, 31);
            lblFoodStatus.TabIndex = 0;
            lblFoodStatus.Text = "Available Food Items";
            // 
            // panelForm
            // 
            panelForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelForm.Controls.Add(lblFoodCategory);
            panelForm.Controls.Add(btnBackToList);
            panelForm.Controls.Add(btnSubmit);
            panelForm.Controls.Add(lblNotificationIcon);
            panelForm.Controls.Add(lblReceiptQuestion);
            panelForm.Controls.Add(chkAnonymous);
            panelForm.Controls.Add(grpReceipt);
            panelForm.Controls.Add(chkInformationCorrect);
            panelForm.Controls.Add(cmbFrequency);
            panelForm.Controls.Add(label7);
            panelForm.Controls.Add(cmbCategory);
            panelForm.Controls.Add(label6);
            panelForm.Controls.Add(txtPeople);
            panelForm.Controls.Add(label5);
            panelForm.Controls.Add(cmbType);
            panelForm.Controls.Add(label4);
            panelForm.Controls.Add(txtOrgName);
            panelForm.Controls.Add(label2);
            panelForm.Controls.Add(lblRequestHeading);
            panelForm.Controls.Add(cmbUrgency);
            panelForm.Controls.Add(label3);
            panelForm.Controls.Add(btnOpenMap);
            panelForm.Controls.Add(txtReason);
            panelForm.Controls.Add(label8);
            panelForm.Controls.Add(txtLocation);
            panelForm.Location = new Point(174, 92);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(1043, 520);
            panelForm.TabIndex = 2;
            panelForm.Visible = false;
            // 
            // lblFoodCategory
            // 
            lblFoodCategory.AutoSize = true;
            lblFoodCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoodCategory.ForeColor = Color.DarkGreen;
            lblFoodCategory.Location = new Point(561, 168);
            lblFoodCategory.Name = "lblFoodCategory";
            lblFoodCategory.Size = new Size(129, 23);
            lblFoodCategory.TabIndex = 51;
            lblFoodCategory.Text = "Food Category";
            // 
            // btnBackToList
            // 
            btnBackToList.BackColor = Color.Orange;
            btnBackToList.ForeColor = Color.White;
            btnBackToList.Location = new Point(38, 477);
            btnBackToList.Name = "btnBackToList";
            btnBackToList.Size = new Size(274, 37);
            btnBackToList.TabIndex = 50;
            btnBackToList.Text = "Back to Food List";
            btnBackToList.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Orange;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(495, 476);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(446, 38);
            btnSubmit.TabIndex = 46;
            btnSubmit.Text = "Submit beneficiary request";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // lblNotificationIcon
            // 
            lblNotificationIcon.AutoSize = true;
            lblNotificationIcon.ForeColor = Color.DarkGreen;
            lblNotificationIcon.Location = new Point(355, 403);
            lblNotificationIcon.Name = "lblNotificationIcon";
            lblNotificationIcon.Size = new Size(0, 20);
            lblNotificationIcon.TabIndex = 49;
            // 
            // lblReceiptQuestion
            // 
            lblReceiptQuestion.AutoSize = true;
            lblReceiptQuestion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReceiptQuestion.ForeColor = Color.DarkGreen;
            lblReceiptQuestion.Location = new Point(45, 364);
            lblReceiptQuestion.Name = "lblReceiptQuestion";
            lblReceiptQuestion.Size = new Size(240, 20);
            lblReceiptQuestion.TabIndex = 45;
            lblReceiptQuestion.Text = "Would you like a request receipt?";
            // 
            // chkAnonymous
            // 
            chkAnonymous.AutoSize = true;
            chkAnonymous.ForeColor = Color.DarkGreen;
            chkAnonymous.Location = new Point(45, 417);
            chkAnonymous.Name = "chkAnonymous";
            chkAnonymous.Size = new Size(222, 24);
            chkAnonymous.TabIndex = 43;
            chkAnonymous.Text = "Keep my request anonymous";
            chkAnonymous.UseVisualStyleBackColor = true;
            // 
            // grpReceipt
            // 
            grpReceipt.Controls.Add(radReceiptYes);
            grpReceipt.Controls.Add(radReceiptNo);
            grpReceipt.Location = new Point(45, 378);
            grpReceipt.Name = "grpReceipt";
            grpReceipt.Size = new Size(250, 33);
            grpReceipt.TabIndex = 48;
            grpReceipt.TabStop = false;
            // 
            // radReceiptYes
            // 
            radReceiptYes.AutoSize = true;
            radReceiptYes.ForeColor = Color.DarkGreen;
            radReceiptYes.Location = new Point(12, 8);
            radReceiptYes.Name = "radReceiptYes";
            radReceiptYes.Size = new Size(51, 24);
            radReceiptYes.TabIndex = 2;
            radReceiptYes.TabStop = true;
            radReceiptYes.Text = "Yes";
            radReceiptYes.UseVisualStyleBackColor = true;
            // 
            // radReceiptNo
            // 
            radReceiptNo.AutoSize = true;
            radReceiptNo.ForeColor = Color.DarkGreen;
            radReceiptNo.Location = new Point(154, 8);
            radReceiptNo.Name = "radReceiptNo";
            radReceiptNo.Size = new Size(50, 24);
            radReceiptNo.TabIndex = 3;
            radReceiptNo.TabStop = true;
            radReceiptNo.Text = "No";
            radReceiptNo.UseVisualStyleBackColor = true;
            // 
            // chkInformationCorrect
            // 
            chkInformationCorrect.AutoSize = true;
            chkInformationCorrect.ForeColor = Color.DarkGreen;
            chkInformationCorrect.Location = new Point(45, 447);
            chkInformationCorrect.Name = "chkInformationCorrect";
            chkInformationCorrect.Size = new Size(368, 24);
            chkInformationCorrect.TabIndex = 44;
            chkInformationCorrect.Text = "I confirm that the information provided is accurate.";
            chkInformationCorrect.UseVisualStyleBackColor = true;
            // 
            // cmbFrequency
            // 
            cmbFrequency.FormattingEnabled = true;
            cmbFrequency.Location = new Point(557, 249);
            cmbFrequency.Name = "cmbFrequency";
            cmbFrequency.Size = new Size(384, 28);
            cmbFrequency.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(557, 219);
            label7.Name = "label7";
            label7.Size = new Size(161, 23);
            label7.TabIndex = 41;
            label7.Text = "Support frequency";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(557, 194);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(384, 28);
            cmbCategory.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(557, 115);
            label6.Name = "label6";
            label6.Size = new Size(139, 23);
            label6.TabIndex = 39;
            label6.Text = "Location or area";
            // 
            // txtPeople
            // 
            txtPeople.Location = new Point(38, 138);
            txtPeople.Name = "txtPeople";
            txtPeople.Size = new Size(384, 27);
            txtPeople.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(38, 115);
            label5.Name = "label5";
            label5.Size = new Size(321, 23);
            label5.TabIndex = 37;
            label5.Text = "Number of people requiring assistance";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(557, 75);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(384, 28);
            cmbType.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(557, 49);
            label4.Name = "label4";
            label4.Size = new Size(143, 23);
            label4.TabIndex = 35;
            label4.Text = "Beneficiary Type";
            // 
            // txtOrgName
            // 
            txtOrgName.Location = new Point(39, 75);
            txtOrgName.Name = "txtOrgName";
            txtOrgName.Size = new Size(384, 27);
            txtOrgName.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(38, 53);
            label2.Name = "label2";
            label2.Size = new Size(274, 23);
            label2.TabIndex = 33;
            label2.Text = "Organisation or Household name";
            // 
            // lblRequestHeading
            // 
            lblRequestHeading.AutoSize = true;
            lblRequestHeading.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRequestHeading.ForeColor = Color.DarkGreen;
            lblRequestHeading.Location = new Point(38, 15);
            lblRequestHeading.Name = "lblRequestHeading";
            lblRequestHeading.Size = new Size(254, 28);
            lblRequestHeading.TabIndex = 32;
            lblRequestHeading.Text = "Beneficiary Food Request";
            // 
            // cmbUrgency
            // 
            cmbUrgency.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUrgency.FormattingEnabled = true;
            cmbUrgency.Items.AddRange(new object[] { "Routine support", "Support needed soon ", "Urgent support" });
            cmbUrgency.Location = new Point(38, 218);
            cmbUrgency.Name = "cmbUrgency";
            cmbUrgency.Size = new Size(384, 28);
            cmbUrgency.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(38, 195);
            label3.Name = "label3";
            label3.Size = new Size(166, 23);
            label3.TabIndex = 30;
            label3.Text = "Urgency of support";
            // 
            // btnOpenMap
            // 
            btnOpenMap.BackColor = Color.Orange;
            btnOpenMap.ForeColor = Color.White;
            btnOpenMap.Location = new Point(820, 124);
            btnOpenMap.Name = "btnOpenMap";
            btnOpenMap.Size = new Size(121, 41);
            btnOpenMap.TabIndex = 29;
            btnOpenMap.Text = "Open map";
            btnOpenMap.UseVisualStyleBackColor = false;
            // 
            // txtReason
            // 
            txtReason.Location = new Point(38, 290);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(786, 63);
            txtReason.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(38, 267);
            label8.Name = "label8";
            label8.Size = new Size(160, 23);
            label8.TabIndex = 20;
            label8.Text = "Reason for request";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(557, 138);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(248, 27);
            txtLocation.TabIndex = 19;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmBeneficiaryDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 725);
            Controls.Add(label1);
            Controls.Add(panelForm);
            Controls.Add(b);
            Name = "frmBeneficiaryDashboard";
            Text = "C";
            Load += frmBeneficiaryDashboard_Load;
            b.ResumeLayout(false);
            b.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableFood).EndInit();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            grpReceipt.ResumeLayout(false);
            grpReceipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel bBBB;
        private Panel panelForm;
        private DataGridView dgvAvailableFood;
        private Label lblFoodStatus;
        private Button btnRequestFood;
        private TextBox txtLocation;
        private TextBox txtReason;
        private Label label8;
        private Button btnOpenMap;
        private TextBox txtOrgName;
        private Label label2;
        private Label lblRequestHeading;
        private ComboBox cmbUrgency;
        private Label label3;
        private ComboBox cmbCategory;
        private Label label6;
        private TextBox txtPeople;
        private Label label5;
        private ComboBox cmbType;
        private Label label4;
        private ComboBox cmbFrequency;
        private Label label7;
        private Button btnSubmit;
        private Label lblNotificationIcon;
        private Label lblReceiptQuestion;
        private CheckBox chkAnonymous;
        private GroupBox grpReceipt;
        private RadioButton radReceiptYes;
        private RadioButton radReceiptNo;
        private CheckBox chkInformationCorrect;
        private Button btnBackToList;
        private ErrorProvider errorProvider;
        private Panel b;
        private Label lblFoodCategory;
    }
}