namespace EDC.Views.Realtors
{
    partial class UpdateRealtor
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
            txtboxFirstName = new TextBox();
            txtBoxLastName = new TextBox();
            txtBoxPhone = new TextBox();
            txtBoxEmail = new TextBox();
            btnUpdateRealtor = new Button();
            pictureBox1 = new PictureBox();
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtboxFirstName
            // 
            txtboxFirstName.Cursor = Cursors.IBeam;
            txtboxFirstName.Location = new Point(12, 316);
            txtboxFirstName.Margin = new Padding(3, 2, 3, 2);
            txtboxFirstName.Name = "txtboxFirstName";
            txtboxFirstName.Size = new Size(204, 23);
            txtboxFirstName.TabIndex = 1;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Cursor = Cursors.IBeam;
            txtBoxLastName.Location = new Point(12, 372);
            txtBoxLastName.Margin = new Padding(3, 2, 3, 2);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(204, 23);
            txtBoxLastName.TabIndex = 2;
            // 
            // txtBoxPhone
            // 
            txtBoxPhone.Cursor = Cursors.IBeam;
            txtBoxPhone.Location = new Point(12, 434);
            txtBoxPhone.Margin = new Padding(3, 2, 3, 2);
            txtBoxPhone.Name = "txtBoxPhone";
            txtBoxPhone.Size = new Size(204, 23);
            txtBoxPhone.TabIndex = 3;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Cursor = Cursors.IBeam;
            txtBoxEmail.Location = new Point(12, 494);
            txtBoxEmail.Margin = new Padding(3, 2, 3, 2);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(204, 23);
            txtBoxEmail.TabIndex = 4;
            // 
            // btnUpdateRealtor
            // 
            btnUpdateRealtor.Anchor = AnchorStyles.Bottom;
            btnUpdateRealtor.BackColor = Color.LightSteelBlue;
            btnUpdateRealtor.ForeColor = SystemColors.ControlText;
            btnUpdateRealtor.Location = new Point(438, 554);
            btnUpdateRealtor.Margin = new Padding(3, 2, 3, 2);
            btnUpdateRealtor.Name = "btnUpdateRealtor";
            btnUpdateRealtor.Size = new Size(126, 40);
            btnUpdateRealtor.TabIndex = 5;
            btnUpdateRealtor.Text = "Opdater mægler";
            btnUpdateRealtor.UseVisualStyleBackColor = false;
            btnUpdateRealtor.Click += btnUpdateRealtor_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::EDC.Properties.Resources.edc_logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 257);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.BackgroundImage = global::EDC.Properties.Resources.LeftArrow;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.Location = new Point(36, 572);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(39, 22);
            btnBack.TabIndex = 7;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 298);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 8;
            label1.Text = "Fornavn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 355);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 9;
            label2.Text = "Efternavn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 417);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 10;
            label3.Text = "Telefonnummer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 477);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 11;
            label4.Text = "Email";
            // 
            // UpdateRealtor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(958, 632);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(pictureBox1);
            Controls.Add(btnUpdateRealtor);
            Controls.Add(txtBoxEmail);
            Controls.Add(txtBoxPhone);
            Controls.Add(txtBoxLastName);
            Controls.Add(txtboxFirstName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "UpdateRealtor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Opdater Mægler";
            Load += UpdateRealtor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtboxFirstName;
        private TextBox txtBoxLastName;
        private TextBox txtBoxPhone;
        private TextBox txtBoxEmail;
        private Button btnUpdateRealtor;
        private PictureBox pictureBox1;
        private Button btnBack;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}