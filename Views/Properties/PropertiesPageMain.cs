using EDC.Helpers;

namespace EDC.Views.Properties
{
    public partial class PropertiesPageMain : Form
    {
        public PropertiesPageMain()
        {
            InitializeComponent();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            btnNewProperty.Click += btnNewProperty_Click;
            btnViewProperties.Click += btnViewProperties_Click;
            btnBack.Click += btnBack_Click;
        }

        private void btnNewProperty_Click(object sender, EventArgs e)
        {
            var newPropertyForm = new NewProperty();
            NavigationHelper.NavigateTo(this, newPropertyForm);
        }

        private void btnViewProperties_Click(object sender, EventArgs e)
        {
            var viewPropertiesForm = new ViewProperties();
            NavigationHelper.NavigateTo(this, viewPropertiesForm);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateBack(this);
        }
    }
}
