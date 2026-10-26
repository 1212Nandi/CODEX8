namespace CODEX8
{
    partial class frmBeneficiaryQuestions
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
            panel1 = new Panel();
            btnSubmit = new Button();
            lblNotificationIcon = new Label();
            btnOpenMap = new Button();
            lblReceiptQuestion = new Label();
            chkAnonymous = new CheckBox();
            grpReceipt = new GroupBox();
            radReceiptYes = new RadioButton();
            radReceiptNo = new RadioButton();
            label11 = new Label();
            cmbFoodCategory = new ComboBox();
            btnClear = new Button();
            label5 = new Label();
            cmbSupportFrequency = new ComboBox();
            txtReason = new TextBox();
            txtLocation = new TextBox();
            cmbUrgency = new ComboBox();
            cmbBeneficiaryTypes = new ComboBox();
            txtFoodNeeded = new TextBox();
            txtPeopleCount = new TextBox();
            txtOrganisationName = new TextBox();
            label9 = new Label();
            chkInformationCorrect = new CheckBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            cboBeneficiaryType = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            lblDonor = new Label();
            panel2 = new Panel();
            btnBack = new Button();
            label14 = new Label();
            label18 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label13 = new Label();
            label12 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            errorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            grpReceipt.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(lblNotificationIcon);
            panel1.Controls.Add(btnOpenMap);
            panel1.Controls.Add(lblReceiptQuestion);
            panel1.Controls.Add(chkAnonymous);
            panel1.Controls.Add(grpReceipt);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(cmbFoodCategory);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbSupportFrequency);
            panel1.Controls.Add(txtReason);
            panel1.Controls.Add(txtLocation);
            panel1.Controls.Add(cmbUrgency);
            panel1.Controls.Add(cmbBeneficiaryTypes);
            panel1.Controls.Add(txtFoodNeeded);
            panel1.Controls.Add(txtPeopleCount);
            panel1.Controls.Add(txtOrganisationName);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(chkInformationCorrect);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cboBeneficiaryType);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblDonor);
            panel1.Location = new Point(585, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 710);
            panel1.TabIndex = 0;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Orange;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(30, 646);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(444, 29);
            btnSubmit.TabIndex = 23;
            btnSubmit.Text = "Submit beneficiary request";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblNotificationIcon
            // 
            lblNotificationIcon.AutoSize = true;
            lblNotificationIcon.ForeColor = Color.DarkGreen;
            lblNotificationIcon.Location = new Point(346, 567);
            lblNotificationIcon.Name = "lblNotificationIcon";
            lblNotificationIcon.Size = new Size(0, 20);
            lblNotificationIcon.TabIndex = 29;
            // 
            // btnOpenMap
            // 
            btnOpenMap.BackColor = Color.Orange;
            btnOpenMap.ForeColor = Color.White;
            btnOpenMap.Location = new Point(270, 422);
            btnOpenMap.Name = "btnOpenMap";
            btnOpenMap.Size = new Size(145, 29);
            btnOpenMap.TabIndex = 28;
            btnOpenMap.Text = "Open map";
            btnOpenMap.UseVisualStyleBackColor = false;
            btnOpenMap.Click += btnOpenMap_Click;
            // 
            // lblReceiptQuestion
            // 
            lblReceiptQuestion.AutoSize = true;
            lblReceiptQuestion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReceiptQuestion.ForeColor = Color.DarkGreen;
            lblReceiptQuestion.Location = new Point(36, 528);
            lblReceiptQuestion.Name = "lblReceiptQuestion";
            lblReceiptQuestion.Size = new Size(240, 20);
            lblReceiptQuestion.TabIndex = 22;
            lblReceiptQuestion.Text = "Would you like a request receipt?";
            // 
            // chkAnonymous
            // 
            chkAnonymous.AutoSize = true;
            chkAnonymous.ForeColor = Color.DarkGreen;
            chkAnonymous.Location = new Point(36, 581);
            chkAnonymous.Name = "chkAnonymous";
            chkAnonymous.Size = new Size(222, 24);
            chkAnonymous.TabIndex = 5;
            chkAnonymous.Text = "Keep my request anonymous";
            chkAnonymous.UseVisualStyleBackColor = true;
            // 
            // grpReceipt
            // 
            grpReceipt.Controls.Add(radReceiptYes);
            grpReceipt.Controls.Add(radReceiptNo);
            grpReceipt.Location = new Point(36, 542);
            grpReceipt.Name = "grpReceipt";
            grpReceipt.Size = new Size(250, 33);
            grpReceipt.TabIndex = 27;
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.ForeColor = Color.DarkGreen;
            label11.Location = new Point(456, 297);
            label11.Name = "label11";
            label11.Size = new Size(110, 20);
            label11.TabIndex = 26;
            label11.Text = "Food category";
            // 
            // cmbFoodCategory
            // 
            cmbFoodCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFoodCategory.FormattingEnabled = true;
            cmbFoodCategory.Items.AddRange(new object[] { "Fresh produce", "Canned goods", "Dry Food", "Frozen food", "Prepared food", "Baby food", "Other" });
            cmbFoodCategory.Location = new Point(456, 320);
            cmbFoodCategory.Name = "cmbFoodCategory";
            cmbFoodCategory.Size = new Size(366, 28);
            cmbFoodCategory.TabIndex = 25;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Orange;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(509, 646);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(313, 29);
            btnClear.TabIndex = 24;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(457, 358);
            label5.Name = "label5";
            label5.Size = new Size(219, 20);
            label5.TabIndex = 21;
            label5.Text = "How often is support needed?";
            // 
            // cmbSupportFrequency
            // 
            cmbSupportFrequency.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupportFrequency.FormattingEnabled = true;
            cmbSupportFrequency.Items.AddRange(new object[] { "Once ", "Weekly", "Monthly", "Occasionally" });
            cmbSupportFrequency.Location = new Point(456, 389);
            cmbSupportFrequency.Name = "cmbSupportFrequency";
            cmbSupportFrequency.Size = new Size(366, 28);
            cmbSupportFrequency.TabIndex = 20;
            // 
            // txtReason
            // 
            txtReason.Location = new Point(36, 462);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(786, 63);
            txtReason.TabIndex = 19;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(31, 389);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(384, 27);
            txtLocation.TabIndex = 18;
            // 
            // cmbUrgency
            // 
            cmbUrgency.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUrgency.FormattingEnabled = true;
            cmbUrgency.Items.AddRange(new object[] { "Routine support", "Support needed soon ", "Urgent support" });
            cmbUrgency.Location = new Point(456, 254);
            cmbUrgency.Name = "cmbUrgency";
            cmbUrgency.Size = new Size(366, 28);
            cmbUrgency.TabIndex = 15;
            // 
            // cmbBeneficiaryTypes
            // 
            cmbBeneficiaryTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBeneficiaryTypes.FormattingEnabled = true;
            cmbBeneficiaryTypes.Items.AddRange(new object[] { "Community organisation", "Shelter", "School", "Household", "Other" });
            cmbBeneficiaryTypes.Location = new Point(456, 178);
            cmbBeneficiaryTypes.Name = "cmbBeneficiaryTypes";
            cmbBeneficiaryTypes.Size = new Size(366, 28);
            cmbBeneficiaryTypes.TabIndex = 14;
            // 
            // txtFoodNeeded
            // 
            txtFoodNeeded.Location = new Point(31, 321);
            txtFoodNeeded.Name = "txtFoodNeeded";
            txtFoodNeeded.Size = new Size(384, 27);
            txtFoodNeeded.TabIndex = 13;
            // 
            // txtPeopleCount
            // 
            txtPeopleCount.Location = new Point(31, 255);
            txtPeopleCount.Name = "txtPeopleCount";
            txtPeopleCount.Size = new Size(384, 27);
            txtPeopleCount.TabIndex = 12;
            // 
            // txtOrganisationName
            // 
            txtOrganisationName.Location = new Point(31, 179);
            txtOrganisationName.Name = "txtOrganisationName";
            txtOrganisationName.Size = new Size(384, 27);
            txtOrganisationName.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.DarkGreen;
            label9.Location = new Point(31, 97);
            label9.Name = "label9";
            label9.Size = new Size(728, 20);
            label9.TabIndex = 10;
            label9.Text = "Your answers help HEART OF HOPE understand your needs and allocate available food fairly and responsibly.";
            // 
            // chkInformationCorrect
            // 
            chkInformationCorrect.AutoSize = true;
            chkInformationCorrect.ForeColor = Color.DarkGreen;
            chkInformationCorrect.Location = new Point(36, 611);
            chkInformationCorrect.Name = "chkInformationCorrect";
            chkInformationCorrect.Size = new Size(368, 24);
            chkInformationCorrect.TabIndex = 9;
            chkInformationCorrect.Text = "I confirm that the information provided is accurate.";
            chkInformationCorrect.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(36, 439);
            label8.Name = "label8";
            label8.Size = new Size(142, 20);
            label8.TabIndex = 8;
            label8.Text = "Reason for request";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(30, 366);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 7;
            label7.Text = "Location";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(31, 298);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 6;
            label6.Text = "Item needed";
            // 
            // cboBeneficiaryType
            // 
            cboBeneficiaryType.AutoSize = true;
            cboBeneficiaryType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cboBeneficiaryType.ForeColor = Color.DarkGreen;
            cboBeneficiaryType.Location = new Point(509, 156);
            cboBeneficiaryType.Name = "cboBeneficiaryType";
            cboBeneficiaryType.Size = new Size(123, 20);
            cboBeneficiaryType.TabIndex = 5;
            cboBeneficiaryType.Text = "Beneficiary type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(31, 231);
            label4.Name = "label4";
            label4.Size = new Size(199, 20);
            label4.TabIndex = 4;
            label4.Text = "People requiring assistance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(456, 231);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 3;
            label3.Text = "Urgency of support";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(31, 156);
            label1.Name = "label1";
            label1.Size = new Size(238, 20);
            label1.TabIndex = 2;
            label1.Text = "Organisation or household name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(30, 68);
            label2.Name = "label2";
            label2.Size = new Size(224, 20);
            label2.TabIndex = 1;
            label2.Text = "Tell us about your support needs";
            // 
            // lblDonor
            // 
            lblDonor.AutoSize = true;
            lblDonor.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDonor.ForeColor = Color.DarkGreen;
            lblDonor.Location = new Point(30, 12);
            lblDonor.Name = "lblDonor";
            lblDonor.Size = new Size(385, 41);
            lblDonor.TabIndex = 0;
            lblDonor.Text = "BENEFICIARY QUESTIONS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 192);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnBack);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 821);
            panel2.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Orange;
            btnBack.Location = new Point(41, 707);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(115, 49);
            btnBack.TabIndex = 30;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Orange;
            label14.Location = new Point(12, 94);
            label14.Name = "label14";
            label14.Size = new Size(281, 23);
            label14.TabIndex = 29;
            label14.Text = "Connecting hearts, inspiring hope";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BorderStyle = BorderStyle.Fixed3D;
            label18.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.DarkGreen;
            label18.Location = new Point(143, 35);
            label18.Name = "label18";
            label18.Size = new Size(334, 56);
            label18.TabIndex = 28;
            label18.Text = "HEART OF HOPE";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.make_background_colour_255_255_192_colour_code1;
            pictureBox3.Location = new Point(12, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 73);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = Properties.Resources.Create_a_picture_of_8_people_donating_food_2_boys_and_6_girl1;
            pictureBox2.Location = new Point(-49, 201);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(589, 418);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(490, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(991, 75);
            panel3.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Orange;
            label13.Location = new Point(366, 36);
            label13.Name = "label13";
            label13.Size = new Size(281, 23);
            label13.TabIndex = 28;
            label13.Text = "Connecting hearts, inspiring hope";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.DarkGreen;
            label12.Location = new Point(360, 35);
            label12.Name = "label12";
            label12.Size = new Size(0, 20);
            label12.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(118, 18);
            label10.Name = "label10";
            label10.Size = new Size(250, 41);
            label10.TabIndex = 0;
            label10.Text = "HEART OF HOPE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.remove_name1;
            pictureBox1.Location = new Point(35, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmBeneficiaryQuestions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1481, 821);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(255, 255, 192);
            Name = "frmBeneficiaryQuestions";
            Text = "Beneficiary Registration";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpReceipt.ResumeLayout(false);
            grpReceipt.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label lblDonor;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label cboBeneficiaryType;
        private Label label4;
        private Label label3;
        private Label label1;
        private CheckBox chkInformationCorrect;
        private Label label9;
        private ComboBox cmbUrgency;
        private ComboBox cmbBeneficiaryTypes;
        private TextBox txtFoodNeeded;
        private TextBox txtPeopleCount;
        private TextBox txtOrganisationName;
        private TextBox txtReason;
        private TextBox txtLocation;
        private Panel panel2;
        private ComboBox cmbSupportFrequency;
        private RadioButton radReceiptYes;
        private RadioButton radReceiptNo;
        private CheckBox chkAnonymous;
        private Label label5;
        private Label lblReceiptQuestion;
        private Button btnClear;
        private Button btnSubmit;
        private ComboBox cmbFoodCategory;
        private Label label11;
        private GroupBox grpReceipt;
        private Label lblNotificationIcon;
        private Button btnOpenMap;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label10;
        private Label label12;
        private ErrorProvider errorProvider;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label13;
        private Label label18;
        private Label label14;
        private Button btnBack;
    }
}