using PerformanceTrackerClient.Helpers;
using PerformanceTrackerClient.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerformanceTrackerClient
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var users = await GetAllUsers();
            var user = users.FirstOrDefault(u => u.Email == txtEmail.Text && u.Password == txtPassword.Text);

            if (user != null)
            {
                MessageBox.Show("Login successful!");
                var homeForm = new HomeForm(user.StudentID);
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed!");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var signUpForm = new SignUpForm();
            signUpForm.Show();
        }

        private async Task<List<Student>> GetAllUsers()
        {
            var response = await ApiHelper.GetAsync("api/students");
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var users = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Student>>(jsonString);
                return users;
            }
            else
            {
                MessageBox.Show("Error fetching users");
                return new List<Student>();
            }
        }
    }
}
