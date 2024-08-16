// HomeForm.cs
using System;
using System.Windows.Forms;

namespace PerformanceTrackerClient
{
    public partial class HomeForm : Form
    {
        private int _userId;

        public HomeForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            lblWelcome.Text = $"Welcome, User ID: {_userId}";
        }

        private void btnViewHours_Click(object sender, EventArgs e)
        {
            var viewForm = new ViewHoursForm(_userId);
            viewForm.Show();
        }

        private void btnAddHours_Click(object sender, EventArgs e)
        {
            var addForm = new AddHoursForm(_userId);
            addForm.Show();
        }

        private void btnViewPrediction_Click(object sender, EventArgs e)
        {
            var calcForm = new CalculatePerformanceForm(_userId);
            calcForm.Show();
        }
    }
}
