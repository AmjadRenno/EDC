using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDC.Helpers
{
    public static class NavigationHelper
    {
        private static readonly Stack<Form> NavigationStack = new();
        private static Form? MainForm = null;

        public static void SetMainForm(Form mainForm)
        {
            MainForm = mainForm;
        }

        public static void NavigateTo(Form currentForm, Form newForm)
        {
            // If this is the first navigation from main form, set it as main
            if (MainForm == null && currentForm is StartView)
            {
                SetMainForm(currentForm);
            }

            NavigationStack.Push(currentForm);
            currentForm.Hide();
            
            // Handle form closing to prevent application exit unless it's the main form
            newForm.FormClosed += (s, e) => 
            {
                // Only exit if we're closing the main form and stack is empty
                if (s == MainForm && NavigationStack.Count == 0)
                    Application.Exit();
            };
            
            newForm.Show();
        }

        public static void NavigateToStartView(Form currentForm)
        {
            // Clear navigation stack when going to start
            ClearNavigationStack();
            
            currentForm.Close(); // Use Close instead of Hide
            var startView = new StartView();
            startView.FormClosed += (s, e) => Application.Exit();
            startView.Show();
        }

        public static void NavigateBack(Form currentForm)
        {
            if (NavigationStack.Count > 0)
            {
                var previousForm = NavigationStack.Pop();
                currentForm.Close();
                
                // Show the previous form
                if (!previousForm.IsDisposed)
                {
                    previousForm.Show();
                    previousForm.BringToFront();
                }
                else
                {
                    // If previous form is disposed, navigate to start
                    NavigateToStartView(currentForm);
                }
            }
            else
            {
                // If no previous form, close current and exit application
                currentForm.Close();
                Application.Exit();
            }
        }

        private static void ClearNavigationStack()
        {
            while (NavigationStack.Count > 0)
            {
                NavigationStack.Pop();
            }
        }
    }
}
