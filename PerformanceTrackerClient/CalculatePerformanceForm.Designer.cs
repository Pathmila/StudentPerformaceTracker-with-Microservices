namespace PerformanceTrackerClient
{
    partial class CalculatePerformanceForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridView performanceDataGridView;
        private System.Windows.Forms.Label lblTitle;

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
            btnCalculate = new Button();
            performanceDataGridView = new DataGridView();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)performanceDataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Navy;
            btnCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(440, 100);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(120, 40);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // performanceDataGridView
            // 
            performanceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            performanceDataGridView.Location = new Point(44, 171);
            performanceDataGridView.Name = "performanceDataGridView";
            performanceDataGridView.RowHeadersWidth = 51;
            performanceDataGridView.RowTemplate.Height = 25;
            performanceDataGridView.Size = new Size(900, 500);
            performanceDataGridView.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Monotype Corsiva", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(328, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(358, 49);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Performance Summary";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CalculatePerformanceForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(1000, 700);
            Controls.Add(lblTitle);
            Controls.Add(performanceDataGridView);
            Controls.Add(btnCalculate);
            Name = "CalculatePerformanceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculate Performance";
            ((System.ComponentModel.ISupportInitialize)performanceDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
