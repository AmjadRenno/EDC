using EDC.Helpers;
using EDC.Models;
using EDC.Services;
using System.ComponentModel.DataAnnotations;

namespace EDC.Views.Properties
{
    public partial class NewProperty : Form
    {
        private readonly IPropertyService _propertyService;

        public NewProperty()
        {
            InitializeComponent();
            _propertyService = new PropertyService();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            Load += NewProperty_Load;
        }

        private void NewProperty_Load(object sender, EventArgs e)
        {
            // Set default values
            cmbPropertyType.SelectedIndex = 0;
            cmbPropertyStatus.SelectedIndex = 0;
            dtpListingDate.Value = DateTime.Now;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                // Disable the button to prevent double-clicking
                btnSave.Enabled = false;
                
                var property = new Property
                {
                    Title = txtTitle.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    PostalCode = txtPostalCode.Text.Trim(),
                    City = txtCity.Text.Trim(),
                    AskingPrice = decimal.Parse(txtPrice.Text.Trim()),
                    SizeM2 = int.Parse(txtSquareMeters.Text.Trim()),
                    Type = (PropertyType)cmbPropertyType.SelectedIndex,
                    Status = (PropertyStatus)cmbPropertyStatus.SelectedIndex,
                    Rooms = 1, // Default value
                    YearBuilt = DateTime.Now.Year, // Default value
                    SellerId = 1, // Default value - would be selected from customers
                    RealtorId = 1, // Default value - would be selected from realtors
                    Description = txtDescription.Text.Trim()
                };

                await _propertyService.CreatePropertyAsync(property);

                MessageBox.Show("Boligen er oprettet succesfuldt!", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                NavigationHelper.NavigateBack(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fejl ved oprettelse af bolig: {ex.Message}", "Fejl", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSave.Enabled = true;
            }
        }

        private bool ValidateInput()
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Titel er påkrævet", "Valideringsfejl", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Adresse er påkrævet", "Valideringsfejl", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price) || price <= 0)
            {
                MessageBox.Show("Pris skal være et gyldigt tal større end 0", "Valideringsfejl", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }

            if (!int.TryParse(txtSquareMeters.Text.Trim(), out int squareMeters) || squareMeters <= 0)
            {
                MessageBox.Show("Kvadratmeter skal være et gyldigt tal større end 0", "Valideringsfejl", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSquareMeters.Focus();
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
