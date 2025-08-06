using EDC.Models;
using EDC.Helpers;
using EDC.Services;
using EDC.UI.Theme;
using EDC.UI.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDC.Views.Realtors
{
    public partial class NewRealtor : Form
    {
        private readonly IRealtorService _realtorService;

        public NewRealtor()
        {
            InitializeComponent();
            _realtorService = new RealtorService();
            ApplyModernStyling();
        }

        private void ApplyModernStyling()
        {
            BackColor = ModernColors.Background;
            UIHelper.ApplyModernStyling(this);
            UIHelper.StyleButton(btnCreateNewRealtor, true);
            UIHelper.StyleButton(btnBack, false);
            
            // Style text boxes
            UIHelper.StyleTextBox(txtboxFirstName);
            UIHelper.StyleTextBox(txtBoxLastName);
            UIHelper.StyleTextBox(txtBoxPhone);
            UIHelper.StyleTextBox(txtBoxEmail);
            
            // Style labels
            UIHelper.StyleLabel(label1);
            UIHelper.StyleLabel(label2);
            UIHelper.StyleLabel(label3);
            UIHelper.StyleLabel(label4);
        }

        private async void btnCreateNewRealtor_Click(object sender, EventArgs e)
        {
            var firstName = txtboxFirstName.Text.Trim();
            var lastName = txtBoxLastName.Text.Trim();
            var phone = txtBoxPhone.Text.Trim();
            var email = txtBoxEmail.Text.Trim();

            var validationResult = ValidationHelper.ValidateRealtor(firstName, lastName, phone, email);
            
            if (!validationResult.IsValid)
            {
                MessageBox.Show(validationResult.GetErrorMessage(), "Valideringsfejl", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var newRealtor = new Realtor
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Phone = phone,
                    Email = email
                };

                var success = await _realtorService.AddRealtorAsync(newRealtor);
                
                if (success)
                {
                    MessageBox.Show("Mægler er oprettet med succes!", "Succes", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Der opstod en fejl ved oprettelse af mægler.", "Fejl", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Der opstod en uventet fejl: {ex.Message}", "Fejl", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtboxFirstName.Clear();
            txtBoxLastName.Clear();
            txtBoxPhone.Clear();
            txtBoxEmail.Clear();
            txtboxFirstName.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateToStartView(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateBack(this);
        }

        private void NewRealtor_Load(object sender, EventArgs e)
        {
            txtboxFirstName.Focus();
        }
    }
}
