using EDC.UI.Components;

namespace EDC
{
    partial class StartView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            btnMægler = new ModernButton();
            btnKunder = new ModernButton();
            btnBolig = new ModernButton();
            pictureBox1 = new PictureBox();
            mainPanel = new Panel();
            headerPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            mainPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(33, 33, 33);
            titleLabel.Location = new Point(300, 80);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(390, 45);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "EDC Ejendomsmæglerne";
            // 
            // btnMægler
            // 
            btnMægler.IsPrimary = true;
            btnMægler.Location = new Point(50, 50);
            btnMægler.Name = "btnMægler";
            btnMægler.Size = new Size(200, 50);
            btnMægler.TabIndex = 0;
            btnMægler.Text = "Mæglere";
            btnMægler.Click += btnRealtors_Click_1;
            // 
            // btnKunder
            // 
            btnKunder.IsPrimary = false;
            btnKunder.Location = new Point(270, 50);
            btnKunder.Name = "btnKunder";
            btnKunder.Size = new Size(200, 50);
            btnKunder.TabIndex = 1;
            btnKunder.Text = "Kunder";
            btnKunder.Click += btnCustomers_Click;
            // 
            // btnBolig
            // 
            btnBolig.IsPrimary = false;
            btnBolig.Location = new Point(490, 50);
            btnBolig.Name = "btnBolig";
            btnBolig.Size = new Size(200, 50);
            btnBolig.TabIndex = 2;
            btnBolig.Text = "Boliger";
            btnBolig.Click += btnProperties_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.edc_logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(20, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 160);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Controls.Add(btnMægler);
            mainPanel.Controls.Add(btnKunder);
            mainPanel.Controls.Add(btnBolig);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 200);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(40);
            mainPanel.Size = new Size(800, 200);
            mainPanel.TabIndex = 5;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(248, 249, 250);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Controls.Add(pictureBox1);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(800, 200);
            headerPanel.TabIndex = 6;
            // 
            // StartView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(800, 400);
            Controls.Add(mainPanel);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StartView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EDC - Ejendomsmægler System";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            mainPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        private ModernButton btnMægler;
        private ModernButton btnKunder;
        private ModernButton btnBolig;
        private PictureBox pictureBox1;
        private Panel mainPanel;
        private Panel headerPanel;
    }
}
