namespace EDC.Views.Customers
{
    partial class ViewCustomers
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
            pnlFilters = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblFilterType = new Label();
            cmbFilterType = new ComboBox();
            btnRefresh = new Button();
            dgvCustomers = new DataGridView();
            pnlStatus = new Panel();
            lblStatus = new Label();
            btnBack = new Button();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            pnlStatus.SuspendLayout();
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
            pnlHeader.Size = new Size(1000, 80);
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
            lblTitle.Size = new Size(185, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Se kunder";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(250, 250, 250);
            pnlContent.Controls.Add(dgvCustomers);
            pnlContent.Controls.Add(pnlFilters);
            pnlContent.Controls.Add(pnlStatus);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 80);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(30);
            pnlContent.Size = new Size(1000, 520);
            pnlContent.TabIndex = 1;
            // 
            // pnlFilters
            // 
            pnlFilters.BackColor = Color.White;
            pnlFilters.Controls.Add(lblSearch);
            pnlFilters.Controls.Add(txtSearch);
            pnlFilters.Controls.Add(lblFilterType);
            pnlFilters.Controls.Add(cmbFilterType);
            pnlFilters.Controls.Add(btnRefresh);
            pnlFilters.Dock = DockStyle.Top;
            pnlFilters.Location = new Point(30, 30);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Padding = new Padding(20);
            pnlFilters.Size = new Size(940, 80);
            pnlFilters.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F);
            lblSearch.Location = new Point(20, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(35, 19);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Søg:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(20, 45);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Søg efter navn, telefon, email eller by...";
            txtSearch.Size = new Size(300, 25);
            txtSearch.TabIndex = 1;
            // 
            // lblFilterType
            // 
            lblFilterType.AutoSize = true;
            lblFilterType.Font = new Font("Segoe UI", 10F);
            lblFilterType.Location = new Point(340, 20);
            lblFilterType.Name = "lblFilterType";
            lblFilterType.Size = new Size(39, 19);
            lblFilterType.TabIndex = 2;
            lblFilterType.Text = "Type:";
            // 
            // cmbFilterType
            // 
            cmbFilterType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterType.Font = new Font("Segoe UI", 10F);
            cmbFilterType.FormattingEnabled = true;
            cmbFilterType.Items.AddRange(new object[] { "Alle", "Køber", "Sælger" });
            cmbFilterType.Location = new Point(340, 45);
            cmbFilterType.Name = "cmbFilterType";
            cmbFilterType.Size = new Size(150, 25);
            cmbFilterType.TabIndex = 3;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(76, 175, 80);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(820, 35);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 35);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "🔄 Opdater";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.BorderStyle = BorderStyle.None;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.GridColor = Color.FromArgb(224, 224, 224);
            dgvCustomers.Location = new Point(30, 110);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(940, 370);
            dgvCustomers.TabIndex = 1;
            // 
            // pnlStatus
            // 
            pnlStatus.BackColor = Color.White;
            pnlStatus.Controls.Add(lblStatus);
            pnlStatus.Dock = DockStyle.Bottom;
            pnlStatus.Location = new Point(30, 480);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Padding = new Padding(20, 10, 20, 10);
            pnlStatus.Size = new Size(940, 40);
            pnlStatus.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Left;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.FromArgb(117, 117, 117);
            lblStatus.Location = new Point(20, 10);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(95, 15);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Indlæser kunder...";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.BackColor = Color.FromArgb(158, 158, 158);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(30, 550);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 35);
            btnBack.TabIndex = 2;
            btnBack.Text = "← Tilbage";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ViewCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(btnBack);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Name = "ViewCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EDC - Se kunder";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            pnlStatus.ResumeLayout(false);
            pnlStatus.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlContent;
        private Panel pnlFilters;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblFilterType;
        private ComboBox cmbFilterType;
        private Button btnRefresh;
        private DataGridView dgvCustomers;
        private Panel pnlStatus;
        private Label lblStatus;
        private Button btnBack;
    }
}
