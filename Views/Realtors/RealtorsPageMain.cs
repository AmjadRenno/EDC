using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDC.Helpers;
using EDC.UI.Theme;
using EDC.UI.Utils;

namespace EDC.Views.Realtors
{
    public partial class RealtorsPageMain : Form
    {
        public RealtorsPageMain()
        {
            InitializeComponent();
            UIHelper.ApplyModernStyle(this);
        }

        private void btnNewRealtor_Click(object sender, EventArgs e)
        {
            var newRealtorForm = new NewRealtor();
            NavigationHelper.NavigateTo(this, newRealtorForm);
        }

        private void btnViewRealtors_Click(object sender, EventArgs e)
        {
            var viewRealtorsForm = new ViewRealtors();
            NavigationHelper.NavigateTo(this, viewRealtorsForm);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateBack(this);
        }
    }
}
