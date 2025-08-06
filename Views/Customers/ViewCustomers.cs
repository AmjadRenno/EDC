using EDC.Helpers;
using EDC.Models;
using EDC.Services;

namespace EDC.Views.Customers
{
    public partial class ViewCustomers : Form
    {
        private readonly ICustomerService _customerService;
        private List<Customer> _allCustomers;
        private List<Customer> _filteredCustomers;

        public ViewCustomers()
        {
            InitializeComponent();
            _customerService = new CustomerService();
            _allCustomers = new List<Customer>();
            _filteredCustomers = new List<Customer>();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            Load += ViewCustomers_Load;
            txtSearch.TextChanged += txtSearch_TextChanged;
            cmbFilterType.SelectedIndexChanged += cmbFilterType_SelectedIndexChanged;
            btnRefresh.Click += btnRefresh_Click;
            dgvCustomers.CellDoubleClick += dgvCustomers_CellDoubleClick;
        }

        private async void ViewCustomers_Load(object sender, EventArgs e)
        {
            await LoadCustomersAsync();
            SetupDataGridView();
            cmbFilterType.SelectedIndex = 0; // All customers
        }

        private async Task LoadCustomersAsync()
        {
            try
            {
                _allCustomers = await _customerService.GetAllCustomersAsync();
                _filteredCustomers = new List<Customer>(_allCustomers);
                UpdateDataGridView();
                UpdateStatusLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fejl ved indlæsning af kunder: {ex.Message}", "Fejl", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.ReadOnly = true;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.MultiSelect = false;

            dgvCustomers.Columns.Clear();

            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 80,
                Visible = false
            });

            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FullName",
                HeaderText = "Navn",
                DataPropertyName = "FullName",
                Width = 200
            });

            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Phone",
                HeaderText = "Telefon",
                DataPropertyName = "Phone",
                Width = 120
            });

            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Email",
                HeaderText = "Email",
                DataPropertyName = "Email",
                Width = 200
            });

            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CustomerType",
                HeaderText = "Type",
                DataPropertyName = "CustomerTypeDisplay",
                Width = 100
            });

            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "City",
                HeaderText = "By",
                DataPropertyName = "City",
                Width = 150
            });

            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Age",
                HeaderText = "Alder",
                DataPropertyName = "Age",
                Width = 80
            });

            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CreatedAt",
                HeaderText = "Oprettet",
                DataPropertyName = "CreatedAt",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });
        }

        private void UpdateDataGridView()
        {
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = _filteredCustomers;
        }

        private void UpdateStatusLabel()
        {
            lblStatus.Text = $"Viser {_filteredCustomers.Count} af {_allCustomers.Count} kunder";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
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
            var filterType = cmbFilterType.SelectedIndex;

            _filteredCustomers = _allCustomers.Where(customer =>
            {
                // Text search filter
                bool matchesSearch = string.IsNullOrEmpty(searchText) ||
                    customer.FullName.ToLower().Contains(searchText) ||
                    customer.Phone.ToLower().Contains(searchText) ||
                    customer.Email.ToLower().Contains(searchText) ||
                    customer.City.ToLower().Contains(searchText);

                // Type filter
                bool matchesType = filterType switch
                {
                    0 => true, // All
                    1 => customer.CustomerType == CustomerType.Buyer, // Køber
                    2 => customer.CustomerType == CustomerType.Seller, // Sælger
                    _ => true
                };

                return matchesSearch && matchesType;
            }).ToList();

            UpdateDataGridView();
            UpdateStatusLabel();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadCustomersAsync();
        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < _filteredCustomers.Count)
            {
                var selectedCustomer = _filteredCustomers[e.RowIndex];
                ShowCustomerDetails(selectedCustomer);
            }
        }

        private void ShowCustomerDetails(Customer customer)
        {
            var details = $"Kunde detaljer:\n\n" +
                         $"Navn: {customer.FullName}\n" +
                         $"Telefon: {customer.Phone}\n" +
                         $"Email: {customer.Email}\n" +
                         $"Fødselsdato: {customer.BirthDate:dd/MM/yyyy} (Alder: {customer.Age})\n" +
                         $"Type: {customer.CustomerTypeDisplay}\n" +
                         $"Adresse: {customer.Address}\n" +
                         $"Postnummer: {customer.PostalCode}\n" +
                         $"By: {customer.City}\n" +
                         $"Oprettet: {customer.CreatedAt:dd/MM/yyyy HH:mm}";

            MessageBox.Show(details, "Kunde detaljer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateBack(this);
        }
    }
}
