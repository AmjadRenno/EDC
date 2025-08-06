namespace EDC.Views.Customers
{
    partial class NewCustomer
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
            lblTitle = new Label();
            pnlContent = new Panel();
            pnlForm = new Panel();
            pnlPersonalInfo = new Panel();
            lblPersonalInfo = new Label();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblBirthDate = new Label();
            dtpBirthDate = new DateTimePicker();
            lblCustomerType = new Label();
            cmbCustomerType = new ComboBox();
            pnlAddressInfo = new Panel();
            lblAddressInfo = new Label();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblPostalCode = new Label();
            txtPostalCode = new TextBox();
            lblCity = new Label();
            txtCity = new TextBox();
            pnlButtons = new Panel();
            btnSave = new Button();
            btnCancel = new Button();
            btnBack = new Button();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlForm.SuspendLayout();
            pnlPersonalInfo.SuspendLayout();
            pnlAddressInfo.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(33, 150, 243);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(30, 20, 30, 20);
            pnlHeader.Size = new Size(800, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Left;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(189, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Ny kunde";
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
            pnlForm.Controls.Add(pnlPersonalInfo);
            pnlForm.Controls.Add(pnlAddressInfo);
            pnlForm.Controls.Add(pnlButtons);
            pnlForm.Dock = DockStyle.Top;
            pnlForm.Location = new Point(50, 50);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new Padding(30);
            pnlForm.Size = new Size(700, 600);
            pnlForm.TabIndex = 0;
            // 
            // pnlPersonalInfo
            // 
            pnlPersonalInfo.Controls.Add(lblPersonalInfo);
            pnlPersonalInfo.Controls.Add(lblFirstName);
            pnlPersonalInfo.Controls.Add(txtFirstName);
            pnlPersonalInfo.Controls.Add(lblLastName);
            pnlPersonalInfo.Controls.Add(txtLastName);
            pnlPersonalInfo.Controls.Add(lblPhone);
            pnlPersonalInfo.Controls.Add(txtPhone);
            pnlPersonalInfo.Controls.Add(lblEmail);
            pnlPersonalInfo.Controls.Add(txtEmail);
            pnlPersonalInfo.Controls.Add(lblBirthDate);
            pnlPersonalInfo.Controls.Add(dtpBirthDate);
            pnlPersonalInfo.Controls.Add(lblCustomerType);
            pnlPersonalInfo.Controls.Add(cmbCustomerType);
            pnlPersonalInfo.Dock = DockStyle.Top;
            pnlPersonalInfo.Location = new Point(30, 30);
            pnlPersonalInfo.Name = "pnlPersonalInfo";
            pnlPersonalInfo.Size = new Size(640, 300);
            pnlPersonalInfo.TabIndex = 0;
            // 
            // lblPersonalInfo
            // 
            lblPersonalInfo.AutoSize = true;
            lblPersonalInfo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPersonalInfo.ForeColor = Color.FromArgb(33, 150, 243);
            lblPersonalInfo.Location = new Point(0, 0);
            lblPersonalInfo.Name = "lblPersonalInfo";
            lblPersonalInfo.Size = new Size(179, 25);
            lblPersonalInfo.TabIndex = 0;
            lblPersonalInfo.Text = "Personlige oplysninger";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 10F);
            lblFirstName.Location = new Point(0, 40);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(60, 19);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "Fornavn:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.Location = new Point(0, 65);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(300, 25);
            txtFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 10F);
            lblLastName.Location = new Point(320, 40);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(70, 19);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Efternavn:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.Location = new Point(320, 65);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(300, 25);
            txtLastName.TabIndex = 4;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F);
            lblPhone.Location = new Point(0, 110);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(58, 19);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Telefon:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.Location = new Point(0, 135);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(300, 25);
            txtPhone.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(320, 110);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 19);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(320, 135);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 25);
            txtEmail.TabIndex = 8;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Segoe UI", 10F);
            lblBirthDate.Location = new Point(0, 180);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(89, 19);
            lblBirthDate.TabIndex = 9;
            lblBirthDate.Text = "Fødselsdato:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Font = new Font("Segoe UI", 10F);
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(0, 205);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(300, 25);
            dtpBirthDate.TabIndex = 10;
            // 
            // lblCustomerType
            // 
            lblCustomerType.AutoSize = true;
            lblCustomerType.Font = new Font("Segoe UI", 10F);
            lblCustomerType.Location = new Point(320, 180);
            lblCustomerType.Name = "lblCustomerType";
            lblCustomerType.Size = new Size(74, 19);
            lblCustomerType.TabIndex = 11;
            lblCustomerType.Text = "Kundetype:";
            // 
            // cmbCustomerType
            // 
            cmbCustomerType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomerType.Font = new Font("Segoe UI", 10F);
            cmbCustomerType.FormattingEnabled = true;
            cmbCustomerType.Items.AddRange(new object[] { "Køber", "Sælger" });
            cmbCustomerType.Location = new Point(320, 205);
            cmbCustomerType.Name = "cmbCustomerType";
            cmbCustomerType.Size = new Size(300, 25);
            cmbCustomerType.TabIndex = 12;
            // 
            // pnlAddressInfo
            // 
            pnlAddressInfo.Controls.Add(lblAddressInfo);
            pnlAddressInfo.Controls.Add(lblAddress);
            pnlAddressInfo.Controls.Add(txtAddress);
            pnlAddressInfo.Controls.Add(lblPostalCode);
            pnlAddressInfo.Controls.Add(txtPostalCode);
            pnlAddressInfo.Controls.Add(lblCity);
            pnlAddressInfo.Controls.Add(txtCity);
            pnlAddressInfo.Dock = DockStyle.Top;
            pnlAddressInfo.Location = new Point(30, 330);
            pnlAddressInfo.Name = "pnlAddressInfo";
            pnlAddressInfo.Size = new Size(640, 180);
            pnlAddressInfo.TabIndex = 1;
            // 
            // lblAddressInfo
            // 
            lblAddressInfo.AutoSize = true;
            lblAddressInfo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblAddressInfo.ForeColor = Color.FromArgb(33, 150, 243);
            lblAddressInfo.Location = new Point(0, 0);
            lblAddressInfo.Name = "lblAddressInfo";
            lblAddressInfo.Size = new Size(76, 25);
            lblAddressInfo.TabIndex = 0;
            lblAddressInfo.Text = "Adresse";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10F);
            lblAddress.Location = new Point(0, 40);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(59, 19);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "Adresse:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10F);
            txtAddress.Location = new Point(0, 65);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(620, 25);
            txtAddress.TabIndex = 2;
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Font = new Font("Segoe UI", 10F);
            lblPostalCode.Location = new Point(0, 110);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(83, 19);
            lblPostalCode.TabIndex = 3;
            lblPostalCode.Text = "Postnummer:";
            // 
            // txtPostalCode
            // 
            txtPostalCode.Font = new Font("Segoe UI", 10F);
            txtPostalCode.Location = new Point(0, 135);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(150, 25);
            txtPostalCode.TabIndex = 4;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 10F);
            lblCity.Location = new Point(170, 110);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(28, 19);
            lblCity.TabIndex = 5;
            lblCity.Text = "By:";
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 10F);
            txtCity.Location = new Point(170, 135);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(450, 25);
            txtCity.TabIndex = 6;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnSave);
            pnlButtons.Controls.Add(btnCancel);
            pnlButtons.Dock = DockStyle.Top;
            pnlButtons.Location = new Point(30, 510);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(640, 60);
            pnlButtons.TabIndex = 2;
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
            btnBack.TabIndex = 3;
            btnBack.Text = "← Tilbage";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // NewCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 550);
            Controls.Add(btnBack);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Name = "NewCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EDC - Ny kunde";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlForm.ResumeLayout(false);
            pnlPersonalInfo.ResumeLayout(false);
            pnlPersonalInfo.PerformLayout();
            pnlAddressInfo.ResumeLayout(false);
            pnlAddressInfo.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlContent;
        private Panel pnlForm;
        private Panel pnlPersonalInfo;
        private Label lblPersonalInfo;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblBirthDate;
        private DateTimePicker dtpBirthDate;
        private Label lblCustomerType;
        private ComboBox cmbCustomerType;
        private Panel pnlAddressInfo;
        private Label lblAddressInfo;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblPostalCode;
        private TextBox txtPostalCode;
        private Label lblCity;
        private TextBox txtCity;
        private Panel pnlButtons;
        private Button btnSave;
        private Button btnCancel;
        private Button btnBack;
    }
}
