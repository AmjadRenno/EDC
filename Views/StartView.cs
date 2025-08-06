using EDC.Helpers;
using EDC.Views;
using EDC.Views.Realtors;
using EDC.Views.Customers;
using EDC.Views.Properties;
using EDC.UI.Theme;
using EDC.UI.Utils;
using EDC.UI.Components;

namespace EDC
{
    public partial class StartView : Form
    {
        public StartView()
        {
            InitializeComponent();
            ApplyModernStyling();
        }

        private void ApplyModernStyling()
        {
            BackColor = ModernColors.Background;
            UIHelper.ApplyModernStyling(this);
        }

        private void btnRealtors_Click_1(object sender, EventArgs e)
        {
            var realtorsForm = new RealtorsPageMain();
            NavigationHelper.NavigateTo(this, realtorsForm);
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            var propertiesForm = new EDC.Views.Properties.PropertiesPageMain();
            NavigationHelper.NavigateTo(this, propertiesForm);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            var customersForm = new CustomersPageMain();
            NavigationHelper.NavigateTo(this, customersForm);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Already on start view
        }
    }
}
