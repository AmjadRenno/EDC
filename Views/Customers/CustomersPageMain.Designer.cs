namespace EDC.Views.Customers
{
    partial class CustomersPageMain
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
            pnlActions = new Panel();
            btnNewCustomer = new Button();
            btnViewCustomers = new Button();
            btnBack = new Button();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlActions.SuspendLayout();
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
            lblTitle.Size = new Size(114, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Kunder";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(250, 250, 250);
            pnlContent.Controls.Add(pnlActions);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 80);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(50);
            pnlContent.Size = new Size(800, 420);
            pnlContent.TabIndex = 1;
            // 
            // pnlActions
            // 
            pnlActions.Controls.Add(btnNewCustomer);
            pnlActions.Controls.Add(btnViewCustomers);
            pnlActions.Dock = DockStyle.Top;
            pnlActions.Location = new Point(50, 50);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(700, 100);
            pnlActions.TabIndex = 0;
            // 
            // btnNewCustomer
            // 
            btnNewCustomer.BackColor = Color.FromArgb(33, 150, 243);
            btnNewCustomer.FlatAppearance.BorderSize = 0;
            btnNewCustomer.FlatStyle = FlatStyle.Flat;
            btnNewCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNewCustomer.ForeColor = Color.White;
            btnNewCustomer.Location = new Point(20, 20);
            btnNewCustomer.Name = "btnNewCustomer";
            btnNewCustomer.Size = new Size(200, 50);
            btnNewCustomer.TabIndex = 0;
            btnNewCustomer.Text = "📝 Opret kunde";
            btnNewCustomer.UseVisualStyleBackColor = false;
            btnNewCustomer.Click += btnNewCustomer_Click;
            // 
            // btnViewCustomers
            // 
            btnViewCustomers.BackColor = Color.FromArgb(76, 175, 80);
            btnViewCustomers.FlatAppearance.BorderSize = 0;
            btnViewCustomers.FlatStyle = FlatStyle.Flat;
            btnViewCustomers.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnViewCustomers.ForeColor = Color.White;
            btnViewCustomers.Location = new Point(240, 20);
            btnViewCustomers.Name = "btnViewCustomers";
            btnViewCustomers.Size = new Size(200, 50);
            btnViewCustomers.TabIndex = 1;
            btnViewCustomers.Text = "👥 Se kunder";
            btnViewCustomers.UseVisualStyleBackColor = false;
            btnViewCustomers.Click += btnViewCustomers_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.BackColor = Color.FromArgb(158, 158, 158);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(30, 450);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 35);
            btnBack.TabIndex = 2;
            btnBack.Text = "← Tilbage";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // CustomersPageMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(800, 500);
            Controls.Add(btnBack);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CustomersPageMain";
            Text = "EDC - Kunder";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlContent;
        private Panel pnlActions;
        private Button btnNewCustomer;
        private Button btnViewCustomers;
        private Button btnBack;
    }
}
