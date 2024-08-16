using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace PerformanceTrackerClient
{
    public partial class AddHoursForm : Form
    {
        private int _userId;
        private readonly HttpClient _httpClient;

        public AddHoursForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _httpClient = new HttpClient { BaseAddress = new Uri("https://studenthoursmanagement20240721174701.azurewebsites.net") };
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var hours = new Hours
            {
                Name = txtName.Text,
                Subject = txtSubject.Text,
                StudyHours = int.Parse(txtStudyHours.Text),
                BreakHours = int.Parse(txtBreakHours.Text)
            };

            var response = await _httpClient.PostAsJsonAsync("api/Hours", hours);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Hours added successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add hours.");
            }
        }
    }

    public class Hours
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public int StudyHours { get; set; }
        public int BreakHours { get; set; }
    }
}
