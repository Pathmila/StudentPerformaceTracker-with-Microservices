using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PerformanceTrackerClient.Models;

namespace PerformanceTrackerClient
{
    public partial class ViewHoursForm : Form
    {
        private int _userId;
        private HttpClient _httpClient;
        private readonly string _studentApiBaseUrl = "https://studentmanagement20240721180238.azurewebsites.net";
        private readonly string _hoursApiBaseUrl = "https://studenthoursmanagement20240721174701.azurewebsites.net";

        public ViewHoursForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            InitializeHttpClient();
        }

        private void InitializeHttpClient()
        {
            _httpClient = new HttpClient();
        }

        private async void ViewHoursForm_Load(object sender, EventArgs e)
        {
            var userEmail = await GetUserEmailAsync(_userId);
            if (userEmail != null)
            {
                await LoadHours(userEmail);
            }
            else
            {
                MessageBox.Show("Failed to retrieve user email.");
            }
        }

        private async Task<string> GetUserEmailAsync(int userId)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{_studentApiBaseUrl}/api/students");
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var users = JsonConvert.DeserializeObject<List<Student>>(jsonString);
                    var user = users.FirstOrDefault(u => u.StudentID == userId);
                    return user?.Email;
                }
                else
                {
                    MessageBox.Show("Failed to fetch students.");
                    return null;
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Request error: {ex.Message}");
                return null;
            }
        }

        private async Task LoadHours(string userEmail)
        {
            try
            {
                var hours = await _httpClient.GetFromJsonAsync<List<Hours>>($"{_hoursApiBaseUrl}/api/Hours");
                var filteredHours = hours.Where(h => h.Name == userEmail).ToList();
                dataGridView1.DataSource = filteredHours;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Request error: {ex.Message}");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                var response = await _httpClient.DeleteAsync($"{_hoursApiBaseUrl}/api/Hours/{id}");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Hours deleted successfully.");
                    var userEmail = await GetUserEmailAsync(_userId);
                    await LoadHours(userEmail);
                }
                else
                {
                    MessageBox.Show("Failed to delete hours.");
                }
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var id = (int)selectedRow.Cells["Id"].Value;

                var hours = new Hours
                {
                    Id = id,
                    Name = (string)selectedRow.Cells["Name"].Value,
                    Subject = (string)selectedRow.Cells["Subject"].Value,
                    StudyHours = (int)selectedRow.Cells["StudyHours"].Value,
                    BreakHours = (int)selectedRow.Cells["BreakHours"].Value
                };

                var response = await _httpClient.PutAsJsonAsync($"{_hoursApiBaseUrl}/api/Hours/{id}", hours);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Hours updated successfully.");
                    var userEmail = await GetUserEmailAsync(_userId);
                    await LoadHours(userEmail);
                }
                else
                {
                    MessageBox.Show("Failed to update hours.");
                }
            }
        }
    }
}
