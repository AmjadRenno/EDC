using EDC.Helpers;
using EDC.Models;
using EDC.Services;
using System.ComponentModel.DataAnnotations;

namespace EDC.Views.Customers
{
    public partial class NewCustomer : Form
    {
        private readonly ICustomerService _customerService;

        public NewCustomer()
        {
            InitializeComponent();
            _customerService = new CustomerService();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            Load += NewCustomer_Load;
        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {
            // Set default values
            dtpBirthDate.Value = DateTime.Now.AddYears(-30);
            cmbCustomerType.SelectedIndex = 0;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                // Disable the button to prevent double-clicking
                btnSave.Enabled = false;
                
                var customer = new Customer
                {
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    BirthDate = dtpBirthDate.Value,
                    Address = txtAddress.Text.Trim(),
                    PostalCode = txtPostalCode.Text.Trim(),
                    City = txtCity.Text.Trim(),
                    CustomerType = (CustomerType)cmbCustomerType.SelectedIndex
                };

                await _customerService.CreateCustomerAsync(customer);

                MessageBox.Show("Kunden er oprettet succesfuldt!", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                NavigationHelper.NavigateBack(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fejl ved oprettelse af kunde: {ex.Message}", "Fejl", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSave.Enabled = true;
            }
        }

        private bool ValidateInput()
        {
            var customer = new Customer
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                BirthDate = dtpBirthDate.Value,
                Address = txtAddress.Text.Trim(),
                PostalCode = txtPostalCode.Text.Trim(),
                City = txtCity.Text.Trim(),
                CustomerType = (CustomerType)cmbCustomerType.SelectedIndex
            };

            var context = new ValidationContext(customer);
            var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();

            if (!Validator.TryValidateObject(customer, context, results, true))
            {
                string errorMessage = string.Join("\n", results.Select(r => r.ErrorMessage));
                MessageBox.Show(errorMessage, "Valideringsfejl", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateBack(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateBack(this);
        }
    }
}
