namespace EDC.Views.Realtors
{
    partial class RealtorsPageMain
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlContent = new Panel();
            pnlActions = new Panel();
            btnNewRealtor = new Button();
            btnViewRealtors = new Button();
            btnBack = new Button();
            pictureBox1 = new PictureBox();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            pnlHeader.Size = new Size(888, 80);
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
            lblTitle.Size = new Size(187, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Ejendomsmæglere";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(250, 250, 250);
            pnlContent.Controls.Add(pnlActions);
            pnlContent.Controls.Add(pictureBox1);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 80);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(50);
            pnlContent.Size = new Size(888, 488);
            pnlContent.TabIndex = 1;
            // 
            // pnlActions
            // 
            pnlActions.Controls.Add(btnNewRealtor);
            pnlActions.Controls.Add(btnViewRealtors);
            pnlActions.Dock = DockStyle.Bottom;
            pnlActions.Location = new Point(50, 338);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(788, 100);
            pnlActions.TabIndex = 1;
            // 
            // btnNewRealtor
            // 
            btnNewRealtor.BackColor = Color.FromArgb(33, 150, 243);
            btnNewRealtor.FlatAppearance.BorderSize = 0;
            btnNewRealtor.FlatStyle = FlatStyle.Flat;
            btnNewRealtor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNewRealtor.ForeColor = Color.White;
            btnNewRealtor.Location = new Point(20, 20);
            btnNewRealtor.Name = "btnNewRealtor";
            btnNewRealtor.Size = new Size(200, 50);
            btnNewRealtor.TabIndex = 0;
            btnNewRealtor.Text = "📝 Opret mægler";
            btnNewRealtor.UseVisualStyleBackColor = false;
            btnNewRealtor.Click += btnNewRealtor_Click;
            // 
            // btnViewRealtors
            // 
            btnViewRealtors.BackColor = Color.FromArgb(76, 175, 80);
            btnViewRealtors.FlatAppearance.BorderSize = 0;
            btnViewRealtors.FlatStyle = FlatStyle.Flat;
            btnViewRealtors.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnViewRealtors.ForeColor = Color.White;
            btnViewRealtors.Location = new Point(240, 20);
            btnViewRealtors.Name = "btnViewRealtors";
            btnViewRealtors.Size = new Size(200, 50);
            btnViewRealtors.TabIndex = 1;
            btnViewRealtors.Text = "👥 Se mæglere";
            btnViewRealtors.UseVisualStyleBackColor = false;
            btnViewRealtors.Click += btnViewRealtors_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.BackColor = Color.FromArgb(158, 158, 158);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(30, 520);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 35);
            btnBack.TabIndex = 2;
            btnBack.Text = "← Tilbage";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = global::EDC.Properties.Resources.edc_logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(200, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 250);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // RealtorsPageMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(888, 568);
            Controls.Add(btnBack);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RealtorsPageMain";
            Text = "EDC - Ejendomsmæglere";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlContent;
        private Panel pnlActions;
        private Button btnNewRealtor;
        private Button btnViewRealtors;
        private Button btnBack;
        private PictureBox pictureBox1;
    }
}