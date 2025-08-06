using EDC.Models;
using EDC.Helpers;
using EDC.Services;
using EDC.UI.Theme;
using EDC.UI.Utils;
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
    public partial class ViewRealtors : Form
    {
        private readonly IRealtorService _realtorService;
        private List<Realtor> _realtors = new();

        public ViewRealtors()
        {
            InitializeComponent();
            _realtorService = new RealtorService();
            UIHelper.ApplyModernStyle(this);
        }

        private async void ViewRealtors_Load(object sender, EventArgs e)
        {
            await LoadRealtors();
        }

        private async Task LoadRealtors()
        {
            try
            {
                _realtors = await _realtorService.GetAllRealtorsAsync();
                UpdateDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fejl ved indlæsning af mæglere: {ex.Message}", "Fejl", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDataGridView()
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _realtors.Select(r => new
            {
                Id = r.Id,
                Navn = r.FullName,
                Telefon = r.Phone,
                Email = r.Email,
                Oprettet = r.CreatedDate.ToString("dd/MM/yyyy")
            }).ToList();

            dataGridView1.DataSource = bindingSource;
            
            // Configure columns
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["Id"].Width = 50;
                dataGridView1.Columns["Navn"].Width = 150;
                dataGridView1.Columns["Telefon"].Width = 100;
                dataGridView1.Columns["Email"].Width = 200;
                dataGridView1.Columns["Oprettet"].Width = 100;
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var searchTerm = txtSearch.Text.Trim();
            
            try
            {
                _realtors = await _realtorService.SearchRealtorsAsync(searchTerm);
                UpdateDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fejl ved søgning: {ex.Message}", "Fejl", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadRealtors();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var selectedId = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                var updateForm = new UpdateRealtor(selectedId);
                NavigationHelper.NavigateTo(this, updateForm);
            }
            else
            {
                MessageBox.Show("Vælg venligst en mægler at redigere.", "Ingen valg", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var selectedId = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                var selectedName = dataGridView1.CurrentRow.Cells["Navn"].Value.ToString();

                var result = MessageBox.Show($"Er du sikker på, at du vil slette mægler '{selectedName}'?", 
                    "Bekræft sletning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var success = await _realtorService.DeleteRealtorAsync(selectedId);
                        if (success)
                        {
                            MessageBox.Show("Mægler er slettet.", "Succes", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadRealtors();
                        }
                        else
                        {
                            MessageBox.Show("Fejl ved sletning af mægler.", "Fejl", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Fejl ved sletning: {ex.Message}", "Fejl", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vælg venligst en mægler at slette.", "Ingen valg", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
