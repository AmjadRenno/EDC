using EDC.Models;
using EDC.Helpers;
using EDC.Services;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDC.Views.Realtors
{
    public partial class UpdateRealtor : Form
    {
        private readonly IRealtorService _realtorService;
        private readonly int _realtorId;
        private Realtor? _currentRealtor;

        public UpdateRealtor(int realtorId)
        {
            InitializeComponent();
            _realtorService = new RealtorService();
            _realtorId = realtorId;
        }

        private async void UpdateRealtor_Load(object sender, EventArgs e)
        {
            await LoadRealtor();
        }

        private async Task LoadRealtor()
        {
            try
            {
                _currentRealtor = await _realtorService.GetRealtorByIdAsync(_realtorId);
                
                if (_currentRealtor != null)
                {
                    txtboxFirstName.Text = _currentRealtor.FirstName;
                    txtBoxLastName.Text = _currentRealtor.LastName;
                    txtBoxPhone.Text = _currentRealtor.Phone;
                    txtBoxEmail.Text = _currentRealtor.Email;
                }
                else
                {
                    MessageBox.Show("Mægler ikke fundet.", "Fejl", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NavigationHelper.NavigateBack(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fejl ved indlæsning af mægler: {ex.Message}", "Fejl", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUpdateRealtor_Click(object sender, EventArgs e)
        {
            if (_currentRealtor == null) return;

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
                _currentRealtor.FirstName = firstName;
                _currentRealtor.LastName = lastName;
                _currentRealtor.Phone = phone;
                _currentRealtor.Email = email;

                var success = await _realtorService.UpdateRealtorAsync(_currentRealtor);
                
                if (success)
                {
                    MessageBox.Show("Mægler er opdateret med succes!", "Succes", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NavigationHelper.NavigateBack(this);
                }
                else
                {
                    MessageBox.Show("Der opstod en fejl ved opdatering af mægler.", "Fejl", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Der opstod en uventet fejl: {ex.Message}", "Fejl", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateBack(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateToStartView(this);
        }
    }
}
