namespace EDC.Views.Properties
{
    partial class PropertiesPageMain
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
            btnNewProperty = new Button();
            btnViewProperties = new Button();
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
            lblTitle.Size = new Size(119, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Boliger";
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
            pnlActions.Controls.Add(btnNewProperty);
            pnlActions.Controls.Add(btnViewProperties);
            pnlActions.Dock = DockStyle.Top;
            pnlActions.Location = new Point(50, 50);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(700, 100);
            pnlActions.TabIndex = 0;
            // 
            // btnNewProperty
            // 
            btnNewProperty.BackColor = Color.FromArgb(33, 150, 243);
            btnNewProperty.FlatAppearance.BorderSize = 0;
            btnNewProperty.FlatStyle = FlatStyle.Flat;
            btnNewProperty.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNewProperty.ForeColor = Color.White;
            btnNewProperty.Location = new Point(20, 20);
            btnNewProperty.Name = "btnNewProperty";
            btnNewProperty.Size = new Size(200, 50);
            btnNewProperty.TabIndex = 0;
            btnNewProperty.Text = "🏠 Opret bolig";
            btnNewProperty.UseVisualStyleBackColor = false;
            // 
            // btnViewProperties
            // 
            btnViewProperties.BackColor = Color.FromArgb(76, 175, 80);
            btnViewProperties.FlatAppearance.BorderSize = 0;
            btnViewProperties.FlatStyle = FlatStyle.Flat;
            btnViewProperties.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnViewProperties.ForeColor = Color.White;
            btnViewProperties.Location = new Point(240, 20);
            btnViewProperties.Name = "btnViewProperties";
            btnViewProperties.Size = new Size(200, 50);
            btnViewProperties.TabIndex = 1;
            btnViewProperties.Text = "🏘️ Se boliger";
            btnViewProperties.UseVisualStyleBackColor = false;
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
            // 
            // PropertiesPageMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(btnBack);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Name = "PropertiesPageMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EDC - Boliger";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlContent;
        private Panel pnlActions;
        private Button btnNewProperty;
        private Button btnViewProperties;
        private Button btnBack;
    }
}
