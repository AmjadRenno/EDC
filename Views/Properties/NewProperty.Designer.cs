namespace EDC.Views.Properties
{
    partial class NewProperty
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblHeader = new Label();
            pnlContent = new Panel();
            pnlForm = new Panel();
            pnlBasicInfo = new Panel();
            lblBasicInfo = new Label();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblPostalCode = new Label();
            txtPostalCode = new TextBox();
            lblCity = new Label();
            txtCity = new TextBox();
            pnlPropertyDetails = new Panel();
            lblPropertyDetails = new Label();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblSquareMeters = new Label();
            txtSquareMeters = new TextBox();
            lblPropertyType = new Label();
            cmbPropertyType = new ComboBox();
            lblPropertyStatus = new Label();
            cmbPropertyStatus = new ComboBox();
            lblListingDate = new Label();
            dtpListingDate = new DateTimePicker();
            pnlDescription = new Panel();
            lblDescriptionTitle = new Label();
            lblDescription = new Label();
            txtDescription = new TextBox();
            pnlButtons = new Panel();
            btnSave = new Button();
            btnCancel = new Button();
            btnBack = new Button();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlForm.SuspendLayout();
            pnlBasicInfo.SuspendLayout();
            pnlPropertyDetails.SuspendLayout();
            pnlDescription.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(33, 150, 243);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(30, 20, 30, 20);
            pnlHeader.Size = new Size(800, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Dock = DockStyle.Left;
            lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(30, 20);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(164, 45);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Ny bolig";
            // 
            // pnlContent
            // 
            pnlContent.AutoScroll = true;
            pnlContent.BackColor = Color.FromArgb(250, 250, 250);
            pnlContent.Controls.Add(pnlForm);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 80);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(50);
            pnlContent.Size = new Size(800, 470);
            pnlContent.TabIndex = 1;
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.White;
            pnlForm.Controls.Add(pnlBasicInfo);
            pnlForm.Controls.Add(pnlPropertyDetails);
            pnlForm.Controls.Add(pnlDescription);
            pnlForm.Controls.Add(pnlButtons);
            pnlForm.Dock = DockStyle.Top;
            pnlForm.Location = new Point(50, 50);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new Padding(30);
            pnlForm.Size = new Size(700, 750);
            pnlForm.TabIndex = 0;
            // 
            // pnlBasicInfo
            // 
            pnlBasicInfo.Controls.Add(lblBasicInfo);
            pnlBasicInfo.Controls.Add(lblTitle);
            pnlBasicInfo.Controls.Add(txtTitle);
            pnlBasicInfo.Controls.Add(lblAddress);
            pnlBasicInfo.Controls.Add(txtAddress);
            pnlBasicInfo.Controls.Add(lblPostalCode);
            pnlBasicInfo.Controls.Add(txtPostalCode);
            pnlBasicInfo.Controls.Add(lblCity);
            pnlBasicInfo.Controls.Add(txtCity);
            pnlBasicInfo.Dock = DockStyle.Top;
            pnlBasicInfo.Location = new Point(30, 30);
            pnlBasicInfo.Name = "pnlBasicInfo";
            pnlBasicInfo.Size = new Size(640, 220);
            pnlBasicInfo.TabIndex = 0;
            // 
            // lblBasicInfo
            // 
            lblBasicInfo.AutoSize = true;
            lblBasicInfo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBasicInfo.ForeColor = Color.FromArgb(33, 150, 243);
            lblBasicInfo.Location = new Point(0, 0);
            lblBasicInfo.Name = "lblBasicInfo";
            lblBasicInfo.Size = new Size(179, 25);
            lblBasicInfo.TabIndex = 0;
            lblBasicInfo.Text = "Grundlæggende info";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10F);
            lblTitle.Location = new Point(0, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(37, 19);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Titel:";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 10F);
            txtTitle.Location = new Point(0, 65);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(620, 25);
            txtTitle.TabIndex = 2;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10F);
            lblAddress.Location = new Point(0, 110);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(59, 19);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Adresse:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10F);
            txtAddress.Location = new Point(0, 135);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(620, 25);
            txtAddress.TabIndex = 4;
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Font = new Font("Segoe UI", 10F);
            lblPostalCode.Location = new Point(0, 180);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(83, 19);
            lblPostalCode.TabIndex = 5;
            lblPostalCode.Text = "Postnummer:";
            // 
            // txtPostalCode
            // 
            txtPostalCode.Font = new Font("Segoe UI", 10F);
            txtPostalCode.Location = new Point(0, 205);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(150, 25);
            txtPostalCode.TabIndex = 6;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 10F);
            lblCity.Location = new Point(170, 180);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(28, 19);
            lblCity.TabIndex = 7;
            lblCity.Text = "By:";
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 10F);
            txtCity.Location = new Point(170, 205);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(450, 25);
            txtCity.TabIndex = 8;
            // 
            // pnlPropertyDetails
            // 
            pnlPropertyDetails.Controls.Add(lblPropertyDetails);
            pnlPropertyDetails.Controls.Add(lblPrice);
            pnlPropertyDetails.Controls.Add(txtPrice);
            pnlPropertyDetails.Controls.Add(lblSquareMeters);
            pnlPropertyDetails.Controls.Add(txtSquareMeters);
            pnlPropertyDetails.Controls.Add(lblPropertyType);
            pnlPropertyDetails.Controls.Add(cmbPropertyType);
            pnlPropertyDetails.Controls.Add(lblPropertyStatus);
            pnlPropertyDetails.Controls.Add(cmbPropertyStatus);
            pnlPropertyDetails.Controls.Add(lblListingDate);
            pnlPropertyDetails.Controls.Add(dtpListingDate);
            pnlPropertyDetails.Dock = DockStyle.Top;
            pnlPropertyDetails.Location = new Point(30, 250);
            pnlPropertyDetails.Name = "pnlPropertyDetails";
            pnlPropertyDetails.Size = new Size(640, 240);
            pnlPropertyDetails.TabIndex = 1;
            // 
            // lblPropertyDetails
            // 
            lblPropertyDetails.AutoSize = true;
            lblPropertyDetails.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPropertyDetails.ForeColor = Color.FromArgb(33, 150, 243);
            lblPropertyDetails.Location = new Point(0, 0);
            lblPropertyDetails.Name = "lblPropertyDetails";
            lblPropertyDetails.Size = new Size(112, 25);
            lblPropertyDetails.TabIndex = 0;
            lblPropertyDetails.Text = "Boligdetaljer";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 10F);
            lblPrice.Location = new Point(0, 40);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(68, 19);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Pris (DKK):";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 10F);
            txtPrice.Location = new Point(0, 65);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(300, 25);
            txtPrice.TabIndex = 2;
            // 
            // lblSquareMeters
            // 
            lblSquareMeters.AutoSize = true;
            lblSquareMeters.Font = new Font("Segoe UI", 10F);
            lblSquareMeters.Location = new Point(320, 40);
            lblSquareMeters.Name = "lblSquareMeters";
            lblSquareMeters.Size = new Size(94, 19);
            lblSquareMeters.TabIndex = 3;
            lblSquareMeters.Text = "Kvadratmeter:";
            // 
            // txtSquareMeters
            // 
            txtSquareMeters.Font = new Font("Segoe UI", 10F);
            txtSquareMeters.Location = new Point(320, 65);
            txtSquareMeters.Name = "txtSquareMeters";
            txtSquareMeters.Size = new Size(300, 25);
            txtSquareMeters.TabIndex = 4;
            // 
            // lblPropertyType
            // 
            lblPropertyType.AutoSize = true;
            lblPropertyType.Font = new Font("Segoe UI", 10F);
            lblPropertyType.Location = new Point(0, 110);
            lblPropertyType.Name = "lblPropertyType";
            lblPropertyType.Size = new Size(75, 19);
            lblPropertyType.TabIndex = 5;
            lblPropertyType.Text = "Boligtype:";
            // 
            // cmbPropertyType
            // 
            cmbPropertyType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPropertyType.Font = new Font("Segoe UI", 10F);
            cmbPropertyType.FormattingEnabled = true;
            cmbPropertyType.Items.AddRange(new object[] { "Hus", "Lejlighed", "Rækkehus", "Villa", "Ejerlejlighed" });
            cmbPropertyType.Location = new Point(0, 135);
            cmbPropertyType.Name = "cmbPropertyType";
            cmbPropertyType.Size = new Size(300, 25);
            cmbPropertyType.TabIndex = 6;
            // 
            // lblPropertyStatus
            // 
            lblPropertyStatus.AutoSize = true;
            lblPropertyStatus.Font = new Font("Segoe UI", 10F);
            lblPropertyStatus.Location = new Point(320, 110);
            lblPropertyStatus.Name = "lblPropertyStatus";
            lblPropertyStatus.Size = new Size(49, 19);
            lblPropertyStatus.TabIndex = 7;
            lblPropertyStatus.Text = "Status:";
            // 
            // cmbPropertyStatus
            // 
            cmbPropertyStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPropertyStatus.Font = new Font("Segoe UI", 10F);
            cmbPropertyStatus.FormattingEnabled = true;
            cmbPropertyStatus.Items.AddRange(new object[] { "Til salg", "Solgt", "Under bud", "Reserveret" });
            cmbPropertyStatus.Location = new Point(320, 135);
            cmbPropertyStatus.Name = "cmbPropertyStatus";
            cmbPropertyStatus.Size = new Size(300, 25);
            cmbPropertyStatus.TabIndex = 8;
            // 
            // lblListingDate
            // 
            lblListingDate.AutoSize = true;
            lblListingDate.Font = new Font("Segoe UI", 10F);
            lblListingDate.Location = new Point(0, 180);
            lblListingDate.Name = "lblListingDate";
            lblListingDate.Size = new Size(85, 19);
            lblListingDate.TabIndex = 9;
            lblListingDate.Text = "Annoncedag:";
            // 
            // dtpListingDate
            // 
            dtpListingDate.Font = new Font("Segoe UI", 10F);
            dtpListingDate.Format = DateTimePickerFormat.Short;
            dtpListingDate.Location = new Point(0, 205);
            dtpListingDate.Name = "dtpListingDate";
            dtpListingDate.Size = new Size(300, 25);
            dtpListingDate.TabIndex = 10;
            // 
            // pnlDescription
            // 
            pnlDescription.Controls.Add(lblDescriptionTitle);
            pnlDescription.Controls.Add(lblDescription);
            pnlDescription.Controls.Add(txtDescription);
            pnlDescription.Dock = DockStyle.Top;
            pnlDescription.Location = new Point(30, 490);
            pnlDescription.Name = "pnlDescription";
            pnlDescription.Size = new Size(640, 160);
            pnlDescription.TabIndex = 2;
            // 
            // lblDescriptionTitle
            // 
            lblDescriptionTitle.AutoSize = true;
            lblDescriptionTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDescriptionTitle.ForeColor = Color.FromArgb(33, 150, 243);
            lblDescriptionTitle.Location = new Point(0, 0);
            lblDescriptionTitle.Name = "lblDescriptionTitle";
            lblDescriptionTitle.Size = new Size(111, 25);
            lblDescriptionTitle.TabIndex = 0;
            lblDescriptionTitle.Text = "Beskrivelse";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.Location = new Point(0, 40);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(81, 19);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Beskrivelse:";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.Location = new Point(0, 65);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(620, 80);
            txtDescription.TabIndex = 2;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnSave);
            pnlButtons.Controls.Add(btnCancel);
            pnlButtons.Dock = DockStyle.Top;
            pnlButtons.Location = new Point(30, 650);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(640, 60);
            pnlButtons.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(76, 175, 80);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(0, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "💾 Gem";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(244, 67, 54);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(170, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 40);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "❌ Annuller";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.BackColor = Color.FromArgb(158, 158, 158);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(30, 500);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 35);
            btnBack.TabIndex = 2;
            btnBack.Text = "← Tilbage";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // NewProperty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 550);
            Controls.Add(btnBack);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Name = "NewProperty";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EDC - Ny bolig";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlForm.ResumeLayout(false);
            pnlBasicInfo.ResumeLayout(false);
            pnlBasicInfo.PerformLayout();
            pnlPropertyDetails.ResumeLayout(false);
            pnlPropertyDetails.PerformLayout();
            pnlDescription.ResumeLayout(false);
            pnlDescription.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel pnlHeader;
        private Label lblHeader;
        private Panel pnlContent;
        private Panel pnlForm;
        private Panel pnlBasicInfo;
        private Label lblBasicInfo;
        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblPostalCode;
        private TextBox txtPostalCode;
        private Label lblCity;
        private TextBox txtCity;
        private Panel pnlPropertyDetails;
        private Label lblPropertyDetails;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblSquareMeters;
        private TextBox txtSquareMeters;
        private Label lblPropertyType;
        private ComboBox cmbPropertyType;
        private Label lblPropertyStatus;
        private ComboBox cmbPropertyStatus;
        private Label lblListingDate;
        private DateTimePicker dtpListingDate;
        private Panel pnlDescription;
        private Label lblDescriptionTitle;
        private Label lblDescription;
        private TextBox txtDescription;
        private Panel pnlButtons;
        private Button btnSave;
        private Button btnCancel;
        private Button btnBack;
    }
}
