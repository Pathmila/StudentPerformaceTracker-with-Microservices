namespace PerformanceTrackerClient
{
    partial class HomeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnViewHours;
        private System.Windows.Forms.Button btnAddHours;
        private System.Windows.Forms.Button btnViewPrediction;  // New button for viewing predictions
        private System.Windows.Forms.Label lblIntroduction;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblWelcome = new Label();
            lblIntroduction = new Label();
            btnViewHours = new Button();
            btnAddHours = new Button();
            btnViewPrediction = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Lucida Calligraphy", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.Navy;
            lblWelcome.Location = new Point(300, 50);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(219, 52);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            // 
            // lblIntroduction
            // 
            lblIntroduction.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIntroduction.Location = new Point(42, 350);
            lblIntroduction.Name = "lblIntroduction";
            lblIntroduction.Size = new Size(900, 120);
            lblIntroduction.TabIndex = 1;
            lblIntroduction.Text = "This system aims to develop a comprehensive Student Performance Tracking System that enhances academic success through effective study habit monitoring and performance prediction.";
            lblIntroduction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnViewHours
            // 
            btnViewHours.BackColor = Color.Navy;
            btnViewHours.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewHours.ForeColor = Color.White;
            btnViewHours.Location = new Point(160, 218);
            btnViewHours.Name = "btnViewHours";
            btnViewHours.Size = new Size(202, 45);
            btnViewHours.TabIndex = 2;
            btnViewHours.Text = "View Hours";
            btnViewHours.UseVisualStyleBackColor = false;
            btnViewHours.Click += btnViewHours_Click;
            // 
            // btnAddHours
            // 
            btnAddHours.BackColor = Color.Navy;
            btnAddHours.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddHours.ForeColor = Color.White;
            btnAddHours.Location = new Point(393, 218);
            btnAddHours.Name = "btnAddHours";
            btnAddHours.Size = new Size(202, 45);
            btnAddHours.TabIndex = 3;
            btnAddHours.Text = "Add Hours";
            btnAddHours.UseVisualStyleBackColor = false;
            btnAddHours.Click += btnAddHours_Click;
            // 
            // btnViewPrediction
            // 
            btnViewPrediction.BackColor = Color.Navy;
            btnViewPrediction.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewPrediction.ForeColor = Color.White;
            btnViewPrediction.Location = new Point(630, 218);
            btnViewPrediction.Name = "btnViewPrediction";
            btnViewPrediction.Size = new Size(202, 45);
            btnViewPrediction.TabIndex = 4;
            btnViewPrediction.Text = "View Prediction";
            btnViewPrediction.UseVisualStyleBackColor = false;
            btnViewPrediction.Click += btnViewPrediction_Click;
            // 
            // HomeForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(1000, 800);
            Controls.Add(btnViewPrediction);
            Controls.Add(btnAddHours);
            Controls.Add(btnViewHours);
            Controls.Add(lblIntroduction);
            Controls.Add(lblWelcome);
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
