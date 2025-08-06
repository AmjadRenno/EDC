using EDC.Helpers;
using EDC.Models;
using EDC.Services;

namespace EDC.Views.Properties
{
    public partial class ViewProperties : Form
    {
        private readonly IPropertyService _propertyService;
        private List<Property> _allProperties;
        private List<Property> _filteredProperties;

        public ViewProperties()
        {
            InitializeComponent();
            _propertyService = new PropertyService();
            _allProperties = new List<Property>();
            _filteredProperties = new List<Property>();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            Load += ViewProperties_Load;
            txtSearch.TextChanged += txtSearch_TextChanged;
            cmbFilterStatus.SelectedIndexChanged += cmbFilterStatus_SelectedIndexChanged;
            cmbFilterType.SelectedIndexChanged += cmbFilterType_SelectedIndexChanged;
            btnRefresh.Click += btnRefresh_Click;
            dgvProperties.CellDoubleClick += dgvProperties_CellDoubleClick;
        }

        private async void ViewProperties_Load(object sender, EventArgs e)
        {
            await LoadPropertiesAsync();
            SetupDataGridView();
            cmbFilterStatus.SelectedIndex = 0; // All statuses
            cmbFilterType.SelectedIndex = 0; // All types
        }

        private async Task LoadPropertiesAsync()
        {
            try
            {
                _allProperties = await _propertyService.GetAllPropertiesAsync();
                _filteredProperties = new List<Property>(_allProperties);
                UpdateDataGridView();
                UpdateStatusLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fejl ved indlæsning af boliger: {ex.Message}", "Fejl", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            dgvProperties.AutoGenerateColumns = false;
            dgvProperties.AllowUserToAddRows = false;
            dgvProperties.AllowUserToDeleteRows = false;
            dgvProperties.ReadOnly = true;
            dgvProperties.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProperties.MultiSelect = false;

            dgvProperties.Columns.Clear();

            dgvProperties.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 60,
                Visible = false
            });

            dgvProperties.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Title",
                HeaderText = "Titel",
                DataPropertyName = "Title",
                Width = 200
            });

            dgvProperties.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Address",
                HeaderText = "Adresse",
                DataPropertyName = "FullAddress",
                Width = 250
            });

            dgvProperties.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Pris",
                DataPropertyName = "FormattedPrice",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvProperties.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SquareMeters",
                HeaderText = "m²",
                DataPropertyName = "SquareMeters",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvProperties.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PricePerM2",
                HeaderText = "Pris/m²",
                DataPropertyName = "FormattedPricePerM2",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvProperties.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PropertyType",
                HeaderText = "Type",
                DataPropertyName = "PropertyTypeDisplay",
                Width = 120
            });

            dgvProperties.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "Status",
                DataPropertyName = "StatusDisplay",
                Width = 100
            });

            dgvProperties.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ListingDate",
                HeaderText = "Annonceret",
                DataPropertyName = "ListingDate",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });
        }

        private void UpdateDataGridView()
        {
            dgvProperties.DataSource = null;
            dgvProperties.DataSource = _filteredProperties;
        }

        private void UpdateStatusLabel()
        {
            lblStatus.Text = $"Viser {_filteredProperties.Count} af {_allProperties.Count} boliger";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cmbFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            var searchText = txtSearch.Text.ToLower().Trim();
            var filterStatus = cmbFilterStatus.SelectedIndex;
            var filterType = cmbFilterType.SelectedIndex;

            _filteredProperties = _allProperties.Where(property =>
            {
                // Text search filter
                bool matchesSearch = string.IsNullOrEmpty(searchText) ||
                    property.Title.ToLower().Contains(searchText) ||
                    property.Address.ToLower().Contains(searchText) ||
                    property.City.ToLower().Contains(searchText) ||
                    property.PostalCode.Contains(searchText);

                // Status filter
                bool matchesStatus = filterStatus switch
                {
                    0 => true, // All
                    1 => property.Status == PropertyStatus.ForSale, // Til salg
                    2 => property.Status == PropertyStatus.Sold, // Solgt
                    3 => property.Status == PropertyStatus.UnderOffer, // Under bud
                    4 => property.Status == PropertyStatus.Reserved, // Reserveret
                    _ => true
                };

                // Type filter
                bool matchesType = filterType switch
                {
                    0 => true, // All
                    1 => property.PropertyType == PropertyType.House, // Hus
                    2 => property.PropertyType == PropertyType.Apartment, // Lejlighed
                    3 => property.PropertyType == PropertyType.Townhouse, // Rækkehus
                    4 => property.PropertyType == PropertyType.Villa, // Villa
                    5 => property.PropertyType == PropertyType.Condominium, // Ejerlejlighed
                    _ => true
                };

                return matchesSearch && matchesStatus && matchesType;
            }).ToList();

            UpdateDataGridView();
            UpdateStatusLabel();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadPropertiesAsync();
        }

        private void dgvProperties_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < _filteredProperties.Count)
            {
                var selectedProperty = _filteredProperties[e.RowIndex];
                ShowPropertyDetails(selectedProperty);
            }
        }

        private void ShowPropertyDetails(Property property)
        {
            var details = $"Bolig detaljer:\n\n" +
                         $"Titel: {property.Title}\n" +
                         $"Adresse: {property.FullAddress}\n" +
                         $"Pris: {property.FormattedPrice}\n" +
                         $"Kvadratmeter: {property.SquareMeters} m²\n" +
                         $"Pris pr. m²: {property.FormattedPricePerM2}\n" +
                         $"Type: {property.PropertyTypeDisplay}\n" +
                         $"Status: {property.StatusDisplay}\n" +
                         $"Annonceret: {property.ListingDate:dd/MM/yyyy}\n" +
                         $"Beskrivelse: {property.Description}\n" +
                         $"Oprettet: {property.CreatedAt:dd/MM/yyyy HH:mm}";

            MessageBox.Show(details, "Bolig detaljer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateBack(this);
        }
    }
}
