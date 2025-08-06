using System;
using System.Drawing;
using System.Windows.Forms;
using EDC.Helpers;
using EDC.UI.Theme;
using EDC.UI.Utils;
using EDC.Services;
using EDC.Models;
using System.Threading.Tasks;

namespace EDC.Views.Customers
{
    public partial class CustomersPageMain : Form
    {
        private readonly ICustomerService _customerService;

        public CustomersPageMain()
        {
            InitializeComponent();
            UIHelper.ApplyModernStyle(this);
            _customerService = new CustomerService();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            var newCustomerForm = new NewCustomer();
            NavigationHelper.NavigateTo(this, newCustomerForm);
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            var viewCustomersForm = new ViewCustomers();
            NavigationHelper.NavigateTo(this, viewCustomersForm);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateBack(this);
        }
    }
}
