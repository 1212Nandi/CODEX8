namespace CODEX8
{
    partial class frmDonorQuestions
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
            lblFullName = new Label();
            label3 = new Label();
            lblEmail = new Label();
            panel1 = new Panel();
            txtFoodDescription = new TextBox();
            label11 = new Label();
            label9 = new Label();
            label5 = new Label();
            txtLocations = new TextBox();
            chkAnonymous = new CheckBox();
            lblAdditionalNotes = new Label();
            grpDonationMethod = new GroupBox();
            label12 = new Label();
            radCollection = new RadioButton();
            radDeliver = new RadioButton();
            lblPreferredMethod = new Label();
            radReceiptNo = new RadioButton();
            cmbPreferredTime = new ComboBox();
            lblCollectionAddress = new Label();
            chkFoodSafety = new CheckBox();
            txtCollectionAddress = new TextBox();
            cmbFoodCondition = new ComboBox();
            dtpAvailableDate = new DateTimePicker();
            lblPreferredTime = new Label();
            radReceiptYes = new RadioButton();
            btnsubmitDonation = new Button();
            label8 = new Label();
            btnClear = new Button();
            dtpExpiryDate = new DateTimePicker();
            btnOpenMap = new Button();
            cmbDonationFrequency = new ComboBox();
            rtbAdditionalNotes = new RichTextBox();
            label6 = new Label();
            cmbQuantityUnit = new ComboBox();
            cmbDonorType = new ComboBox();
            cmbFoodCategory = new ComboBox();
            txtLocation = new Label();
            numQuantity = new NumericUpDown();
            label4 = new Label();
            label10 = new Label();
            label2 = new Label();
            label17 = new Label();
            label7 = new Label();
            lblNotification = new Label();
            notificationIcon = new NotifyIcon(components);
            errorProvider = new ErrorProvider(components);
            pictureBox2 = new PictureBox();
            label18 = new Label();
            pictureBox1 = new PictureBox();
            label13 = new Label();
            btnBack = new Button();
            panel1.SuspendLayout();
            grpDonationMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 104);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblFullName.ForeColor = Color.DarkGreen;
            lblFullName.Location = new Point(22, 365);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(126, 23);
            lblFullName.TabIndex = 13;
            lblFullName.Text = "Food category";

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(360, 288);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 14;
            label3.Text = "Quantity";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblEmail.ForeColor = Color.DarkGreen;
            lblEmail.Location = new Point(341, 434);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(102, 23);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Expiry date";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtFoodDescription);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtLocations);
            panel1.Controls.Add(chkAnonymous);
            panel1.Controls.Add(lblAdditionalNotes);
            panel1.Controls.Add(grpDonationMethod);
            panel1.Controls.Add(radReceiptNo);
            panel1.Controls.Add(cmbPreferredTime);
            panel1.Controls.Add(lblCollectionAddress);
            panel1.Controls.Add(chkFoodSafety);
            panel1.Controls.Add(txtCollectionAddress);
            panel1.Controls.Add(cmbFoodCondition);
            panel1.Controls.Add(dtpAvailableDate);
            panel1.Controls.Add(lblPreferredTime);
            panel1.Controls.Add(radReceiptYes);
            panel1.Controls.Add(btnsubmitDonation);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(dtpExpiryDate);
            panel1.Controls.Add(btnOpenMap);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(cmbDonationFrequency);
            panel1.Controls.Add(rtbAdditionalNotes);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmbQuantityUnit);
            panel1.Controls.Add(cmbDonorType);
            panel1.Controls.Add(cmbFoodCategory);
            panel1.Controls.Add(txtLocation);
            panel1.Controls.Add(numQuantity);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(lblFullName);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblNotification);
            panel1.Location = new Point(597, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 939);
            panel1.TabIndex = 17;
            // 
            // txtFoodDescription
            // 
            txtFoodDescription.Location = new Point(26, 324);
            txtFoodDescription.Name = "txtFoodDescription";
            txtFoodDescription.Size = new Size(287, 27);
            txtFoodDescription.TabIndex = 55;
            txtFoodDescription.TextChanged += txtFoodDescription_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DarkGreen;
            label11.Location = new Point(35, 221);
            label11.Name = "label11";
            label11.Size = new Size(259, 23);
            label11.TabIndex = 54;
            label11.Text = "Do you like a donation receipt?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkGreen;
            label9.Location = new Point(22, 41);
            label9.Name = "label9";
            label9.Size = new Size(378, 31);
            label9.TabIndex = 53;
            label9.Text = "TELL US ABOUT YOUR DONATION";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(26, 604);
            label5.Name = "label5";
            label5.Size = new Size(229, 23);
            label5.TabIndex = 52;
            label5.Text = "How often can you donate?";
            // 
            // txtLocations
            // 
            txtLocations.Location = new Point(23, 519);
            txtLocations.Name = "txtLocations";
            txtLocations.Size = new Size(627, 27);
            txtLocations.TabIndex = 51;
            // 
            // chkAnonymous
            // 
            chkAnonymous.AutoSize = true;
            chkAnonymous.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            chkAnonymous.ForeColor = Color.DarkGreen;
            chkAnonymous.Location = new Point(404, 221);
            chkAnonymous.Name = "chkAnonymous";
            chkAnonymous.Size = new Size(335, 27);
            chkAnonymous.TabIndex = 36;
            chkAnonymous.Text = "Would you like to remain Anonymous";
            chkAnonymous.UseVisualStyleBackColor = true;
            // 
            // lblAdditionalNotes
            // 
            lblAdditionalNotes.AutoSize = true;
            lblAdditionalNotes.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdditionalNotes.ForeColor = Color.DarkGreen;
            lblAdditionalNotes.Location = new Point(26, 719);
            lblAdditionalNotes.Name = "lblAdditionalNotes";
            lblAdditionalNotes.Size = new Size(143, 23);
            lblAdditionalNotes.TabIndex = 44;
            lblAdditionalNotes.Text = "Additional notes";
            // 
            // grpDonationMethod
            // 
            grpDonationMethod.Controls.Add(label12);
            grpDonationMethod.Controls.Add(radCollection);
            grpDonationMethod.Controls.Add(radDeliver);
            grpDonationMethod.Controls.Add(lblPreferredMethod);
            grpDonationMethod.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            grpDonationMethod.Location = new Point(462, 606);
            grpDonationMethod.Name = "grpDonationMethod";
            grpDonationMethod.Size = new Size(463, 52);
            grpDonationMethod.TabIndex = 39;
            grpDonationMethod.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DarkGreen;
            label12.Location = new Point(0, -5);
            label12.Name = "label12";
            label12.Size = new Size(233, 25);
            label12.TabIndex = 18;
            label12.Text = "Preferred donation method";
            // 
            // radCollection
            // 
            radCollection.AutoSize = true;
            radCollection.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radCollection.ForeColor = Color.DarkGreen;
            radCollection.Location = new Point(229, 23);
            radCollection.Name = "radCollection";
            radCollection.Size = new Size(170, 27);
            radCollection.TabIndex = 41;
            radCollection.TabStop = true;
            radCollection.Text = "Arrange collection";
            radCollection.UseVisualStyleBackColor = true;
            // 
            // radDeliver
            // 
            radDeliver.AutoSize = true;
            radDeliver.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radDeliver.ForeColor = Color.DarkGreen;
            radDeliver.Location = new Point(40, 23);
            radDeliver.Name = "radDeliver";
            radDeliver.Size = new Size(120, 27);
            radDeliver.TabIndex = 40;
            radDeliver.TabStop = true;
            radDeliver.Text = "I will deliver";
            radDeliver.UseVisualStyleBackColor = true;
            // 
            // lblPreferredMethod
            // 
            lblPreferredMethod.AutoSize = true;
            lblPreferredMethod.Location = new Point(-7, -18);
            lblPreferredMethod.Name = "lblPreferredMethod";
            lblPreferredMethod.Size = new Size(236, 23);
            lblPreferredMethod.TabIndex = 26;
            lblPreferredMethod.Text = "Preferred donation method:";
            // 
            // radReceiptNo
            // 
            radReceiptNo.AutoSize = true;
            radReceiptNo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            radReceiptNo.ForeColor = Color.DarkGreen;
            radReceiptNo.Location = new Point(218, 247);
            radReceiptNo.Name = "radReceiptNo";
            radReceiptNo.Size = new Size(54, 27);
            radReceiptNo.TabIndex = 46;
            radReceiptNo.TabStop = true;
            radReceiptNo.Text = "No";
            radReceiptNo.UseVisualStyleBackColor = true;
            // 
            // cmbPreferredTime
            // 
            cmbPreferredTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPreferredTime.FormattingEnabled = true;
            cmbPreferredTime.Items.AddRange(new object[] { "Morning", "Afternoon", "Evening" });
            cmbPreferredTime.Location = new Point(29, 688);
            cmbPreferredTime.Name = "cmbPreferredTime";
            cmbPreferredTime.Size = new Size(267, 28);
            cmbPreferredTime.TabIndex = 43;
            // 
            // lblCollectionAddress
            // 
            lblCollectionAddress.AutoSize = true;
            lblCollectionAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCollectionAddress.ForeColor = Color.DarkGreen;
            lblCollectionAddress.Location = new Point(374, 661);
            lblCollectionAddress.Name = "lblCollectionAddress";
            lblCollectionAddress.Size = new Size(248, 23);
            lblCollectionAddress.TabIndex = 28;
            lblCollectionAddress.Text = "Collection or delivery address";
            // 
            // chkFoodSafety
            // 
            chkFoodSafety.AutoSize = true;
            chkFoodSafety.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkFoodSafety.ForeColor = Color.DarkGreen;
            chkFoodSafety.Location = new Point(33, 828);
            chkFoodSafety.Name = "chkFoodSafety";
            chkFoodSafety.Size = new Size(658, 27);
            chkFoodSafety.TabIndex = 50;
            chkFoodSafety.Text = "I confirm that the food information is accurate and the food is safe to donate.";
            chkFoodSafety.UseVisualStyleBackColor = true;
            // 
            // txtCollectionAddress
            // 
            txtCollectionAddress.Location = new Point(374, 688);
            txtCollectionAddress.Name = "txtCollectionAddress";
            txtCollectionAddress.Size = new Size(558, 27);
            txtCollectionAddress.TabIndex = 20;
            // 
            // cmbFoodCondition
            // 
            cmbFoodCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFoodCondition.FormattingEnabled = true;
            cmbFoodCondition.Items.AddRange(new object[] { "Sealed", "Fresh", "Frozen", "Prepared", "Unopened", "Other" });
            cmbFoodCondition.Location = new Point(25, 462);
            cmbFoodCondition.Name = "cmbFoodCondition";
            cmbFoodCondition.Size = new Size(284, 28);
            cmbFoodCondition.TabIndex = 37;
            // 
            // dtpAvailableDate
            // 
            dtpAvailableDate.Location = new Point(632, 460);
            dtpAvailableDate.Name = "dtpAvailableDate";
            dtpAvailableDate.Size = new Size(303, 27);
            dtpAvailableDate.TabIndex = 28;
            // 
            // lblPreferredTime
            // 
            lblPreferredTime.AutoSize = true;
            lblPreferredTime.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreferredTime.ForeColor = Color.DarkGreen;
            lblPreferredTime.Location = new Point(29, 661);
            lblPreferredTime.Name = "lblPreferredTime";
            lblPreferredTime.Size = new Size(128, 23);
            lblPreferredTime.TabIndex = 42;
            lblPreferredTime.Text = "Preferred time";
            // 
            // radReceiptYes
            // 
            radReceiptYes.AutoSize = true;
            radReceiptYes.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            radReceiptYes.ForeColor = Color.DarkGreen;
            radReceiptYes.Location = new Point(46, 247);
            radReceiptYes.Name = "radReceiptYes";
            radReceiptYes.Size = new Size(55, 27);
            radReceiptYes.TabIndex = 45;
            radReceiptYes.TabStop = true;
            radReceiptYes.Text = "Yes";
            radReceiptYes.UseVisualStyleBackColor = true;
            // 
            // btnsubmitDonation
            // 
            btnsubmitDonation.BackColor = Color.Orange;
            btnsubmitDonation.ForeColor = Color.White;
            btnsubmitDonation.Location = new Point(33, 861);
            btnsubmitDonation.Name = "btnsubmitDonation";
            btnsubmitDonation.Size = new Size(433, 29);
            btnsubmitDonation.TabIndex = 47;
            btnsubmitDonation.Text = "Submit donation";
            btnsubmitDonation.UseVisualStyleBackColor = false;
            btnsubmitDonation.Click += btnsubmitDonation_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(632, 434);
            label8.Name = "label8";
            label8.Size = new Size(125, 23);
            label8.TabIndex = 25;
            label8.Text = "Available date";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Orange;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(507, 861);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(425, 29);
            btnClear.TabIndex = 48;
            btnClear.Text = "clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dtpExpiryDate
            // 
            dtpExpiryDate.Location = new Point(341, 460);
            dtpExpiryDate.Name = "dtpExpiryDate";
            dtpExpiryDate.Size = new Size(257, 27);
            dtpExpiryDate.TabIndex = 27;
            // 
            // btnOpenMap
            // 
            btnOpenMap.BackColor = Color.Orange;
            btnOpenMap.Location = new Point(684, 519);
            btnOpenMap.Name = "btnOpenMap";
            btnOpenMap.Size = new Size(113, 47);
            btnOpenMap.TabIndex = 49;
            btnOpenMap.Text = "Open map";
            btnOpenMap.UseVisualStyleBackColor = false;
            btnOpenMap.Click += btnOpenMap_Click;
            // 
            // cmbDonationFrequency
            // 
            cmbDonationFrequency.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDonationFrequency.FormattingEnabled = true;
            cmbDonationFrequency.Items.AddRange(new object[] { "Once", "Weekly", "Monthly", "Occasionally" });
            cmbDonationFrequency.Location = new Point(26, 630);
            cmbDonationFrequency.Name = "cmbDonationFrequency";
            cmbDonationFrequency.Size = new Size(397, 28);
            cmbDonationFrequency.TabIndex = 35;
            // 
            // rtbAdditionalNotes
            // 
            rtbAdditionalNotes.Location = new Point(26, 745);
            rtbAdditionalNotes.Name = "rtbAdditionalNotes";
            rtbAdditionalNotes.Size = new Size(899, 66);
            rtbAdditionalNotes.TabIndex = 38;
            rtbAdditionalNotes.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(22, 436);
            label6.Name = "label6";
            label6.Size = new Size(134, 23);
            label6.TabIndex = 21;
            label6.Text = "Food Condition";
            // 
            // cmbQuantityUnit
            // 
            cmbQuantityUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbQuantityUnit.FormattingEnabled = true;
            cmbQuantityUnit.Items.AddRange(new object[] { "Items", "Kilograms", "Litres", "Boxes", "Packets", "Crates" });
            cmbQuantityUnit.Location = new Point(629, 313);
            cmbQuantityUnit.Name = "cmbQuantityUnit";
            cmbQuantityUnit.Size = new Size(303, 28);
            cmbQuantityUnit.TabIndex = 33;
            // 
            // cmbDonorType
            // 
            cmbDonorType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDonorType.FormattingEnabled = true;
            cmbDonorType.Items.AddRange(new object[] { "Individual", "Business", "Restaurant", "Supermarket", "Community organisation", "Other" });
            cmbDonorType.Location = new Point(26, 152);
            cmbDonorType.Name = "cmbDonorType";
            cmbDonorType.Size = new Size(425, 28);
            cmbDonorType.TabIndex = 32;
            // 
            // cmbFoodCategory
            // 
            cmbFoodCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFoodCategory.FormattingEnabled = true;
            cmbFoodCategory.Items.AddRange(new object[] { "Fresh produce", "Canned goods", "Dry food", "Frozen food", "Prepared food", "Baby food", "Other" });
            cmbFoodCategory.Location = new Point(23, 391);
            cmbFoodCategory.Name = "cmbFoodCategory";
            cmbFoodCategory.Size = new Size(284, 28);
            cmbFoodCategory.TabIndex = 34;
            // 
            // txtLocation
            // 
            txtLocation.AutoSize = true;
            txtLocation.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLocation.ForeColor = Color.DarkGreen;
            txtLocation.Location = new Point(23, 493);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(78, 23);
            txtLocation.TabIndex = 19;
            txtLocation.Text = "Location";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(350, 314);
            numQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(257, 27);
            numQuantity.TabIndex = 26;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(23, 76);
            label4.Name = "label4";
            label4.Size = new Size(328, 20);
            label4.TabIndex = 18;
            label4.Text = "Please provide details about your support needs";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(629, 288);
            label10.Name = "label10";
            label10.Size = new Size(44, 23);
            label10.TabIndex = 27;
            label10.Text = "Unit";
            label10.Click += label10_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(23, 0);
            label2.Name = "label2";
            label2.Size = new Size(308, 41);
            label2.TabIndex = 17;
            label2.Text = "DONOR QUESTIONS";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label17.ForeColor = Color.DarkGreen;
            label17.Location = new Point(26, 126);
            label17.Name = "label17";
            label17.Size = new Size(125, 23);
            label17.TabIndex = 21;
            label17.Text = "Type of Donor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(27, 297);
            label7.Name = "label7";
            label7.Size = new Size(266, 23);
            label7.TabIndex = 24;
            label7.Text = "What would you like to donate?";
            // 
            // lblNotification
            // 
            lblNotification.BackColor = Color.LightGreen;
            lblNotification.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotification.ForeColor = Color.DarkGreen;
            lblNotification.Location = new Point(33, 898);
            lblNotification.Name = "lblNotification";
            lblNotification.Size = new Size(899, 27);
            lblNotification.TabIndex = 25;
            // 
            // notificationIcon
            // 
            notificationIcon.Text = "notifyIcon1";
            notificationIcon.Visible = true;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.make_background_colour_255_255_192_colour_code1;
            pictureBox2.Location = new Point(26, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BorderStyle = BorderStyle.Fixed3D;
            label18.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.DarkGreen;
            label18.Location = new Point(157, 50);
            label18.Name = "label18";
            label18.Size = new Size(334, 56);
            label18.TabIndex = 24;
            label18.Text = "HEART OF HOPE";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.Create_a_picture_of_8_people_donating_food_2_boys_and_6_girl1;
            pictureBox1.Location = new Point(2, 202);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(589, 418);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Orange;
            label13.Location = new Point(26, 113);
            label13.Name = "label13";
            label13.Size = new Size(281, 23);
            label13.TabIndex = 28;
            label13.Text = "Connecting hearts, inspiring hope";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Orange;
            btnBack.Location = new Point(47, 901);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 52);
            btnBack.TabIndex = 29;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmDonorQuestions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1569, 1003);
            Controls.Add(btnBack);
            Controls.Add(label13);
            Controls.Add(pictureBox1);
            Controls.Add(label18);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "frmDonorQuestions";
            Text = "Donor Registration";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpDonationMethod.ResumeLayout(false);
            grpDonationMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblFullName;
        private Label label3;
        private Label lblEmail;
        private Panel panel1;
        private Label label4;
        private Label label2;
        private TextBox txtCollectionAddress;
        private Label txtLocation;
        private Label label6;
        private Label lblCollectionAddress;
        private Label label10;
        private Label lblPreferredMethod;
        private Label label8;
        private Label label7;
        private ComboBox cmbFoodCategory;
        private ComboBox cmbQuantityUnit;
        private ComboBox cmbDonorType;
        private ComboBox cmbFoodCondition;
        private ComboBox cmbDonationFrequency;
        private Label label17;
        private Label lblNotification;
        private NumericUpDown numQuantity;
        private DateTimePicker dtpExpiryDate;
        private DateTimePicker dtpAvailableDate;
        private RichTextBox rtbAdditionalNotes;
        private GroupBox grpDonationMethod;
        private RadioButton radDeliver;
        private RadioButton radCollection;
        private Label lblPreferredTime;
        private ComboBox cmbPreferredTime;
        private Label lblAdditionalNotes;
        private RadioButton radReceiptYes;
        private RadioButton radReceiptNo;
        private Button btnsubmitDonation;
        private Button btnClear;
        private Button btnOpenMap;
        private NotifyIcon notificationIcon;
        private ErrorProvider errorProvider;
        private CheckBox chkFoodSafety;
        private CheckBox chkAnonymous;
        private TextBox txtLocations;
        private Label label5;
        private Label label9;
        private Label label11;
        private Label label12;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label18;
        private Label label13;
        private Button btnBack;
        private TextBox txtFoodDescription;
    }
}