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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text
            };

            var response = await ApiHelper.PostAsync("api/students", student);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Sign up successful!");
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Sign up failed!");
            }
        }
    }
}
