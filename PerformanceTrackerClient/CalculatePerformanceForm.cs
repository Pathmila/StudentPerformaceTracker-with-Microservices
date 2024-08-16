using System;
using System.Linq;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using PerformanceTrackerClient.Models;

namespace PerformanceTrackerClient
{
    public partial class CalculatePerformanceForm : Form
    {
        private const string HoursApiUrl = "https://studenthoursmanagement20240721174701.azurewebsites.net/api/Hours";
        private const string StudentsApiUrl = "https://studentmanagement20240721180238.azurewebsites.net/api/students";
        private readonly HttpClient _httpClient;
        private int _userId;

        public CalculatePerformanceForm(int userId)
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            _userId = userId;
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve user email from user ID
                var studentResponse = await _httpClient.GetStringAsync($"{StudentsApiUrl}/{_userId}");
                var student = JObject.Parse(studentResponse);
                var userEmail = (string)student["email"];

                // Retrieve hours data for the user
                var hoursResponse = await _httpClient.GetStringAsync(HoursApiUrl);
                var hoursData = JArray.Parse(hoursResponse);

                // Filter hours data based on user email
                var filteredHoursData = hoursData
                    .Where(item => (string)item["name"] == userEmail)
                    .ToList();

                // Prepare data for DataGridView
                var performanceData = filteredHoursData
                    .GroupBy(item => (string)item["subject"])
                    .Select(group => new
                    {
                        Subject = group.Key,
                        TotalStudyHours = group.Sum(item => (int)item["studyHours"]),
                        TotalBreakHours = group.Sum(item => (int)item["breakHours"]),
                        PredictedGrade = PredictGrade(group.Sum(item => (int)item["studyHours"]))
                    })
                    .ToList();

                // Bind data to DataGridView
                performanceDataGridView.DataSource = performanceData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private string PredictGrade(int studyHours)
        {
            // Simple grade prediction logic
            if (studyHours > 100)
                return "A";
            else if (studyHours > 75)
                return "B";
            else if (studyHours > 50)
                return "C";
            else
                return "D";
        }
    }
}
