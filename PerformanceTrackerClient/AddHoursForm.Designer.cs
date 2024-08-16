namespace PerformanceTrackerClient
{
    partial class AddHoursForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblStudyHours;
        private System.Windows.Forms.Label lblBreakHours;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtStudyHours;
        private System.Windows.Forms.TextBox txtBreakHours;
        private System.Windows.Forms.Button btnSave;

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
            lblTitle = new Label();
            lblName = new Label();
            lblSubject = new Label();
            lblStudyHours = new Label();
            lblBreakHours = new Label();
            txtName = new TextBox();
            txtSubject = new TextBox();
            txtStudyHours = new TextBox();
            txtBreakHours = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Lucida Calligraphy", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(366, 160);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(270, 52);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add Hours";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(276, 260);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 28);
            lblName.TabIndex = 1;
            lblName.Text = "Email";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubject.Location = new Point(276, 310);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(77, 28);
            lblSubject.TabIndex = 2;
            lblSubject.Text = "Subject";
            // 
            // lblStudyHours
            // 
            lblStudyHours.AutoSize = true;
            lblStudyHours.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudyHours.Location = new Point(276, 360);
            lblStudyHours.Name = "lblStudyHours";
            lblStudyHours.Size = new Size(119, 28);
            lblStudyHours.TabIndex = 3;
            lblStudyHours.Text = "Study Hours";
            // 
            // lblBreakHours
            // 
            lblBreakHours.AutoSize = true;
            lblBreakHours.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBreakHours.Location = new Point(276, 410);
            lblBreakHours.Name = "lblBreakHours";
            lblBreakHours.Size = new Size(117, 28);
            lblBreakHours.TabIndex = 4;
            lblBreakHours.Text = "Break Hours";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(416, 257);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 34);
            txtName.TabIndex = 5;
            // 
            // txtSubject
            // 
            txtSubject.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubject.Location = new Point(416, 307);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(300, 34);
            txtSubject.TabIndex = 6;
            // 
            // txtStudyHours
            // 
            txtStudyHours.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudyHours.Location = new Point(416, 357);
            txtStudyHours.Name = "txtStudyHours";
            txtStudyHours.Size = new Size(300, 34);
            txtStudyHours.TabIndex = 7;
            // 
            // txtBreakHours
            // 
            txtBreakHours.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBreakHours.Location = new Point(416, 407);
            txtBreakHours.Name = "txtBreakHours";
            txtBreakHours.Size = new Size(300, 34);
            txtBreakHours.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Navy;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(433, 502);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 45);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // AddHoursForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(1000, 800);
            Controls.Add(btnSave);
            Controls.Add(txtBreakHours);
            Controls.Add(txtStudyHours);
            Controls.Add(txtSubject);
            Controls.Add(txtName);
            Controls.Add(lblBreakHours);
            Controls.Add(lblStudyHours);
            Controls.Add(lblSubject);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "AddHoursForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Hours";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
